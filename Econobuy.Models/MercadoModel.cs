using Econobuy.Controllers;
using Econobuy.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econobuy.Models
{
    public class MercadoModel
    {

        MercadoController mer = new MercadoController();

        public int acessarMercado(Mercado u)
        {
            int id = mer.verificaLoginMercado(u.User, u.Senha);
            return id;
        }

        public string consultarNomeMercado(int mer_id)
        {
            string name = mer.buscaNomeMercado(mer_id);

            return name;
        }

        public int inserirMercado(Mercado u, int end_id)
        {
            int mer_id = mer.cadastraMercado(u.Name, u.User, u.Senha, u.Cpnj, u.Email, end_id);
            mer.criaAvaliacaoMercado(mer_id);
            if (u.Imagem_Mercado != null) mer.cadastraImagem(mer_id, u.Imagem_Mercado);
            return mer_id;
        }

        public bool verificaUsuarioDisponivel(string username)
        {
            bool var = mer.verificaSeNomeDeUsuarioDisponivel(username);
            return var;
        }

        public int contaPedidosEmAguardo(int id)
        {
            int conta = mer.contaPedidosEmAguardo(id);
            return conta;
        }

        public DataTable trazerInformacoes()
        {
            DataTable informacoes = new DataTable();
            informacoes = mer.buscaMercadosParaAdmin();
            return informacoes;
        }

        public void ativarMercado(int mer_id)
        {
            mer.ativaUsuarioMercado(mer_id);
        }
        
        public void desativarMercado(int mer_id)
        {
            mer.desativaUsuarioMercado(mer_id);
        }

        public DataTable selecionarParaEdicao(int mer_id)
        {
            DataTable info = new DataTable();
            info = mer.selecionaMercadoParaEdicao(mer_id);
            return info;
        }

        public byte[] selecionaImagemParaEdicao(int mer_id)
        {
            byte[] img = null;
            img = mer.selecionaImagem(mer_id);
            return img;
        }

        public bool alterarMercadoAdmin(int id, Mercado m, Endereco e)
        {
            bool var = false;
            var = mer.alteraUsuarioMercadoPorAdmin(id, m.Name, m.Cpnj, e.Logradouro, e.Bairro, e.Cidade, e.Uf, e.Numero, e.CEP);
            return var;
        }

        public bool alterarMercado(int id, Mercado m, Endereco e)
        {
            bool var = false;
            var = mer.alteraUsuarioMercado(id, m.User, m.Senha, m.Email, e.Cell, e.Tel);
            if (m.Imagem_Mercado != null)
            {
                var = mer.cadastraImagem(id, m.Imagem_Mercado);
                if (var == false) mer.alteraImagem(id, m.Imagem_Mercado);
            }
            return var;
        }

        public DataTable selecionarPedidos(int mer_id)
        {
            DataTable info = new DataTable();
            info = mer.buscaPedidos(mer_id);
            return info;
        }

        public DataTable selecionaPedidoUnico(int ped_id)
        {
            DataTable info = new DataTable();
            info = mer.selecionaPedido(ped_id);
            return info;
        }

        public DataTable selecionaItensPedido(int ped_id)
        {
            DataTable info = new DataTable();
            info = mer.buscaItensDoPedido(ped_id);
            return info;
        }

        public string aprovaPedido(int ped_id, string msg)
        {
            string msg_ = mer.aprovaPedido(ped_id, msg);
            return msg_;
        }

        public string reprovaPedido(int ped_id, string msg)
        {
            string msg_ = mer.reprovaPedido(ped_id, msg);
            return msg_;
        }

        public DataTable pedidoAprovado(int ped_id)
        {
            DataTable info = new DataTable();
            info = mer.visualizaPedidoAprovado(ped_id);
            return info;
        }

        public DataTable verAvCliente(int ped_id)
        {
            DataTable info = new DataTable();
            info = mer.visualizaAvaliacaoClientePedido(ped_id);
            return info;
        }

        public double verAvaliacao(int ped_id)
        {
            return mer.visualizaAvaliacaoDoPedido(ped_id);
        }

        public bool avaliarPedido(int ped_id, double nota, string desc)
        {
            bool var = mer.verificaSeClientePossuiAvaliacao(ped_id);
            if (!var) var = mer.criaAvaliacaoClienteSeNaoExistir(ped_id);
            int avcli_id = mer.buscaIDAvaliacaoCliente(ped_id);
            if (var) var = mer.avaliaClientePedido(nota, desc, avcli_id, ped_id);
            return var;
        }

        public bool verificaSeJaFoiAvaliado(int ped_id)
        {
            return mer.verificaSeMercadoAvaliouPedido(ped_id);
        }

        public DataTable preencheAvaliacaoCliente(int ped_id)
        {
            return mer.buscaAvaliacaoCliente(ped_id);
        }

        public DataTable verAvalicoesClientes(int mer_id)
        {
            return mer.visualizaAvaliacoesClientes(mer_id);
        }

        public bool inserirPedidoDeRemocao(int ped_id, string msg)
        {
            return mer.cadastraPedidoRemocaoAvaliacaoMercado(mer.buscaIDAvaliacaoClientePedido(ped_id), msg);
        }

        public bool verificaSeExistePedidoDeRemocao(int ped_id)
        {
            return mer.verificaSeExistePedidoRemocaoAvaliacao(mer.buscaIDAvaliacaoClientePedido(ped_id));
        }

        public DataTable verPedidoDeRemocao(int ped_id)
        {
            return mer.visualizaPedidoRemocaoAvaliacao(mer.buscaIDAvaliacaoClientePedido(ped_id));
        }

        public DataTable relatorioProdutos(int mer_id, int type)
        {
            DataTable info = new DataTable();
            info = mer.buscaRelatorioProdutos(mer_id, type);
            return info;
        }

        public DataTable relatorioPedidos(int mer_id, int type)
        {
            DataTable info = new DataTable();
            info = mer.buscaRelatorioPedidos(mer_id, type);
            return info;
        }

        public DataTable relatorioClientes(int mer_id, int type)
        {
            DataTable info = new DataTable();
            info = mer.buscaRelatorioClientes(mer_id, type);
            return info;
        }

        public bool recuperarSenha(string email)
        {
            int id = mer.verificaEmail(email);
            if (id != 0)
            {
                string senha = mer.randomizarSenha(id);
                string usuario = mer.buscaUsuarioMercado(id);
                mer.EnviaMensagemEmail(email, usuario, senha);
                return true;
            }
            else return false;
        }

        public DataTable consultarCliente(int cli_id)
        {
            DataTable info = new DataTable();
            info = mer.consultaAvaliacoesCliente(cli_id);
            return info;
        }

        public decimal consultarAvCliente(int cli_id)
        {
            decimal av = mer.consultaAvaliacaoCliente(cli_id);
            return av;
        }
    }
}
