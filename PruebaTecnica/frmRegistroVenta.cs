using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTecnica
{
    public partial class frmRegistrarVenta : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString;
        public string query;
        private SqlConnection conexion;
        public frmRegistrarVenta()
        {
            InitializeComponent();
        }

        private void frmRegistrarVenta_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        public void cargarProductos()
        {
            query = "Select * from dbo.Producto";
            conexion = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataAdapter sdaProducto = new SqlDataAdapter(command);
            DataTable dtProducto = new DataTable();
            sdaProducto.Fill(dtProducto);
            this.cboProducto.DisplayMember = "NombreProducto";
            this.cboProducto.ValueMember = "IdProducto";
            this.cboProducto.DataSource = dtProducto;
        }

        private void btnRegistroCompra_Click(object sender, EventArgs e)
        {
            if (this.validarEntradas())
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        DateTime dtFechaVenta = dtpFechaVenta.Value;
                        string fechaFormateada = dtFechaVenta.ToString("yyyy-MM-dd");
                        int filasAfectadas = 0;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "paInsertarVenta";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdProducto", this.cboProducto.SelectedValue);
                        cmd.Parameters.AddWithValue("@Cantidad", this.txtCantidad.Text.Trim());
                        cmd.Parameters.AddWithValue("@PrecioUnitario", this.txtPrecio.Text.Trim());
                        cmd.Parameters.AddWithValue("@FechaVenta", fechaFormateada);
                        filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("La información fue registrada satisfactoriamente.", "REGISTRO DE COMPRA EXITOSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un problema al intentar guardar la información de la compra.", "REGISTRO DE COMPRA SIN FINALIZAR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EventLog.WriteEntry("PruebaTecnica", ex.Message, EventLogEntryType.Error);
                }
            }
            else
            {
                MessageBox.Show("Verifique los datos ingresados.", "REGISTRO DE VENTA SIN VALIDAR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool validarEntradas()
        {
            bool formValido = true;
            if (this.txtCantidad.Text.Trim() == "") { return formValido = false; }
            if (this.txtPrecio.Text.Trim() == "") { return formValido = false; }
            if (this.cboProducto.SelectedIndex == 0) { return formValido = false; }
            if (Convert.ToInt32(this.txtCantidad.Text) <= 0) { return formValido = false; }
            if (Convert.ToInt32(this.txtPrecio.Text) <= 0) { return formValido = false; }
            return formValido;
        }
    }
}
