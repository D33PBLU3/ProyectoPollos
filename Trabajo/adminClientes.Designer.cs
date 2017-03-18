namespace Pollos
{
    partial class adminClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminClientes));
            this.listClientes = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NOMBRE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TELEFONO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DIRECCION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CALLES = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.COLONIA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.buscarNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listClientes
            // 
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
            this.listClientes.Location = new System.Drawing.Point(12, 47);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(628, 299);
            this.listClientes.TabIndex = 5;
            this.listClientes.UseCompatibleStateImageBehavior = false;
            this.listClientes.View = System.Windows.Forms.View.Details;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(646, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 66);
            this.button2.TabIndex = 7;
            this.button2.Text = "Editar Cliente";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(646, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 71);
            this.button1.TabIndex = 8;
            this.button1.Text = "Eliminar Cliente";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClientes.Location = new System.Drawing.Point(646, 47);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(93, 71);
            this.btnClientes.TabIndex = 6;
            this.btnClientes.Text = "Registrar Cliente";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // buscarNombre
            // 
            this.buscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarNombre.Location = new System.Drawing.Point(12, 12);
            this.buscarNombre.Name = "buscarNombre";
            this.buscarNombre.Size = new System.Drawing.Size(628, 29);
            this.buscarNombre.TabIndex = 9;
            this.buscarNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // adminClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 367);
            this.Controls.Add(this.buscarNombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.listClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.adminClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listClientes;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NOMBRE;
        private System.Windows.Forms.ColumnHeader TELEFONO;
        private System.Windows.Forms.ColumnHeader DIRECCION;
        private System.Windows.Forms.ColumnHeader CALLES;
        private System.Windows.Forms.ColumnHeader COLONIA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.TextBox buscarNombre;
    }
}