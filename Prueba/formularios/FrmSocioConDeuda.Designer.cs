namespace AplicacionGym
{
    partial class FrmSocioConDeuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSocioConDeuda));
            this.VerSociosConDeuda = new System.Windows.Forms.Label();
            this.PictureBoxLogoSociosDeudas = new System.Windows.Forms.PictureBox();
            this.BarraTituloSociosDeudas = new System.Windows.Forms.Panel();
            this.PtbCerrarFormulariosSociosDeuda = new System.Windows.Forms.PictureBox();
            this.DataGridViewBaseDeDatosMostrarSociosDeudas = new System.Windows.Forms.DataGridView();
            this.NombreSocioDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoSocioDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasDeudaSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogoSociosDeudas)).BeginInit();
            this.BarraTituloSociosDeudas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrarFormulariosSociosDeuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBaseDeDatosMostrarSociosDeudas)).BeginInit();
            this.SuspendLayout();
            // 
            // VerSociosConDeuda
            // 
            this.VerSociosConDeuda.AutoSize = true;
            this.VerSociosConDeuda.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerSociosConDeuda.ForeColor = System.Drawing.Color.White;
            this.VerSociosConDeuda.Location = new System.Drawing.Point(261, 6);
            this.VerSociosConDeuda.Name = "VerSociosConDeuda";
            this.VerSociosConDeuda.Size = new System.Drawing.Size(389, 48);
            this.VerSociosConDeuda.TabIndex = 2;
            this.VerSociosConDeuda.Text = "VER SOCIOS CON DEUDA";
            this.VerSociosConDeuda.Click += new System.EventHandler(this.VerEstadisticas_Click);
            // 
            // PictureBoxLogoSociosDeudas
            // 
            this.PictureBoxLogoSociosDeudas.BackColor = System.Drawing.Color.SeaGreen;
            this.PictureBoxLogoSociosDeudas.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogoSociosDeudas.Image")));
            this.PictureBoxLogoSociosDeudas.Location = new System.Drawing.Point(-27, -5);
            this.PictureBoxLogoSociosDeudas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBoxLogoSociosDeudas.Name = "PictureBoxLogoSociosDeudas";
            this.PictureBoxLogoSociosDeudas.Size = new System.Drawing.Size(266, 65);
            this.PictureBoxLogoSociosDeudas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLogoSociosDeudas.TabIndex = 0;
            this.PictureBoxLogoSociosDeudas.TabStop = false;
            // 
            // BarraTituloSociosDeudas
            // 
            this.BarraTituloSociosDeudas.BackColor = System.Drawing.Color.SeaGreen;
            this.BarraTituloSociosDeudas.Controls.Add(this.VerSociosConDeuda);
            this.BarraTituloSociosDeudas.Controls.Add(this.PictureBoxLogoSociosDeudas);
            this.BarraTituloSociosDeudas.Controls.Add(this.PtbCerrarFormulariosSociosDeuda);
            this.BarraTituloSociosDeudas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTituloSociosDeudas.Location = new System.Drawing.Point(0, 0);
            this.BarraTituloSociosDeudas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarraTituloSociosDeudas.Name = "BarraTituloSociosDeudas";
            this.BarraTituloSociosDeudas.Size = new System.Drawing.Size(804, 61);
            this.BarraTituloSociosDeudas.TabIndex = 5;
            // 
            // PtbCerrarFormulariosSociosDeuda
            // 
            this.PtbCerrarFormulariosSociosDeuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PtbCerrarFormulariosSociosDeuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PtbCerrarFormulariosSociosDeuda.Image = ((System.Drawing.Image)(resources.GetObject("PtbCerrarFormulariosSociosDeuda.Image")));
            this.PtbCerrarFormulariosSociosDeuda.Location = new System.Drawing.Point(757, 14);
            this.PtbCerrarFormulariosSociosDeuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PtbCerrarFormulariosSociosDeuda.Name = "PtbCerrarFormulariosSociosDeuda";
            this.PtbCerrarFormulariosSociosDeuda.Size = new System.Drawing.Size(34, 35);
            this.PtbCerrarFormulariosSociosDeuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtbCerrarFormulariosSociosDeuda.TabIndex = 1;
            this.PtbCerrarFormulariosSociosDeuda.TabStop = false;
            this.PtbCerrarFormulariosSociosDeuda.Click += new System.EventHandler(this.PtbCerrarFormularioEstadisticas_Click);
            // 
            // DataGridViewBaseDeDatosMostrarSociosDeudas
            // 
            this.DataGridViewBaseDeDatosMostrarSociosDeudas.AllowUserToAddRows = false;
            this.DataGridViewBaseDeDatosMostrarSociosDeudas.AllowUserToDeleteRows = false;
            this.DataGridViewBaseDeDatosMostrarSociosDeudas.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewBaseDeDatosMostrarSociosDeudas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewBaseDeDatosMostrarSociosDeudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewBaseDeDatosMostrarSociosDeudas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreSocioDeuda,
            this.ApellidoSocioDeuda,
            this.DiasDeudaSocio});
            this.DataGridViewBaseDeDatosMostrarSociosDeudas.GridColor = System.Drawing.SystemColors.ControlLight;
            this.DataGridViewBaseDeDatosMostrarSociosDeudas.Location = new System.Drawing.Point(12, 91);
            this.DataGridViewBaseDeDatosMostrarSociosDeudas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridViewBaseDeDatosMostrarSociosDeudas.Name = "DataGridViewBaseDeDatosMostrarSociosDeudas";
            this.DataGridViewBaseDeDatosMostrarSociosDeudas.ReadOnly = true;
            this.DataGridViewBaseDeDatosMostrarSociosDeudas.RowHeadersWidth = 62;
            this.DataGridViewBaseDeDatosMostrarSociosDeudas.RowTemplate.Height = 28;
            this.DataGridViewBaseDeDatosMostrarSociosDeudas.Size = new System.Drawing.Size(777, 534);
            this.DataGridViewBaseDeDatosMostrarSociosDeudas.TabIndex = 9;
            // 
            // NombreSocioDeuda
            // 
            this.NombreSocioDeuda.HeaderText = "Nombre";
            this.NombreSocioDeuda.MinimumWidth = 6;
            this.NombreSocioDeuda.Name = "NombreSocioDeuda";
            this.NombreSocioDeuda.ReadOnly = true;
            this.NombreSocioDeuda.Width = 125;
            // 
            // ApellidoSocioDeuda
            // 
            this.ApellidoSocioDeuda.HeaderText = "Apellido";
            this.ApellidoSocioDeuda.MinimumWidth = 6;
            this.ApellidoSocioDeuda.Name = "ApellidoSocioDeuda";
            this.ApellidoSocioDeuda.ReadOnly = true;
            this.ApellidoSocioDeuda.Width = 125;
            // 
            // DiasDeudaSocio
            // 
            this.DiasDeudaSocio.HeaderText = "Dias Deuda";
            this.DiasDeudaSocio.MinimumWidth = 6;
            this.DiasDeudaSocio.Name = "DiasDeudaSocio";
            this.DiasDeudaSocio.ReadOnly = true;
            this.DiasDeudaSocio.Width = 125;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(477, 100);
            this.domainUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 26);
            this.domainUpDown1.TabIndex = 10;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // FrmSocioConDeuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 711);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.DataGridViewBaseDeDatosMostrarSociosDeudas);
            this.Controls.Add(this.BarraTituloSociosDeudas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(284, 3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmSocioConDeuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioSocioConDeuda";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogoSociosDeudas)).EndInit();
            this.BarraTituloSociosDeudas.ResumeLayout(false);
            this.BarraTituloSociosDeudas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrarFormulariosSociosDeuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBaseDeDatosMostrarSociosDeudas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label VerSociosConDeuda;
        private System.Windows.Forms.PictureBox PictureBoxLogoSociosDeudas;
        private System.Windows.Forms.Panel BarraTituloSociosDeudas;
        private System.Windows.Forms.PictureBox PtbCerrarFormulariosSociosDeuda;
        private System.Windows.Forms.DataGridView DataGridViewBaseDeDatosMostrarSociosDeudas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreSocioDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoSocioDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasDeudaSocio;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
    }
}