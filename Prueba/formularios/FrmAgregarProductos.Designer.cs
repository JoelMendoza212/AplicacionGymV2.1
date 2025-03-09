using System.Windows.Forms;

namespace AplicacionGym
{
    public partial class AgregarProductos : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProductos));
            this.LabelCodigoFormularioAgregarProducto = new System.Windows.Forms.Label();
            this.LabelNombreFormularioAgregarProducto = new System.Windows.Forms.Label();
            this.LabelDescripcionFormularioAgregarProducto = new System.Windows.Forms.Label();
            this.LabelPrecioCompraFormularioAgregarProducto = new System.Windows.Forms.Label();
            this.LabelPrecioVentaFormularioAgregarProducto = new System.Windows.Forms.Label();
            this.TxtCodigoProducto = new System.Windows.Forms.TextBox();
            this.TxtprecioCompraProducto = new System.Windows.Forms.TextBox();
            this.TxtPrecioVentaProducto = new System.Windows.Forms.TextBox();
            this.TxtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.BarraTituloFormularioAgregarProducto = new System.Windows.Forms.Panel();
            this.LabelVerAgregarProducto = new System.Windows.Forms.Label();
            this.LabelCerrarSesion = new System.Windows.Forms.Label();
            this.PictureBoxLogoFormularioAgregarProducto = new System.Windows.Forms.PictureBox();
            this.PtbCerrarFormularioAgregarProductos = new System.Windows.Forms.PictureBox();
            this.ButtonGuardarAgregarProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCantidadProducto = new System.Windows.Forms.TextBox();
            this.BarraTituloFormularioAgregarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogoFormularioAgregarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrarFormularioAgregarProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelCodigoFormularioAgregarProducto
            // 
            this.LabelCodigoFormularioAgregarProducto.AutoSize = true;
            this.LabelCodigoFormularioAgregarProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCodigoFormularioAgregarProducto.Location = new System.Drawing.Point(93, 65);
            this.LabelCodigoFormularioAgregarProducto.Name = "LabelCodigoFormularioAgregarProducto";
            this.LabelCodigoFormularioAgregarProducto.Size = new System.Drawing.Size(66, 21);
            this.LabelCodigoFormularioAgregarProducto.TabIndex = 0;
            this.LabelCodigoFormularioAgregarProducto.Text = "Código";
            // 
            // LabelNombreFormularioAgregarProducto
            // 
            this.LabelNombreFormularioAgregarProducto.AutoSize = true;
            this.LabelNombreFormularioAgregarProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombreFormularioAgregarProducto.Location = new System.Drawing.Point(85, 104);
            this.LabelNombreFormularioAgregarProducto.Name = "LabelNombreFormularioAgregarProducto";
            this.LabelNombreFormularioAgregarProducto.Size = new System.Drawing.Size(74, 21);
            this.LabelNombreFormularioAgregarProducto.TabIndex = 1;
            this.LabelNombreFormularioAgregarProducto.Text = "Nombre";
            // 
            // LabelDescripcionFormularioAgregarProducto
            // 
            this.LabelDescripcionFormularioAgregarProducto.AutoSize = true;
            this.LabelDescripcionFormularioAgregarProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescripcionFormularioAgregarProducto.Location = new System.Drawing.Point(57, 183);
            this.LabelDescripcionFormularioAgregarProducto.Name = "LabelDescripcionFormularioAgregarProducto";
            this.LabelDescripcionFormularioAgregarProducto.Size = new System.Drawing.Size(102, 21);
            this.LabelDescripcionFormularioAgregarProducto.TabIndex = 2;
            this.LabelDescripcionFormularioAgregarProducto.Text = "Descripción";
            // 
            // LabelPrecioCompraFormularioAgregarProducto
            // 
            this.LabelPrecioCompraFormularioAgregarProducto.AutoSize = true;
            this.LabelPrecioCompraFormularioAgregarProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrecioCompraFormularioAgregarProducto.Location = new System.Drawing.Point(9, 223);
            this.LabelPrecioCompraFormularioAgregarProducto.Name = "LabelPrecioCompraFormularioAgregarProducto";
            this.LabelPrecioCompraFormularioAgregarProducto.Size = new System.Drawing.Size(150, 21);
            this.LabelPrecioCompraFormularioAgregarProducto.TabIndex = 3;
            this.LabelPrecioCompraFormularioAgregarProducto.Text = "Precio de Compra";
            // 
            // LabelPrecioVentaFormularioAgregarProducto
            // 
            this.LabelPrecioVentaFormularioAgregarProducto.AutoSize = true;
            this.LabelPrecioVentaFormularioAgregarProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrecioVentaFormularioAgregarProducto.Location = new System.Drawing.Point(26, 261);
            this.LabelPrecioVentaFormularioAgregarProducto.Name = "LabelPrecioVentaFormularioAgregarProducto";
            this.LabelPrecioVentaFormularioAgregarProducto.Size = new System.Drawing.Size(133, 21);
            this.LabelPrecioVentaFormularioAgregarProducto.TabIndex = 4;
            this.LabelPrecioVentaFormularioAgregarProducto.Text = "Precio de Venta";
            // 
            // TxtCodigoProducto
            // 
            this.TxtCodigoProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoProducto.Location = new System.Drawing.Point(165, 57);
            this.TxtCodigoProducto.Name = "TxtCodigoProducto";
            this.TxtCodigoProducto.Size = new System.Drawing.Size(121, 29);
            this.TxtCodigoProducto.TabIndex = 1;
            // 
            // TxtprecioCompraProducto
            // 
            this.TxtprecioCompraProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtprecioCompraProducto.Location = new System.Drawing.Point(165, 215);
            this.TxtprecioCompraProducto.Name = "TxtprecioCompraProducto";
            this.TxtprecioCompraProducto.Size = new System.Drawing.Size(121, 29);
            this.TxtprecioCompraProducto.TabIndex = 5;
            // 
            // TxtPrecioVentaProducto
            // 
            this.TxtPrecioVentaProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioVentaProducto.Location = new System.Drawing.Point(165, 253);
            this.TxtPrecioVentaProducto.Name = "TxtPrecioVentaProducto";
            this.TxtPrecioVentaProducto.Size = new System.Drawing.Size(121, 29);
            this.TxtPrecioVentaProducto.TabIndex = 6;
            // 
            // TxtDescripcionProducto
            // 
            this.TxtDescripcionProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcionProducto.Location = new System.Drawing.Point(165, 175);
            this.TxtDescripcionProducto.Name = "TxtDescripcionProducto";
            this.TxtDescripcionProducto.Size = new System.Drawing.Size(391, 29);
            this.TxtDescripcionProducto.TabIndex = 4;
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreProducto.Location = new System.Drawing.Point(165, 96);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(391, 29);
            this.TxtNombreProducto.TabIndex = 2;
            // 
            // BarraTituloFormularioAgregarProducto
            // 
            this.BarraTituloFormularioAgregarProducto.BackColor = System.Drawing.Color.SeaGreen;
            this.BarraTituloFormularioAgregarProducto.Controls.Add(this.LabelVerAgregarProducto);
            this.BarraTituloFormularioAgregarProducto.Controls.Add(this.LabelCerrarSesion);
            this.BarraTituloFormularioAgregarProducto.Controls.Add(this.PictureBoxLogoFormularioAgregarProducto);
            this.BarraTituloFormularioAgregarProducto.Controls.Add(this.PtbCerrarFormularioAgregarProductos);
            this.BarraTituloFormularioAgregarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTituloFormularioAgregarProducto.Location = new System.Drawing.Point(0, 0);
            this.BarraTituloFormularioAgregarProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BarraTituloFormularioAgregarProducto.Name = "BarraTituloFormularioAgregarProducto";
            this.BarraTituloFormularioAgregarProducto.Size = new System.Drawing.Size(570, 41);
            this.BarraTituloFormularioAgregarProducto.TabIndex = 11;
            // 
            // LabelVerAgregarProducto
            // 
            this.LabelVerAgregarProducto.AutoSize = true;
            this.LabelVerAgregarProducto.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVerAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.LabelVerAgregarProducto.Location = new System.Drawing.Point(218, 3);
            this.LabelVerAgregarProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelVerAgregarProducto.Name = "LabelVerAgregarProducto";
            this.LabelVerAgregarProducto.Size = new System.Drawing.Size(235, 34);
            this.LabelVerAgregarProducto.TabIndex = 7;
            this.LabelVerAgregarProducto.Text = "AGREGAR PRODUCTO";
            // 
            // LabelCerrarSesion
            // 
            this.LabelCerrarSesion.AutoSize = true;
            this.LabelCerrarSesion.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.LabelCerrarSesion.Location = new System.Drawing.Point(686, 11);
            this.LabelCerrarSesion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelCerrarSesion.Name = "LabelCerrarSesion";
            this.LabelCerrarSesion.Size = new System.Drawing.Size(90, 19);
            this.LabelCerrarSesion.TabIndex = 5;
            this.LabelCerrarSesion.Text = "Cerrar Sesion";
            // 
            // PictureBoxLogoFormularioAgregarProducto
            // 
            this.PictureBoxLogoFormularioAgregarProducto.BackColor = System.Drawing.Color.SeaGreen;
            this.PictureBoxLogoFormularioAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogoFormularioAgregarProducto.Image")));
            this.PictureBoxLogoFormularioAgregarProducto.Location = new System.Drawing.Point(-18, -3);
            this.PictureBoxLogoFormularioAgregarProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PictureBoxLogoFormularioAgregarProducto.Name = "PictureBoxLogoFormularioAgregarProducto";
            this.PictureBoxLogoFormularioAgregarProducto.Size = new System.Drawing.Size(177, 42);
            this.PictureBoxLogoFormularioAgregarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLogoFormularioAgregarProducto.TabIndex = 0;
            this.PictureBoxLogoFormularioAgregarProducto.TabStop = false;
            // 
            // PtbCerrarFormularioAgregarProductos
            // 
            this.PtbCerrarFormularioAgregarProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PtbCerrarFormularioAgregarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PtbCerrarFormularioAgregarProductos.Image = ((System.Drawing.Image)(resources.GetObject("PtbCerrarFormularioAgregarProductos.Image")));
            this.PtbCerrarFormularioAgregarProductos.Location = new System.Drawing.Point(540, 9);
            this.PtbCerrarFormularioAgregarProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PtbCerrarFormularioAgregarProductos.Name = "PtbCerrarFormularioAgregarProductos";
            this.PtbCerrarFormularioAgregarProductos.Size = new System.Drawing.Size(22, 23);
            this.PtbCerrarFormularioAgregarProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtbCerrarFormularioAgregarProductos.TabIndex = 1;
            this.PtbCerrarFormularioAgregarProductos.TabStop = false;
            this.PtbCerrarFormularioAgregarProductos.Click += new System.EventHandler(this.PtbCerrarFormularioAgregarProductos_Click);
            // 
            // ButtonGuardarAgregarProducto
            // 
            this.ButtonGuardarAgregarProducto.BackColor = System.Drawing.Color.SeaGreen;
            this.ButtonGuardarAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGuardarAgregarProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGuardarAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.ButtonGuardarAgregarProducto.Location = new System.Drawing.Point(420, 226);
            this.ButtonGuardarAgregarProducto.Name = "ButtonGuardarAgregarProducto";
            this.ButtonGuardarAgregarProducto.Size = new System.Drawing.Size(136, 56);
            this.ButtonGuardarAgregarProducto.TabIndex = 7;
            this.ButtonGuardarAgregarProducto.Text = "Guardar";
            this.ButtonGuardarAgregarProducto.UseVisualStyleBackColor = false;
            this.ButtonGuardarAgregarProducto.Click += new System.EventHandler(this.ButtonGuardarAgregarProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cantidad";
            // 
            // TxtCantidadProducto
            // 
            this.TxtCantidadProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidadProducto.Location = new System.Drawing.Point(165, 136);
            this.TxtCantidadProducto.Name = "TxtCantidadProducto";
            this.TxtCantidadProducto.Size = new System.Drawing.Size(391, 29);
            this.TxtCantidadProducto.TabIndex = 3;
            // 
            // AgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(570, 297);
            this.Controls.Add(this.TxtCantidadProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonGuardarAgregarProducto);
            this.Controls.Add(this.BarraTituloFormularioAgregarProducto);
            this.Controls.Add(this.TxtNombreProducto);
            this.Controls.Add(this.TxtDescripcionProducto);
            this.Controls.Add(this.TxtPrecioVentaProducto);
            this.Controls.Add(this.TxtprecioCompraProducto);
            this.Controls.Add(this.TxtCodigoProducto);
            this.Controls.Add(this.LabelPrecioVentaFormularioAgregarProducto);
            this.Controls.Add(this.LabelPrecioCompraFormularioAgregarProducto);
            this.Controls.Add(this.LabelDescripcionFormularioAgregarProducto);
            this.Controls.Add(this.LabelNombreFormularioAgregarProducto);
            this.Controls.Add(this.LabelCodigoFormularioAgregarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del producto";
            this.BarraTituloFormularioAgregarProducto.ResumeLayout(false);
            this.BarraTituloFormularioAgregarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogoFormularioAgregarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCerrarFormularioAgregarProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelCodigoFormularioAgregarProducto;
        private System.Windows.Forms.Label LabelNombreFormularioAgregarProducto;
        private System.Windows.Forms.Label LabelDescripcionFormularioAgregarProducto;
        private System.Windows.Forms.Label LabelPrecioCompraFormularioAgregarProducto;
        private System.Windows.Forms.Label LabelPrecioVentaFormularioAgregarProducto;
        private System.Windows.Forms.Panel BarraTituloFormularioAgregarProducto;
        private System.Windows.Forms.PictureBox PictureBoxLogoFormularioAgregarProducto;
        private System.Windows.Forms.PictureBox PtbCerrarFormularioAgregarProductos;
        public System.Windows.Forms.Label LabelVerAgregarProducto;
        private System.Windows.Forms.Button ButtonGuardarAgregarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelCerrarSesion;
        public System.Windows.Forms.TextBox TxtCodigoProducto;
        public System.Windows.Forms.TextBox TxtprecioCompraProducto;
        public System.Windows.Forms.TextBox TxtPrecioVentaProducto;
        public System.Windows.Forms.TextBox TxtDescripcionProducto;
        public System.Windows.Forms.TextBox TxtNombreProducto;
        public System.Windows.Forms.TextBox TxtCantidadProducto;
    }
}