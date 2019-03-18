using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion.Extras
{
    public static class Conexion
    {
        public static SqlConnection conexion()
        {
            SqlConnection cn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["GUERRA"].ConnectionString);
            return cn;
        }
    }
}
