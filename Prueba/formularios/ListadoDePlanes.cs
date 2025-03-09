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
    public partial class ListadoDePlanes : Form

    {
        gPlanes gPlan;
        csConectaSQL conectar = new csConectaSQL();
        public ListadoDePlanes()
        {
            InitializeComponent();
        }

        private void BtnAgregarPlanActividades_Click(object sender, EventArgs e)
        {
            int tp = 0;
            FrmNuevoPlan planNuevo = new FrmNuevoPlan();
            this.AddOwnedForm(planNuevo);
            planNuevo.tp = tp;
            planNuevo.ShowInTaskbar = false;
            planNuevo.ShowDialog();
            

        }

        private void ListadoDePlanes_Load(object sender, EventArgs e)
        {
            DGVActividades.DataSource = conectar.retornaRegistros("select*from PlanesEntrenamiento");
        }

        private void DGVActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbEliminarPlanActividades_Click(object sender, EventArgs e)
        {
            gPlan = new gPlanes();

            if (DGVActividades.RowCount > 0)//Validar que tengo alguna fila seleccionada
            {
                DialogResult opc = MessageBox.Show(this, "Se eliminará la fila " + DGVActividades.CurrentRow.Index + ", que pertenece a " + DGVActividades[0, DGVActividades.CurrentRow.Index].Value.ToString(), "Confirmación de Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opc == DialogResult.Yes)
                {
                    gPlan.EliminarPlan("PlanesEntrenamiento", "PlanID='" + DGVActividades[0, DGVActividades.CurrentRow.Index].Value.ToString() + "'");
                    DGVActividades.DataSource = conectar.retornaRegistros("Select * from Productos");
                }
            }
        }

        private void PtbCerrarFormularioNuevoPlan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbModificarPlanActividades_Click(object sender, EventArgs e)
        {
            int tp = 1;
            FrmNuevoPlan ModificarPlan = new FrmNuevoPlan();
            this.AddOwnedForm(ModificarPlan);
            ModificarPlan.FormularioVerNuevoPlan.Text = "MODIFICAR PLAN";
            ModificarPlan.TxtNombrePlan.Text = DGVActividades[1, DGVActividades.CurrentRow.Index].Value.ToString();
            ModificarPlan.TxtTipoPlan.Text = DGVActividades[2, DGVActividades.CurrentRow.Index].Value.ToString();
            ModificarPlan.TxtPrecioPlan.Text = DGVActividades[3, DGVActividades.CurrentRow.Index].Value.ToString();
            ModificarPlan.TxtDuracionPlan.Text = DGVActividades[4, DGVActividades.CurrentRow.Index].Value.ToString();
            ModificarPlan.cbmDuracionPlan.Text = DGVActividades[5, DGVActividades.CurrentRow.Index].Value.ToString();
            ModificarPlan.lblIdd.Text= DGVActividades[0, DGVActividades.CurrentRow.Index].Value.ToString();
            ModificarPlan.tp = tp;
            ModificarPlan.ShowInTaskbar = false;
            ModificarPlan.ShowDialog();
        }

        private void tsbFiltroPlan_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtFiltroPlan.Text.Length > 0)
                {
                    DGVActividades.DataSource = conectar.retornaRegistros("Select * from PlanesEntrenamiento where NombrePlan like '%" + TxtFiltroPlan.Text + "%'");  

                }
                else
                {
                    DGVActividades.DataSource = conectar.retornaRegistros("Select * from PlanesEntrenamiento");
                }            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}

