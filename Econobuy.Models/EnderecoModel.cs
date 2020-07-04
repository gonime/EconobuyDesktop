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
    public class EnderecoModel
    {
        EnderecoController end = new EnderecoController();

        public int inserirEnderecoMercado(Endereco u)
        {
            int end_id = end.cadastraEndereco(u.CEP, u.Logradouro, u.Numero, u.Bairro, u.Cidade, u.Uf, u.Cell, u.Tel);
            return end_id;
        }

        public int inserirEnderecoAdministrador(Endereco u)
        {
            int end_id = end.cadastraEndereco(u.CEP, u.Logradouro, u.Numero, null, u.Cidade, u.Uf, u.Cell, null);
            return end_id;
        }
        
    }
}
