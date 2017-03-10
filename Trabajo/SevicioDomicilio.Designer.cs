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
            this.textTicketPedido = new System.Windows.Forms.TextBox();
            this.txtComen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptarPedido = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNomCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.txtEntreCallesCliente = new System.Windows.Forms.TextBox();
            this.txtColoniaCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(854, 31);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(93, 28);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Registrar Cliente";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(12, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(526, 80);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
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
            this.listClientes.Location = new System.Drawing.Point(676, 803);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(44, 22);
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
            this.button1.Location = new System.Drawing.Point(854, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Eliminar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(854, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Editar Cliente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textTicketPedido
            // 
            this.textTicketPedido.Location = new System.Drawing.Point(14, 772);
            this.textTicketPedido.Name = "textTicketPedido";
            this.textTicketPedido.Size = new System.Drawing.Size(100, 20);
            this.textTicketPedido.TabIndex = 11;
            // 
            // txtComen
            // 
            this.txtComen.Location = new System.Drawing.Point(931, 580);
            this.txtComen.Multiline = true;
            this.txtComen.Name = "txtComen";
            this.txtComen.Size = new System.Drawing.Size(272, 72);
            this.txtComen.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1061, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Comentarios:";
            // 
            // btnAceptarPedido
            // 
            this.btnAceptarPedido.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAceptarPedido.Location = new System.Drawing.Point(1070, 679);
            this.btnAceptarPedido.Name = "btnAceptarPedido";
            this.btnAceptarPedido.Size = new System.Drawing.Size(133, 60);
            this.btnAceptarPedido.TabIndex = 7;
            this.btnAceptarPedido.Text = "VENDER";
            this.btnAceptarPedido.UseVisualStyleBackColor = false;
            this.btnAceptarPedido.Click += new System.EventHandler(this.btnAceptarPedido_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(979, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha:";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(1036, 46);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(0, 13);
            this.lbFecha.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(979, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cliente:";
            // 
            // lbNomCliente
            // 
            this.lbNomCliente.AutoSize = true;
            this.lbNomCliente.Location = new System.Drawing.Point(1039, 80);
            this.lbNomCliente.Name = "lbNomCliente";
            this.lbNomCliente.Size = new System.Drawing.Size(0, 13);
            this.lbNomCliente.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(979, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(1067, 137);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 13);
            this.lbTotal.TabIndex = 17;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(1039, 122);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 13);
            this.labelTotal.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(27, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 60);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(383, 250);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 60);
            this.button4.TabIndex = 9;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(199, 250);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 60);
            this.button5.TabIndex = 10;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Location = new System.Drawing.Point(567, 250);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(153, 60);
            this.button6.TabIndex = 11;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Location = new System.Drawing.Point(742, 251);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(146, 59);
            this.button7.TabIndex = 12;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.Location = new System.Drawing.Point(27, 338);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(147, 63);
            this.button8.TabIndex = 18;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.Location = new System.Drawing.Point(199, 338);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(158, 63);
            this.button9.TabIndex = 13;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button10.Location = new System.Drawing.Point(383, 338);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(155, 63);
            this.button10.TabIndex = 14;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button11.Location = new System.Drawing.Point(567, 338);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(153, 63);
            this.button11.TabIndex = 15;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button12.Location = new System.Drawing.Point(742, 338);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(146, 63);
            this.button12.TabIndex = 16;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button13.Location = new System.Drawing.Point(27, 422);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(147, 61);
            this.button13.TabIndex = 17;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button14.Location = new System.Drawing.Point(383, 422);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(155, 61);
            this.button14.TabIndex = 19;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button15.Location = new System.Drawing.Point(567, 422);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(153, 61);
            this.button15.TabIndex = 20;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button16.Location = new System.Drawing.Point(742, 422);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(146, 61);
            this.button16.TabIndex = 21;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button17.Location = new System.Drawing.Point(27, 509);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(147, 62);
            this.button17.TabIndex = 22;
            this.button17.Text = "button17";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button18.Location = new System.Drawing.Point(199, 422);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(158, 61);
            this.button18.TabIndex = 28;
            this.button18.Text = "button18";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button19.Location = new System.Drawing.Point(199, 509);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(158, 62);
            this.button19.TabIndex = 27;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button20.Location = new System.Drawing.Point(383, 509);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(155, 62);
            this.button20.TabIndex = 26;
            this.button20.Text = "button20";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button21.Location = new System.Drawing.Point(567, 509);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(153, 62);
            this.button21.TabIndex = 25;
            this.button21.Text = "button21";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button22.Location = new System.Drawing.Point(742, 509);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(146, 62);
            this.button22.TabIndex = 24;
            this.button22.Text = "button22";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button23.Location = new System.Drawing.Point(27, 598);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(147, 65);
            this.button23.TabIndex = 23;
            this.button23.Text = "button23";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // gridProductos
            // 
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombreProducto,
            this.precioProducto,
            this.cantidadProducto});
            this.gridProductos.Location = new System.Drawing.Point(931, 251);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.ReadOnly = true;
            this.gridProductos.Size = new System.Drawing.Size(272, 320);
            this.gridProductos.TabIndex = 29;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "ID";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Width = 30;
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "NOMBRE";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            // 
            // precioProducto
            // 
            this.precioProducto.HeaderText = "PRECIO";
            this.precioProducto.Name = "precioProducto";
            this.precioProducto.ReadOnly = true;
            this.precioProducto.Width = 50;
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.HeaderText = "CANTIDAD";
            this.cantidadProducto.Name = "cantidadProducto";
            this.cantidadProducto.ReadOnly = true;
            this.cantidadProducto.Width = 50;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(139, 115);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(399, 26);
            this.txtNombreCliente.TabIndex = 30;
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCliente.Location = new System.Drawing.Point(139, 163);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(399, 26);
            this.txtDireccionCliente.TabIndex = 31;
            // 
            // txtEntreCallesCliente
            // 
            this.txtEntreCallesCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntreCallesCliente.Location = new System.Drawing.Point(139, 207);
            this.txtEntreCallesCliente.Name = "txtEntreCallesCliente";
            this.txtEntreCallesCliente.Size = new System.Drawing.Size(399, 26);
            this.txtEntreCallesCliente.TabIndex = 32;
            // 
            // txtColoniaCliente
            // 
            this.txtColoniaCliente.Location = new System.Drawing.Point(486, 772);
            this.txtColoniaCliente.Name = "txtColoniaCliente";
            this.txtColoniaCliente.Size = new System.Drawing.Size(167, 20);
            this.txtColoniaCliente.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "NOMBRE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "DIRECCION:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "ENTRE CALLES:";
            // 
            // SevicioDomicilio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1226, 755);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtColoniaCliente);
            this.Controls.Add(this.txtEntreCallesCliente);
            this.Controls.Add(this.txtDireccionCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbNomCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAceptarPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComen);
            this.Controls.Add(this.textTicketPedido);
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
        private System.Windows.Forms.TextBox textTicketPedido;
        private System.Windows.Forms.TextBox txtComen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptarPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNomCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProducto;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.TextBox txtEntreCallesCliente;
        private System.Windows.Forms.TextBox txtColoniaCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}