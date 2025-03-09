using AplicacionGym.Clases.Formularios;
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

    public partial class FrmNuevoInstructor : Form
    {
        csConectaSQL conSQL = new csConectaSQL();
        gInstructor gInstructor;
        string cadena;
        public FrmNuevoInstructor()
        {
            InitializeComponent();
        }

        private void PtbCerrarFormularioEstadisticas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void button1_Click(object sender, EventArgs e)
        {
            gInstructor = new gInstructor();
            string query= $"update Instructores set Nombre='{TxtBoxNombreInstructor.Text}',Apellido='{TxtBoxApellidoInstructor.Text}',Especialidad='{TxtBoxEspecialidadInstructor.Text}',Telefono='{TxtBoxTelefonoInstructor.Text}',Email='{TxtBoxEmailInstructor.Text}',FechaContratacion='{DTFechaContratacion.Text}' where InstructorID ={LBLid.Text} ";
            gInstructor.ModificarInstructor(query);
            DGVinstructor.DataSource = conSQL.retornaRegistros("Select * from Instructores ");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gInstructor = new gInstructor();
            if (DGVinstructor.RowCount > 0)//Validar que tengo alguna fila seleccionada
            {
                DialogResult opc = MessageBox.Show(this, "Se eliminará la fila " + DGVinstructor.CurrentRow.Index + ", que pertenece al cliente " + DGVinstructor[0, DGVinstructor.CurrentRow.Index].Value.ToString(), "Confirmación de Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opc == DialogResult.Yes)
                {
                    gInstructor.EliminarInstructor("Instructores", "InstructorID='" + DGVinstructor[0, DGVinstructor.CurrentRow.Index].Value.ToString() + "'");
                    DGVinstructor.DataSource = conSQL.retornaRegistros("Select * from Instructores ");
                }
            }
        }

        private void ButtonGuardarAgregarInstructor_Click(object sender, EventArgs e)
        {
            gInstructor = new gInstructor();
            cadena =
                "'" + TxtBoxNombreInstructor.Text +
                "','" + TxtBoxApellidoInstructor.Text + 
                "','" + TxtBoxEspecialidadInstructor.Text +
                "','" + TxtBoxTelefonoInstructor.Text + 
                "','" + TxtBoxEmailInstructor.Text + 
                "','" + DTFechaContratacion.Text + 
                "'";
            gInstructor.InsertarInstructor("Instructores", "Nombre, Apellido, Especialidad, Telefono, Email,FechaContratacion", cadena);
            DGVinstructor.DataSource = conSQL.retornaRegistros("Select * from Instructores");
        }   
        private void FrmNuevoInstructor_Load(object sender, EventArgs e)
        {
            DGVinstructor.DataSource = conSQL.retornaRegistros("Select * from Instructores");
        }

        private void DGVinstructor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
           if (e.RowIndex >= 0) // Verifica que se hizo clic en una fila válida
            {
                TxtBoxNombreInstructor.Text = DGVinstructor.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                TxtBoxApellidoInstructor.Text = DGVinstructor.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                TxtBoxEspecialidadInstructor.Text = DGVinstructor.Rows[e.RowIndex].Cells["Especialidad"].Value.ToString();
                TxtBoxTelefonoInstructor.Text = DGVinstructor.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                TxtBoxEmailInstructor.Text = DGVinstructor.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                DTFechaContratacion.Value = Convert.ToDateTime(DGVinstructor.Rows[e.RowIndex].Cells["FechaContratacion"].Value);
                LBLid.Text = DGVinstructor.Rows[e.RowIndex].Cells["InstructorID"].Value.ToString();

                // Guardar el ID del instructor en una variable oculta (Tag)
                this.Tag = DGVinstructor.Rows[e.RowIndex].Cells["InstructorID"].Value.ToString();
            }
        }

    }
}

