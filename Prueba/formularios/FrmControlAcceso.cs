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
    public partial class FrmControlAcceso : Form
    {
        public FrmControlAcceso()
        {
            InitializeComponent();
        }

        private void PictureBoxAgregarSocio_Click(object sender, EventArgs e)
        {
            // Mostrar Formulario Agregar Socio de forma modal
            FrmAgregarSocio MostrarFormularioAgregarSocio = new FrmAgregarSocio();
            MostrarFormularioAgregarSocio.ShowDialog();
        }

        private void DateTimeHoraAutomatica_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FechaHoraHoy_Tick(object sender, EventArgs e)
        {
            LabelHoraHoy.Text = DateTime.Now.ToString("HH:mm:ss");
            LabelFechaHoy.Text = DateTime.Now.ToShortDateString();
        }

        private void PictureBoxBuscarSocio_Click(object sender, EventArgs e)
        {
            string BusquedaId = TextBoxBusquedaOpciones.Text;
            FrmFichaSocios VerFichaSocio = new FrmFichaSocios();
            VerFichaSocio.Show();

        }
    }
}
