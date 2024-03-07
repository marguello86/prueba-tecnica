using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Configuration;
using System.Diagnostics;

namespace PruebaTecnica
{
    public partial class frmProducto : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString;
        public frmProducto()
        {
            InitializeComponent();
            this.cargarProductos();
        }
        public void cargarProductos()
        {
            SqlDataAdapter sdaProductos = new SqlDataAdapter("Select * from dbo.Producto", connectionString);
            DataSet dsProductos = new DataSet();
            sdaProductos.Fill(dsProductos);
            this.dgvProductos.DataSource = dsProductos.Tables[0].DefaultView;
            this.dgvProductos.Columns["IdProducto"].HeaderText = "Id";
            this.dgvProductos.Columns["NombreProducto"].HeaderText = "Nombre del producto";
            this.dgvProductos.Columns["Existencia"].HeaderText = "Existencias en inventario";
        }

        private void btnGuardarProducto_click(object sender, EventArgs e)
        {
            if (this.validarEntradas())
            {   
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        int filasAfectadas = 0;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "paInsertarProducto";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdProducto", 0);
                        cmd.Parameters.AddWithValue("@NombreProducto", this.txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@Existencia", this.txtExistencia.Text.Trim());
                        filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("La información fue registrada satisfactoriamente.", "REGISTRO DE PRODUCTO EXITOSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                } 
                catch (Exception ex) {
                    MessageBox.Show("Ha ocurrido un problema al intentar guardar la información del producto.", "REGISTRO DE PRODUCTO SIN FINALIZAR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EventLog.WriteEntry("PruebaTecnica", ex.Message, EventLogEntryType.Error);
                }    
            }
        }
        public bool validarEntradas()
        {
            bool formValido = true;
            if (this.txtNombre.Text.Trim() == "") { return formValido=false; }
            if (this.txtExistencia.Text.Trim() == "") { return formValido = false; }
            if (this.txtNombre.Text.Trim().Length<3) { return formValido = false; }
            if (this.txtExistencia.Text.Trim().Length < 0) { return formValido = false; }
            return formValido;
        }

    }
}
