using Econobuy.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econobuy.Controllers
{
    public class ProdutoController
    {
        public int inserirProduto(Produto p, int mer_id)
        {
            int prod_id = 0;
            string sql = "INSERT INTO [dbo].[tb_produto] ([prod_st_nome], [prod_st_descricao], [prod_dec_valor_un], " +
                "[prod_st_cod_mer], [prod_bit_trad_active], [prod_bit_active], [mer_in_codigo], [cat01_in_codigo]," +
                "[cat02_in_codigo], [cat03_in_codigo]) output Inserted.prod_in_codigo VALUES ('" + p.Nome + "', '" + p.Descricao + "', @valor, '" + p.Codigo_estoque +
                "', " + Convert.ToInt32(p.Trad_active) + ", 1, " + mer_id + ", " + p.Cat01ID + ", " + p.Cat02ID + ", " + p.Cat03ID + ");";
            SqlConnection conexao = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@valor", p.Valor_unidade);
            try
            {
                prod_id = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                prod_id = 0;
            }
            finally
            {
                Conexao.fechaConexao();
            }
            return prod_id;
        }

        public int buscarIDProduto(string nome, double valor, string cod_mer)
        {
            string sql = "SELECT prod.prod_in_codigo FROM tb_produto prod WHERE prod_st_nome = '" + nome + "'" +
                "and prod_dec_valor_un = @valor and prod_st_cod_mer = '" + cod_mer + "';";
            SqlConnection conn = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@valor", valor);
            SqlDataReader reader;
            int id = 0;
            try
            {
                reader = cmd.ExecuteReader();
                reader.Read();
                id = Convert.ToInt32(reader[0]);

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

        public List<string> buscarCategorias_01()
        {
            List<string> categories = new List<string>();
            string sql = "SELECT cat01_st_nome FROM tb_categoria_n01;";
            SqlConnection conn = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string category = reader.GetString(0);
                    categories.Add(category);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Conexao.fechaConexao();
            }
            return categories;
        }

        public int buscarIDCategoria_01(string category)
        {
            string sql = "SELECT cat.cat01_in_codigo FROM tb_categoria_n01 cat WHERE cat01_st_nome = '" + category + "';";
            SqlConnection conn = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            int id = 0;
            try
            {
                reader = cmd.ExecuteReader();
                reader.Read();
                if(reader.HasRows) id = Convert.ToInt32(reader[0]);
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

        public List<string> buscarCategorias_02(int cat01)
        {
            List<string> categories = new List<string>();
            string sql = "SELECT cat02_st_nome FROM tb_categoria_n02 where cat01_in_codigo = "+cat01+";";
            SqlConnection conn = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string category = reader.GetString(0);
                    categories.Add(category);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Conexao.fechaConexao();
            }
            return categories;
        }

        public int buscarIDCategoria_02(string category)
        {
            string sql = "SELECT cat.cat02_in_codigo FROM tb_categoria_n02 cat WHERE cat02_st_nome = '" + category + "';";
            SqlConnection conn = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            int id = 0;
            try
            {
                reader = cmd.ExecuteReader();
                reader.Read();
                if(reader.HasRows) id = Convert.ToInt32(reader[0]);
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

        public List<string> buscarCategorias_03(int cat02)
        {
            List<string> categories = new List<string>();
            string sql = "SELECT cat03_st_nome FROM tb_categoria_n03 where cat02_in_codigo = " + cat02 + ";";
            SqlConnection conn = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string category = reader.GetString(0);
                    categories.Add(category);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Conexao.fechaConexao();
            }
            return categories;
        }

        public int buscarIDCategoria03(string category)
        {
            string sql = "SELECT cat.cat03_in_codigo FROM tb_categoria_n03 cat WHERE cat03_st_nome = '" + category + "';";
            SqlConnection conn = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            int id = 0;
            try
            {
                reader = cmd.ExecuteReader();
                reader.Read();
                if(reader.HasRows) id = Convert.ToInt32(reader[0]);
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

        public int inserirCategoria_01(string category)
        {
            int cat01_id;
            string sql = "INSERT INTO tb_categoria_n01 output Inserted.cat01_in_codigo VALUES ('" + category + "');";
            SqlConnection conexao = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            try
            {
                cat01_id = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                cat01_id = 0;
            }
            finally
            {
                Conexao.fechaConexao();
            }
            return cat01_id;
        }

        public int inserirCategoria_02(string category, int cat01_id)
        {
            int cat02_id;
            string sql = "INSERT INTO tb_categoria_n02 output Inserted.cat02_in_codigo VALUES ('" + category + "'," + cat01_id + ");";
            SqlConnection conexao = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            try
            {
                cat02_id = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                cat02_id = 0;
            }
            finally
            {
                Conexao.fechaConexao();
            }
            return cat02_id;
        }

        public int inserirCategoria_03(string category, int cat02_id)
        {
            int cat03_id;
            string sql = "INSERT INTO tb_categoria_n03 output Inserted.cat03_in_codigo VALUES ('" + category + "'," + cat02_id + ");";
            SqlConnection conexao = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            try
            {
                cat03_id = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                cat03_id = 0;
            }
            finally
            {
                Conexao.fechaConexao();
            }
            return cat03_id;
        }

        public DataTable buscaProdutos(int id)
        {
            DataTable dt = new DataTable();
            string sql = "select prod.prod_in_codigo Registro, prod.prod_st_nome Nome, prod.prod_dec_valor_un Preço, " +
                "prod.prod_st_cod_mer Código, prod.prod_bit_trad_active Tradicional, prod.prod_bit_active Ativo," +
                " cat01.cat01_st_nome Departamento, cat02.cat02_st_nome Categoria_primária, " +
                "cat03.cat03_st_nome Categoria_secundária from tb_produto prod, tb_categoria_n01 cat01," +
                " tb_categoria_n02 cat02, tb_categoria_n03 cat03 where " +
                "prod.cat01_in_codigo = cat01.cat01_in_codigo and prod.cat02_in_codigo = cat02.cat02_in_codigo " +
                "and prod.cat03_in_codigo = cat03.cat03_in_codigo and prod.mer_in_codigo = " + id;
            SqlConnection conexao = Conexao.abrirConexao();
            SqlDataAdapter da = new SqlDataAdapter(sql, conexao);
            try
            {
                da.Fill(dt);
            }
            catch(Exception ex) { }
            finally { Conexao.fechaConexao(); }
            return dt;
        }

        public DataTable selecionaProdutoParaEdicao(int id)
        {
            DataTable dt = new DataTable();
            string sql = "select prod.prod_st_nome nome, prod.prod_dec_valor_un valor, prod.prod_st_descricao descricao, prod.prod_st_cod_mer mer, prod.prod_bit_trad_active trad, " +
                "cat01.cat01_st_nome cat01, cat02.cat02_st_nome cat02, cat03.cat03_st_nome cat03 from " +
                "tb_produto prod, tb_categoria_n01 cat01, tb_categoria_n02 cat02, tb_categoria_n03 cat03 where " +
                "prod.cat01_in_codigo = cat01.cat01_in_codigo and prod.cat02_in_codigo = cat02.cat02_in_codigo and cat03.cat03_in_codigo = prod.cat03_in_codigo and prod.prod_in_codigo = " + id;
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

        public bool desativaProduto(int id)
        {
            bool var = false;
            string sql = "update tb_produto set prod_bit_active = 0 where prod_in_codigo = " + id;
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

        public bool ativaProduto(int id)
        {
            bool var = false;
            string sql = "update tb_produto set prod_bit_active = 1 where prod_in_codigo = " + id;
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

        public bool desativaModoTradicional(int id)
        {
            bool var = false;
            string sql = "update tb_produto set prod_bit_trad_active = 0 where prod_in_codigo = " + id;
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

        public bool ativaModoTradicional(int id)
        {
            bool var = false;
            string sql = "update tb_produto set prod_bit_trad_active = 1 where prod_in_codigo = " + id;
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

        public bool alteraProduto(int id, Produto p)
        {
            bool var = false;
            string sql = "update tb_produto set prod_st_nome = '" + p.Nome +
                "', prod_st_descricao = '" + p.Descricao + "', prod_bit_trad_active = " 
                + Convert.ToInt32(p.Trad_active) + ", prod_dec_valor_un = @valor, prod_st_cod_mer = '"
                + p.Codigo_estoque + "' where prod_in_codigo = " + id;
            SqlConnection conexao = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@valor", p.Valor_unidade);
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


        public void deletaProduto(int id)
        {
            string sql = "DELETE FROM tb_produto_img WHERE prod_in_codigo = " + id +
                "; DELETE FROM[dbo].[tb_produto] WHERE prod_in_codigo = " + id;
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

        public bool cadastraImagem(int id, byte[] img)
        {
            bool var = false;
            string sql = "INSERT INTO [dbo].[tb_produto_img] ([prod_in_codigo], [prod_img])" +
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
            catch(Exception ex)
            {
                var = false;
            }
            finally
            {
                Conexao.fechaConexao();
            }
            return var;
        }

        public bool alteraImagem(int id, byte[] img)
        {
            bool var = false;
            string sql = "UPDATE [dbo].[tb_produto_img] SET prod_img = @img" +
                "WHERE prod_in_codigo = " + id;
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
            string sql = "select prod_img from tb_produto_img where prod_in_codigo = " + id;
            SqlConnection conn = Conexao.abrirConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    img = (byte[])(reader["prod_img"]);
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

    }
}
