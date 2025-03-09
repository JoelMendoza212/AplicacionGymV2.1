using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionGym
{
    public partial class FrmAgregarSocio : Form
    {
        csConectaSQL conSQL = new csConectaSQL();
        string cadena;

        public FrmAgregarSocio()
        {
            InitializeComponent();
        }

        private void PtbCerrarFormularioAgregarSocio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonInicioSesion_Click(object sender, EventArgs e)
        {
            TabControlFormularioAgregarSocio.TabIndex = 1;
        }

        private void ButtonSeleccionarFoto_Click(object sender, EventArgs e)
        {

        }

        private void PictureBoxFotoSocio_Click(object sender, EventArgs e)
        {
            OpenFileDialog SeleccionarFotoCarpetas = new OpenFileDialog
            {
                Filter = "Imagenes |*.jpg; *.png",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                Title = "Seleccionar Imagen"
            };

            if (SeleccionarFotoCarpetas.ShowDialog() == DialogResult.OK)
            {
                PictureBoxFotoSocio.Image = Image.FromFile(SeleccionarFotoCarpetas.FileName);
            }
        }

        private void PictureSeleccionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog SeleccionarFotoCarpetas = new OpenFileDialog
            {
                Filter = "Imagenes |*.jpg; *.png",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                Title = "Seleccionar Imagen"
            };

            if (SeleccionarFotoCarpetas.ShowDialog() == DialogResult.OK)
            {
                PictureBoxFotoSocio.Image = Image.FromFile(SeleccionarFotoCarpetas.FileName);
            }
        }

        private void ButtonCobrarSocio_Click(object sender, EventArgs e)
        {
            ListadoDeSocio listado = new ListadoDeSocio();
            FrmAgregarSocio agregarSocio = new FrmAgregarSocio();
            agregarSocio.Owner = listado;
            agregarSocio.ShowDialog();

            cadena = "'" + TxtNombreSocio.Text + "'," +
                     "'" + TxtApellidoSocio.Text + "'," +
                     "'" + TxtCedulaSocio.Text + "'," +
                     "'" + DTFNacimientoSocio.TabStop + "'," +
                     "'" + CmboxSexoSocio.Text + "'," +
                     "'" + CmbCodigoPaisSocio.Text + "'," +
                     "'" + TxtPesoSocio.Text + "'," +
                     "'" + CmbProvinciaSocio.Text + "'," +
                     "'" + CmboxCantonSocio.Text + "'," +
                     "'" + TxtNDomicilioSocio.Text + "'," +
                     "'" + TxtAlturaSocio.Text + "'," +
                     "'" + TxtEmailSocio.Text + "'," +
                     "'" + TxtTelefonoSocio.Text + "'";

            conSQL.insertarDatos("Socio", "Nombre,Apellido,Cedula,FechaNacimiento,Sexo,CodigoPaisTelefono,Peso,Provincia,Canton,Domicilio,Altura,Email,Telefono", cadena);
            TabControlFormularioAgregarSocio.SelectedIndex = 1;
            FrmHuella FormularioHuellaMostrar = new FrmHuella();
            FormularioHuellaMostrar.ShowDialog();
        }

        private void PanelAgregarSocioFormulario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmAgregarSocio_Load(object sender, EventArgs e)
        {

        }

        private void TabPageMembresia_Click(object sender, EventArgs e)
        {

        }
    }
}
