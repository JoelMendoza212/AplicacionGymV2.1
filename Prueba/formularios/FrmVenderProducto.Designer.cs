namespace AplicacionGym
{
    partial class FrmVenderProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenderProducto));
            this.BarraTituloFormularioAgregarProducto = new System.Windows.Forms.Panel();
            this.LabelVerAgregarProducto = new System.Windows.Forms.Label();
            this.PictureBoxLogoFormularioAgregarProducto = new System.Windows.Forms.PictureBox();
            this.PtbCerrarFormularioVenderProductos = new System.Windows.Forms.PictureBox();
            this.LabelCodigoProducto = new System.Windows.Forms.Label();
            this.TextBoxCodigoAgregarProducto = new System.Windows.Forms.TextBox();
            this.labelProducto = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.comboBoxProducto = new System.Windows.Forms.ComboBox();
            this.labelTipoPago = new System.Windows.Forms.Label();
            this.comboBoxTipoPago = new System.Windows.Forms.ComboBox();
            this.ButtonVenderProducto = new System.Windows.Forms.Button();
            this.labelTotalPagar = new System.Windows.Forms.Label();
            this.textBoxTotalPgar = new System.Windows.Forms.TextBox();
            this.BarraTituloFormularioAgregarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogoFormularioAgregarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrarFormularioVenderProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTituloFormularioAgregarProducto
            // 
            this.BarraTituloFormularioAgregarProducto.BackColor = System.Drawing.Color.SeaGreen;
            this.BarraTituloFormularioAgregarProducto.Controls.Add(this.LabelVerAgregarProducto);
            this.BarraTituloFormularioAgregarProducto.Controls.Add(this.PictureBoxLogoFormularioAgregarProducto);
            this.BarraTituloFormularioAgregarProducto.Controls.Add(this.PtbCerrarFormularioVenderProductos);
            this.BarraTituloFormularioAgregarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTituloFormularioAgregarProducto.Location = new System.Drawing.Point(0, 0);
            this.BarraTituloFormularioAgregarProducto.Name = "BarraTituloFormularioAgregarProducto";
            this.BarraTituloFormularioAgregarProducto.Size = new System.Drawing.Size(900, 63);
            this.BarraTituloFormularioAgregarProducto.TabIndex = 12;
            // 
            // LabelVerAgregarProducto
            // 
            this.LabelVerAgregarProducto.AutoSize = true;
            this.LabelVerAgregarProducto.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVerAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.LabelVerAgregarProducto.Location = new System.Drawing.Point(298, 8);
            this.LabelVerAgregarProducto.Name = "LabelVerAgregarProducto";
            this.LabelVerAgregarProducto.Size = new System.Drawing.Size(338, 48);
            this.LabelVerAgregarProducto.TabIndex = 7;
            this.LabelVerAgregarProducto.Text = "VENTA DE PRODUCTO";
            this.LabelVerAgregarProducto.Click += new System.EventHandler(this.LabelVerAgregarProducto_Click);
            // 
            // PictureBoxLogoFormularioAgregarProducto
            // 
            this.PictureBoxLogoFormularioAgregarProducto.BackColor = System.Drawing.Color.SeaGreen;
            this.PictureBoxLogoFormularioAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogoFormularioAgregarProducto.Image")));
            this.PictureBoxLogoFormularioAgregarProducto.Location = new System.Drawing.Point(-27, -5);
            this.PictureBoxLogoFormularioAgregarProducto.Name = "PictureBoxLogoFormularioAgregarProducto";
            this.PictureBoxLogoFormularioAgregarProducto.Size = new System.Drawing.Size(266, 65);
            this.PictureBoxLogoFormularioAgregarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLogoFormularioAgregarProducto.TabIndex = 0;
            this.PictureBoxLogoFormularioAgregarProducto.TabStop = false;
            // 
            // PtbCerrarFormularioVenderProductos
            // 
            this.PtbCerrarFormularioVenderProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PtbCerrarFormularioVenderProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PtbCerrarFormularioVenderProductos.Image = ((System.Drawing.Image)(resources.GetObject("PtbCerrarFormularioVenderProductos.Image")));
            this.PtbCerrarFormularioVenderProductos.Location = new System.Drawing.Point(855, 14);
            this.PtbCerrarFormularioVenderProductos.Name = "PtbCerrarFormularioVenderProductos";
            this.PtbCerrarFormularioVenderProductos.Size = new System.Drawing.Size(33, 35);
            this.PtbCerrarFormularioVenderProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtbCerrarFormularioVenderProductos.TabIndex = 1;
            this.PtbCerrarFormularioVenderProductos.TabStop = false;
            this.PtbCerrarFormularioVenderProductos.Click += new System.EventHandler(this.PtbCerrarFormularioAgregarProductos_Click);
            // 
            // LabelCodigoProducto
            // 
            this.LabelCodigoProducto.AutoSize = true;
            this.LabelCodigoProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCodigoProducto.Location = new System.Drawing.Point(110, 112);
            this.LabelCodigoProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCodigoProducto.Name = "LabelCodigoProducto";
            this.LabelCodigoProducto.Size = new System.Drawing.Size(97, 32);
            this.LabelCodigoProducto.TabIndex = 13;
            this.LabelCodigoProducto.Text = "Código";
            // 
            // TextBoxCodigoAgregarProducto
            // 
            this.TextBoxCodigoAgregarProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCodigoAgregarProducto.Location = new System.Drawing.Point(219, 108);
            this.TextBoxCodigoAgregarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxCodigoAgregarProducto.Name = "TextBoxCodigoAgregarProducto";
            this.TextBoxCodigoAgregarProducto.Size = new System.Drawing.Size(180, 39);
            this.TextBoxCodigoAgregarProducto.TabIndex = 14;
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.Location = new System.Drawing.Point(482, 108);
            this.labelProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(118, 32);
            this.labelProducto.TabIndex = 15;
            this.labelProducto.Text = "Producto";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.Location = new System.Drawing.Point(483, 228);
            this.labelCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(117, 32);
            this.labelCantidad.TabIndex = 17;
            this.labelCantidad.Text = "Cantidad";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.Location = new System.Drawing.Point(630, 215);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(180, 39);
            this.textBoxCantidad.TabIndex = 18;
            // 
            // comboBoxProducto
            // 
            this.comboBoxProducto.FormattingEnabled = true;
            this.comboBoxProducto.Location = new System.Drawing.Point(630, 108);
            this.comboBoxProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxProducto.Name = "comboBoxProducto";
            this.comboBoxProducto.Size = new System.Drawing.Size(230, 28);
            this.comboBoxProducto.TabIndex = 19;
            // 
            // labelTipoPago
            // 
            this.labelTipoPago.AutoSize = true;
            this.labelTipoPago.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoPago.Location = new System.Drawing.Point(40, 348);
            this.labelTipoPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipoPago.Name = "labelTipoPago";
            this.labelTipoPago.Size = new System.Drawing.Size(167, 32);
            this.labelTipoPago.TabIndex = 20;
            this.labelTipoPago.Text = "Tipo de Pago";
            // 
            // comboBoxTipoPago
            // 
            this.comboBoxTipoPago.FormattingEnabled = true;
            this.comboBoxTipoPago.Location = new System.Drawing.Point(218, 348);
            this.comboBoxTipoPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxTipoPago.Name = "comboBoxTipoPago";
            this.comboBoxTipoPago.Size = new System.Drawing.Size(230, 28);
            this.comboBoxTipoPago.TabIndex = 21;
            // 
            // ButtonVenderProducto
            // 
            this.ButtonVenderProducto.BackColor = System.Drawing.Color.SeaGreen;
            this.ButtonVenderProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonVenderProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonVenderProducto.ForeColor = System.Drawing.Color.White;
            this.ButtonVenderProducto.Location = new System.Drawing.Point(580, 348);
            this.ButtonVenderProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonVenderProducto.Name = "ButtonVenderProducto";
            this.ButtonVenderProducto.Size = new System.Drawing.Size(204, 86);
            this.ButtonVenderProducto.TabIndex = 22;
            this.ButtonVenderProducto.Text = "Vender";
            this.ButtonVenderProducto.UseVisualStyleBackColor = false;
            this.ButtonVenderProducto.Click += new System.EventHandler(this.ButtonVenderProducto_Click);
            // 
            // labelTotalPagar
            // 
            this.labelTotalPagar.AutoSize = true;
            this.labelTotalPagar.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPagar.Location = new System.Drawing.Point(40, 232);
            this.labelTotalPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalPagar.Name = "labelTotalPagar";
            this.labelTotalPagar.Size = new System.Drawing.Size(165, 32);
            this.labelTotalPagar.TabIndex = 23;
            this.labelTotalPagar.Text = "Total a Pagar";
            // 
            // textBoxTotalPgar
            // 
            this.textBoxTotalPgar.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalPgar.Location = new System.Drawing.Point(219, 228);
            this.textBoxTotalPgar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTotalPgar.Name = "textBoxTotalPgar";
            this.textBoxTotalPgar.Size = new System.Drawing.Size(180, 39);
            this.textBoxTotalPgar.TabIndex = 24;
            // 
            // FrmVenderProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(900, 502);
            this.Controls.Add(this.textBoxTotalPgar);
            this.Controls.Add(this.labelTotalPagar);
            this.Controls.Add(this.ButtonVenderProducto);
            this.Controls.Add(this.comboBoxTipoPago);
            this.Controls.Add(this.labelTipoPago);
            this.Controls.Add(this.comboBoxProducto);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelProducto);
            this.Controls.Add(this.TextBoxCodigoAgregarProducto);
            this.Controls.Add(this.LabelCodigoProducto);
            this.Controls.Add(this.BarraTituloFormularioAgregarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmVenderProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioVenderProducto";
            this.BarraTituloFormularioAgregarProducto.ResumeLayout(false);
            this.BarraTituloFormularioAgregarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogoFormularioAgregarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrarFormularioVenderProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTituloFormularioAgregarProducto;
        public System.Windows.Forms.Label LabelVerAgregarProducto;
        private System.Windows.Forms.PictureBox PictureBoxLogoFormularioAgregarProducto;
        private System.Windows.Forms.PictureBox PtbCerrarFormularioVenderProductos;
        private System.Windows.Forms.Label LabelCodigoProducto;
        private System.Windows.Forms.TextBox TextBoxCodigoAgregarProducto;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.ComboBox comboBoxProducto;
        private System.Windows.Forms.Label labelTipoPago;
        private System.Windows.Forms.ComboBox comboBoxTipoPago;
        private System.Windows.Forms.Button ButtonVenderProducto;
        private System.Windows.Forms.Label labelTotalPagar;
        private System.Windows.Forms.TextBox textBoxTotalPgar;
    }
}