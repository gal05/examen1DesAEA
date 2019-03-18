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
    public partial class FrmIngreso : Form
    {
        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            ListaAnios();//:v
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
        }




        //GEGE
        public void ListaAnios()
        {
            using (SqlCommand cmd = new SqlCommand("Usp_listaAnios", Conexion.conexion()))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.SelectCommand = cmd;
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    using (DataSet ds = new DataSet())
                    {
                        adapter.Fill(ds, "ListaAnios");
                        cbxAnio.DataSource = ds.Tables["ListaAnios"];
                        cbxAnio.DisplayMember = "anios";
                        cbxAnio.ValueMember = "anios";
                    }
                }
            }
        }
        //GEGE :D
    }
}
