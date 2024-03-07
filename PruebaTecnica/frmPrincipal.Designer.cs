namespace PruebaTecnica
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemRegistrarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemRegistrarVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemRegistrarCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemMostrarReporteInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 818);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1374, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1374, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemRegistrarProducto,
            this.mItemRegistrarVenta,
            this.mItemRegistrarCompra,
            this.mItemMostrarReporteInventario});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(85, 24);
            this.toolStripMenuItem1.Text = "Opciones";
            // 
            // mItemRegistrarProducto
            // 
            this.mItemRegistrarProducto.Name = "mItemRegistrarProducto";
            this.mItemRegistrarProducto.Size = new System.Drawing.Size(224, 26);
            this.mItemRegistrarProducto.Text = "Registrar Producto";
            this.mItemRegistrarProducto.Click += new System.EventHandler(this.mItemRegistrarProducto_Click);
            // 
            // mItemRegistrarVenta
            // 
            this.mItemRegistrarVenta.Name = "mItemRegistrarVenta";
            this.mItemRegistrarVenta.Size = new System.Drawing.Size(224, 26);
            this.mItemRegistrarVenta.Text = "Registrar Venta";
            this.mItemRegistrarVenta.Click += new System.EventHandler(this.mItemRegistrarVenta_Click);
            // 
            // mItemRegistrarCompra
            // 
            this.mItemRegistrarCompra.Name = "mItemRegistrarCompra";
            this.mItemRegistrarCompra.Size = new System.Drawing.Size(224, 26);
            this.mItemRegistrarCompra.Text = "Registrar compra";
            this.mItemRegistrarCompra.Click += new System.EventHandler(this.registrarCompraToolStripMenuItem_Click);
            // 
            // mItemMostrarReporteInventario
            // 
            this.mItemMostrarReporteInventario.Name = "mItemMostrarReporteInventario";
            this.mItemMostrarReporteInventario.Size = new System.Drawing.Size(224, 26);
            this.mItemMostrarReporteInventario.Text = "Reporte Inventario";
            this.mItemMostrarReporteInventario.Click += new System.EventHandler(this.mItemMostrarReporteInventario_Click);
            // 
            // frmPrincipal
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 844);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mItemRegistrarProducto;
        private System.Windows.Forms.ToolStripMenuItem mItemRegistrarCompra;
        private System.Windows.Forms.ToolStripMenuItem mItemRegistrarVenta;
        private System.Windows.Forms.ToolStripMenuItem mItemMostrarReporteInventario;
    }
}



