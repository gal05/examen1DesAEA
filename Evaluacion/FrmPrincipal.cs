using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void lISTADEPRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaRapida listaRapida = new FrmListaRapida();
            listaRapida.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void lISTADECLIENTESPORPAISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientesPorPais porPais = new FrmClientesPorPais();
            porPais.Show();
        }
    }
}
