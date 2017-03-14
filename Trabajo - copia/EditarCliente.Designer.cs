namespace Pollos
{
    partial class EditarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarCliente));
            this.btnEditar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirC = new System.Windows.Forms.TextBox();
            this.txtEntreC = new System.Windows.Forms.TextBox();
            this.txtColoniaC = new System.Windows.Forms.TextBox();
            this.txtTelC = new System.Windows.Forms.TextBox();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(289, 109);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Entre que calles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Colonia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre";
            // 
            // txtDirC
            // 
            this.txtDirC.Location = new System.Drawing.Point(153, 29);
            this.txtDirC.Name = "txtDirC";
            this.txtDirC.Size = new System.Drawing.Size(100, 20);
            this.txtDirC.TabIndex = 2;
            // 
            // txtEntreC
            // 
            this.txtEntreC.Location = new System.Drawing.Point(289, 29);
            this.txtEntreC.Name = "txtEntreC";
            this.txtEntreC.Size = new System.Drawing.Size(100, 20);
            this.txtEntreC.TabIndex = 3;
            // 
            // txtColoniaC
            // 
            this.txtColoniaC.Location = new System.Drawing.Point(153, 109);
            this.txtColoniaC.Name = "txtColoniaC";
            this.txtColoniaC.Size = new System.Drawing.Size(100, 20);
            this.txtColoniaC.TabIndex = 5;
            // 
            // txtTelC
            // 
            this.txtTelC.Location = new System.Drawing.Point(12, 109);
            this.txtTelC.Name = "txtTelC";
            this.txtTelC.Size = new System.Drawing.Size(100, 20);
            this.txtTelC.TabIndex = 4;
            // 
            // txtNombreC
            // 
            this.txtNombreC.Location = new System.Drawing.Point(12, 29);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(100, 20);
            this.txtNombreC.TabIndex = 1;
            // 
            // EditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 156);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDirC);
            this.Controls.Add(this.txtEntreC);
            this.Controls.Add(this.txtColoniaC);
            this.Controls.Add(this.txtTelC);
            this.Controls.Add(this.txtNombreC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditarCliente";
            this.Text = "Editar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirC;
        private System.Windows.Forms.TextBox txtEntreC;
        private System.Windows.Forms.TextBox txtColoniaC;
        private System.Windows.Forms.TextBox txtTelC;
        private System.Windows.Forms.TextBox txtNombreC;
    }
}