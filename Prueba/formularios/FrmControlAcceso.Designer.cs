namespace AplicacionGym
{
    partial class FrmControlAcceso
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControlAcceso));
            this.PanelLetrasControlAcceso = new System.Windows.Forms.Panel();
            this.PictureBoxBuscarSocio = new System.Windows.Forms.PictureBox();
            this.TextBoxBusquedaOpciones = new System.Windows.Forms.TextBox();
            this.LabelOpcionesDeBusquedaNombre = new System.Windows.Forms.Label();
            this.LabelControlAcceso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PictureBoxNotificaicones = new System.Windows.Forms.PictureBox();
            this.PictureBoxAgregarSocio = new System.Windows.Forms.PictureBox();
            this.PictureBoxDeudasClientes = new System.Windows.Forms.PictureBox();
            this.PictureBoxAgregarVentaProductos = new System.Windows.Forms.PictureBox();
            this.LabelFechaHoy = new System.Windows.Forms.Label();
            this.FechaHoraHoy = new System.Windows.Forms.Timer(this.components);
            this.LabelHoraHoy = new System.Windows.Forms.Label();
            this.PanelLetrasControlAcceso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBuscarSocio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxNotificaicones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAgregarSocio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDeudasClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAgregarVentaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLetrasControlAcceso
            // 
            this.PanelLetrasControlAcceso.Controls.Add(this.PictureBoxBuscarSocio);
            this.PanelLetrasControlAcceso.Controls.Add(this.TextBoxBusquedaOpciones);
            this.PanelLetrasControlAcceso.Controls.Add(this.LabelOpcionesDeBusquedaNombre);
            this.PanelLetrasControlAcceso.Controls.Add(this.LabelControlAcceso);
            this.PanelLetrasControlAcceso.Controls.Add(this.label1);
            this.PanelLetrasControlAcceso.Location = new System.Drawing.Point(205, 15);
            this.PanelLetrasControlAcceso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelLetrasControlAcceso.Name = "PanelLetrasControlAcceso";
            this.PanelLetrasControlAcceso.Size = new System.Drawing.Size(800, 136);
            this.PanelLetrasControlAcceso.TabIndex = 0;
            // 
            // PictureBoxBuscarSocio
            // 
            this.PictureBoxBuscarSocio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxBuscarSocio.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxBuscarSocio.Image")));
            this.PictureBoxBuscarSocio.Location = new System.Drawing.Point(744, 79);
            this.PictureBoxBuscarSocio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBoxBuscarSocio.Name = "PictureBoxBuscarSocio";
            this.PictureBoxBuscarSocio.Size = new System.Drawing.Size(45, 50);
            this.PictureBoxBuscarSocio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxBuscarSocio.TabIndex = 7;
            this.PictureBoxBuscarSocio.TabStop = false;
            this.PictureBoxBuscarSocio.Click += new System.EventHandler(this.PictureBoxBuscarSocio_Click);
            // 
            // TextBoxBusquedaOpciones
            // 
            this.TextBoxBusquedaOpciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxBusquedaOpciones.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBusquedaOpciones.Location = new System.Drawing.Point(350, 79);
            this.TextBoxBusquedaOpciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxBusquedaOpciones.Name = "TextBoxBusquedaOpciones";
            this.TextBoxBusquedaOpciones.Size = new System.Drawing.Size(367, 37);
            this.TextBoxBusquedaOpciones.TabIndex = 4;
            // 
            // LabelOpcionesDeBusquedaNombre
            // 
            this.LabelOpcionesDeBusquedaNombre.AutoSize = true;
            this.LabelOpcionesDeBusquedaNombre.Font = new System.Drawing.Font("Segoe UI Symbol", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOpcionesDeBusquedaNombre.ForeColor = System.Drawing.Color.Black;
            this.LabelOpcionesDeBusquedaNombre.Location = new System.Drawing.Point(14, 79);
            this.LabelOpcionesDeBusquedaNombre.Name = "LabelOpcionesDeBusquedaNombre";
            this.LabelOpcionesDeBusquedaNombre.Size = new System.Drawing.Size(317, 37);
            this.LabelOpcionesDeBusquedaNombre.TabIndex = 2;
            this.LabelOpcionesDeBusquedaNombre.Text = "NOMBRE / ID / HUELLA";
            // 
            // LabelControlAcceso
            // 
            this.LabelControlAcceso.AutoSize = true;
            this.LabelControlAcceso.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControlAcceso.ForeColor = System.Drawing.Color.SeaGreen;
            this.LabelControlAcceso.Location = new System.Drawing.Point(161, 11);
            this.LabelControlAcceso.Name = "LabelControlAcceso";
            this.LabelControlAcceso.Size = new System.Drawing.Size(401, 56);
            this.LabelControlAcceso.TabIndex = 1;
            this.LabelControlAcceso.Text = "CONTROL DE ACCESO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "__________________________________________________________";
            // 
            // PictureBoxNotificaicones
            // 
            this.PictureBoxNotificaicones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxNotificaicones.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxNotificaicones.Image")));
            this.PictureBoxNotificaicones.Location = new System.Drawing.Point(1230, 15);
            this.PictureBoxNotificaicones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBoxNotificaicones.Name = "PictureBoxNotificaicones";
            this.PictureBoxNotificaicones.Size = new System.Drawing.Size(45, 50);
            this.PictureBoxNotificaicones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxNotificaicones.TabIndex = 1;
            this.PictureBoxNotificaicones.TabStop = false;
            // 
            // PictureBoxAgregarSocio
            // 
            this.PictureBoxAgregarSocio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxAgregarSocio.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxAgregarSocio.Image")));
            this.PictureBoxAgregarSocio.Location = new System.Drawing.Point(1230, 326);
            this.PictureBoxAgregarSocio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBoxAgregarSocio.Name = "PictureBoxAgregarSocio";
            this.PictureBoxAgregarSocio.Size = new System.Drawing.Size(45, 50);
            this.PictureBoxAgregarSocio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxAgregarSocio.TabIndex = 2;
            this.PictureBoxAgregarSocio.TabStop = false;
            this.PictureBoxAgregarSocio.Click += new System.EventHandler(this.PictureBoxAgregarSocio_Click);
            // 
            // PictureBoxDeudasClientes
            // 
            this.PictureBoxDeudasClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxDeudasClientes.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxDeudasClientes.Image")));
            this.PictureBoxDeudasClientes.Location = new System.Drawing.Point(1230, 401);
            this.PictureBoxDeudasClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBoxDeudasClientes.Name = "PictureBoxDeudasClientes";
            this.PictureBoxDeudasClientes.Size = new System.Drawing.Size(45, 50);
            this.PictureBoxDeudasClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxDeudasClientes.TabIndex = 3;
            this.PictureBoxDeudasClientes.TabStop = false;
            // 
            // PictureBoxAgregarVentaProductos
            // 
            this.PictureBoxAgregarVentaProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxAgregarVentaProductos.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxAgregarVentaProductos.Image")));
            this.PictureBoxAgregarVentaProductos.Location = new System.Drawing.Point(1230, 479);
            this.PictureBoxAgregarVentaProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBoxAgregarVentaProductos.Name = "PictureBoxAgregarVentaProductos";
            this.PictureBoxAgregarVentaProductos.Size = new System.Drawing.Size(45, 50);
            this.PictureBoxAgregarVentaProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxAgregarVentaProductos.TabIndex = 4;
            this.PictureBoxAgregarVentaProductos.TabStop = false;
            // 
            // LabelFechaHoy
            // 
            this.LabelFechaHoy.AutoSize = true;
            this.LabelFechaHoy.BackColor = System.Drawing.Color.White;
            this.LabelFechaHoy.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFechaHoy.ForeColor = System.Drawing.Color.Brown;
            this.LabelFechaHoy.Location = new System.Drawing.Point(1082, 680);
            this.LabelFechaHoy.Name = "LabelFechaHoy";
            this.LabelFechaHoy.Size = new System.Drawing.Size(112, 44);
            this.LabelFechaHoy.TabIndex = 5;
            this.LabelFechaHoy.Text = "label2";
            // 
            // FechaHoraHoy
            // 
            this.FechaHoraHoy.Enabled = true;
            this.FechaHoraHoy.Tick += new System.EventHandler(this.FechaHoraHoy_Tick);
            // 
            // LabelHoraHoy
            // 
            this.LabelHoraHoy.AutoSize = true;
            this.LabelHoraHoy.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHoraHoy.ForeColor = System.Drawing.Color.Gray;
            this.LabelHoraHoy.Location = new System.Drawing.Point(26, 26);
            this.LabelHoraHoy.Name = "LabelHoraHoy";
            this.LabelHoraHoy.Size = new System.Drawing.Size(112, 44);
            this.LabelHoraHoy.TabIndex = 6;
            this.LabelHoraHoy.Text = "label2";
            // 
            // FrmControlAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1288, 738);
            this.Controls.Add(this.LabelHoraHoy);
            this.Controls.Add(this.LabelFechaHoy);
            this.Controls.Add(this.PictureBoxAgregarVentaProductos);
            this.Controls.Add(this.PictureBoxDeudasClientes);
            this.Controls.Add(this.PictureBoxAgregarSocio);
            this.Controls.Add(this.PictureBoxNotificaicones);
            this.Controls.Add(this.PanelLetrasControlAcceso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmControlAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlAcceso";
            this.PanelLetrasControlAcceso.ResumeLayout(false);
            this.PanelLetrasControlAcceso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBuscarSocio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxNotificaicones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAgregarSocio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDeudasClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAgregarVentaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelLetrasControlAcceso;
        private System.Windows.Forms.Label LabelControlAcceso;
        private System.Windows.Forms.Label LabelOpcionesDeBusquedaNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxBusquedaOpciones;
        private System.Windows.Forms.PictureBox PictureBoxNotificaicones;
        private System.Windows.Forms.PictureBox PictureBoxAgregarSocio;
        private System.Windows.Forms.PictureBox PictureBoxDeudasClientes;
        private System.Windows.Forms.PictureBox PictureBoxAgregarVentaProductos;
        private System.Windows.Forms.Label LabelFechaHoy;
        private System.Windows.Forms.Timer FechaHoraHoy;
        private System.Windows.Forms.Label LabelHoraHoy;
        private System.Windows.Forms.PictureBox PictureBoxBuscarSocio;
    }
}