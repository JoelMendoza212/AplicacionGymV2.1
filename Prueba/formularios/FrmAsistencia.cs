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
    public partial class FrmAsistencia : Form
    {
        csConectaSQL conectaSQL = new csConectaSQL();
        public FrmAsistencia()
        {
            InitializeComponent();
        }

        private void PtbCerrarFormularioPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAsistencia_Load(object sender, EventArgs e)
        {
            DGVAsistenciaUsuarios.DataSource = conectaSQL.retornaRegistros("select * from Asistencia");
        }
    }
}
