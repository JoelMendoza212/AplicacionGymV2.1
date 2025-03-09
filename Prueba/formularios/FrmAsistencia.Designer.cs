namespace AplicacionGym
{
    partial class FrmAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsistencia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarraTituloAsistencia = new System.Windows.Forms.Panel();
            this.VerAsistencias = new System.Windows.Forms.Label();
            this.PictureBoxLogoAsistencia = new System.Windows.Forms.PictureBox();
            this.PtbCerrarFormularioAsistencia = new System.Windows.Forms.PictureBox();
            this.PanelFiltrosDefechas = new System.Windows.Forms.Panel();
            this.ButtonInicioSesion = new System.Windows.Forms.Button();
            this.DateTimeFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.DateTimeFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxRangoFinalHorario = new System.Windows.Forms.ComboBox();
            this.ComboBoxRangoInicioHorario = new System.Windows.Forms.ComboBox();
            this.ComboBoxFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.LabelFiltroCategoriaAsistencia = new System.Windows.Forms.Label();
            this.LabelRangoHorarioAsistencia = new System.Windows.Forms.Label();
            this.LabelRangoHastaAsistencia = new System.Windows.Forms.Label();
            this.LabelRangoDesdeAsistencia = new System.Windows.Forms.Label();
            this.DGVAsistenciaUsuarios = new System.Windows.Forms.DataGridView();
            this.colAsistenciaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSocioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarraTituloAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogoAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrarFormularioAsistencia)).BeginInit();
            this.PanelFiltrosDefechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAsistenciaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTituloAsistencia
            // 
            this.BarraTituloAsistencia.BackColor = System.Drawing.Color.SeaGreen;
            this.BarraTituloAsistencia.Controls.Add(this.VerAsistencias);
            this.BarraTituloAsistencia.Controls.Add(this.PictureBoxLogoAsistencia);
            this.BarraTituloAsistencia.Controls.Add(this.PtbCerrarFormularioAsistencia);
            this.BarraTituloAsistencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTituloAsistencia.Location = new System.Drawing.Point(0, 0);
            this.BarraTituloAsistencia.Name = "BarraTituloAsistencia";
            this.BarraTituloAsistencia.Size = new System.Drawing.Size(1224, 62);
            this.BarraTituloAsistencia.TabIndex = 3;
            // 
            // VerAsistencias
            // 
            this.VerAsistencias.AutoSize = true;
            this.VerAsistencias.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerAsistencias.ForeColor = System.Drawing.Color.White;
            this.VerAsistencias.Location = new System.Drawing.Point(558, 5);
            this.VerAsistencias.Name = "VerAsistencias";
            this.VerAsistencias.Size = new System.Drawing.Size(205, 48);
            this.VerAsistencias.TabIndex = 2;
            this.VerAsistencias.Text = "ASISTENCIA";
            // 
            // PictureBoxLogoAsistencia
            // 
            this.PictureBoxLogoAsistencia.BackColor = System.Drawing.Color.SeaGreen;
            this.PictureBoxLogoAsistencia.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogoAsistencia.Image")));
            this.PictureBoxLogoAsistencia.Location = new System.Drawing.Point(-27, -5);
            this.PictureBoxLogoAsistencia.Name = "PictureBoxLogoAsistencia";
            this.PictureBoxLogoAsistencia.Size = new System.Drawing.Size(266, 65);
            this.PictureBoxLogoAsistencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLogoAsistencia.TabIndex = 0;
            this.PictureBoxLogoAsistencia.TabStop = false;
            // 
            // PtbCerrarFormularioAsistencia
            // 
            this.PtbCerrarFormularioAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PtbCerrarFormularioAsistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PtbCerrarFormularioAsistencia.Image = ((System.Drawing.Image)(resources.GetObject("PtbCerrarFormularioAsistencia.Image")));
            this.PtbCerrarFormularioAsistencia.Location = new System.Drawing.Point(1176, 14);
            this.PtbCerrarFormularioAsistencia.Name = "PtbCerrarFormularioAsistencia";
            this.PtbCerrarFormularioAsistencia.Size = new System.Drawing.Size(33, 35);
            this.PtbCerrarFormularioAsistencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtbCerrarFormularioAsistencia.TabIndex = 1;
            this.PtbCerrarFormularioAsistencia.TabStop = false;
            this.PtbCerrarFormularioAsistencia.Click += new System.EventHandler(this.PtbCerrarFormularioPrincipal_Click);
            // 
            // PanelFiltrosDefechas
            // 
            this.PanelFiltrosDefechas.BackColor = System.Drawing.Color.White;
            this.PanelFiltrosDefechas.Controls.Add(this.ButtonInicioSesion);
            this.PanelFiltrosDefechas.Controls.Add(this.DateTimeFechaHasta);
            this.PanelFiltrosDefechas.Controls.Add(this.DateTimeFechaDesde);
            this.PanelFiltrosDefechas.Controls.Add(this.ComboBoxRangoFinalHorario);
            this.PanelFiltrosDefechas.Controls.Add(this.ComboBoxRangoInicioHorario);
            this.PanelFiltrosDefechas.Controls.Add(this.ComboBoxFiltroCategoria);
            this.PanelFiltrosDefechas.Controls.Add(this.LabelFiltroCategoriaAsistencia);
            this.PanelFiltrosDefechas.Controls.Add(this.LabelRangoHorarioAsistencia);
            this.PanelFiltrosDefechas.Controls.Add(this.LabelRangoHastaAsistencia);
            this.PanelFiltrosDefechas.Controls.Add(this.LabelRangoDesdeAsistencia);
            this.PanelFiltrosDefechas.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFiltrosDefechas.Location = new System.Drawing.Point(0, 62);
            this.PanelFiltrosDefechas.Name = "PanelFiltrosDefechas";
            this.PanelFiltrosDefechas.Size = new System.Drawing.Size(1224, 100);
            this.PanelFiltrosDefechas.TabIndex = 4;
            // 
            // ButtonInicioSesion
            // 
            this.ButtonInicioSesion.BackColor = System.Drawing.Color.SeaGreen;
            this.ButtonInicioSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonInicioSesion.FlatAppearance.BorderSize = 0;
            this.ButtonInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInicioSesion.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonInicioSesion.ForeColor = System.Drawing.Color.White;
            this.ButtonInicioSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonInicioSesion.Location = new System.Drawing.Point(933, 23);
            this.ButtonInicioSesion.Name = "ButtonInicioSesion";
            this.ButtonInicioSesion.Size = new System.Drawing.Size(231, 54);
            this.ButtonInicioSesion.TabIndex = 26;
            this.ButtonInicioSesion.Text = "Mostrar Filtro";
            this.ButtonInicioSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonInicioSesion.UseVisualStyleBackColor = false;
            // 
            // DateTimeFechaHasta
            // 
            this.DateTimeFechaHasta.CustomFormat = "dd:mm:aaaa";
            this.DateTimeFechaHasta.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeFechaHasta.Location = new System.Drawing.Point(172, 46);
            this.DateTimeFechaHasta.MaxDate = new System.DateTime(2025, 2, 17, 0, 0, 0, 0);
            this.DateTimeFechaHasta.MinDate = new System.DateTime(2025, 2, 17, 0, 0, 0, 0);
            this.DateTimeFechaHasta.Name = "DateTimeFechaHasta";
            this.DateTimeFechaHasta.Size = new System.Drawing.Size(140, 36);
            this.DateTimeFechaHasta.TabIndex = 8;
            this.DateTimeFechaHasta.Value = new System.DateTime(2025, 2, 17, 0, 0, 0, 0);
            // 
            // DateTimeFechaDesde
            // 
            this.DateTimeFechaDesde.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeFechaDesde.Location = new System.Drawing.Point(14, 46);
            this.DateTimeFechaDesde.MaxDate = new System.DateTime(2025, 2, 17, 0, 0, 0, 0);
            this.DateTimeFechaDesde.MinDate = new System.DateTime(2025, 2, 17, 0, 0, 0, 0);
            this.DateTimeFechaDesde.Name = "DateTimeFechaDesde";
            this.DateTimeFechaDesde.Size = new System.Drawing.Size(140, 36);
            this.DateTimeFechaDesde.TabIndex = 7;
            this.DateTimeFechaDesde.Value = new System.DateTime(2025, 2, 17, 0, 0, 0, 0);
            // 
            // ComboBoxRangoFinalHorario
            // 
            this.ComboBoxRangoFinalHorario.FormattingEnabled = true;
            this.ComboBoxRangoFinalHorario.Location = new System.Drawing.Point(435, 55);
            this.ComboBoxRangoFinalHorario.Name = "ComboBoxRangoFinalHorario";
            this.ComboBoxRangoFinalHorario.Size = new System.Drawing.Size(70, 28);
            this.ComboBoxRangoFinalHorario.TabIndex = 6;
            // 
            // ComboBoxRangoInicioHorario
            // 
            this.ComboBoxRangoInicioHorario.FormattingEnabled = true;
            this.ComboBoxRangoInicioHorario.Location = new System.Drawing.Point(358, 55);
            this.ComboBoxRangoInicioHorario.Name = "ComboBoxRangoInicioHorario";
            this.ComboBoxRangoInicioHorario.Size = new System.Drawing.Size(70, 28);
            this.ComboBoxRangoInicioHorario.TabIndex = 5;
            // 
            // ComboBoxFiltroCategoria
            // 
            this.ComboBoxFiltroCategoria.FormattingEnabled = true;
            this.ComboBoxFiltroCategoria.Location = new System.Drawing.Point(579, 55);
            this.ComboBoxFiltroCategoria.Name = "ComboBoxFiltroCategoria";
            this.ComboBoxFiltroCategoria.Size = new System.Drawing.Size(196, 28);
            this.ComboBoxFiltroCategoria.TabIndex = 4;
            // 
            // LabelFiltroCategoriaAsistencia
            // 
            this.LabelFiltroCategoriaAsistencia.AutoSize = true;
            this.LabelFiltroCategoriaAsistencia.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFiltroCategoriaAsistencia.Location = new System.Drawing.Point(573, 11);
            this.LabelFiltroCategoriaAsistencia.Name = "LabelFiltroCategoriaAsistencia";
            this.LabelFiltroCategoriaAsistencia.Size = new System.Drawing.Size(214, 30);
            this.LabelFiltroCategoriaAsistencia.TabIndex = 3;
            this.LabelFiltroCategoriaAsistencia.Text = "Filtro De Categoria";
            // 
            // LabelRangoHorarioAsistencia
            // 
            this.LabelRangoHorarioAsistencia.AutoSize = true;
            this.LabelRangoHorarioAsistencia.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRangoHorarioAsistencia.Location = new System.Drawing.Point(354, 11);
            this.LabelRangoHorarioAsistencia.Name = "LabelRangoHorarioAsistencia";
            this.LabelRangoHorarioAsistencia.Size = new System.Drawing.Size(168, 30);
            this.LabelRangoHorarioAsistencia.TabIndex = 2;
            this.LabelRangoHorarioAsistencia.Text = "Rango Horario";
            // 
            // LabelRangoHastaAsistencia
            // 
            this.LabelRangoHastaAsistencia.AutoSize = true;
            this.LabelRangoHastaAsistencia.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRangoHastaAsistencia.Location = new System.Drawing.Point(206, 11);
            this.LabelRangoHastaAsistencia.Name = "LabelRangoHastaAsistencia";
            this.LabelRangoHastaAsistencia.Size = new System.Drawing.Size(72, 30);
            this.LabelRangoHastaAsistencia.TabIndex = 1;
            this.LabelRangoHastaAsistencia.Text = "Hasta";
            // 
            // LabelRangoDesdeAsistencia
            // 
            this.LabelRangoDesdeAsistencia.AutoSize = true;
            this.LabelRangoDesdeAsistencia.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRangoDesdeAsistencia.Location = new System.Drawing.Point(46, 11);
            this.LabelRangoDesdeAsistencia.Name = "LabelRangoDesdeAsistencia";
            this.LabelRangoDesdeAsistencia.Size = new System.Drawing.Size(79, 30);
            this.LabelRangoDesdeAsistencia.TabIndex = 0;
            this.LabelRangoDesdeAsistencia.Text = "Desde";
            // 
            // DGVAsistenciaUsuarios
            // 
            this.DGVAsistenciaUsuarios.AllowUserToAddRows = false;
            this.DGVAsistenciaUsuarios.AllowUserToDeleteRows = false;
            this.DGVAsistenciaUsuarios.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVAsistenciaUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVAsistenciaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVAsistenciaUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.DGVAsistenciaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVAsistenciaUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVAsistenciaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVAsistenciaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAsistenciaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAsistenciaID,
            this.colSocioID,
            this.colFecha,
            this.colHoraEntrada,
            this.colHoraSalida});
            this.DGVAsistenciaUsuarios.Cursor = System.Windows.Forms.Cursors.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVAsistenciaUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVAsistenciaUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVAsistenciaUsuarios.EnableHeadersVisualStyles = false;
            this.DGVAsistenciaUsuarios.Location = new System.Drawing.Point(0, 162);
            this.DGVAsistenciaUsuarios.Name = "DGVAsistenciaUsuarios";
            this.DGVAsistenciaUsuarios.ReadOnly = true;
            this.DGVAsistenciaUsuarios.RowHeadersWidth = 51;
            this.DGVAsistenciaUsuarios.RowTemplate.Height = 24;
            this.DGVAsistenciaUsuarios.Size = new System.Drawing.Size(1224, 643);
            this.DGVAsistenciaUsuarios.TabIndex = 28;
            // 
            // colAsistenciaID
            // 
            this.colAsistenciaID.HeaderText = "AsistenciaID";
            this.colAsistenciaID.MinimumWidth = 8;
            this.colAsistenciaID.Name = "colAsistenciaID";
            this.colAsistenciaID.ReadOnly = true;
            // 
            // colSocioID
            // 
            this.colSocioID.HeaderText = "SocioID";
            this.colSocioID.MinimumWidth = 6;
            this.colSocioID.Name = "colSocioID";
            this.colSocioID.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colHoraEntrada
            // 
            this.colHoraEntrada.HeaderText = "Hora de Entrada";
            this.colHoraEntrada.MinimumWidth = 6;
            this.colHoraEntrada.Name = "colHoraEntrada";
            this.colHoraEntrada.ReadOnly = true;
            // 
            // colHoraSalida
            // 
            this.colHoraSalida.HeaderText = "Hora de Salida";
            this.colHoraSalida.MinimumWidth = 8;
            this.colHoraSalida.Name = "colHoraSalida";
            this.colHoraSalida.ReadOnly = true;
            // 
            // FrmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 805);
            this.Controls.Add(this.DGVAsistenciaUsuarios);
            this.Controls.Add(this.PanelFiltrosDefechas);
            this.Controls.Add(this.BarraTituloAsistencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(284, 3);
            this.Name = "FrmAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistencia";
            this.Load += new System.EventHandler(this.FrmAsistencia_Load);
            this.BarraTituloAsistencia.ResumeLayout(false);
            this.BarraTituloAsistencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogoAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrarFormularioAsistencia)).EndInit();
            this.PanelFiltrosDefechas.ResumeLayout(false);
            this.PanelFiltrosDefechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAsistenciaUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTituloAsistencia;
        private System.Windows.Forms.PictureBox PictureBoxLogoAsistencia;
        private System.Windows.Forms.PictureBox PtbCerrarFormularioAsistencia;
        private System.Windows.Forms.Panel PanelFiltrosDefechas;
        private System.Windows.Forms.Label LabelFiltroCategoriaAsistencia;
        private System.Windows.Forms.Label LabelRangoHorarioAsistencia;
        private System.Windows.Forms.Label LabelRangoHastaAsistencia;
        private System.Windows.Forms.Label LabelRangoDesdeAsistencia;
        private System.Windows.Forms.ComboBox ComboBoxFiltroCategoria;
        private System.Windows.Forms.DateTimePicker DateTimeFechaHasta;
        private System.Windows.Forms.DateTimePicker DateTimeFechaDesde;
        private System.Windows.Forms.ComboBox ComboBoxRangoFinalHorario;
        private System.Windows.Forms.ComboBox ComboBoxRangoInicioHorario;
        private System.Windows.Forms.Button ButtonInicioSesion;
        private System.Windows.Forms.Label VerAsistencias;
        private System.Windows.Forms.DataGridView DGVAsistenciaUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsistenciaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSocioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraSalida;
    }
}