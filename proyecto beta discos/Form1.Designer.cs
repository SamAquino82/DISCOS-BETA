﻿namespace proyecto_beta_discos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.pbxDiscos = new System.Windows.Forms.PictureBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminarfisica = new System.Windows.Forms.Button();
            this.btneliminarlogico = new System.Windows.Forms.Button();
            this.lblfiltro = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtfiltrar = new System.Windows.Forms.TextBox();
            this.lblcampo = new System.Windows.Forms.Label();
            this.lblcriterio = new System.Windows.Forms.Label();
            this.lblfiltroavanzado = new System.Windows.Forms.Label();
            this.txtfiltroavanzado = new System.Windows.Forms.TextBox();
            this.cbocriterio = new System.Windows.Forms.ComboBox();
            this.cbocampo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv1.Location = new System.Drawing.Point(16, 80);
            this.dgv1.Margin = new System.Windows.Forms.Padding(4);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(735, 319);
            this.dgv1.TabIndex = 0;
            this.dgv1.SelectionChanged += new System.EventHandler(this.dgv1_SelectionChanged);
            // 
            // pbxDiscos
            // 
            this.pbxDiscos.Location = new System.Drawing.Point(759, 80);
            this.pbxDiscos.Margin = new System.Windows.Forms.Padding(4);
            this.pbxDiscos.Name = "pbxDiscos";
            this.pbxDiscos.Size = new System.Drawing.Size(304, 319);
            this.pbxDiscos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDiscos.TabIndex = 1;
            this.pbxDiscos.TabStop = false;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(16, 418);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(99, 47);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(122, 418);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(119, 47);
            this.btnmodificar.TabIndex = 3;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminarfisica
            // 
            this.btneliminarfisica.Location = new System.Drawing.Point(247, 418);
            this.btneliminarfisica.Name = "btneliminarfisica";
            this.btneliminarfisica.Size = new System.Drawing.Size(121, 47);
            this.btneliminarfisica.TabIndex = 4;
            this.btneliminarfisica.Text = "Eliminar Fisica";
            this.btneliminarfisica.UseVisualStyleBackColor = true;
            this.btneliminarfisica.Click += new System.EventHandler(this.btneliminarfisica_Click);
            // 
            // btneliminarlogico
            // 
            this.btneliminarlogico.Location = new System.Drawing.Point(374, 418);
            this.btneliminarlogico.Name = "btneliminarlogico";
            this.btneliminarlogico.Size = new System.Drawing.Size(121, 47);
            this.btneliminarlogico.TabIndex = 5;
            this.btneliminarlogico.Text = "Eliminar Logica";
            this.btneliminarlogico.UseVisualStyleBackColor = true;
            this.btneliminarlogico.Click += new System.EventHandler(this.btneliminarlogico_Click);
            // 
            // lblfiltro
            // 
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.Location = new System.Drawing.Point(13, 48);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(39, 16);
            this.lblfiltro.TabIndex = 6;
            this.lblfiltro.Text = "Filtro:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(640, 485);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(111, 31);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtfiltrar
            // 
            this.txtfiltrar.Location = new System.Drawing.Point(58, 42);
            this.txtfiltrar.Name = "txtfiltrar";
            this.txtfiltrar.Size = new System.Drawing.Size(310, 22);
            this.txtfiltrar.TabIndex = 8;
            this.txtfiltrar.TextChanged += new System.EventHandler(this.txtfiltrar_TextChanged);
            // 
            // lblcampo
            // 
            this.lblcampo.AutoSize = true;
            this.lblcampo.Location = new System.Drawing.Point(13, 500);
            this.lblcampo.Name = "lblcampo";
            this.lblcampo.Size = new System.Drawing.Size(54, 16);
            this.lblcampo.TabIndex = 9;
            this.lblcampo.Text = "Campo:";
            // 
            // lblcriterio
            // 
            this.lblcriterio.AutoSize = true;
            this.lblcriterio.Location = new System.Drawing.Point(202, 500);
            this.lblcriterio.Name = "lblcriterio";
            this.lblcriterio.Size = new System.Drawing.Size(52, 16);
            this.lblcriterio.TabIndex = 11;
            this.lblcriterio.Text = "Criterio:";
            // 
            // lblfiltroavanzado
            // 
            this.lblfiltroavanzado.AutoSize = true;
            this.lblfiltroavanzado.Location = new System.Drawing.Point(389, 500);
            this.lblfiltroavanzado.Name = "lblfiltroavanzado";
            this.lblfiltroavanzado.Size = new System.Drawing.Size(39, 16);
            this.lblfiltroavanzado.TabIndex = 12;
            this.lblfiltroavanzado.Text = "Filtro:";
            // 
            // txtfiltroavanzado
            // 
            this.txtfiltroavanzado.Location = new System.Drawing.Point(435, 494);
            this.txtfiltroavanzado.Name = "txtfiltroavanzado";
            this.txtfiltroavanzado.Size = new System.Drawing.Size(121, 22);
            this.txtfiltroavanzado.TabIndex = 14;
            this.txtfiltroavanzado.TextChanged += new System.EventHandler(this.txtfiltroavanzado_TextChanged);
            // 
            // cbocriterio
            // 
            this.cbocriterio.FormattingEnabled = true;
            this.cbocriterio.Location = new System.Drawing.Point(261, 492);
            this.cbocriterio.Name = "cbocriterio";
            this.cbocriterio.Size = new System.Drawing.Size(121, 24);
            this.cbocriterio.TabIndex = 15;
            // 
            // cbocampo
            // 
            this.cbocampo.FormattingEnabled = true;
            this.cbocampo.Location = new System.Drawing.Point(74, 492);
            this.cbocampo.Name = "cbocampo";
            this.cbocampo.Size = new System.Drawing.Size(121, 24);
            this.cbocampo.TabIndex = 16;
            this.cbocampo.SelectedIndexChanged += new System.EventHandler(this.cbocampo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cbocampo);
            this.Controls.Add(this.cbocriterio);
            this.Controls.Add(this.txtfiltroavanzado);
            this.Controls.Add(this.lblfiltroavanzado);
            this.Controls.Add(this.lblcriterio);
            this.Controls.Add(this.lblcampo);
            this.Controls.Add(this.txtfiltrar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblfiltro);
            this.Controls.Add(this.btneliminarlogico);
            this.Controls.Add(this.btneliminarfisica);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.pbxDiscos);
            this.Controls.Add(this.dgv1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiscos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.PictureBox pbxDiscos;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminarfisica;
        private System.Windows.Forms.Button btneliminarlogico;
        private System.Windows.Forms.Label lblfiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtfiltrar;
        private System.Windows.Forms.Label lblcampo;
        private System.Windows.Forms.Label lblcriterio;
        private System.Windows.Forms.Label lblfiltroavanzado;
        private System.Windows.Forms.TextBox txtfiltroavanzado;
        private System.Windows.Forms.ComboBox cbocriterio;
        private System.Windows.Forms.ComboBox cbocampo;
    }
}

