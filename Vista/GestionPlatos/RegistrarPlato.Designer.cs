﻿namespace Vista.GestionPlatos
{
    partial class RegistrarPlato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPlato));
            this.panelRegistrarPlato = new System.Windows.Forms.Panel();
            this.btnCerrarRegistrarIngrediente = new System.Windows.Forms.Button();
            this.labelRegistrarPlato = new System.Windows.Forms.Label();
            this.labelNombreRP = new System.Windows.Forms.Label();
            this.labelStockRP = new System.Windows.Forms.Label();
            this.txtNombreRP = new System.Windows.Forms.TextBox();
            this.txtStockRP = new System.Windows.Forms.TextBox();
            this.btnRegistrarRP = new System.Windows.Forms.Button();
            this.btnAñadirRP = new System.Windows.Forms.Button();
            this.labelDescripcionRP = new System.Windows.Forms.Label();
            this.labelPrecioRP = new System.Windows.Forms.Label();
            this.txtPrecioRP = new System.Windows.Forms.TextBox();
            this.cmbDescripcionRP = new System.Windows.Forms.ComboBox();
            this.dgvRegistrarPlato = new System.Windows.Forms.DataGridView();
            this.btnLimpiarRP = new System.Windows.Forms.Button();
            this.panelRegistrarPlato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarPlato)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRegistrarPlato
            // 
            this.panelRegistrarPlato.BackColor = System.Drawing.Color.Khaki;
            this.panelRegistrarPlato.Controls.Add(this.btnCerrarRegistrarIngrediente);
            this.panelRegistrarPlato.Controls.Add(this.labelRegistrarPlato);
            this.panelRegistrarPlato.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegistrarPlato.Location = new System.Drawing.Point(0, 0);
            this.panelRegistrarPlato.Name = "panelRegistrarPlato";
            this.panelRegistrarPlato.Size = new System.Drawing.Size(804, 51);
            this.panelRegistrarPlato.TabIndex = 0;
            this.panelRegistrarPlato.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRegistrarPlato_MouseDown);
            // 
            // btnCerrarRegistrarIngrediente
            // 
            this.btnCerrarRegistrarIngrediente.BackColor = System.Drawing.Color.Khaki;
            this.btnCerrarRegistrarIngrediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarRegistrarIngrediente.FlatAppearance.BorderSize = 0;
            this.btnCerrarRegistrarIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarRegistrarIngrediente.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarRegistrarIngrediente.Image")));
            this.btnCerrarRegistrarIngrediente.Location = new System.Drawing.Point(757, 8);
            this.btnCerrarRegistrarIngrediente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarRegistrarIngrediente.Name = "btnCerrarRegistrarIngrediente";
            this.btnCerrarRegistrarIngrediente.Size = new System.Drawing.Size(34, 35);
            this.btnCerrarRegistrarIngrediente.TabIndex = 18;
            this.btnCerrarRegistrarIngrediente.UseVisualStyleBackColor = false;
            this.btnCerrarRegistrarIngrediente.Click += new System.EventHandler(this.btnCerrarRegistrarIngrediente_Click);
            // 
            // labelRegistrarPlato
            // 
            this.labelRegistrarPlato.AutoSize = true;
            this.labelRegistrarPlato.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrarPlato.Location = new System.Drawing.Point(278, 0);
            this.labelRegistrarPlato.Name = "labelRegistrarPlato";
            this.labelRegistrarPlato.Size = new System.Drawing.Size(227, 43);
            this.labelRegistrarPlato.TabIndex = 17;
            this.labelRegistrarPlato.Text = "REGISTRAR PLATO";
            // 
            // labelNombreRP
            // 
            this.labelNombreRP.AutoSize = true;
            this.labelNombreRP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreRP.Location = new System.Drawing.Point(63, 82);
            this.labelNombreRP.Name = "labelNombreRP";
            this.labelNombreRP.Size = new System.Drawing.Size(145, 34);
            this.labelNombreRP.TabIndex = 2;
            this.labelNombreRP.Text = "NOMBRE        :";
            // 
            // labelStockRP
            // 
            this.labelStockRP.AutoSize = true;
            this.labelStockRP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockRP.Location = new System.Drawing.Point(64, 276);
            this.labelStockRP.Name = "labelStockRP";
            this.labelStockRP.Size = new System.Drawing.Size(138, 34);
            this.labelStockRP.TabIndex = 3;
            this.labelStockRP.Text = "STOCK          :";
            // 
            // txtNombreRP
            // 
            this.txtNombreRP.Location = new System.Drawing.Point(226, 90);
            this.txtNombreRP.Name = "txtNombreRP";
            this.txtNombreRP.Size = new System.Drawing.Size(210, 26);
            this.txtNombreRP.TabIndex = 4;
            // 
            // txtStockRP
            // 
            this.txtStockRP.Location = new System.Drawing.Point(226, 285);
            this.txtStockRP.Name = "txtStockRP";
            this.txtStockRP.Size = new System.Drawing.Size(210, 26);
            this.txtStockRP.TabIndex = 5;
            // 
            // btnRegistrarRP
            // 
            this.btnRegistrarRP.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarRP.FlatAppearance.BorderSize = 0;
            this.btnRegistrarRP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarRP.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarRP.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarRP.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarRP.Image")));
            this.btnRegistrarRP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarRP.Location = new System.Drawing.Point(255, 526);
            this.btnRegistrarRP.Name = "btnRegistrarRP";
            this.btnRegistrarRP.Size = new System.Drawing.Size(250, 132);
            this.btnRegistrarRP.TabIndex = 6;
            this.btnRegistrarRP.Text = "REGISTRAR";
            this.btnRegistrarRP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarRP.UseVisualStyleBackColor = false;
            // 
            // btnAñadirRP
            // 
            this.btnAñadirRP.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirRP.FlatAppearance.BorderSize = 0;
            this.btnAñadirRP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirRP.ForeColor = System.Drawing.Color.Black;
            this.btnAñadirRP.Location = new System.Drawing.Point(461, 145);
            this.btnAñadirRP.Name = "btnAñadirRP";
            this.btnAñadirRP.Size = new System.Drawing.Size(99, 43);
            this.btnAñadirRP.TabIndex = 7;
            this.btnAñadirRP.Text = "AÑADIR";
            this.btnAñadirRP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadirRP.UseVisualStyleBackColor = false;
            // 
            // labelDescripcionRP
            // 
            this.labelDescripcionRP.AutoSize = true;
            this.labelDescripcionRP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionRP.Location = new System.Drawing.Point(63, 145);
            this.labelDescripcionRP.Name = "labelDescripcionRP";
            this.labelDescripcionRP.Size = new System.Drawing.Size(144, 34);
            this.labelDescripcionRP.TabIndex = 8;
            this.labelDescripcionRP.Text = "DESCRIPCION :";
            // 
            // labelPrecioRP
            // 
            this.labelPrecioRP.AutoSize = true;
            this.labelPrecioRP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioRP.Location = new System.Drawing.Point(64, 212);
            this.labelPrecioRP.Name = "labelPrecioRP";
            this.labelPrecioRP.Size = new System.Drawing.Size(140, 34);
            this.labelPrecioRP.TabIndex = 9;
            this.labelPrecioRP.Text = "PRECIO         :";
            // 
            // txtPrecioRP
            // 
            this.txtPrecioRP.Location = new System.Drawing.Point(226, 220);
            this.txtPrecioRP.Name = "txtPrecioRP";
            this.txtPrecioRP.Size = new System.Drawing.Size(210, 26);
            this.txtPrecioRP.TabIndex = 10;
            // 
            // cmbDescripcionRP
            // 
            this.cmbDescripcionRP.FormattingEnabled = true;
            this.cmbDescripcionRP.Location = new System.Drawing.Point(226, 154);
            this.cmbDescripcionRP.Name = "cmbDescripcionRP";
            this.cmbDescripcionRP.Size = new System.Drawing.Size(210, 28);
            this.cmbDescripcionRP.TabIndex = 11;
            // 
            // dgvRegistrarPlato
            // 
            this.dgvRegistrarPlato.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvRegistrarPlato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrarPlato.Location = new System.Drawing.Point(12, 360);
            this.dgvRegistrarPlato.Name = "dgvRegistrarPlato";
            this.dgvRegistrarPlato.RowHeadersWidth = 62;
            this.dgvRegistrarPlato.RowTemplate.Height = 28;
            this.dgvRegistrarPlato.Size = new System.Drawing.Size(779, 160);
            this.dgvRegistrarPlato.TabIndex = 12;
            // 
            // btnLimpiarRP
            // 
            this.btnLimpiarRP.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarRP.FlatAppearance.BorderSize = 0;
            this.btnLimpiarRP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarRP.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarRP.Location = new System.Drawing.Point(680, 526);
            this.btnLimpiarRP.Name = "btnLimpiarRP";
            this.btnLimpiarRP.Size = new System.Drawing.Size(111, 43);
            this.btnLimpiarRP.TabIndex = 13;
            this.btnLimpiarRP.Text = "LIMPIAR";
            this.btnLimpiarRP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarRP.UseVisualStyleBackColor = false;
            // 
            // RegistrarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(804, 660);
            this.Controls.Add(this.btnLimpiarRP);
            this.Controls.Add(this.dgvRegistrarPlato);
            this.Controls.Add(this.cmbDescripcionRP);
            this.Controls.Add(this.txtPrecioRP);
            this.Controls.Add(this.labelPrecioRP);
            this.Controls.Add(this.labelDescripcionRP);
            this.Controls.Add(this.btnAñadirRP);
            this.Controls.Add(this.btnRegistrarRP);
            this.Controls.Add(this.txtStockRP);
            this.Controls.Add(this.txtNombreRP);
            this.Controls.Add(this.labelStockRP);
            this.Controls.Add(this.labelNombreRP);
            this.Controls.Add(this.panelRegistrarPlato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarPlato";
            this.Text = "RegistrarPlato";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistrarPlato_MouseDown);
            this.panelRegistrarPlato.ResumeLayout(false);
            this.panelRegistrarPlato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarPlato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRegistrarPlato;
        private System.Windows.Forms.Label labelRegistrarPlato;
        private System.Windows.Forms.Button btnCerrarRegistrarIngrediente;
        private System.Windows.Forms.Label labelNombreRP;
        private System.Windows.Forms.Label labelStockRP;
        private System.Windows.Forms.TextBox txtNombreRP;
        private System.Windows.Forms.TextBox txtStockRP;
        private System.Windows.Forms.Button btnRegistrarRP;
        private System.Windows.Forms.Button btnAñadirRP;
        private System.Windows.Forms.Label labelDescripcionRP;
        private System.Windows.Forms.Label labelPrecioRP;
        private System.Windows.Forms.TextBox txtPrecioRP;
        private System.Windows.Forms.ComboBox cmbDescripcionRP;
        private System.Windows.Forms.DataGridView dgvRegistrarPlato;
        private System.Windows.Forms.Button btnLimpiarRP;
    }
}