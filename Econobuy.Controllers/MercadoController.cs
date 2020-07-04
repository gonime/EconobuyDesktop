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
    public class MercadoController
    {
        public int verificaLoginMercado(string login, string senha)
        {
            int id = 0;
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = Conexao.abrirConexao();
            cmd.CommandText = "select mer_in_codigo from tb_mercado where " +
                "mer_st_user = @user COLLATE SQL_Latin1_General_CP1_CS_AS " +
                "and mer_st_senha = @password COLLATE SQL_Latin1_General_CP1_CS_AS and mer_bit_active = 1";
            cmd.Parameters.AddWithValue("@user", login);
            cmd.Parameters.AddWithValue("@password", senha);
            try
            {
                cmd.Connection = conn;
                id = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Conexao.fechaConexao();
            }
            return id;
        }

        public string buscaNomeMercado(int id)
        {
            string sql = "SELECT mer.mer_st_nome FROM tb_mercado mer WHERE mer_in_codigo = '" + id + "';";
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

        public int cadastraMercado(string nome, string user, string senha, string CPNJ, string email, int end_id)
        {
            int mer_id = 0;
            string sql = "INSERT INTO tb_mercado output Inserted.mer_in_codigo " +
                "VALUES ('" + nome + "','" + user + "','" + senha + "','" + CPNJ + "','"
                + email + "'," + end_id + ",1, 0, 0);";
            SqlConnection conexao = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            try
            {
                mer_id = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                mer_id = 0;
            }
            finally
            {
                Conexao.fechaConexao();
            }
            EnviaEmailCadastro(email, user, senha);
            return mer_id;
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

        public void criaAvaliacaoMercado(int id)
        {
            string sql = "INSERT INTO [dbo].[tb_avaliacao_mercado] ([av_mer_dec_nota]," +
                "[mer_in_codigo]) VALUES (0.0," + id + ");";
            SqlConnection conexao = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.ExecuteNonQuery();
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

        public bool verificaSeNomeDeUsuarioDisponivel(string username)
        {
            bool var = false;
            string mensagem = "";
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            SqlConnection conn = Conexao.abrirConexao();
            SqlDataReader dr;
            cmd.CommandText = "select * from tb_mercado where mer_st_user=@user";
            cmd.Parameters.AddWithValue("@user", username);
            try
            {
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    var = true;
                    mensagem = "Usuário Indisponível";
                }
                else
                {
                    mensagem = "Usuário Disponível";
                }
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
            return var;
        }

        public int contaPedidosEmAguardo(int id)
        {
            string sql = "select count(ped_in_codigo) from tb_pedido where mer_in_codigo = '" + id + "' and ped_status = 'Aguardando';";
            SqlConnection conn = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            int count = 0;
            try
            {
                reader = cmd.ExecuteReader();
                reader.Read();
                return count = Convert.ToInt32(reader[0]);

            }
            catch (Exception ex)
            {
                return count = 0;
            }
            finally
            {
                Conexao.fechaConexao();
            }
        }

        public DataTable buscaMercadosParaAdmin()
        {
            DataTable dt = new DataTable();
            string sql = "select mer.mer_in_codigo mer_cod, en.end_in_codigo en_cod, mer.mer_bit_active Ativo, mer.mer_st_nome Razão_Social," +
                " av.av_mer_dec_nota Avaliação, mer.mer_st_email Email, mer.mer_st_CPNJ CPNJ, " +
                "en.end_st_CEP CEP, en.end_st_cidade Cidade, en.end_st_uf Estado," +
                "en.end_st_bairro Bairro, en.end_st_log Logradouro, en.end_st_num Número, " +
                "en.end_st_tel1 Telefone_1, en.end_st_tel2 Telefone_2 from tb_mercado mer," +
                "tb_endereco en, tb_avaliacao_mercado av where mer.mer_in_codigo = av.mer_in_codigo and " +
                "en.end_in_codigo = mer.end_in_codigo";
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

        public void ativaUsuarioMercado(int id)
        {
            string sql = "update tb_mercado set mer_bit_active = 1 where mer_in_codigo = " + id;
            SqlConnection conexao = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally
            {
                Conexao.fechaConexao();
            }
        }

        public void desativaUsuarioMercado(int id)
        {
            string sql = "update tb_mercado set mer_bit_active = 0 where mer_in_codigo = " + id;
            SqlConnection conexao = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally
            {
                Conexao.fechaConexao();
            }
        }

        public DataTable selecionaMercadoParaEdicao(int id)
        {
            DataTable dt = new DataTable();
            string sql = "select mer.mer_st_nome Razão_Social, mer.mer_st_user username, mer.mer_st_senha senha, " +
                "mer.mer_st_email Email, mer_st_CPNJ CPNJ, en.end_st_CEP CEP, en.end_st_cidade Cidade, en.end_st_uf Estado," +
                " en.end_st_bairro Bairro, en.end_st_log Logradouro, en.end_st_num Número, en.end_st_tel1 tel1, en.end_st_tel2 tel2" +
                " from tb_mercado mer, tb_endereco en where en.end_in_codigo = mer.end_in_codigo and mer.mer_in_codigo = " + id;
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

        public bool alteraUsuarioMercadoPorAdmin(int id, string nome, string CPNJ, string log, string bairro, string cidade, string uf, string num, string cep)
        {
            bool var = false;
            string sql = "update tb_mercado set mer_st_nome = '" + nome + "', mer_st_CPNJ = '" + CPNJ + "' " +
                "where mer_in_codigo = " + id +";GO " + "update tb_endereco set end_st_log = '" + log + 
                "', end_st_bairro = '" + bairro + "', end_st_cidade = '" + cidade + "', end_st_uf = '" +
                uf + "', end_st_num = '" + num + "', end_st_cep = '" + cep + "'where end_in_codigo = " +
                "(select mer.end_in_codigo from tb_mercado mer where mer.mer_in_codigo = " + id + ")";
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

        public bool alteraUsuarioMercado(int id, string user, string senha, string email, string tel1, string tel2)
        {
            bool var = false;
            string sql = "update tb_mercado set mer_st_user = '" + user + "', mer_st_senha = '" + senha + 
                "', mer_st_email = '" + email + "'where mer_in_codigo = " + id + "; GO update tb_endereco set " +
                "end_st_tel1 = '" + tel1 + "', end_st_tel2 = '" + tel2 + "'where end_in_codigo = " +
                "(select mer.end_in_codigo from tb_mercado mer where mer.mer_in_codigo = " + id + ")";
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

        public DataTable buscaPedidos(int mer_id)
        {
            DataTable dt = new DataTable();
            string sql = "select ped.ped_in_codigo codigo, ped_dec_valor Valor, ped.ped_status Status, ped.data_dt_pedido Data, cli.cli_st_nome Cliente" +
                ", en.end_st_CEP CEP, en.end_st_cidade Cidade, en.end_st_log Logradouro " +
                "from tb_pedido ped, tb_cliente cli, tb_endereco en where ped.cli_in_codigo = cli.cli_in_codigo and ped.end_in_codigo = en.end_in_codigo " +
                "and ped.mer_in_codigo = " + mer_id;
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

        public DataTable selecionaPedido(int ped_id)
        {
            DataTable dt = new DataTable();
            string sql = "select cli.cli_in_codigo Cod, cli.cli_st_nome Cliente, ped.data_dt_pedido Data_ped, ped.ped_status Status_pedido, " +
                "en.end_st_CEP CEP, ped.ped_dec_valor Valor, en.end_st_cidade Cidade, " +
                "en.end_st_bairro Bairro, av.av_cli_dec_nota Av from tb_cliente cli, tb_pedido ped, tb_endereco en, tb_avaliacao_cliente av" +
                " where cli.cli_in_codigo = ped.cli_in_codigo and en.end_in_codigo = ped.end_in_codigo and av.cli_in_codigo = cli.cli_in_codigo" +
                "  and ped.ped_in_codigo = " + ped_id;
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

        public DataTable buscaItensDoPedido(int ped_id)
        {
            DataTable dt = new DataTable();
            string sql = "select prod_st_nome Produto, prod_st_cod_mer Código, prod_dec_valor_un Valor_unidade, " +
                "item.item_in_qtde Quantidade, item_dec_valor Valor " +
                "from tb_item item, tb_produto prod, tb_pedido ped where " +
                "item.ped_in_codigo = ped.ped_in_codigo and item.prod_in_codigo =" +
                " prod.prod_in_codigo and ped.ped_in_codigo = " + ped_id;
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

        public string aprovaPedido(int ped_id, string msg)
        {
            string sql = "update tb_pedido set ped_status = 'Aprovado', ped_st_msg = '" + msg +
                "' where ped_in_codigo = " + ped_id;
            SqlConnection conexao = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i <= 0)
                {
                    msg = "Erro";
                }
            }
            catch (Exception ex) { }
            finally
            {
                Conexao.fechaConexao();
            }
            return msg;
        }

        public string reprovaPedido(int ped_id, string msg)
        {
            string sql = "update tb_pedido set ped_status = 'Reprovado', ped_st_msg = '" + msg +
                "' where ped_in_codigo = " + ped_id;
            SqlConnection conexao = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i <= 0)
                {
                    msg = "Erro";
                }
            }
            catch (Exception ex) { }
            finally
            {
                Conexao.fechaConexao();
            }
            return msg;
        }

        public DataTable visualizaPedidoAprovado(int ped_id)
        {
            DataTable dt = new DataTable();
            string sql = "select cli.cli_st_email Email, en.end_st_log Log, en.end_st_num Num, " +
                "en.end_st_tel1 Cell, en.end_st_tel2 Tel, en.end_st_compl Compl, ped.ped_st_msg Msg " +
                "from tb_cliente cli, tb_endereco en, tb_pedido ped where cli.cli_in_codigo = ped.cli_in_codigo " +
                "and en.end_in_codigo = ped.end_in_codigo and ped.ped_in_codigo = " + ped_id;
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

        public DataTable visualizaAvaliacaoClientePedido(int ped_id)
        {
            DataTable dt = new DataTable();
            string sql = "select avcli.ped_av_cli_dec_nota Nota, avcli.ped_av_cli_st_descricao Descricao " +
                "from tb_pedido_avaliacao_cliente avcli, tb_pedido ped " +
                "where ped.ped_in_codigo = avcli.ped_in_codigo and ped.ped_in_codigo = " + ped_id;
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

        public double visualizaAvaliacaoDoPedido(int ped_id)
        {
            double nota = -1;
            string sql = "select av.ped_av_cli_dec_nota from tb_pedido_avaliacao_cliente av, " +
                "tb_pedido ped where av.ped_in_codigo = ped.ped_in_codigo and ped.ped_in_codigo = " + ped_id;
            SqlConnection conn = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                reader.Read();
                nota = Convert.ToDouble(reader[0]);

            }
            catch (Exception ex) { }
            finally
            {
                Conexao.fechaConexao();
            }
            return nota;
        }  

        public bool verificaSeClientePossuiAvaliacao(int ped_id)
        {
            bool var = false;
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            SqlConnection conn = Conexao.abrirConexao();
            SqlDataReader dr;
            cmd.CommandText = "select av.av_cli_in_codigo from tb_avaliacao_cliente av, " +
                "tb_pedido ped where ped.cli_in_codigo = av.cli_in_codigo";
            try
            {
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    var = true;
                }
            }
            catch (Exception ex) {  }
            finally
            {
                Conexao.fechaConexao();
            }
            return var;
        }

        public bool criaAvaliacaoClienteSeNaoExistir(int ped_id)
        {
            bool var = false;
            string sql = "insert into tb_avaliacao_cliente VALUES (0.0, " +
                "(select ped.cli_in_codigo from tb_pedido ped where ped_in_codigo = " + ped_id + "))";
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

        public int buscaIDAvaliacaoCliente(int ped_id)
        {
            int AvCliId = 0;
            string sql = "select av.av_cli_in_codigo from tb_avaliacao_cliente av, tb_pedido ped" +
                " where av.cli_in_codigo = ped.cli_in_codigo and ped.ped_in_codigo = " + ped_id;
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

        public bool avaliaClientePedido(double nota, string desc, int avcli_id, int ped_id)
        {
            bool var = false;
            string sql = "insert into tb_pedido_avaliacao_mercado VALUES " +
                "(@nota , '" + desc + "', "+ped_id+", " + avcli_id + ",1)";
            SqlConnection conexao = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@nota", nota);
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

        public bool verificaSeMercadoAvaliouPedido(int ped_id)
        {
            bool var = false;
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            SqlConnection conn = Conexao.abrirConexao();
            SqlDataReader dr;
            cmd.CommandText = "select ped_av_mer_in_codigo from tb_pedido_avaliacao_mercado " +
                "where ped_in_codigo = " + ped_id;
            try
            {
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
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

        public DataTable buscaAvaliacaoCliente(int ped_id)
        {
            DataTable dt = new DataTable();
            string sql = "select ped_av_mer_dec_nota Nota, ped_av_mer_st_descricao Descricao from tb_pedido_avaliacao_mercado" +
                " where ped_in_codigo = " + ped_id;
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

        public DataTable visualizaAvaliacoesClientes(int mer_id)
        {
            DataTable dt = new DataTable();
            string sql = "select ped.ped_in_codigo codigo, cli.cli_st_nome Cliente, ped.ped_dec_valor Valor, " +
                "av.ped_av_cli_dec_nota Avaliação, av.ped_bit_active Ativo " +
                "from tb_pedido_avaliacao_cliente av, tb_pedido ped, tb_cliente cli " +
                "where av.ped_in_codigo = ped.ped_in_codigo and cli.cli_in_codigo = ped.cli_in_codigo " +
                "and ped.mer_in_codigo = " + mer_id;
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


        public int buscaIDAvaliacaoClientePedido(int ped_id)
        {
            int AvCliId = 0;
            string sql = "select av.ped_av_cli_in_codigo from tb_pedido_avaliacao_cliente av " +
                "where av.ped_in_codigo = " + ped_id;
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

        public bool cadastraPedidoRemocaoAvaliacaoMercado(int ped_av_id, string msg)
        {
            bool var = false;
            string sql = "insert into tb_pedido_remocao_avaliacao_mercado VALUES " +
                "(" + ped_av_id + ",'" + msg + "','','Em análise')";
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

        public bool verificaSeExistePedidoRemocaoAvaliacao(int ped_id)
        {
            bool var = false;
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            SqlConnection conn = Conexao.abrirConexao();
            SqlDataReader dr;
            cmd.CommandText = "select ped_rem_av_mer_in_codigo from tb_pedido_remocao_avaliacao_mercado rem " +
                "where rem.ped_av_cli_in_codigo = " + ped_id;
            try
            {
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
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

        public DataTable visualizaPedidoRemocaoAvaliacao(int ped_id)
        {
            DataTable dt = new DataTable();
            string sql = "select rem.ped_rem_av_mer_st_msg_mer Msg_mer, rem.ped_status Stat, " +
                "rem.ped_rem_av_mer_st_msg_adm Msg_adm from tb_pedido_remocao_avaliacao_mercado rem " +
                "where ped_av_cli_in_codigo = " + ped_id;
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

        public bool cadastraImagem(int id, byte[] img)
        {
            bool var = false;
            string sql = "INSERT INTO [dbo].[tb_mercado_img] ([mer_in_codigo], [mer_img])" +
                "VALUES (" + id + ", @img)";
            SqlConnection conexao = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@img", img);
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

        public bool alteraImagem(int id, byte[] img)
        {
            bool var = false;
            string sql = "UPDATE [dbo].[tb_mercado_img] SET mer_img = @img" +
                "WHERE mer_in_codigo = " + id;
            SqlConnection conexao = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@img", img);
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

        public byte[] selecionaImagem(int id)
        {
            byte[] img = null;
            string sql = "select mer_img from tb_mercado_img where mer_in_codigo = " + id;
            SqlConnection conn = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    img = (byte[])(reader["mer_img"]);
                }
            }
            catch (Exception ex)
            {
                img = null;
            }
            finally
            {
                Conexao.fechaConexao();
            }
            return img;
        }

        public DataTable buscaRelatorioProdutos(int mer_id, int type)
        {
            DataTable dt = new DataTable();
            string sql;
            if (type == 1||type == 2) {
                string like;
                if (type == 1) { like = "Entregue%"; } else { like = "Aprovado%"; }
                sql = "select DISTINCT(prod.prod_st_nome) Produto, prod.prod_dec_valor_un Valor," +
                    " prod.prod_st_cod_mer Código,  (select sum(itn.item_in_qtde) from tb_item itn, " +
                    "tb_pedido ped where itn.ped_in_codigo = ped.ped_in_codigo and ped.ped_status " +
                    "like '" + like + "' and itn.prod_in_codigo = prod.prod_in_codigo) Quantidade " +
                    "from tb_produto prod inner join tb_item itn on itn.prod_in_codigo = prod.prod_in_codigo " +
                    "inner join tb_pedido ped on itn.ped_in_codigo = ped.ped_in_codigo " +
                    "inner join tb_mercado mer on ped.mer_in_codigo = mer.mer_in_codigo " +
                    "where ped.ped_status like '" + like + "' and mer.mer_in_codigo = prod.mer_in_codigo " +
                    "and mer.mer_in_codigo = " + mer_id;
            }
            else
            {
                sql = "select prod.prod_st_nome Nome, prod.prod_dec_valor_un Valor, " +
                   "prod.prod_st_cod_mer Código, prod.prod_bit_active Ativo, " +
                   "prod.prod_bit_trad_active Trad_Ativo, c01.cat01_st_nome Categoria_1, " +
                   "c02.cat02_st_nome Categoria_2, c03.cat03_st_nome Categoria_3 from tb_produto prod, " +
                   "tb_categoria_n01 c01, tb_categoria_n02 c02, tb_categoria_n03 c03 " +
                   "where prod.cat01_in_codigo = c01.cat01_in_codigo and " +
                   "prod.cat02_in_codigo = c02.cat02_in_codigo and " +
                   "prod.cat03_in_codigo = c03.cat03_in_codigo and mer_in_codigo = " + mer_id;
            }
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

        public DataTable buscaRelatorioPedidos(int mer_id, int type)
        {
            DataTable dt = new DataTable();
            string sql;
            if (type == 1 || type == 2)
            {
                string like;
                if (type == 1) { like = "Aguardando%"; } else { like = "Entregue%"; }
                sql = "select ped.ped_in_codigo COD, cli.cli_st_nome Nome, ped.data_dt_pedido Dia, " +
                    "ped.ped_dec_valor Valor, en.end_st_log Logradouro, en.end_st_num Número," +
                    " en.end_st_tel1 Telefone, cli.cli_st_email Email from tb_pedido ped," +
                    " tb_cliente cli, tb_endereco en where ped.cli_in_codigo = cli.cli_in_codigo " +
                    "and ped.ped_status like '" + like + "' and en.end_in_codigo = ped.end_in_codigo " +
                    "and ped.mer_in_codigo = " + mer_id;
            }
            else
            {
                sql = "select ped.ped_in_codigo COD, cli.cli_st_nome Nome, ped.data_dt_pedido Dia, ped.ped_dec_valor Valor," +
                    " en.end_st_log Logradouro, en.end_st_num Número, en.end_st_tel1 Telefone," +
                    " cli.cli_st_email Email from tb_pedido ped, tb_cliente cli, tb_endereco en" +
                    " where ped.cli_in_codigo = cli.cli_in_codigo and en.end_in_codigo = ped.end_in_codigo " +
                    "and ped.mer_in_codigo = " + mer_id;
            }
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

        public DataTable buscaRelatorioClientes(int mer_id, int type)
        {
            DataTable dt = new DataTable();
            string sql;
            if (type == 1 || type == 2)
            {
                string like;
                if (type == 1) { like = "Aguardando%"; } else { like = "Entregue%"; }
                sql = "select DISTINCT(cli.cli_st_nome) Nome, cli.cli_st_email Email, en.end_st_tel1 Telefone," +
                    " av.av_cli_dec_nota Avaliação from tb_cliente cli, tb_pedido ped, tb_endereco en, " +
                    "tb_avaliacao_cliente av where cli.cli_in_codigo = ped.cli_in_codigo and " +
                    "cli.end_in_codigo = en.end_in_codigo and av.cli_in_codigo = cli.cli_in_codigo" +
                    " and ped.end_in_codigo = en.end_in_codigo and ped.ped_status " +
                    "like 'Entregue%' and ped.mer_in_codigo = " + mer_id;
            }
            else
            {
                sql = "select DISTINCT(cli.cli_st_nome) Nome, cli.cli_st_email Email, en.end_st_tel1 Telefone, " +
                    "av.av_cli_dec_nota Avaliação from tb_cliente cli, tb_pedido ped, tb_endereco en," +
                    " tb_avaliacao_cliente av where cli.cli_in_codigo = ped.cli_in_codigo" +
                    " and cli.end_in_codigo = en.end_in_codigo and " +
                    "av.cli_in_codigo = cli.cli_in_codigo and ped.end_in_codigo = en.end_in_codigo " +
                    "and ped.mer_in_codigo = " + mer_id;
            }
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

        public int verificaEmail(string email)
        {
            int id = 0;
            string sql = "select mer_in_codigo from tb_mercado where mer_st_email = @email";
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

        public string buscaUsuarioMercado(int id)
        {
            string sql = "SELECT mer.mer_st_user FROM tb_mercado mer WHERE mer_in_codigo = '" + id + "';";
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
            string sql = "update tb_mercado set mer_st_senha = @senha where mer_in_codigo = " + id;
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

        public void EnviaMensagemEmail(string email,string usuario, string senha)
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
            return;
        }

        public DataTable consultaAvaliacoesCliente(int cli_id)
        {
            DataTable dt = new DataTable();
            string sql = "select pedav.ped_av_mer_dec_nota Nota, pedav.ped_av_mer_st_descricao Descricao from " +
                "dbo.tb_pedido_avaliacao_mercado as pedav join tb_avaliacao_cliente as av" +
                " on pedav.av_cli_in_codigo = av.av_cli_in_codigo join tb_cliente as cli on cli.cli_in_codigo = " +
                "av.cli_in_codigo where pedav.ped_bit_active = 1 and cli.cli_in_codigo = " + cli_id;
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

        public decimal consultaAvaliacaoCliente(int cli_id)
        {
            string sql = "SELECT [av_cli_dec_nota] FROM [dbo].[tb_avaliacao_cliente] where cli_in_codigo = " + cli_id;
            SqlConnection conn = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            decimal av = 0;
            try
            {
                reader = cmd.ExecuteReader();
                reader.Read();
                return av = Convert.ToDecimal(reader[0]);

            }
            catch (Exception ex)
            {
                return av = 0;
            }
            finally
            {
                Conexao.fechaConexao();
            }
        }
    }
}
