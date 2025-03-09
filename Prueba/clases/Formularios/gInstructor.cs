using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionGym.Clases.Formularios
{
    internal class gInstructor
    {
        csConectaSQL Ocon;
        string Nombre;
        string Apellido;
        string Especialidad;
        string telefono;
        string email;
        string Contratacion;

        public string NOMBRE
        {
            get { return Nombre; }
            set { Nombre = value; }

        }
        public string APELIIDO
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        public string ESPECIALIDAD
        {
            get { return Especialidad; }
            set { Especialidad = value; }
        }
        public string TELEFONO
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }
        public string CONTRATACION
        {
            get { return Contratacion; }
            set { Contratacion = value; }
        }
        public gInstructor()
        {
            Ocon = new csConectaSQL();
        }
            
        
        public void InsertarInstructor(string tabla,string campos,string datos)
        {
            Ocon.insertarDatos(tabla, campos, datos);
        }
        public void EliminarInstructor(string tabla, string condicion)
        {
            Ocon.eliminarDatos(tabla, condicion);
        }
        public void ModificarInstructor(string cadena)
        {
            Ocon.ModificarDatos(cadena);
        }
        

    }
}
