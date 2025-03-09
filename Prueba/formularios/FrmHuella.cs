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
    public partial class FrmHuella : Form
    {
        public FrmHuella()
        {
            InitializeComponent();
        }

        private async void FormularioHuella_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'h' || e.KeyChar == 'H') // Simular captura con la tecla 'H'
            {
                LabelMensajeConfirmacion.Text = "Huella registrada correctamente";
                LabelMensajeConfirmacion.ForeColor = Color.Green; // Opcional: cambiar color para destacar el mensaje

                await Task.Delay(5000); // Espera 5 segundos

                // Cerrar FormularioHuella
                this.Close();

                // Cerrar FichaSocio si está abierto
                Form AgregarSocio = Application.OpenForms["AgregarSocio"];
                if (AgregarSocio != null)
                {
                    AgregarSocio.Close();
                }

                // Verificar si PantallaInicio ya está abierta
                Form PantallaInicio = Application.OpenForms["PantallaInicio"];
                if (PantallaInicio != null)
                {
                    PantallaInicio.BringToFront(); // Traerla al frente si ya está abierta
                }
                else
                {
                    // Si no está abierta, la creamos y mostramos
                    PantallaInicio = new PantallaInicio();
                    PantallaInicio.Show();
                }
            }
        }

        private void PtbCerrarFormularioAgregarSocio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBoxRegistrarHuella_Click(object sender, EventArgs e)
        {

        }
    }
}
