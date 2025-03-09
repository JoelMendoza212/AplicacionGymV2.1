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
    public partial class LoginGym : Form
    {
        public LoginGym()
        {
            InitializeComponent();
        }

        private void TextBoxUsuarioLogin_Leave(object sender, EventArgs e)
        {
            if (TextBoxUsuarioLogin.Text == "")
            {
                TextBoxUsuarioLogin.Text = "Ingrese Usuario";
                TextBoxUsuarioLogin.ForeColor = Color.DarkGray;
            }
        }

        private void TextBoxUsuarioLogin_Enter(object sender, EventArgs e)
        {
            if (TextBoxUsuarioLogin.Text == "Ingrese Usuario")
            {
                TextBoxUsuarioLogin.Text = "";
                TextBoxUsuarioLogin.ForeColor = Color.Black;
            }
        }

        private void TextBoxContraseñaLogin_Leave(object sender, EventArgs e)
        {
            if (TextBoxContraseñaLogin.Text == "")
            {
                TextBoxContraseñaLogin.Text = "Ingrese Contraseña";
                TextBoxContraseñaLogin.ForeColor = Color.DarkGray;
            }
        }

        private void TextBoxContraseñaLogin_Validated(object sender, EventArgs e)
        {

        }

        private void TextBoxContraseñaLogin_Enter(object sender, EventArgs e)
        {
            if (TextBoxContraseñaLogin.Text == "Ingrese Contraseña")
            {
                TextBoxContraseñaLogin.Text = "";
                TextBoxContraseñaLogin.ForeColor = Color.Black;
            }
        }

        private void PtbCerrarInicioSesion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonInicioSesion_Click(object sender, EventArgs e)
        {
           if (TextBoxUsuarioLogin.Text == "admin" && TextBoxContraseñaLogin.Text == "admin")
            {
                MessageBox.Show("Bienvenido");
                PantallaInicio principal = new PantallaInicio();
                principal.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }   
        }

        private void LoginGym_Load(object sender, EventArgs e)
        {
            TextBoxContraseñaLogin.ForeColor = Color.DarkGray;
            TextBoxUsuarioLogin.ForeColor = Color.DarkGray;
        }

        private void TextBoxContraseñaLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
