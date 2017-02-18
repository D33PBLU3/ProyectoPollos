namespace Pollos
{
    partial class ProductosAdmin
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
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtTipoProducto = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listSubProductos = new System.Windows.Forms.ListView();
            this.idProductos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombreProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btn_agregarSubP = new System.Windows.Forms.Button();
            this.btn_quitarSubP = new System.Windows.Forms.Button();
            this.listSubProductosAg = new System.Windows.Forms.ListView();
            this.idProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombreP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantidadSubP = new System.Windows.Forms.NumericUpDown();
            this.cantidadSubProductos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadSubP)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(48, 25);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProducto.TabIndex = 0;
            // 
            // txtTipoProducto
            // 
            this.txtTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipoProducto.FormattingEnabled = true;
            this.txtTipoProducto.Items.AddRange(new object[] {
            "NORMAL",
            "PAQUETE",
            "CUPON"});
            this.txtTipoProducto.Location = new System.Drawing.Point(198, 25);
            this.txtTipoProducto.Name = "txtTipoProducto";
            this.txtTipoProducto.Size = new System.Drawing.Size(121, 21);
            this.txtTipoProducto.TabIndex = 1;
            this.txtTipoProducto.TextChanged += new System.EventHandler(this.txtTipoProducto_TextChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.DecimalPlaces = 2;
            this.txtPrecio.Location = new System.Drawing.Point(361, 26);
            this.txtPrecio.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtPrecio.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(87, 20);
            this.txtPrecio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio";
            // 
            // listSubProductos
            // 
            this.listSubProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idProductos,
            this.nombreProducto});
            this.listSubProductos.Location = new System.Drawing.Point(48, 85);
            this.listSubProductos.Name = "listSubProductos";
            this.listSubProductos.Size = new System.Drawing.Size(175, 133);
            this.listSubProductos.TabIndex = 6;
            this.listSubProductos.UseCompatibleStateImageBehavior = false;
            this.listSubProductos.View = System.Windows.Forms.View.Details;
            this.listSubProductos.Visible = false;
            // 
            // idProductos
            // 
            this.idProductos.Text = "ID";
            this.idProductos.Width = 31;
            // 
            // nombreProducto
            // 
            this.nombreProducto.Text = "NOMBRE";
            this.nombreProducto.Width = 139;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(500, 22);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btn_agregarSubP
            // 
            this.btn_agregarSubP.Location = new System.Drawing.Point(258, 127);
            this.btn_agregarSubP.Name = "btn_agregarSubP";
            this.btn_agregarSubP.Size = new System.Drawing.Size(75, 23);
            this.btn_agregarSubP.TabIndex = 8;
            this.btn_agregarSubP.Text = "Agregar";
            this.btn_agregarSubP.UseVisualStyleBackColor = true;
            this.btn_agregarSubP.Visible = false;
            this.btn_agregarSubP.Click += new System.EventHandler(this.btn_agregarSubP_Click);
            // 
            // btn_quitarSubP
            // 
            this.btn_quitarSubP.Location = new System.Drawing.Point(258, 156);
            this.btn_quitarSubP.Name = "btn_quitarSubP";
            this.btn_quitarSubP.Size = new System.Drawing.Size(75, 23);
            this.btn_quitarSubP.TabIndex = 9;
            this.btn_quitarSubP.Text = "Eliminar";
            this.btn_quitarSubP.UseVisualStyleBackColor = true;
            this.btn_quitarSubP.Visible = false;
            this.btn_quitarSubP.Click += new System.EventHandler(this.btn_quitarSubP_Click);
            // 
            // listSubProductosAg
            // 
            this.listSubProductosAg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idProducto,
            this.nombreP,
            this.cantidadSubProductos});
            this.listSubProductosAg.Location = new System.Drawing.Point(361, 85);
            this.listSubProductosAg.Name = "listSubProductosAg";
            this.listSubProductosAg.Size = new System.Drawing.Size(193, 133);
            this.listSubProductosAg.TabIndex = 10;
            this.listSubProductosAg.UseCompatibleStateImageBehavior = false;
            this.listSubProductosAg.View = System.Windows.Forms.View.Details;
            this.listSubProductosAg.Visible = false;
            // 
            // idProducto
            // 
            this.idProducto.Text = "ID";
            this.idProducto.Width = 29;
            // 
            // nombreP
            // 
            this.nombreP.Text = "NOMBRE";
            this.nombreP.Width = 89;
            // 
            // cantidadSubP
            // 
            this.cantidadSubP.DecimalPlaces = 1;
            this.cantidadSubP.Location = new System.Drawing.Point(258, 85);
            this.cantidadSubP.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.cantidadSubP.Name = "cantidadSubP";
            this.cantidadSubP.Size = new System.Drawing.Size(46, 20);
            this.cantidadSubP.TabIndex = 11;
            this.cantidadSubP.Visible = false;
            // 
            // cantidadSubProductos
            // 
            this.cantidadSubProductos.Text = "CANTIDAD";
            this.cantidadSubProductos.Width = 82;
            // 
            // ProductosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 230);
            this.Controls.Add(this.cantidadSubP);
            this.Controls.Add(this.listSubProductosAg);
            this.Controls.Add(this.btn_quitarSubP);
            this.Controls.Add(this.btn_agregarSubP);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.listSubProductos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTipoProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Name = "ProductosAdmin";
            this.Text = "ProductosAdmin";
            this.Load += new System.EventHandler(this.ProductosAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadSubP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.NumericUpDown txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listSubProductos;
        private System.Windows.Forms.ComboBox txtTipoProducto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btn_agregarSubP;
        private System.Windows.Forms.Button btn_quitarSubP;
        private System.Windows.Forms.ListView listSubProductosAg;
        private System.Windows.Forms.ColumnHeader idProductos;
        private System.Windows.Forms.ColumnHeader nombreProducto;
        private System.Windows.Forms.ColumnHeader idProducto;
        private System.Windows.Forms.ColumnHeader nombreP;
        private System.Windows.Forms.NumericUpDown cantidadSubP;
        private System.Windows.Forms.ColumnHeader cantidadSubProductos;
    }
}