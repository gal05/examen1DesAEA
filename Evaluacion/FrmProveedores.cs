using Evaluacion.Extras;
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


namespace Evaluacion
{
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {

        }

        public void ListaProveedores()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("examen1_guerra_proveedores", Conexion.conexion());
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
           // adapter.Fill(lvwProveedor);
        }
    }
}
