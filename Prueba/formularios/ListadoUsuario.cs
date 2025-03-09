using AplicacionGym.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionGym
{
    public partial class ListadoUsuario : Form
    {
        csConectaSQL conectar = new csConectaSQL();
        gUsuarios gUsuario = new gUsuarios();
        
        public ListadoUsuario()
        {
            InitializeComponent();
        }

        private void DataGridViewBaseDeDatosListadoUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PtbCerrarFormularioListadoUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListadoUsuario_Load(object sender, EventArgs e)
        {
            DGVListadoUsuario.DataSource = conectar.retornaRegistros("Select UsuarioID,Nombre,Apellido,Telefono,Email,PerfilUsuario from Usuarios");
        }

        private void buttonAñadirCliente_Click(object sender, EventArgs e)
        {
            int tp = 0;
            FrmAgregarUsuario VerFormularioAgregarUsuario = new FrmAgregarUsuario();
            this.AddOwnedForm(VerFormularioAgregarUsuario);
            VerFormularioAgregarUsuario.tp = tp;
            VerFormularioAgregarUsuario.Show();
        }

        private void LabelVerEstadoDeSocio_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditarCLiente_Click(object sender, EventArgs e)
        {
            int tp = 1;
             
            FrmAgregarUsuario ModificarRegistroUsuario = new FrmAgregarUsuario();
            this.AddOwnedForm(ModificarRegistroUsuario);
            ModificarRegistroUsuario.tp=tp;
            ModificarRegistroUsuario.LabelNuevoUsuario.Font = new Font("Impact", 15.75F);
            ModificarRegistroUsuario.LabelNuevoUsuario.Text = "MODIFICAR USUARIO";
            ModificarRegistroUsuario.TxtBoxNombreUsuario.Text = DGVListadoUsuario[1, DGVListadoUsuario.CurrentRow.Index].Value.ToString();
            ModificarRegistroUsuario.TxtBoxApellidoUsuario.Text = DGVListadoUsuario[2, DGVListadoUsuario.CurrentRow.Index].Value.ToString();
            ModificarRegistroUsuario.TxtBoxTelefonoUsuario.Text = DGVListadoUsuario[3, DGVListadoUsuario.CurrentRow.Index].Value.ToString();
            ModificarRegistroUsuario.TxtBoxDomicilioUsuario.Text = DGVListadoUsuario[4, DGVListadoUsuario.CurrentRow.Index].Value.ToString();
            ModificarRegistroUsuario.TxtBoxUsuarioUsuario.Text = DGVListadoUsuario[5, DGVListadoUsuario.CurrentRow.Index].Value.ToString();
            ModificarRegistroUsuario.TxtBoxMailUsuario.Text = DGVListadoUsuario[6, DGVListadoUsuario.CurrentRow.Index].Value.ToString();
            ModificarRegistroUsuario.TxtBoxContraseñaUsuario.Text = DGVListadoUsuario[7, DGVListadoUsuario.CurrentRow.Index].Value.ToString();
            ModificarRegistroUsuario.ComboBoxPerfilUsuario.Text = DGVListadoUsuario[8, DGVListadoUsuario.CurrentRow.Index].Value.ToString();
            ModificarRegistroUsuario.lbldondevaelid.Text = DGVListadoUsuario[0, DGVListadoUsuario.CurrentRow.Index].Value.ToString();
            ModificarRegistroUsuario.Show();

        }

        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {
            if (DGVListadoUsuario.RowCount > 1)
            {
                DialogResult opc = MessageBox.Show(this, "Se eliminará la fila "
                    + DGVListadoUsuario.CurrentRow.Index + ", que pertenece al Usuario " 
                    + DGVListadoUsuario[0, DGVListadoUsuario.CurrentRow.Index].Value.ToString(), "Confirmación de Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opc == DialogResult.Yes)
                {
                    gUsuario.EliminarUsuario("Usuarios", "Nombre='" + DGVListadoUsuario[1, DGVListadoUsuario.CurrentRow.Index].Value.ToString() + "'");
                    DGVListadoUsuario.DataSource = conectar.retornaRegistros("Select UsuarioID,Nombre,Apellido,Telefono,Email,PerfilUsuario from Usuarios");
                }
            }
        }

        private void DGVListadoUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFiltroClientes_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtFiltroClientes.Text.Length > 0)
                {
                    switch (cmbFiltroClientes.Text)
                    {
                        case "Nombre":
                            DGVListadoUsuario.DataSource = conectar.retornaRegistros("Select * from Usuarios where Nombre like '%" + txtFiltroClientes.Text + "%'");
                            break;
                        case "Apellido":
                            DGVListadoUsuario.DataSource = conectar.retornaRegistros("Select * from Usuarios where Apellido like '%" + txtFiltroClientes.Text + "%'");
                            break;
                        case "ID de Usuario":
                            DGVListadoUsuario.DataSource = conectar.retornaRegistros("Select * from Usuarios where UsuarioID like '%" + txtFiltroClientes.Text + "%'");
                            break;
                        case "Correo":
                            DGVListadoUsuario.DataSource = conectar.retornaRegistros("Select * from Usuarios where Email like '%" + txtFiltroClientes.Text + "%'");
                            break;
                    }
                }
                if (txtFiltroClientes.Text.Length == 0)
                {
                    DGVListadoUsuario.DataSource = conectar.retornaRegistros("Select * from Usuarios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void txtFiltroClientes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
