﻿namespace Pollos
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.listProductos = new System.Windows.Forms.ListView();
            this.idProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombreProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipoProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precioProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listProductos
            // 
            this.listProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idProducto,
            this.nombreProducto,
            this.tipoProducto,
            this.precioProducto});
            this.listProductos.Location = new System.Drawing.Point(12, 12);
            this.listProductos.Name = "listProductos";
            this.listProductos.Size = new System.Drawing.Size(477, 320);
            this.listProductos.TabIndex = 0;
            this.listProductos.UseCompatibleStateImageBehavior = false;
            this.listProductos.View = System.Windows.Forms.View.Details;
            // 
            // idProducto
            // 
            this.idProducto.Text = "ID";
            this.idProducto.Width = 89;
            // 
            // nombreProducto
            // 
            this.nombreProducto.Text = "NOMBRE";
            this.nombreProducto.Width = 178;
            // 
            // tipoProducto
            // 
            this.tipoProducto.Text = "TIPO";
            this.tipoProducto.Width = 101;
            // 
            // precioProducto
            // 
            this.precioProducto.Text = "PRECIO";
            this.precioProducto.Width = 103;
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditarProducto.Location = new System.Drawing.Point(490, 12);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(102, 66);
            this.btnEditarProducto.TabIndex = 2;
            this.btnEditarProducto.Text = "Editar Producto";
            this.btnEditarProducto.UseVisualStyleBackColor = false;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 358);
            this.Controls.Add(this.btnEditarProducto);
            this.Controls.Add(this.listProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listProductos;
        private System.Windows.Forms.ColumnHeader idProducto;
        private System.Windows.Forms.ColumnHeader tipoProducto;
        private System.Windows.Forms.ColumnHeader nombreProducto;
        private System.Windows.Forms.ColumnHeader precioProducto;
        private System.Windows.Forms.Button btnEditarProducto;
    }
}