namespace Pollos
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnServicioDomicilio = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnConfiguracionUsuarios = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnServicioDomicilio
            // 
            this.btnServicioDomicilio.Image = ((System.Drawing.Image)(resources.GetObject("btnServicioDomicilio.Image")));
            this.btnServicioDomicilio.Location = new System.Drawing.Point(12, 12);
            this.btnServicioDomicilio.Name = "btnServicioDomicilio";
            this.btnServicioDomicilio.Size = new System.Drawing.Size(67, 57);
            this.btnServicioDomicilio.TabIndex = 0;
            this.btnServicioDomicilio.UseVisualStyleBackColor = true;
            this.btnServicioDomicilio.Click += new System.EventHandler(this.btnServicioDomicilio_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.Location = new System.Drawing.Point(158, 12);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(67, 57);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnConfiguracionUsuarios
            // 
            this.btnConfiguracionUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracionUsuarios.Image")));
            this.btnConfiguracionUsuarios.Location = new System.Drawing.Point(231, 12);
            this.btnConfiguracionUsuarios.Name = "btnConfiguracionUsuarios";
            this.btnConfiguracionUsuarios.Size = new System.Drawing.Size(67, 57);
            this.btnConfiguracionUsuarios.TabIndex = 2;
            this.btnConfiguracionUsuarios.UseVisualStyleBackColor = true;
            this.btnConfiguracionUsuarios.Click += new System.EventHandler(this.btnConfiguracionUsuarios_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.Location = new System.Drawing.Point(85, 12);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(67, 57);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 80);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnConfiguracionUsuarios);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnServicioDomicilio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnServicioDomicilio;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnConfiguracionUsuarios;
        private System.Windows.Forms.Button btnVentas;
    }
}