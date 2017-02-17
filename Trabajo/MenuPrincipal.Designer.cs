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
            this.btnServicioDomicilio = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnConfiguracionUsuarios = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnServicioDomicilio
            // 
            this.btnServicioDomicilio.Location = new System.Drawing.Point(27, 72);
            this.btnServicioDomicilio.Name = "btnServicioDomicilio";
            this.btnServicioDomicilio.Size = new System.Drawing.Size(199, 84);
            this.btnServicioDomicilio.TabIndex = 0;
            this.btnServicioDomicilio.Text = "SERVICIO DOMICILIO";
            this.btnServicioDomicilio.UseVisualStyleBackColor = true;
            this.btnServicioDomicilio.Click += new System.EventHandler(this.btnServicioDomicilio_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(256, 72);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(205, 84);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnConfiguracionUsuarios
            // 
            this.btnConfiguracionUsuarios.Location = new System.Drawing.Point(499, 72);
            this.btnConfiguracionUsuarios.Name = "btnConfiguracionUsuarios";
            this.btnConfiguracionUsuarios.Size = new System.Drawing.Size(198, 84);
            this.btnConfiguracionUsuarios.TabIndex = 2;
            this.btnConfiguracionUsuarios.Text = "CONFIGURACION";
            this.btnConfiguracionUsuarios.UseVisualStyleBackColor = true;
            this.btnConfiguracionUsuarios.Click += new System.EventHandler(this.btnConfiguracionUsuarios_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(736, 72);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(207, 84);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 217);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnConfiguracionUsuarios);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnServicioDomicilio);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
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