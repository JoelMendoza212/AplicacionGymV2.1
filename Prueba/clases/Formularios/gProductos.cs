using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionGym.Clases.Formularios
{
    public class gProductos
    {
        csConectaSQL oCon;
        string Nombre;
        int Cantidad;
        string Descripcion;
        decimal PrecioCompra;
        decimal PrecioVenta;

        public string NOMBRE
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public int CANTIDAD
        {
            get { return Cantidad; }
            set { Cantidad = value; }
        }
        public string DESCRIPCION
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
        public decimal PRECIOCOMPRA
        {
            get { return PrecioCompra; }
            set { PrecioCompra = value; }
        }
        public decimal PRECIOVENTA
        {
            get { return PrecioVenta; }
            set { PrecioVenta = value; }
        }
        public gProductos()
        {
            oCon = new csConectaSQL();
        }

        public void insertarProductos(string Tabla,string Campos,string datos)
        {
            oCon.insertarDatos(Tabla,Campos,datos);
        }
        public void ModificarProductos(string cadena)
        {
            oCon.ModificarDatos(cadena);
        }
        public void EliminarProductos(string tabla,string condicion)
        {
            oCon.eliminarDatos(tabla, condicion);

        }



    }
}
