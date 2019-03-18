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
            //ListaAnios();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario= textBox1.Text;
            string contrasenia = textBox2.Text;
            string time = DateTime.Now.ToString();

            if (VerificacionUsuario(usuario, contrasenia) == true)
            {
                MessageBox.Show(usuario + "\n" + contrasenia + "\n" + time);
            }
            else
            {
                MessageBox.Show("Error de validacion");
            }

            
        }

        public Boolean VerificacionUsuario(String  nombre ,String pass)
        {
            SqlCommand sqlcommand = new SqlCommand("CheckPassword");
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.Connection = Conexion.conexion();
            sqlcommand.Connection.Open();
            sqlcommand.Parameters.AddWithValue("@username", nombre);
            sqlcommand.Parameters.AddWithValue("@password", pass);
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            if (sqlDataReader.HasRows == true)
            {
                return true;
            }
            else{ return false; }

        }

        /* GEGE  funciona!! hay conexion
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
        }*/
    }
}
