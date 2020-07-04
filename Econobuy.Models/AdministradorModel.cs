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
    public class AdministradorModel
    {
        AdministradorController adm = new AdministradorController();

        public int acessarAdmin(Administrador u)
        {
            int id = 0;
            id = adm.verificaLoginAdmin(u.User, u.Senha);
            return id;
        }


        public string consultarNomeAdmin(Administrador u)
        {
            string name = adm.buscaNomeAdmin(u.Id);
            return name;
        }

        public int inserirAdministrador(Administrador u, int end_id)
        {
            int id = adm.cadastraAdmin(u.Name, u.User, u.Senha, u.Email, end_id);
            adm.cadastraPermissaoAdmin(id, u.Cadastro_administrador,
                u.Cadastro_mercado, u.Consulta_mercado,  u.Remover_avaliacao);
            return id;
        }

        public int[] verificarPermissoes(int id)
        {
            int[] permissoes = new int[6];
            permissoes = adm.verificaPermissoes(id);
            return permissoes;
        }

        public bool verificaUsuarioDisponivel(string username)
        {
            bool var = adm.verificaUsuarioDisponivel(username);
            return var;
        }

        public DataTable verPedidosRemocaoMercado()
        {
            return adm.buscaPedidosRemocaoMercado();
        }

        public DataTable verPedidosRemocaoCliente()
        {
            return adm.buscaPedidosRemocaoCliente();
        }

        public DataTable preencherPedidoRemocaoCliente(int ped_id)
        {
            return adm.preenchePedidoRemocaoCliente(ped_id);
        }

        public DataTable preencherPedidoRemocaoMercado(int ped_id)
        {
            return adm.preenchePedidoRemocaoMercado(ped_id);
        }

        public bool aprovarPedidoRemocaoCliente(int ped_id, string msg)
        {
            bool var = adm.aprovaPedidoRemocaoCliente(ped_id, msg);
            if (var) var = adm.atualizaPedidoAprovadoCliente(adm.buscaIDAvaliacaoPedidoCliente(ped_id));

            return var;
        }

        public bool aprovarPedidoRemocaoMercado(int ped_id, string msg)
        {
            bool var = adm.aprovaPedidoRemocaoMercado(ped_id, msg);
            if (var) var = adm.atualizaPedidoAprovadoMercado(adm.buscaIDPedidoAvaliacaoMercado(ped_id));

            return var;
        }

        public bool reprovarPedidoRemocaoMercado(int ped_id, string msg)
        {
            return adm.reprovaPedidoRemocaoMercado(ped_id, msg);
        }

        public bool reprovarPedidoRemocaoCliente(int ped_id, string msg)
        {
            return adm.reprovaPedidoRemocaoCliente(ped_id, msg);
        }

        public bool recuperarSenha(string email)
        {
            int id = adm.verificaEmail(email);
            if (id != 0)
            {
                string senha = adm.randomizarSenha(id);
                string usuario = adm.buscaUsuarioAdministrador(id);
                adm.EnviaMensagemEmail(email, usuario, senha);
                return true;
            }
            else return false;
        }
    }
}