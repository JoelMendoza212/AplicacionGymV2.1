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
    public partial class PantallaInicio : Form
    {
        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void PtbCerrarFormularioPrincipal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LabelRolUsuario_Click(object sender, EventArgs e)
        {

        }

        private void ptbminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            ptbrestaurar.Visible = false;
            ptbrestaurar.Visible = true;
        }

        private void LabelCerrarSesion_Click(object sender, EventArgs e)
        {
            LoginGym CerrarSesionUsuario = new LoginGym();
            CerrarSesionUsuario.Show();
            this.Close();
        }

        private void PanelControlInterfaces_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void AbrirFormulariosHijas(object formulariosHijos)
        {
            if (formulariosHijos == null)
                return;

            if (this.PanelControlInterfaces.Controls.Count > 0)
            {
                this.PanelControlInterfaces.Controls.RemoveAt(0);
            }

            Form Formularios = formulariosHijos as Form;
            if (Formularios != null)
            {
                Formularios.TopLevel = false;
                Formularios.Dock = DockStyle.Fill;
                this.PanelControlInterfaces.Controls.Add(Formularios);
                this.PanelControlInterfaces.Tag = Formularios;
                Formularios.Show();
            }
        }
        private void PantallaInicio_Load(object sender, EventArgs e)
        {
            FrmControlAcceso ControlAccesoVer = new FrmControlAcceso();
            AbrirFormulariosHijas(ControlAccesoVer);
        }

        private void registroDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarSocio AgregarSocioNuevo = new FrmAgregarSocio();
            AgregarSocioNuevo.ShowInTaskbar = false;
            AgregarSocioNuevo.Owner = this.Owner;
            AgregarSocioNuevo.ShowDialog();
        }

        private async void AccesoUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Buscar si PantallaInicio ya está abierta para mantenerla activa
            Form pantallaInicio = Application.OpenForms["PantallaInicio"];

            // Abrir el formulario de huella sin cerrar PantallaInicio
            FrmHuella formularioHuella = new FrmHuella();
            formularioHuella.Show();

            await Task.Delay(5000); // Esperar 5 segundos
            // Cerrar el formulario de huella
            formularioHuella.Close();

            // Abrir el formulario de CoutaAlDia sin cerrar PantallaInicio
            FrmCoutaAlDia FormularioCoutaAlDia = new FrmCoutaAlDia();
            FormularioCoutaAlDia.Show();
            await Task.Delay(15000);
            // Cerrar el formulario de huella
            FormularioCoutaAlDia.Close();

            // Si PantallaInicio está abierta, la traemos al frente
            if (pantallaInicio != null)
            {
                pantallaInicio.BringToFront();
            }
        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAsistencia VerAsistencia = new FrmAsistencia();
            VerAsistencia.ShowInTaskbar = false;
            VerAsistencia.Owner = this.Owner;
            VerAsistencia.ShowDialog();

        }

        private void listadoDeSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoDeSocio VerListadoDeSocios = new ListadoDeSocio();
            VerListadoDeSocios.ShowInTaskbar = false;
            VerListadoDeSocios.Owner = this.Owner;
            VerListadoDeSocios.ShowDialog();
        }

        private void EstadisticasDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEstadisticas VerEstadisticas = new FrmEstadisticas();
            VerEstadisticas.ShowInTaskbar = false;
            VerEstadisticas.Owner = this.Owner;
            VerEstadisticas.ShowDialog();
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario VerFormularioAgregarUsuario = new FrmAgregarUsuario();
            AddOwnedForm(VerFormularioAgregarUsuario);
            VerFormularioAgregarUsuario.ShowInTaskbar = false;
            VerFormularioAgregarUsuario.Owner = this.Owner;
            VerFormularioAgregarUsuario.ShowDialog();
        }

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoUsuario VerFormularioDeListadoSocio = new ListadoUsuario();
            VerFormularioDeListadoSocio.ShowInTaskbar = false;
            VerFormularioDeListadoSocio.Owner = this.Owner;
            VerFormularioDeListadoSocio.ShowDialog();
        }

        private void SociosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarProductos VerFormularioAgregarProducto = new AgregarProductos();
            VerFormularioAgregarProducto.ShowInTaskbar = false;
            VerFormularioAgregarProducto.Owner = this.Owner;
            VerFormularioAgregarProducto.ShowDialog();
        }

        private void listadoDeIntructoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CajaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoIntructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoInstructor VerFormularioNuevoInstructor = new FrmNuevoInstructor();
            VerFormularioNuevoInstructor.ShowInTaskbar = false;
            VerFormularioNuevoInstructor.Owner = this.Owner;
            VerFormularioNuevoInstructor.ShowDialog();
        }

        private void nuevoPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoPlan VerFormularioNuevoPlan = new FrmNuevoPlan();
            VerFormularioNuevoPlan.ShowInTaskbar = false;
            VerFormularioNuevoPlan.Owner = this.Owner;
            VerFormularioNuevoPlan.ShowDialog();
        }

        private void darDeBajaAInactivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDarDeBajaInactivos VerFormularioBajaInactivos = new FrmDarDeBajaInactivos();
            VerFormularioBajaInactivos.ShowInTaskbar = false;
            VerFormularioBajaInactivos.Owner = this.Owner;
            VerFormularioBajaInactivos.ShowDialog();
        }

        private void sociosConDeudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSocioConDeuda VerFormularioSociosConDeuda = new FrmSocioConDeuda();
            VerFormularioSociosConDeuda.ShowInTaskbar = false;
            VerFormularioSociosConDeuda.Owner = this.Owner;
            VerFormularioSociosConDeuda.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void listadoDePlanesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoDePlanes ListadoPlanes = new ListadoDePlanes();
            ListadoPlanes.ShowInTaskbar = false;
            ListadoPlanes.Owner = this.Owner;
            ListadoPlanes.ShowDialog();
        }

        private void verCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarProductos VerFormularioAgregarProductos = new AgregarProductos();
            VerFormularioAgregarProductos.ShowInTaskbar = false;
            VerFormularioAgregarProductos.Owner = this.Owner;
            VerFormularioAgregarProductos.ShowDialog();
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerProductos verProductos = new VerProductos();
            verProductos.ShowInTaskbar = false;
            verProductos.Owner = this.Owner;
            verProductos.ShowDialog();
        }

        private void venderUnProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVenderProducto frmVenderProducto = new FrmVenderProducto();
            frmVenderProducto.ShowInTaskbar = false;
            frmVenderProducto.Owner= this.Owner;
            frmVenderProducto.ShowDialog();
        }
    }
}
