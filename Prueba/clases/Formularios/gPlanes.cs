using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionGym.Clases.Formularios
{
    internal class gPlanes
    {
        csConectaSQL ocon;
        string NombrePLan;
        string TipoPlan;
        string PrecioPlan;
        int Duracion;
        string UnidadDuracion;

        public string NOMBREPLAN
        {
            get { return  NombrePLan; }
            set { NombrePLan = value; }
        }
        public string TIPOPLAN
        {
            get { return TipoPlan; }
            set { TipoPlan = value; }
        }
        public int DURACION
        {
            get { return Duracion; }
            set {  Duracion = value; }
        }
        public string UNIDADDURACION
        {
            get { return UnidadDuracion; }
            set { UnidadDuracion = value; }
        }

        public gPlanes()
        {
            ocon = new csConectaSQL();
        }
        public void InsertarPlan(string tabla, string campos, string datos)
        {
            ocon.insertarDatos(tabla,campos,datos);
        }
        public void ModificarPlan(string cadena)
        {
            ocon.ModificarDatos(cadena);
        }
        public void EliminarPlan(string cadena, string condicion)
        {
            ocon.eliminarDatos(cadena,condicion);
        }
    }
}
