﻿namespace Pollos
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnRep = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.btnProductos.TabIndex = 2;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnConfiguracionUsuarios
            // 
            this.btnConfiguracionUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracionUsuarios.Image")));
            this.btnConfiguracionUsuarios.Location = new System.Drawing.Point(393, 14);
            this.btnConfiguracionUsuarios.Name = "btnConfiguracionUsuarios";
            this.btnConfiguracionUsuarios.Size = new System.Drawing.Size(67, 57);
            this.btnConfiguracionUsuarios.TabIndex = 3;
            this.btnConfiguracionUsuarios.UseVisualStyleBackColor = true;
            this.btnConfiguracionUsuarios.Click += new System.EventHandler(this.btnConfiguracionUsuarios_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.Location = new System.Drawing.Point(85, 12);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(67, 57);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(231, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 55);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRep
            // 
            this.btnRep.Image = ((System.Drawing.Image)(resources.GetObject("btnRep.Image")));
            this.btnRep.Location = new System.Drawing.Point(312, 14);
            this.btnRep.Name = "btnRep";
            this.btnRep.Size = new System.Drawing.Size(75, 55);
            this.btnRep.TabIndex = 5;
            this.btnRep.UseVisualStyleBackColor = true;
            this.btnRep.Click += new System.EventHandler(this.btnRep_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(466, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 57);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 79);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRep);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRep;
        private System.Windows.Forms.Button button2;
    }
}