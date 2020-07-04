using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econobuy.Controllers
{
    public class EnderecoController
    {
        public int cadastraEndereco(string cep, string log, string num, string bairro, string cidade, string uf,
            string tel1, string tel2)
        {
            int end_id = 0;
            string sql = "INSERT INTO tb_endereco output Inserted.end_in_codigo" +
                " VALUES ('" + cep + "','" + log + "','" + num + "',null,'"
                + bairro + "','" + cidade + "','" + uf + "','" + tel1 + "','" + tel2 + "');";
            SqlConnection conexao = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            try
            {
                end_id = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                end_id = 0;
            }
            finally
            {
                Conexao.fechaConexao();
            }
            return end_id;
        }
        
    }
}
