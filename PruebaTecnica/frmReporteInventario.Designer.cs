namespace PruebaTecnica
{
    partial class frmReporteInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rptTransacciones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptTransacciones
            // 
            this.rptTransacciones.AllowDrop = true;
            this.rptTransacciones.DocumentMapWidth = 64;
            this.rptTransacciones.Location = new System.Drawing.Point(12, 12);
            this.rptTransacciones.Name = "rptTransacciones";
            this.rptTransacciones.ServerReport.BearerToken = null;
            this.rptTransacciones.Size = new System.Drawing.Size(1041, 621);
            this.rptTransacciones.TabIndex = 0;
            // 
            // frmReporteInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 683);
            this.Controls.Add(this.rptTransacciones);
            this.Name = "frmReporteInventario";
            this.Text = "Reporte de Inventario";
            this.Load += new System.EventHandler(this.frmReporteInventario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptTransacciones;
    }
}