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
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(12, 325);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(114, 28);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Registrar Cliente";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(304, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(286, 20);
            this.txtBuscar.TabIndex = 3;
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
            this.listClientes.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listClientes.Location = new System.Drawing.Point(12, 46);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(807, 262);
            this.listClientes.TabIndex = 4;
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
            this.NOMBRE.Width = 156;
            // 
            // TELEFONO
            // 
            this.TELEFONO.Text = "TELEFONO";
            this.TELEFONO.Width = 131;
            // 
            // DIRECCION
            // 
            this.DIRECCION.Text = "DIRECCION";
            this.DIRECCION.Width = 184;
            // 
            // CALLES
            // 
            this.CALLES.Text = "CALLES";
            this.CALLES.Width = 131;
            // 
            // COLONIA
            // 
            this.COLONIA.Text = "COLONIA";
            this.COLONIA.Width = 129;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(704, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Eliminar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Editar Cliente";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SevicioDomicilio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 365);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listClientes);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnClientes);
            this.Name = "SevicioDomicilio";
            this.Text = "SevicioDomicilio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnBuscar;
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
    }
}