namespace Pollos
{
    partial class buscarProductos
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
            this.gridBusquedaProductos = new System.Windows.Forms.DataGridView();
            this.idProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridBusquedaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridBusquedaProductos
            // 
            this.gridBusquedaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBusquedaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductos,
            this.nombreProducto,
            this.tipoProducto,
            this.precioProducto});
            this.gridBusquedaProductos.Location = new System.Drawing.Point(12, 35);
            this.gridBusquedaProductos.Name = "gridBusquedaProductos";
            this.gridBusquedaProductos.Size = new System.Drawing.Size(392, 417);
            this.gridBusquedaProductos.TabIndex = 0;
            this.gridBusquedaProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBusquedaProductos_CellDoubleClick);
            this.gridBusquedaProductos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridBusquedaProductos_CellMouseDoubleClick);
            // 
            // idProductos
            // 
            this.idProductos.HeaderText = "ID";
            this.idProductos.Name = "idProductos";
            this.idProductos.ReadOnly = true;
            this.idProductos.Width = 50;
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "NOMBRE";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            this.nombreProducto.Width = 150;
            // 
            // tipoProducto
            // 
            this.tipoProducto.HeaderText = "TIPO";
            this.tipoProducto.Name = "tipoProducto";
            this.tipoProducto.ReadOnly = true;
            // 
            // precioProducto
            // 
            this.precioProducto.HeaderText = "PRECIO";
            this.precioProducto.Name = "precioProducto";
            this.precioProducto.ReadOnly = true;
            this.precioProducto.Width = 50;
            // 
            // buscarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 464);
            this.Controls.Add(this.gridBusquedaProductos);
            this.Name = "buscarProductos";
            this.Text = "buscarProductos";
            this.Load += new System.EventHandler(this.buscarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBusquedaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridBusquedaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
    }
}