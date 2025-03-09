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
    public partial class FrmSocioConDeuda : Form
    {
        public FrmSocioConDeuda()
        {
            InitializeComponent();
        }

        private void VerEstadisticas_Click(object sender, EventArgs e)
        {

        }

        private void PtbCerrarFormularioEstadisticas_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
