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
    public partial class ListadoDeSocio : Form
    {
        csConectaSQL Conecta = new csConectaSQL();
        public ListadoDeSocio()
        {
            InitializeComponent();
        }

        private void PtbCerrarFormularioAsistencia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListadoDeSocio_Load(object sender, EventArgs e)
        {
            DGVSListadoSocios.DataSource = Conecta.retornaRegistros("Select * From Socio");
        }

        private void BtnAgregarSocio_Click(object sender, EventArgs e)
        {
            FrmAgregarSocio Socio = new FrmAgregarSocio();
            this.AddOwnedForm(Socio);
            Socio.Show();

        }

        private void tsbFiltroSocio_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminarSocio_Click(object sender, EventArgs e)
        {
            if(DGVSListadoSocios.RowCount > 1)
            {
                DialogResult opc = MessageBox.Show(this, "Se eliminará la fila " + DGVSListadoSocios.CurrentRow.Index + ", que pertenece al Socio " + DGVSListadoSocios[0, DGVSListadoSocios.CurrentRow.Index].Value.ToString(), "Confirmación de Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opc == DialogResult.Yes)
                {
                    Conecta.eliminarDatos("Socio", "Nombre='" + DGVSListadoSocios[0, DGVSListadoSocios.CurrentRow.Index].Value.ToString() + "'");
                    DGVSListadoSocios.DataSource = Conecta.retornaRegistros("Select * from Socio");
                }
            }
        }

        private void btnModificarSocio_Click(object sender, EventArgs e)
        {
            FrmAgregarSocio ModificarSocio = new FrmAgregarSocio();
            this.AddOwnedForm(ModificarSocio);

            ModificarSocio.LabelVerAgregarSocio.Font = new Font("Impact", 15.75F);
            ModificarSocio.LabelVerAgregarSocio.Text = "MODIFICAR SOCIO";
            ModificarSocio.TxtNombreSocio.Text = DGVSListadoSocios[1, DGVSListadoSocios.CurrentRow.Index].Value.ToString();
            ModificarSocio.TxtApellidoSocio.Text = DGVSListadoSocios[2, DGVSListadoSocios.CurrentRow.Index].Value.ToString();
            ModificarSocio.TxtCedulaSocio.Text = DGVSListadoSocios[3, DGVSListadoSocios.CurrentRow.Index].Value.ToString();
            ModificarSocio.DTFNacimientoSocio.Text = DGVSListadoSocios[4, DGVSListadoSocios.CurrentRow.Index].Value.ToString();
            ModificarSocio.CmboxSexoSocio.Text = DGVSListadoSocios[5, DGVSListadoSocios.CurrentRow.Index].Value.ToString();
            ModificarSocio.CmbCodigoPaisSocio.Text = DGVSListadoSocios[6, DGVSListadoSocios.CurrentRow.Index].Value.ToString();
            ModificarSocio.TxtPesoSocio.Text = DGVSListadoSocios[7, DGVSListadoSocios.CurrentRow.Index].Value.ToString();
            ModificarSocio.CmbProvinciaSocio.Text = DGVSListadoSocios[8, DGVSListadoSocios.CurrentRow.Index].Value.ToString();
            ModificarSocio.CmboxCantonSocio.Text = DGVSListadoSocios[9, DGVSListadoSocios.CurrentRow.Index].Value.ToString();
            ModificarSocio.TxtNDomicilioSocio.Text = DGVSListadoSocios[10, DGVSListadoSocios.CurrentRow.Index].Value.ToString();
            ModificarSocio.TxtAlturaSocio.Text = DGVSListadoSocios[11, DGVSListadoSocios.CurrentRow.Index].Value.ToString();
            ModificarSocio.TxtEmailSocio.Text = DGVSListadoSocios[12, DGVSListadoSocios.CurrentRow.Index].Value.ToString();
            ModificarSocio.TxtTelefonoSocio.Text = DGVSListadoSocios[13, DGVSListadoSocios.CurrentRow.Index].Value.ToString();
            ModificarSocio.Show();
        }
    }
}
