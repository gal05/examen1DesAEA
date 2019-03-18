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
    public partial class FrmListaRapida : Form
    {
        public FrmListaRapida()
        {
            InitializeComponent();
        }

        private void FrmListaRapida_Load(object sender, EventArgs e)
        {
            ListaEmpleados();
            ListaCliente();
        }






        public void ListaEmpleados()
        {
            using (SqlCommand cmd = new SqlCommand("examen1_lista_empleados", Conexion.conexion()))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.SelectCommand = cmd;
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    using (DataSet ds = new DataSet())
                    {
                        adapter.Fill(ds, "ListaAnios");
                        cboEmpleado.DataSource = ds.Tables["ListaAnios"];
                        cboEmpleado.DisplayMember = "NomEmpleado";
                        cboEmpleado.ValueMember = "NomEmpleado";
                    }
                }
            }
        }

        public void ListaCliente()
        {
            using (SqlCommand cmd = new SqlCommand("examen1_guerra_lista_clientes", Conexion.conexion()))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.SelectCommand = cmd;
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    using (DataSet ds = new DataSet())
                    {
                        adapter.Fill(ds, "ListaAnios");
                        cboCliente.DataSource = ds.Tables["ListaAnios"];
                        cboCliente.DisplayMember = "nombre";
                        cboCliente.ValueMember = "nombre";
                    }
                }
            }
        }

        private void chkTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodo.Checked)
            {
                using (SqlCommand sqlCommand = new SqlCommand("examen1_guerra_pedidos_todos", Conexion.conexion()))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = sqlCommand;
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        using (DataSet dataset = new DataSet())
                        {
                            adapter.Fill(dataset, "Pedidos");
                            dgdPedido.DataSource = dataset.Tables["Pedidos"];
                            dgdPedido.Text = dataset.Tables["Pedidos"].Rows.Count.ToString();
                        }
                    }
                }
            }else if (!chkTodo.Checked)
            {
                dgdPedido.DataSource = null;
            }
        }

        private void cboEmpleado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (SqlCommand sqlCommand = new SqlCommand("examen1_guerra_pedidos_x_empleado", Conexion.conexion()))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.SelectCommand = sqlCommand;
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.AddWithValue("@nombreEmpl", cboEmpleado.SelectedValue);
                    adapter.SelectCommand.Parameters.AddWithValue("@fechaIn", dtpFecha1.Value.ToString("yyyy"));
                    adapter.SelectCommand.Parameters.AddWithValue("@fechaFin", dtpFecha2.Value.ToString("yyyy"));
                    using (DataSet dataset = new DataSet())
                    {
                        adapter.Fill(dataset, "Pedidos");
                        dgdPedido.DataSource = dataset.Tables["Pedidos"];
                        dgdPedido.Text = dataset.Tables["Pedidos"].Rows.Count.ToString();
                    }
                }
            }


        }

        private void cboCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (SqlCommand sqlCommand = new SqlCommand("examen1_guerra_pedidos_x_cliente", Conexion.conexion()))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.SelectCommand = sqlCommand;
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.AddWithValue("@nombreCli", cboCliente.SelectedValue);
                    adapter.SelectCommand.Parameters.AddWithValue("@fechaIn", dtpFecha1.Value.ToString("yyyy"));
                    adapter.SelectCommand.Parameters.AddWithValue("@fechaFin", dtpFecha2.Value.ToString("yyyy"));
                    using (DataSet dataset = new DataSet())
                    {
                        adapter.Fill(dataset, "Pedidos");
                        dgdPedido.DataSource = dataset.Tables["Pedidos"];
                        dgdPedido.Text = dataset.Tables["Pedidos"].Rows.Count.ToString();
                    }
                }
            }

        }
    }

}
