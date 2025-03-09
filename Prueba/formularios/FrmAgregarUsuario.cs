using AplicacionGym.Clases;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionGym
{
    public partial class FrmAgregarUsuario : Form
    {
        private readonly csConectaSQL conSQL = new csConectaSQL();
         public gUsuarios gUsuario;
        private string cadena;
        public int tp; // 0 para insertar, otro valor para modificar

        public FrmAgregarUsuario()
        {
            InitializeComponent();
        }

        private void PtbCerrarFormularioAgregarUsuario_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonGuardarAgregarUsuario_Click(object sender, EventArgs e)
        {
            
            var GuardarUsuarios = Owner as ListadoUsuario;
            gUsuario = new gUsuarios();
           
            cadena = "'" + TxtBoxNombreUsuario.Text + "','" + TxtBoxApellidoUsuario.Text + "','"
                    + TxtBoxTelefonoUsuario.Text + "','" + TxtBoxDomicilioUsuario.Text + "','"
                    + TxtBoxUsuarioUsuario.Text + "','" + TxtBoxMailUsuario.Text + "','"+TxtBoxContraseñaUsuario.Text + "','"+ ComboBoxPerfilUsuario.Text+ "'";
            if (tp == 0)
            {
                gUsuario.IngresarUsuario("Usuarios", "Nombre,Apellido,Telefono,Domicilio,NombreUsuario,Email,Contraseña,PerfilUsuario", cadena);
            }
            else
            {
                string query = $"update Usuarios set Nombre='{TxtBoxNombreUsuario.Text}',Apellido='{TxtBoxApellidoUsuario.Text}',Telefono='{TxtBoxTelefonoUsuario.Text}',Domicilio='{TxtBoxDomicilioUsuario.Text}',NombreUsuario='{TxtBoxUsuarioUsuario.Text}',Email='{TxtBoxMailUsuario.Text}', Contraseña='{TxtBoxContraseñaUsuario.Text}'\r\n,PerfilUsuario='{ComboBoxPerfilUsuario}' where UsuarioID= {lbldondevaelid.Text}";
                gUsuario.ModificarUsuario(query);
            }
                 GuardarUsuarios.DGVListadoUsuario.DataSource = conSQL.retornaRegistros("Select*from Usuarios");
                 this.Close();
           



        }

        private void TxtBoxMailUsuario_TextChanged(object sender, EventArgs e)
        {
            TxtBoxMailUsuario.BackColor = EsCorreoValido(TxtBoxMailUsuario.Text) ? Color.LightGreen : Color.LightCoral;
        }

        private bool EsCorreoValido(string email)
        {
            return email.Contains("@") && email.Contains(".") && email.IndexOf("@") < email.LastIndexOf(".");
        }
    }
}
