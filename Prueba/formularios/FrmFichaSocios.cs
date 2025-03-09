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
    
    public partial class FrmFichaSocios : Form
    {
        public FrmFichaSocios()
        {
            InitializeComponent();
        }

        private void PtbCerrarInicioSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void ButtonRegistrarHuellaSocios_Click(object sender, EventArgs e)
        {
            // Buscar si PantallaInicio ya está abierta para mantenerla activa
            Form pantallaInicio = Application.OpenForms["PantallaInicio"];

            // Abrir el formulario de huella sin cerrar PantallaInicio
            FrmHuella formularioHuella = new FrmHuella();
            formularioHuella.Show();

            await Task.Delay(5000); // Esperar 5 segundos
            // Cerrar el formulario de huella
            formularioHuella.Close();

            // Si PantallaInicio está abierta, la traemos al frente
            if (pantallaInicio != null)
            {
                pantallaInicio.BringToFront();
            }
        }

        private void ButtonDarDeBaja_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea dar de baja a este socio?",
                                                     "Confirmar baja",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                // Código para eliminar al socio
                MessageBox.Show("El socio ha sido dado de baja correctamente.");
                Form pantallaInicio = Application.OpenForms["PantallaInicio"];
                if (pantallaInicio != null)
                {
                    pantallaInicio.BringToFront();
                }
                this.Close();
            }
        }

        private void ButtonSeguimiento_Click(object sender, EventArgs e)
        {
            FrmPagosAsistencias VerFormularioPagosAsistenciasIndividuales = new FrmPagosAsistencias();
            VerFormularioPagosAsistenciasIndividuales.Show();
        }

        private void ButtonEditarDatosSocios_Click(object sender, EventArgs e)
        {
            FrmAgregarSocio VerModificarSocio = new FrmAgregarSocio();
            VerModificarSocio.LabelVerAgregarSocio.Text = "MODIFICAR SOCIO";
            VerModificarSocio.TxtNombreSocio.Text = LabelNombreDatos.Text;
            VerModificarSocio.TxtCedulaSocio.Text = LabelCedulaDatos.Text; VerModificarSocio.TxtCedulaSocio.Enabled = false;
            VerModificarSocio.DTFNacimientoSocio.Value = Convert.ToDateTime(LabelFechaNacimientoDatos.Text); VerModificarSocio.DTFNacimientoSocio.Enabled = false;
            VerModificarSocio.TxtNDomicilioSocio.Text = LabelDomicilioDatos.Text;
            VerModificarSocio.TxtEmailSocio.Text = LabelMailDatos.Text;
            VerModificarSocio.TxtPesoSocio.Text = LabelPesoDatos.Text;
            VerModificarSocio.TxtAlturaSocio.Text = LabelEstaturaDatos.Text;    
            VerModificarSocio.Show();         

        }

        private void ButtonNuevaMembresiaSocio_Click(object sender, EventArgs e)
        {
            FrmNuevoPlan VerFormularioAgregarNuevoPlan = new FrmNuevoPlan();
            VerFormularioAgregarNuevoPlan.Show();
        }
    }
}
