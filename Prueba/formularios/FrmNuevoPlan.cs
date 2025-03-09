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
    public partial class FrmNuevoPlan : Form
    {
        public int tp;
        csConectaSQL conSQL;
        gPlanes gPlan;
        string cadena;
        public FrmNuevoPlan()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void PtbCerrarFormularioEstadisticas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonGuardarNuevoPlan_Click(object sender, EventArgs e)
        {
            gPlan = new gPlanes();
            conSQL = new csConectaSQL();
            ListadoDePlanes Planess = Owner as ListadoDePlanes;
            
                try
                {
                    // Construir la cadena de valores para insertarDatos
                    string valores = "'" + TxtNombrePlan.Text + "', '" + TxtTipoPlan.Text + "', '" + TxtPrecioPlan.Text + "', '" + TxtDuracionPlan.Text + "', '" + cbmDuracionPlan.Text + "'";

                    // Llamar al método insertarDatos
                    if (tp == 0)
                    {
                        gPlan.InsertarPlan("PlanesEntrenamiento", "NombrePlan, TipoPlan, PrecioPlan, Duracion, UnidadDuracion", valores);
                    }
                    else
                    {
                        string query = $"update PlanesEntrenamiento set NombrePlan='{TxtNombrePlan.Text}',TipoPlan='{TxtTipoPlan.Text}',PrecioPlan= '{TxtPrecioPlan.Text}',Duracion= '{TxtDuracionPlan.Text}', UnidadDuracion='{cbmDuracionPlan.Text}' where PlanID={lblIdd.Text}";
                        gPlan.ModificarPlan(query);
                    }
                    Planess.DGVActividades.DataSource = conSQL.retornaRegistros("SELECT * FROM PlanesEntrenamiento");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el plan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
