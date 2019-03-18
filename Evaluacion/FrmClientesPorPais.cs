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
    public partial class FrmClientesPorPais : Form
    {
        public FrmClientesPorPais()
        {
            InitializeComponent();
        }

        private void FrmClientesPorPais_Load(object sender, EventArgs e)
        {

            ListaPaises();
        }


        public void ListaPaises()
        {
            using (SqlCommand cmd = new SqlCommand("examen1_guerra_lista_paises", Conexion.conexion()))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.SelectCommand = cmd;
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    using (DataSet ds = new DataSet())
                    {
                        adapter.Fill(ds, "ListaPaises");
                        cbxAnio.DataSource = ds.Tables["ListaPaises"];
                        cbxAnio.DisplayMember = "NombrePais";
                        cbxAnio.ValueMember = "NombrePais";
                    }
                }
            }
        }

        private void cbxAnio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (SqlCommand sqlCommand = new SqlCommand("examen1_guerra_lista_clientes_pais", Conexion.conexion()))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.SelectCommand = sqlCommand;
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.AddWithValue("@pais", cbxAnio.SelectedValue);
                    using (DataSet dataset = new DataSet())
                    {
                        adapter.Fill(dataset, "Pedidos");
                        dataGridView1.DataSource = dataset.Tables["Pedidos"];
                        //txtPedidos.Text = dataset.Tables["Pedidos"].Rows.Count.ToString();
                    }
                }
            }
        }

        private void cbxAnio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            String idCliente;
            idCliente = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            using (SqlCommand sqlcomand = new SqlCommand("examen1_guerra_detalles_cliente", Conexion.conexion()))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.SelectCommand = sqlcomand;
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.AddWithValue("@idCliente", idCliente);
                    using (DataSet dataset = new DataSet())
                    {
                        adapter.Fill(dataset, "Detalles");
                        dataGridView2.DataSource = dataset.Tables["Detalles"];
                        txbNPedidos.Text = dataset.Tables[0].Rows.Count.ToString();
                    }
                }
            }
        }
    }
}
