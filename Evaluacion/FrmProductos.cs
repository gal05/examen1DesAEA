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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            using (SqlCommand sqlCommand = new SqlCommand("examen1_guerra_busqueda_producto", Conexion.conexion()))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.SelectCommand = sqlCommand;
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.AddWithValue("@producName", txtProducto.Text);
                    using (DataSet dataset = new DataSet())
                    {
                        adapter.Fill(dataset, "Pedidos");
                        dgvProductos.DataSource = dataset.Tables["Pedidos"];
                        //dgvProductos.Text = dataset.Tables["Pedidos"].Rows.Count.ToString();
                    }
                }
            }
        }
    }
}
