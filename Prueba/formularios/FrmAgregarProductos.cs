using AplicacionGym.Clases.Formularios;
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

    public partial class AgregarProductos: Form
    {
        csConectaSQL conSQL = new csConectaSQL();
        gProductos gProductos;
        string cadena;
        public int tp;
        public AgregarProductos()
        {
            InitializeComponent();
        }
        private void PtbCerrarFormularioAgregarProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registroDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ButtonGuardarAgregarProducto_Click(object sender, EventArgs e)
        {
            VerProductos Verproductos = Owner as VerProductos;
            gProductos = new gProductos();
            cadena = "'" + TxtCodigoProducto.Text + "','" + TxtNombreProducto.Text + "','" + TxtCantidadProducto.Text + "','" + TxtDescripcionProducto.Text + "','" + TxtprecioCompraProducto.Text + "','" + TxtPrecioVentaProducto.Text + "'";
            if (tp == 0)
            {
                gProductos.insertarProductos("Productos ", "Codigo,Nombre,Cantidad,Descripcion,PrecioCompra,PrecioVenta", cadena);
            }
            else
            {
                string query = $"UPDATE Productos SET " +
     $"Nombre = '{TxtNombreProducto.Text}', " +
     $"Cantidad = {TxtCantidadProducto.Text}, " +
     $"Descripcion = '{TxtDescripcionProducto.Text}', " +
     $"PrecioCompra = {TxtprecioCompraProducto.Text.Replace(',', '.')}, " +
     $"PrecioVenta = {TxtPrecioVentaProducto.Text.Replace(',', '.')} " +
     $"WHERE Codigo = '{TxtCodigoProducto.Text}'";

                gProductos.ModificarProductos(query);
            }
            Verproductos.DGVverProductos.DataSource = conSQL.retornaRegistros("Select*from Productos");
            this.Close();
        }

    }
}
