using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionGym.Clases
{
    public class gUsuarios
    {
        csConectaSQL oCON;
        string Nombre;
        string Apellido;
        string telefono;
        string Domicilio;
        string NombreUsuario;
        string Email;
        string Contraseña;
        string PerfilUsuario;

        public string NOMBRE 
        { get { return Nombre; }
          set { Nombre = value; } 
        }
        public string APELLIDO 
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
       public string TELEFONO 
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string DOMICILIO 
        {
            get { return Domicilio; }
            set { Domicilio = value; }
        }
        public string NOMBREUSUARIO 
        {
            get { return NombreUsuario; }
            set { NombreUsuario = value; }
        }
        public string EMAIL 
        {
            get { return Email; }
            set { Email = value; }
        }
       public string CONTRASEÑA 
        {
            get { return Contraseña; }
            set { Contraseña = value; }
        }
       public string PERFILUSUARIO 
        {
            get { return PerfilUsuario; }
            set { PerfilUsuario = value; }
        }
        public gUsuarios()
        {
            oCON = new csConectaSQL();
        }

        public void IngresarUsuario(string tabla,string campos,string datos)
        {
            oCON.insertarDatos(tabla, campos, datos);
            
            
           
        }
        public void EliminarUsuario(string tabla, string condicion)
        {
            oCON.eliminarDatos(tabla, condicion);
        }
        public void ModificarUsuario(string cadena)
        {
            oCON.ModificarDatos(cadena);
        }
        
            
        
    }
}
