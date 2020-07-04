using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Econobuy.Controllers
{
    public class AdministradorController
    {
        public int verificaLoginAdmin(string login, string senha)
        {
            int id = 0;
            string mensagem = "";
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            SqlConnection conn = Conexao.abrirConexao();
            SqlDataReader dr;
            cmd.CommandText = "select adm_in_codigo from tb_administrador where " +
                "adm_st_user=@user COLLATE SQL_Latin1_General_CP1_CS_AS " +
                "and adm_st_senha=@password COLLATE SQL_Latin1_General_CP1_CS_AS";
            cmd.Parameters.AddWithValue("@user", login);
            cmd.Parameters.AddWithValue("@password", senha);
            try
            {
                cmd.Connection = conn;
                id = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                mensagem = "Erro: " + ex;
            }
            finally
            {
                Conexao.fechaConexao();
            }
            Console.WriteLine(mensagem);
            return id;
        }

        public string buscaNomeAdmin(int id)
        {
            string sql = "SELECT adm.adm_st_nome FROM tb_administrador adm WHERE adm_in_codigo = " + id + ";";
            SqlConnection conn = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            string name = "";
            try
            {
                reader = cmd.ExecuteReader();
                reader.Read();
                return name = reader[0].ToString();

            }
            catch (Exception ex)
            {
                return name = "Erro ao consultar usuário";
            }
            finally
            {
                Conexao.fechaConexao();
            }
        }

        public int cadastraAdmin(string nome, string user, string senha, string email, int end_id)
        {
            int id = 0;
            string sql = "INSERT INTO tb_administrador output Inserted.adm_in_codigo" +
                " VALUES ('" + nome + "','" + user + "','" + senha + "','" + email + "'," +
                end_id + ", 1, 0);";
            SqlConnection conexao = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            try
            {
                id = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                id = 0;
            }
            finally
            {
                Conexao.fechaConexao();
            }
            EnviaEmailCadastro(email, user, senha);
            return id;
        }

        public void EnviaEmailCadastro(string email, string usuario, string senha)
        {
            try
            {
                string msg = "Seja bem-vindo a Econobuy! \n\n Seguem seus dados de acesso: \n\n Usuario: " + usuario + " \n Senha: " + senha +
                    " \n\n Caso não tenha feito este cadastro apenas ignore este e-mail. \n\n Atenciosamente, \n Equipe Econobuy.";
                MailMessage mensagemEmail = new MailMessage("sistemaeconobuy@gmail.com", email, "Seja bem-vindo a Econobuy!", msg);
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("sistemaeconobuy@gmail.com", "Nmb159nmb!");
                client.Send(mensagemEmail);
            }
            finally { }
            return;
        }

        public bool cadastraPermissaoAdmin(int id, bool cad_adm, bool cad_mer, bool con_mer, bool rem_av)
        {
            bool var = false;
            int cad_mer_bit = Convert.ToInt32(cad_mer);
            int cad_adm_bit = Convert.ToInt32(cad_adm);
            int con_mer_bit = Convert.ToInt32(con_mer);
            int rem_av_bit = Convert.ToInt32(rem_av);
            string sql = "INSERT INTO tb_admin_permissoes VALUES (" + id + "," + cad_mer_bit + "," + cad_adm_bit + ","
                + con_mer_bit + "," + rem_av_bit + ");";
            SqlConnection conexao = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    var = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Conexao.fechaConexao();
            }
            return var;
        }

        public int[] verificaPermissoes(int id)
        {
            int[] permissions = new int[4];
            string sql = "SELECT [adm_cad_bit_mer], [adm_cad_bit_amd], [adm_consul_bit_mer]," +
                "[adm_rem_bit_av] FROM tb_admin_permissoes WHERE adm_in_codigo = " + id + ";";
            SqlConnection conn = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                reader.Read();
                for (int i = 0; i < 4; i++)
                {
                    permissions[i] = Convert.ToInt32(reader[i]);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Conexao.fechaConexao();
            }
            return permissions;
        }

        public bool verificaUsuarioDisponivel(string username)
        {
            bool var = false;
            string mensagem = "";
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            SqlConnection conn = Conexao.abrirConexao();
            SqlDataReader dr;
            cmd.CommandText = "select * from tb_administrador where adm_st_user=@user";
            cmd.Parameters.AddWithValue("@user", username);
            try
            {
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    var = true;
                }
            }
            catch (Exception ex)
            {
                var = false;
            }
            finally
            {
                Conexao.fechaConexao();
            }
            Console.WriteLine(mensagem);
            return var;
        }

        public DataTable buscaPedidosRemocaoMercado()
        {
            DataTable dt = new DataTable();
            string sql = "select rem.ped_rem_av_mer_in_codigo codigo, mer.mer_st_nome Mercado, " +
                "cli.cli_st_nome Cliente, av.ped_av_cli_dec_nota Nota, rem.ped_status Situação  " +
                "from tb_pedido_remocao_avaliacao_mercado rem, tb_mercado mer, " +
                "tb_pedido_avaliacao_cliente av, tb_cliente cli, tb_pedido ped " +
                "where rem.ped_av_cli_in_codigo = av.ped_av_cli_in_codigo and av.ped_in_codigo = ped.ped_in_codigo " +
                "and ped.mer_in_codigo = mer.mer_in_codigo and ped.cli_in_codigo = cli.cli_in_codigo and rem.ped_status = 'Em análise'";
            SqlConnection conexao = Conexao.abrirConexao();
            SqlDataAdapter da = new SqlDataAdapter(sql, conexao);
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex) { }
            finally { Conexao.fechaConexao(); }
            return dt;
        }

        public DataTable buscaPedidosRemocaoCliente()
        {
            DataTable dt = new DataTable();
            string sql = "select rem.ped_rem_av_cli_in_codigo codigo, cli.cli_st_nome Cliente, mer.mer_st_nome Mercado," +
                " av.ped_av_mer_dec_nota Nota, rem.ped_status Situação " +
                "from tb_pedido_remocao_avaliacao_cliente rem, tb_mercado mer, " +
                "tb_pedido_avaliacao_mercado av, tb_cliente cli, tb_pedido ped " +
                "where rem.ped_av_mer_in_codigo = av.ped_av_mer_in_codigo and av.ped_in_codigo = ped.ped_in_codigo " +
                "and ped.mer_in_codigo = mer.mer_in_codigo and ped.cli_in_codigo = cli.cli_in_codigo and rem.ped_status = 'Em análise'";
            SqlConnection conexao = Conexao.abrirConexao();
            SqlDataAdapter da = new SqlDataAdapter(sql, conexao);
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex) { }
            finally { Conexao.fechaConexao(); }
            return dt;
        }

        public DataTable preenchePedidoRemocaoCliente(int ped_id)
        {
            DataTable dt = new DataTable();
            string sql = "select rem.ped_rem_av_cli_st_msg_cli Msg_user, av.ped_av_mer_dec_nota Nota, " +
                "av.ped_av_mer_st_descricao av_desc, cli.cli_st_nome requerente, mer.mer_st_nome avaliador" +
                " from tb_pedido_remocao_avaliacao_cliente rem, tb_pedido_avaliacao_mercado av, " +
                "tb_pedido ped, tb_mercado mer, tb_cliente cli where " +
                "rem.ped_av_mer_in_codigo = av.ped_av_mer_in_codigo and " +
                "av.ped_in_codigo = ped.ped_in_codigo and mer.mer_in_codigo = ped.mer_in_codigo " +
                "and ped.cli_in_codigo = cli.cli_in_codigo and rem.ped_rem_av_cli_in_codigo = " + ped_id;
            SqlConnection conexao = Conexao.abrirConexao();
            SqlDataAdapter da = new SqlDataAdapter(sql, conexao);
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex) { }
            finally { Conexao.fechaConexao(); }
            return dt;
        }

        public DataTable preenchePedidoRemocaoMercado(int ped_id)
        {
            DataTable dt = new DataTable();
            string sql = "select rem.ped_rem_av_mer_st_msg_mer Msg_user, av.ped_av_cli_dec_nota Nota, " +
                "av.ped_av_cli_st_descricao av_desc, mer.mer_st_nome requerente, mer.mer_st_nome avaliador " +
                "from tb_pedido_remocao_avaliacao_mercado rem, tb_pedido_avaliacao_cliente av, " +
                "tb_pedido ped, tb_mercado mer, tb_cliente cli where " +
                "rem.ped_av_cli_in_codigo = av.ped_av_cli_in_codigo and " +
                "av.ped_in_codigo = ped.ped_in_codigo and mer.mer_in_codigo = ped.mer_in_codigo " +
                "and ped.cli_in_codigo = cli.cli_in_codigo and rem.ped_rem_av_mer_in_codigo = " + ped_id;
            SqlConnection conexao = Conexao.abrirConexao();
            SqlDataAdapter da = new SqlDataAdapter(sql, conexao);
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex) { }
            finally { Conexao.fechaConexao(); }
            return dt;
        }

        public bool aprovaPedidoRemocaoCliente(int ped_id, string msg)
        {
            bool var = false;
            string sql = "update tb_pedido_remocao_avaliacao_cliente set ped_rem_av_cli_st_msg_adm = '" + msg + "', " +
                "ped_status = 'Aprovado' where ped_rem_av_cli_in_codigo = " + ped_id;
            SqlConnection conexao = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0) var = true;
            }
            catch (Exception ex) { }
            finally
            {
                Conexao.fechaConexao();
            }
            return var;
        }

        public bool reprovaPedidoRemocaoCliente(int ped_id, string msg)
        {
            bool var = false;
            string sql = "update tb_pedido_remocao_avaliacao_cliente set ped_rem_av_cli_st_msg_adm = '" + msg + "', " +
                "ped_status = 'Reprovado' where ped_rem_av_cli_in_codigo = " + ped_id;
            SqlConnection conexao = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0) var = true;
            }
            catch (Exception ex) { }
            finally
            {
                Conexao.fechaConexao();
            }
            return var;
        }

        public bool aprovaPedidoRemocaoMercado(int ped_id, string msg)
        {
            bool var = false;
            string sql = "update tb_pedido_remocao_avaliacao_mercado set ped_rem_av_mer_st_msg_adm = '" + msg + "', " +
                "ped_status = 'Aprovado' where ped_rem_av_mer_in_codigo = " + ped_id;
            SqlConnection conexao = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0) var = true;
            }
            catch (Exception ex) { }
            finally
            {
                Conexao.fechaConexao();
            }
            return var;
        }

        public bool reprovaPedidoRemocaoMercado(int ped_id, string msg)
        {
            bool var = false;
            string sql = "update tb_pedido_remocao_avaliacao_mercado set ped_rem_av_mer_st_msg_adm = '" + msg + "', " +
                "ped_status = 'Reprovado' where ped_rem_av_mer_in_codigo = " + ped_id;
            SqlConnection conexao = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0) var = true;
            }
            catch (Exception ex) { }
            finally
            {
                Conexao.fechaConexao();
            }
            return var;
        }

        public int buscaIDAvaliacaoPedidoCliente(int ped_id)
        {
            int AvCliId = 0;
            string sql = "select av.ped_av_mer_in_codigo from tb_pedido_avaliacao_mercado av, " +
                "tb_pedido_remocao_avaliacao_cliente rem where av.ped_av_mer_in_codigo = " +
                "rem.ped_av_mer_in_codigo and rem.ped_rem_av_cli_in_codigo = " + ped_id;
            SqlConnection conn = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                reader.Read();
                AvCliId = Convert.ToInt32(reader[0]);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Conexao.fechaConexao();
            }
            return AvCliId;
        }

        public int buscaIDPedidoAvaliacaoMercado(int ped_id)
        {
            int AvCliId = 0;
            string sql = "select av.ped_av_cli_in_codigo from tb_pedido_avaliacao_cliente av, " +
                "tb_pedido_remocao_avaliacao_mercado rem where av.ped_av_cli_in_codigo = " +
                "rem.ped_av_cli_in_codigo and rem.ped_rem_av_mer_in_codigo = " + ped_id;
            SqlConnection conn = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                reader.Read();
                AvCliId = Convert.ToInt32(reader[0]);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Conexao.fechaConexao();
            }
            return AvCliId;
        }

        public int buscaIDAvaliacaoCliente(int ped_id)
        {
            int AvCliId = 0;
            string sql = "select pedav.av_cli_in_codigo from tb_pedido_avaliacao_mercado pedav " +
                "where pedav.ped_av_mer_in_codigo = " + ped_id;
            SqlConnection conn = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                reader.Read();
                AvCliId = Convert.ToInt32(reader[0]);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Conexao.fechaConexao();
            }
            return AvCliId;
        }

        public int buscaIDAvaliacaoMercado(int ped_id)
        {
            int AvCliId = 0;
            string sql = "select pedav.av_mer_in_codigo from tb_pedido_avaliacao_cliente pedav " +
                "where pedav.ped_av_cli_in_codigo = " + ped_id;
            SqlConnection conn = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                reader.Read();
                AvCliId = Convert.ToInt32(reader[0]);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Conexao.fechaConexao();
            }
            return AvCliId;
        }

        public bool atualizaPedidoAprovadoCliente(int pedavcli_id)
        {
            bool var = false;
            string sql = "update tb_pedido_avaliacao_mercado set ped_bit_active = 0 where ped_av_cli_in_codigo = " + pedavcli_id;
            SqlConnection conexao = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    var = true;
                }
            }
            catch (Exception ex) { }
            finally
            {
                Conexao.fechaConexao();
            }
            return var;
        }

        public bool atualizaPedidoAprovadoMercado(int pedavmer_id)
        {
            bool var = false;
            string sql = "update tb_pedido_avaliacao_cliente set ped_bit_active = 0 where ped_av_mer_in_codigo = " + pedavmer_id;
            SqlConnection conexao = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    var = true;
                }
            }
            catch (Exception ex) { }
            finally
            {
                Conexao.fechaConexao();
            }
            return var;
        }

        public bool verificaEmailAdmin(string email)
        {
            bool var = false;
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            SqlConnection conn = Conexao.abrirConexao();
            SqlDataReader dr;
            cmd.CommandText = "select * from tb_administrador adm where adm.adm_st_email = @email";
            cmd.Parameters.AddWithValue("@email", email);
            try
            {
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    var = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Conexao.fechaConexao();
            }
            return var;
        }

        public int verificaEmail(string email)
        {
            int id = 0;
            string sql = "select adm_in_codigo from tb_administrador where adm_st_email = @email";
            SqlConnection conn = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@email", email);
            try
            {
                id = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                id = 0;
            }
            finally
            {
                Conexao.fechaConexao();
            }
            return id;
        }

        public string buscaUsuarioAdministrador(int id)
        {
            string sql = "SELECT adm.adm_st_user FROM tb_administrador adm WHERE adm_in_codigo = '" + id + "';";
            SqlConnection conn = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            string usuario = "";
            try
            {
                reader = cmd.ExecuteReader();
                reader.Read();
                return usuario = reader[0].ToString();

            }
            catch (Exception ex)
            {
                return usuario = "Erro ao consultar usuário";
            }
            finally
            {
                Conexao.fechaConexao();
            }
        }
        public string randomizarSenha(int id)
        {
            string sql = "update tb_administrador set adm_st_senha = @senha where adm_in_codigo = " + id;
            SqlConnection conn = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            Random rnd = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string senha = new string(Enumerable.Repeat(chars, 10)
              .Select(s => s[rnd.Next(s.Length)]).ToArray());
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.ExecuteNonQuery();
                return senha;
            }
            catch (Exception ex)
            {
                return senha = "";
            }
            finally
            {
                Conexao.fechaConexao();
            }
        }

        public void EnviaMensagemEmail(string email, string usuario, string senha)
        {
            try
            {
                string msg = "Seguem os dados de acesso solicitados: \n\n Usuario: " + usuario + " \n Senha: " + senha +
                    " \n\n Caso não tenha feito esta solicitação entre em contato conosco respondendo este e-mail. \n\n Atenciosamente, \n Equipe Econobuy.";
                MailMessage mensagemEmail = new MailMessage("sistemaeconobuy@gmail.com", email, "Recuperação de Senha - Econobuy", msg);
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("sistemaeconobuy@gmail.com", "Nmb159nmb!");
                client.Send(mensagemEmail);
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                Conexao.fechaConexao();
            }
            return;
        }
    }
}