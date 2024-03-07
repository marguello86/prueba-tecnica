using Microsoft.Reporting.WinForms;
using PruebaTecnica.Informe;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTecnica
{
    public partial class frmReporteInventario : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString;
        public frmReporteInventario()
        {
            InitializeComponent();
        }
        private void frmReporteInventario_Load(object sender, EventArgs e)
        {
            this.cargarDataReporte();
            
        }
        public void cargarDataReporte()
        {
            try
            {
                SqlDataAdapter sdaProductos = new SqlDataAdapter("Select * from dbo.vwLeerTransacciones", connectionString);
                DataSet dsProductos = new DataSet();
                sdaProductos.Fill(dsProductos);                
                this.rptTransacciones.LocalReport.ReportPath = "rptInforme.rdlc";
                ReportDataSource source = new ReportDataSource("Dataset1", dsProductos.Tables[0].DefaultView);
                this.rptTransacciones.LocalReport.DataSources.Clear();
                this.rptTransacciones.LocalReport.DataSources.Add(source);
                this.rptTransacciones.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema al intentar cargar el reporte.", "ERROR AL CARGAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EventLog.WriteEntry("PruebaTecnica", ex.Message, EventLogEntryType.Error);
                throw;
            }

        }
    }
}
