namespace proyecto_beta_discos
{
    partial class frmaltadisco
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblventas = new System.Windows.Forms.Label();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.txtventas = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.bttnaceptar = new System.Windows.Forms.Button();
            this.bttncancelar = new System.Windows.Forms.Button();
            this.lblFormato = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.cboestilo = new System.Windows.Forms.ComboBox();
            this.cboformato = new System.Windows.Forms.ComboBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.pbxDiscos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(100, 17);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(43, 16);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Titulo:";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(100, 47);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(48, 16);
            this.lblfecha.TabIndex = 1;
            this.lblfecha.Text = "Fecha:";
            // 
            // lblventas
            // 
            this.lblventas.AutoSize = true;
            this.lblventas.Location = new System.Drawing.Point(96, 81);
            this.lblventas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblventas.Name = "lblventas";
            this.lblventas.Size = new System.Drawing.Size(52, 16);
            this.lblventas.TabIndex = 2;
            this.lblventas.Text = "Ventas:";
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(162, 9);
            this.txttitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(160, 22);
            this.txttitulo.TabIndex = 3;
            // 
            // txtventas
            // 
            this.txtventas.Location = new System.Drawing.Point(162, 78);
            this.txtventas.Margin = new System.Windows.Forms.Padding(4);
            this.txtventas.Name = "txtventas";
            this.txtventas.Size = new System.Drawing.Size(160, 22);
            this.txtventas.TabIndex = 4;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(162, 44);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(160, 22);
            this.txtfecha.TabIndex = 5;
            // 
            // bttnaceptar
            // 
            this.bttnaceptar.Location = new System.Drawing.Point(84, 242);
            this.bttnaceptar.Margin = new System.Windows.Forms.Padding(4);
            this.bttnaceptar.Name = "bttnaceptar";
            this.bttnaceptar.Size = new System.Drawing.Size(105, 36);
            this.bttnaceptar.TabIndex = 6;
            this.bttnaceptar.Text = "Aceptar";
            this.bttnaceptar.UseVisualStyleBackColor = true;
            this.bttnaceptar.Click += new System.EventHandler(this.bttnaceptar_Click);
            // 
            // bttncancelar
            // 
            this.bttncancelar.Location = new System.Drawing.Point(252, 242);
            this.bttncancelar.Margin = new System.Windows.Forms.Padding(4);
            this.bttncancelar.Name = "bttncancelar";
            this.bttncancelar.Size = new System.Drawing.Size(105, 36);
            this.bttncancelar.TabIndex = 7;
            this.bttncancelar.Text = "Cancelar";
            this.bttncancelar.UseVisualStyleBackColor = true;
            this.bttncancelar.Click += new System.EventHandler(this.bttncancelar_Click);
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Location = new System.Drawing.Point(84, 196);
            this.lblFormato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(60, 16);
            this.lblFormato.TabIndex = 8;
            this.lblFormato.Text = "Formato:";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(102, 147);
            this.lbltipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(43, 16);
            this.lbltipo.TabIndex = 9;
            this.lbltipo.Text = "Estilo:";
            // 
            // cboestilo
            // 
            this.cboestilo.FormattingEnabled = true;
            this.cboestilo.Location = new System.Drawing.Point(162, 147);
            this.cboestilo.Margin = new System.Windows.Forms.Padding(4);
            this.cboestilo.Name = "cboestilo";
            this.cboestilo.Size = new System.Drawing.Size(160, 24);
            this.cboestilo.TabIndex = 10;
            // 
            // cboformato
            // 
            this.cboformato.FormattingEnabled = true;
            this.cboformato.Location = new System.Drawing.Point(162, 186);
            this.cboformato.Margin = new System.Windows.Forms.Padding(4);
            this.cboformato.Name = "cboformato";
            this.cboformato.Size = new System.Drawing.Size(160, 24);
            this.cboformato.TabIndex = 11;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(76, 115);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(75, 16);
            this.lblUrl.TabIndex = 12;
            this.lblUrl.Text = "UrlImagen: ";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(162, 112);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(160, 22);
            this.txtUrl.TabIndex = 13;
            this.txtUrl.Leave += new System.EventHandler(this.txtUrl_Leave);
            // 
            // pbxDiscos
            // 
            this.pbxDiscos.Location = new System.Drawing.Point(349, 9);
            this.pbxDiscos.Name = "pbxDiscos";
            this.pbxDiscos.Size = new System.Drawing.Size(232, 203);
            this.pbxDiscos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDiscos.TabIndex = 14;
            this.pbxDiscos.TabStop = false;
            // 
            // frmaltadisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 311);
            this.Controls.Add(this.pbxDiscos);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.cboformato);
            this.Controls.Add(this.cboestilo);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.bttncancelar);
            this.Controls.Add(this.bttnaceptar);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtventas);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.lblventas);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lbltitulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmaltadisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Disco";
            this.Load += new System.EventHandler(this.frmaltadisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiscos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblventas;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.TextBox txtventas;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Button bttnaceptar;
        private System.Windows.Forms.Button bttncancelar;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.ComboBox cboestilo;
        private System.Windows.Forms.ComboBox cboformato;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.PictureBox pbxDiscos;
    }
}