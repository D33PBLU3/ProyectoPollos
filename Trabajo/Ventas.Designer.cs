namespace Pollos
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.btnClientes = new System.Windows.Forms.Button();
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
            this.txtColoniaCliente = new System.Windows.Forms.TextBox();
            this.idCliente = new System.Windows.Forms.Label();
            this.telLabel = new System.Windows.Forms.Label();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.numPedido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pago = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cambio = new System.Windows.Forms.Label();
            this.pagoTotal = new System.Windows.Forms.NumericUpDown();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(794, 745);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(93, 28);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Registrar Cliente";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Visible = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
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
            this.button1.Location = new System.Drawing.Point(794, 814);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Eliminar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(794, 780);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Editar Cliente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
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
            this.txtComen.Location = new System.Drawing.Point(496, 281);
            this.txtComen.Multiline = true;
            this.txtComen.Name = "txtComen";
            this.txtComen.Size = new System.Drawing.Size(261, 68);
            this.txtComen.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Comentarios:";
            // 
            // btnAceptarPedido
            // 
            this.btnAceptarPedido.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAceptarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarPedido.Location = new System.Drawing.Point(563, 366);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha:";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(577, 22);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(0, 29);
            this.lbFecha.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 46);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total: $";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(916, 104);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 13);
            this.lbTotal.TabIndex = 17;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(147, 22);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(97, 46);
            this.labelTotal.TabIndex = 18;
            this.labelTotal.Text = "0.00";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(8, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(193, 431);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 36);
            this.button4.TabIndex = 9;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lime;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(100, 221);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 36);
            this.button5.TabIndex = 10;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Lime;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(288, 221);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 36);
            this.button6.TabIndex = 11;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Lime;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(193, 221);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 36);
            this.button7.TabIndex = 12;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Lime;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(383, 221);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 36);
            this.button8.TabIndex = 18;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Yellow;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(8, 431);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(89, 36);
            this.button9.TabIndex = 13;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Red;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(100, 389);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(89, 36);
            this.button10.TabIndex = 14;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(288, 305);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(89, 36);
            this.button11.TabIndex = 15;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Aqua;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(383, 263);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(89, 36);
            this.button12.TabIndex = 16;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Aqua;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(100, 263);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(89, 36);
            this.button13.TabIndex = 17;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Aqua;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(288, 263);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(89, 36);
            this.button14.TabIndex = 19;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Aqua;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(193, 263);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(89, 36);
            this.button15.TabIndex = 20;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Red;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button16.Location = new System.Drawing.Point(193, 389);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(89, 36);
            this.button16.TabIndex = 21;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.White;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(8, 305);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(89, 36);
            this.button17.TabIndex = 22;
            this.button17.Text = "button17";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.White;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(383, 305);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(89, 36);
            this.button18.TabIndex = 28;
            this.button18.Text = "button18";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.White;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(100, 305);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(89, 36);
            this.button19.TabIndex = 27;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Yellow;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(100, 431);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(89, 36);
            this.button20.TabIndex = 26;
            this.button20.Text = "button20";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.White;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(193, 305);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(89, 36);
            this.button21.TabIndex = 25;
            this.button21.Text = "button21";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Lime;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(8, 221);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(89, 36);
            this.button22.TabIndex = 24;
            this.button22.Text = "button22";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.White;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(100, 348);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(89, 36);
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
            this.gridProductos.Location = new System.Drawing.Point(496, 52);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(263, 180);
            this.gridProductos.TabIndex = 29;
            this.gridProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProductos_CellContentClick_1);
            this.gridProductos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProductos_CellValueChanged_1);
            this.gridProductos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.gridProductos_RowsRemoved_1);
            this.gridProductos.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gridProductos_UserDeletedRow);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "ID";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
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
            this.cantidadProducto.Width = 70;
            // 
            // txtColoniaCliente
            // 
            this.txtColoniaCliente.Location = new System.Drawing.Point(486, 772);
            this.txtColoniaCliente.Name = "txtColoniaCliente";
            this.txtColoniaCliente.Size = new System.Drawing.Size(167, 20);
            this.txtColoniaCliente.TabIndex = 33;
            // 
            // idCliente
            // 
            this.idCliente.AutoSize = true;
            this.idCliente.Location = new System.Drawing.Point(571, 235);
            this.idCliente.Name = "idCliente";
            this.idCliente.Size = new System.Drawing.Size(0, 13);
            this.idCliente.TabIndex = 37;
            this.idCliente.Visible = false;
            // 
            // telLabel
            // 
            this.telLabel.AutoSize = true;
            this.telLabel.Location = new System.Drawing.Point(560, 265);
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(0, 13);
            this.telLabel.TabIndex = 40;
            this.telLabel.Visible = false;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(288, 389);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(89, 36);
            this.button24.TabIndex = 41;
            this.button24.Text = "button24";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(288, 431);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(89, 36);
            this.button25.TabIndex = 42;
            this.button25.Text = "button25";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(383, 431);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(89, 36);
            this.button26.TabIndex = 43;
            this.button26.Text = "button26";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.Location = new System.Drawing.Point(383, 389);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(89, 36);
            this.button27.TabIndex = 44;
            this.button27.Text = "button27";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // numPedido
            // 
            this.numPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPedido.Location = new System.Drawing.Point(120, 188);
            this.numPedido.Name = "numPedido";
            this.numPedido.Size = new System.Drawing.Size(308, 21);
            this.numPedido.TabIndex = 45;
            this.numPedido.Visible = false;
            this.numPedido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numPedido_KeyDown_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "NUMERO PEDIDO:";
            this.label3.Visible = false;
            // 
            // pago
            // 
            this.pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pago.Location = new System.Drawing.Point(492, 550);
            this.pago.Name = "pago";
            this.pago.Size = new System.Drawing.Size(278, 53);
            this.pago.TabIndex = 47;
            this.pago.TextChanged += new System.EventHandler(this.pago_TextChanged);
            this.pago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 46);
            this.label5.TabIndex = 48;
            this.label5.Text = "Pagar:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 46);
            this.label6.TabIndex = 49;
            this.label6.Text = "Cambio: $";
            // 
            // cambio
            // 
            this.cambio.AutoSize = true;
            this.cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambio.Location = new System.Drawing.Point(196, 147);
            this.cambio.Name = "cambio";
            this.cambio.Size = new System.Drawing.Size(97, 46);
            this.cambio.TabIndex = 50;
            this.cambio.Text = "0.00";
            // 
            // pagoTotal
            // 
            this.pagoTotal.DecimalPlaces = 2;
            this.pagoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagoTotal.Location = new System.Drawing.Point(148, 77);
            this.pagoTotal.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.pagoTotal.Name = "pagoTotal";
            this.pagoTotal.Size = new System.Drawing.Size(229, 53);
            this.pagoTotal.TabIndex = 51;
            this.pagoTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pagoTotal_KeyDown);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.White;
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.Location = new System.Drawing.Point(8, 348);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(89, 36);
            this.button28.TabIndex = 52;
            this.button28.Text = "button28";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.White;
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.Location = new System.Drawing.Point(383, 348);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(89, 36);
            this.button29.TabIndex = 53;
            this.button29.Text = "button29";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.White;
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.Location = new System.Drawing.Point(288, 348);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(89, 36);
            this.button30.TabIndex = 54;
            this.button30.Text = "button30";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.White;
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button31.Location = new System.Drawing.Point(193, 348);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(89, 36);
            this.button31.TabIndex = 55;
            this.button31.Text = "button31";
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.Lime;
            this.button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button32.Location = new System.Drawing.Point(8, 263);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(89, 36);
            this.button32.TabIndex = 56;
            this.button32.Text = "button32";
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(782, 491);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.pagoTotal);
            this.Controls.Add(this.cambio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numPedido);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.telLabel);
            this.Controls.Add(this.idCliente);
            this.Controls.Add(this.txtColoniaCliente);
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
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAceptarPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComen);
            this.Controls.Add(this.textTicketPedido);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listClientes);
            this.Controls.Add(this.btnClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ventas";
            this.Text = "Sevicio a Domicilio";
            this.Load += new System.EventHandler(this.SevicioDomicilio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
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
        private System.Windows.Forms.TextBox txtColoniaCliente;
        private System.Windows.Forms.Label idCliente;
        private System.Windows.Forms.Label telLabel;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.TextBox numPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProducto;
        private System.Windows.Forms.TextBox pago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cambio;
        private System.Windows.Forms.NumericUpDown pagoTotal;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
    }
}