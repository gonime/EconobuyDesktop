using Econobuy.Entities;
using Econobuy.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Policy;
using System.IO;
using System.Reflection;

namespace Econobuy.Models
{
    public class ProdutoModel
    {

        ProdutoController pro = new ProdutoController();

        public bool inserirProduto(Produto p, int mer_id)
        {
            bool var = false;
            p.Cat01ID = pro.buscarIDCategoria_01(p.Categoria01);
            if (p.Cat01ID == 0) p.Cat01ID = pro.inserirCategoria_01(p.Categoria01);
            p.Cat02ID = pro.buscarIDCategoria_02(p.Categoria02);
            if (p.Cat02ID == 0) p.Cat02ID = pro.inserirCategoria_02(p.Categoria02, p.Cat01ID);
            p.Cat03ID = pro.buscarIDCategoria03(p.Categoria03);
            if (p.Cat03ID == 0) p.Cat03ID = pro.inserirCategoria_03(p.Categoria03, p.Cat02ID);
            p.ProdID = 0;
            if (p.Cat03ID != 0) p.ProdID = pro.inserirProduto(p, mer_id);
            if (p.Imagem_produto != null) var = pro.cadastraImagem(p.ProdID, p.Imagem_produto);
            else var = pro.cadastraImagem(p.ProdID, System.IO.File.ReadAllBytes(@"../../Repositório/NoImg.png"));
            return var;
        }

        public List<string> trazerCategoria01()
        {
            List<string> categorias = new List<string>();
            categorias = pro.buscarCategorias_01();
            return categorias;
        }

        public int trazerCategoria01ID(string categoria){
            int cat01ID = pro.buscarIDCategoria_01(categoria);
            return cat01ID;
        }

        public List<string> trazerCategoria02(int cat_id)
        {
            List<string> categorias = new List<string>();
            categorias = pro.buscarCategorias_02(cat_id);
            return categorias;
        }

        public int trazerCategoria02ID(string categoria)
        {
            int cat01ID = pro.buscarIDCategoria_02(categoria);
            return cat01ID;
        }

        public List<string> trazerCategoria03(int cat_id)
        {
            List<string> categorias = new List<string>();
            categorias = pro.buscarCategorias_03(cat_id);
            return categorias;
        }

        public int trazerCategoria03ID(string categoria)
        {
            int cat01ID = pro.buscarIDCategoria_01(categoria);
            return cat01ID;
        }
        
        public DataTable visualizarProdutosMercado(int id)
        {
            DataTable dt = new DataTable();
            dt = pro.buscaProdutos(id);
            return dt;
        }

        public bool ativarProduto(int id)
        {
            return pro.ativaProduto(id);
        }

        public bool desativarProduto(int id)
        {
            return pro.desativaProduto(id);
        }

        public bool ativarModoTradProduto(int id)
        {
            return pro.ativaModoTradicional(id);
        }

        public bool desativarModoTradProduto(int id)
        {
            return pro.desativaModoTradicional(id);
        }

        public DataTable trazerInformacoes(int prod_id)
        {
            DataTable informacoes = new DataTable();
            informacoes = pro.selecionaProdutoParaEdicao(prod_id);
            return informacoes;
        }

        public bool alterarProduto(Produto p, int prod_id)
        {
            bool var = false;
            int cat01 = pro.buscarIDCategoria_01(p.Categoria01);
            if (cat01 == 0) cat01 = pro.inserirCategoria_01(p.Categoria01);
            int cat02 = pro.buscarIDCategoria_02(p.Categoria02);
            if (cat02 == 0) cat02 = pro.inserirCategoria_02(p.Categoria02, cat01);
            int cat03 = pro.buscarIDCategoria03(p.Categoria03);
            if (cat03 == 0) cat03 = pro.inserirCategoria_03(p.Categoria03, cat02);
            var = pro.alteraProduto(prod_id, p);
            if (p.Imagem_produto != null)
            {
                var = pro.cadastraImagem(prod_id, p.Imagem_produto);
                if (var == false) pro.alteraImagem(prod_id, p.Imagem_produto);
            }
            return var;
        }

        public void deletarProduto(int id)
        {

            pro.deletaProduto(id);
        }

        public byte[] buscarImagem(int id)
        {
            byte[] img = null;
            img = pro.selecionaImagem(id);
            return img;
        }
    }
}
