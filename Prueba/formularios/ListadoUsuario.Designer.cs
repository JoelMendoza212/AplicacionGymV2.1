namespace AplicacionGym
{
    partial class ListadoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelFiltrosDefechasListadoUsuario = new System.Windows.Forms.Panel();
            this.LabelNombreSocio = new System.Windows.Forms.Label();
            this.labelElegirFiltroClientes = new System.Windows.Forms.Label();
            this.cmbFiltroClientes = new System.Windows.Forms.ComboBox();
            this.txtFiltroClientes = new System.Windows.Forms.TextBox();
            this.buttonEliminarCliente = new System.Windows.Forms.Button();
            this.buttonEditarCLiente = new System.Windows.Forms.Button();
            this.buttonAñadirCliente = new System.Windows.Forms.Button();
            this.BarraTituloListadoUsuario = new System.Windows.Forms.Panel();
            this.LabelVerEstadoDeSocio = new System.Windows.Forms.Label();
            this.PictureBoxLogoListadoUsuario = new System.Windows.Forms.PictureBox();
            this.PtbCerrarFormularioListadoUsuario = new System.Windows.Forms.PictureBox();
            this.DGVListadoUsuario = new System.Windows.Forms.DataGridView();
            this.PanelFiltrosDefechasListadoUsuario.SuspendLayout();
            this.BarraTituloListadoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogoListadoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrarFormularioListadoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListadoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelFiltrosDefechasListadoUsuario
            // 
            this.PanelFiltrosDefechasListadoUsuario.BackColor = System.Drawing.Color.White;
            this.PanelFiltrosDefechasListadoUsuario.Controls.Add(this.LabelNombreSocio);
            this.PanelFiltrosDefechasListadoUsuario.Controls.Add(this.labelElegirFiltroClientes);
            this.PanelFiltrosDefechasListadoUsuario.Controls.Add(this.cmbFiltroClientes);
            this.PanelFiltrosDefechasListadoUsuario.Controls.Add(this.txtFiltroClientes);
            this.PanelFiltrosDefechasListadoUsuario.Controls.Add(this.buttonEliminarCliente);
            this.PanelFiltrosDefechasListadoUsuario.Controls.Add(this.buttonEditarCLiente);
            this.PanelFiltrosDefechasListadoUsuario.Controls.Add(this.buttonAñadirCliente);
            this.PanelFiltrosDefechasListadoUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFiltrosDefechasListadoUsuario.Location = new System.Drawing.Point(0, 49);
            this.PanelFiltrosDefechasListadoUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelFiltrosDefechasListadoUsuario.Name = "PanelFiltrosDefechasListadoUsuario";
            this.PanelFiltrosDefechasListadoUsuario.Size = new System.Drawing.Size(1232, 80);
            this.PanelFiltrosDefechasListadoUsuario.TabIndex = 8;
            // 
            // LabelNombreSocio
            // 
            this.LabelNombreSocio.AutoSize = true;
            this.LabelNombreSocio.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombreSocio.Location = new System.Drawing.Point(127, 17);
            this.LabelNombreSocio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNombreSocio.Name = "LabelNombreSocio";
            this.LabelNombreSocio.Size = new System.Drawing.Size(126, 28);
            this.LabelNombreSocio.TabIndex = 18;
            this.LabelNombreSocio.Text = "Elegir filtro:";
            // 
            // labelElegirFiltroClientes
            // 
            this.labelElegirFiltroClientes.AutoSize = true;
            this.labelElegirFiltroClientes.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElegirFiltroClientes.Location = new System.Drawing.Point(439, 17);
            this.labelElegirFiltroClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelElegirFiltroClientes.Name = "labelElegirFiltroClientes";
            this.labelElegirFiltroClientes.Size = new System.Drawing.Size(126, 28);
            this.labelElegirFiltroClientes.TabIndex = 17;
            this.labelElegirFiltroClientes.Text = "Elegir filtro:";
            // 
            // cmbFiltroClientes
            // 
            this.cmbFiltroClientes.FormattingEnabled = true;
            this.cmbFiltroClientes.Items.AddRange(new object[] {
            "Nombre",
            "Apellido",
            "ID de Usuario",
            "Correo"});
            this.cmbFiltroClientes.Location = new System.Drawing.Point(409, 49);
            this.cmbFiltroClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFiltroClientes.Name = "cmbFiltroClientes";
            this.cmbFiltroClientes.Size = new System.Drawing.Size(196, 24);
            this.cmbFiltroClientes.TabIndex = 16;
            // 
            // txtFiltroClientes
            // 
            this.txtFiltroClientes.Location = new System.Drawing.Point(23, 49);
            this.txtFiltroClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltroClientes.Name = "txtFiltroClientes";
            this.txtFiltroClientes.Size = new System.Drawing.Size(349, 22);
            this.txtFiltroClientes.TabIndex = 15;
            this.txtFiltroClientes.TextChanged += new System.EventHandler(this.txtFiltroClientes_TextChanged);
            this.txtFiltroClientes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltroClientes_KeyUp);
            // 
            // buttonEliminarCliente
            // 
            this.buttonEliminarCliente.BackColor = System.Drawing.Color.Red;
            this.buttonEliminarCliente.FlatAppearance.BorderSize = 0;
            this.buttonEliminarCliente.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarCliente.ForeColor = System.Drawing.Color.White;
            this.buttonEliminarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminarCliente.Image")));
            this.buttonEliminarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminarCliente.Location = new System.Drawing.Point(912, 20);
            this.buttonEliminarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEliminarCliente.Name = "buttonEliminarCliente";
            this.buttonEliminarCliente.Size = new System.Drawing.Size(153, 43);
            this.buttonEliminarCliente.TabIndex = 14;
            this.buttonEliminarCliente.Text = "  Eliminar";
            this.buttonEliminarCliente.UseVisualStyleBackColor = false;
            this.buttonEliminarCliente.Click += new System.EventHandler(this.buttonEliminarCliente_Click);
            // 
            // buttonEditarCLiente
            // 
            this.buttonEditarCLiente.BackColor = System.Drawing.Color.Yellow;
            this.buttonEditarCLiente.FlatAppearance.BorderSize = 0;
            this.buttonEditarCLiente.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarCLiente.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditarCLiente.Image")));
            this.buttonEditarCLiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditarCLiente.Location = new System.Drawing.Point(788, 20);
            this.buttonEditarCLiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditarCLiente.Name = "buttonEditarCLiente";
            this.buttonEditarCLiente.Size = new System.Drawing.Size(116, 43);
            this.buttonEditarCLiente.TabIndex = 13;
            this.buttonEditarCLiente.Text = "  Editar";
            this.buttonEditarCLiente.UseVisualStyleBackColor = false;
            this.buttonEditarCLiente.Click += new System.EventHandler(this.buttonEditarCLiente_Click);
            // 
            // buttonAñadirCliente
            // 
            this.buttonAñadirCliente.BackColor = System.Drawing.Color.Orange;
            this.buttonAñadirCliente.FlatAppearance.BorderSize = 0;
            this.buttonAñadirCliente.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAñadirCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonAñadirCliente.Image")));
            this.buttonAñadirCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAñadirCliente.Location = new System.Drawing.Point(647, 20);
            this.buttonAñadirCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAñadirCliente.Name = "buttonAñadirCliente";
            this.buttonAñadirCliente.Size = new System.Drawing.Size(133, 43);
            this.buttonAñadirCliente.TabIndex = 12;
            this.buttonAñadirCliente.Text = "  Añadir";
            this.buttonAñadirCliente.UseVisualStyleBackColor = false;
            this.buttonAñadirCliente.Click += new System.EventHandler(this.buttonAñadirCliente_Click);
            // 
            // BarraTituloListadoUsuario
            // 
            this.BarraTituloListadoUsuario.BackColor = System.Drawing.Color.SeaGreen;
            this.BarraTituloListadoUsuario.Controls.Add(this.LabelVerEstadoDeSocio);
            this.BarraTituloListadoUsuario.Controls.Add(this.PictureBoxLogoListadoUsuario);
            this.BarraTituloListadoUsuario.Controls.Add(this.PtbCerrarFormularioListadoUsuario);
            this.BarraTituloListadoUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTituloListadoUsuario.Location = new System.Drawing.Point(0, 0);
            this.BarraTituloListadoUsuario.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.BarraTituloListadoUsuario.Name = "BarraTituloListadoUsuario";
            this.BarraTituloListadoUsuario.Size = new System.Drawing.Size(1232, 49);
            this.BarraTituloListadoUsuario.TabIndex = 7;
            // 
            // LabelVerEstadoDeSocio
            // 
            this.LabelVerEstadoDeSocio.AutoSize = true;
            this.LabelVerEstadoDeSocio.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVerEstadoDeSocio.ForeColor = System.Drawing.Color.White;
            this.LabelVerEstadoDeSocio.Location = new System.Drawing.Point(592, 5);
            this.LabelVerEstadoDeSocio.Name = "LabelVerEstadoDeSocio";
            this.LabelVerEstadoDeSocio.Size = new System.Drawing.Size(281, 41);
            this.LabelVerEstadoDeSocio.TabIndex = 2;
            this.LabelVerEstadoDeSocio.Text = "LISTADO DE USUARIO";
            this.LabelVerEstadoDeSocio.Click += new System.EventHandler(this.LabelVerEstadoDeSocio_Click);
            // 
            // PictureBoxLogoListadoUsuario
            // 
            this.PictureBoxLogoListadoUsuario.BackColor = System.Drawing.Color.SeaGreen;
            this.PictureBoxLogoListadoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogoListadoUsuario.Image")));
            this.PictureBoxLogoListadoUsuario.Location = new System.Drawing.Point(-24, -4);
            this.PictureBoxLogoListadoUsuario.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.PictureBoxLogoListadoUsuario.Name = "PictureBoxLogoListadoUsuario";
            this.PictureBoxLogoListadoUsuario.Size = new System.Drawing.Size(236, 52);
            this.PictureBoxLogoListadoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLogoListadoUsuario.TabIndex = 0;
            this.PictureBoxLogoListadoUsuario.TabStop = false;
            // 
            // PtbCerrarFormularioListadoUsuario
            // 
            this.PtbCerrarFormularioListadoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PtbCerrarFormularioListadoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PtbCerrarFormularioListadoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("PtbCerrarFormularioListadoUsuario.Image")));
            this.PtbCerrarFormularioListadoUsuario.Location = new System.Drawing.Point(1191, 11);
            this.PtbCerrarFormularioListadoUsuario.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.PtbCerrarFormularioListadoUsuario.Name = "PtbCerrarFormularioListadoUsuario";
            this.PtbCerrarFormularioListadoUsuario.Size = new System.Drawing.Size(31, 28);
            this.PtbCerrarFormularioListadoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtbCerrarFormularioListadoUsuario.TabIndex = 1;
            this.PtbCerrarFormularioListadoUsuario.TabStop = false;
            this.PtbCerrarFormularioListadoUsuario.Click += new System.EventHandler(this.PtbCerrarFormularioListadoUsuario_Click);
            // 
            // DGVListadoUsuario
            // 
            this.DGVListadoUsuario.AllowUserToAddRows = false;
            this.DGVListadoUsuario.AllowUserToDeleteRows = false;
            this.DGVListadoUsuario.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVListadoUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVListadoUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVListadoUsuario.BackgroundColor = System.Drawing.Color.White;
            this.DGVListadoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVListadoUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVListadoUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVListadoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListadoUsuario.Cursor = System.Windows.Forms.Cursors.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVListadoUsuario.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVListadoUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVListadoUsuario.EnableHeadersVisualStyles = false;
            this.DGVListadoUsuario.Location = new System.Drawing.Point(0, 129);
            this.DGVListadoUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVListadoUsuario.MultiSelect = false;
            this.DGVListadoUsuario.Name = "DGVListadoUsuario";
            this.DGVListadoUsuario.RowHeadersWidth = 51;
            this.DGVListadoUsuario.RowTemplate.Height = 24;
            this.DGVListadoUsuario.Size = new System.Drawing.Size(1232, 421);
            this.DGVListadoUsuario.TabIndex = 34;
            this.DGVListadoUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListadoUsuario_CellContentClick);
            // 
            // ListadoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 550);
            this.Controls.Add(this.DGVListadoUsuario);
            this.Controls.Add(this.PanelFiltrosDefechasListadoUsuario);
            this.Controls.Add(this.BarraTituloListadoUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(28, 23);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListadoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoUsuario";
            this.Load += new System.EventHandler(this.ListadoUsuario_Load);
            this.PanelFiltrosDefechasListadoUsuario.ResumeLayout(false);
            this.PanelFiltrosDefechasListadoUsuario.PerformLayout();
            this.BarraTituloListadoUsuario.ResumeLayout(false);
            this.BarraTituloListadoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogoListadoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrarFormularioListadoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListadoUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelFiltrosDefechasListadoUsuario;
        private System.Windows.Forms.Panel BarraTituloListadoUsuario;
        private System.Windows.Forms.Label LabelVerEstadoDeSocio;
        private System.Windows.Forms.PictureBox PictureBoxLogoListadoUsuario;
        private System.Windows.Forms.PictureBox PtbCerrarFormularioListadoUsuario;
        private System.Windows.Forms.Label LabelNombreSocio;
        private System.Windows.Forms.Label labelElegirFiltroClientes;
        private System.Windows.Forms.ComboBox cmbFiltroClientes;
        private System.Windows.Forms.TextBox txtFiltroClientes;
        private System.Windows.Forms.Button buttonEliminarCliente;
        private System.Windows.Forms.Button buttonEditarCLiente;
        private System.Windows.Forms.Button buttonAñadirCliente;
        public System.Windows.Forms.DataGridView DGVListadoUsuario;
    }
}