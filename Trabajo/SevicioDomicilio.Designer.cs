namespace Pollos
{
    partial class SevicioDomicilio
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SevicioDomicilio));
            this.btnClientes = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.listClientes = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NOMBRE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TELEFONO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DIRECCION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CALLES = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.COLONIA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.idProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textTicketPedido = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptarPedido = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNomCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(686, 46);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(93, 28);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Registrar Cliente";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(286, 20);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // listClientes
            // 
            this.listClientes.CheckBoxes = true;
            this.listClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NOMBRE,
            this.TELEFONO,
            this.DIRECCION,
            this.CALLES,
            this.COLONIA});
            listViewItem1.StateImageIndex = 0;
            this.listClientes.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listClientes.Location = new System.Drawing.Point(12, 46);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(668, 96);
            this.listClientes.TabIndex = 4;
            this.listClientes.UseCompatibleStateImageBehavior = false;
            this.listClientes.View = System.Windows.Forms.View.Details;
            this.listClientes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listClientes_ItemCheck);
            this.listClientes.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listClientes_ItemChecked);
            this.listClientes.SelectedIndexChanged += new System.EventHandler(this.listClientes_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 45;
            // 
            // NOMBRE
            // 
            this.NOMBRE.Text = "NOMBRE";
            this.NOMBRE.Width = 139;
            // 
            // TELEFONO
            // 
            this.TELEFONO.Text = "TELEFONO";
            this.TELEFONO.Width = 122;
            // 
            // DIRECCION
            // 
            this.DIRECCION.Text = "DIRECCION";
            this.DIRECCION.Width = 121;
            // 
            // CALLES
            // 
            this.CALLES.Text = "CALLES";
            this.CALLES.Width = 110;
            // 
            // COLONIA
            // 
            this.COLONIA.Text = "COLONIA";
            this.COLONIA.Width = 123;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(686, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Eliminar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(686, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Editar Cliente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gridProductos
            // 
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductos,
            this.nombreProducto,
            this.tipoProducto,
            this.precioProducto,
            this.cantidad});
            this.gridProductos.Location = new System.Drawing.Point(23, 196);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(657, 257);
            this.gridProductos.TabIndex = 5;
            this.gridProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProductos_CellContentClick);
            this.gridProductos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProductos_CellContentDoubleClick);
            this.gridProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProductos_CellDoubleClick);
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
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            // 
            // textTicketPedido
            // 
            this.textTicketPedido.Location = new System.Drawing.Point(785, 416);
            this.textTicketPedido.Name = "textTicketPedido";
            this.textTicketPedido.Size = new System.Drawing.Size(100, 20);
            this.textTicketPedido.TabIndex = 11;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(785, 338);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(282, 72);
            this.txt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(782, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Comentarios:";
            // 
            // btnAceptarPedido
            // 
            this.btnAceptarPedido.Location = new System.Drawing.Point(992, 430);
            this.btnAceptarPedido.Name = "btnAceptarPedido";
            this.btnAceptarPedido.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarPedido.TabIndex = 7;
            this.btnAceptarPedido.Text = "Aceptar";
            this.btnAceptarPedido.UseVisualStyleBackColor = true;
            this.btnAceptarPedido.Click += new System.EventHandler(this.btnAceptarPedido_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(886, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha:";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(933, 80);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(0, 13);
            this.lbFecha.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(886, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(936, 114);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 13);
            this.lbTotal.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(885, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cliente:";
            // 
            // lbNomCliente
            // 
            this.lbNomCliente.AutoSize = true;
            this.lbNomCliente.Location = new System.Drawing.Point(939, 46);
            this.lbNomCliente.Name = "lbNomCliente";
            this.lbNomCliente.Size = new System.Drawing.Size(0, 13);
            this.lbNomCliente.TabIndex = 17;
            // 
            // SevicioDomicilio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 465);
            this.Controls.Add(this.lbNomCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAceptarPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.textTicketPedido);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listClientes);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SevicioDomicilio";
            this.Text = "Sevicio a Domicilio";
            this.Load += new System.EventHandler(this.SevicioDomicilio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ListView listClientes;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NOMBRE;
        private System.Windows.Forms.ColumnHeader TELEFONO;
        private System.Windows.Forms.ColumnHeader DIRECCION;
        private System.Windows.Forms.ColumnHeader CALLES;
        private System.Windows.Forms.ColumnHeader COLONIA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.TextBox textTicketPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptarPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNomCliente;
    }
}