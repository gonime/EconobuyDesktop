using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econobuy.Controllers
{
    class Conexao
    {
        private static string conexao = @"Data Source=DESKTOP-1FBTC95;Initial Catalog=Econobuy;Integrated Security=True";
        private static SqlConnection conn = null;
        public static SqlConnection abrirConexao()
        {
            conn = new SqlConnection(conexao);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                conn = null;
            }
            return conn;
        }
        public static void fechaConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
