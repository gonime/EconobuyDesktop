using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econobuy.Entities
{
    public class Endereco
    {
        private int id;
        private string cep;
        private string logradouro;
        private string numero;
        private string bairro;
        private string cidade;
        private string uf;
        private string cell;
        private string tel;

        public string CEP { get => cep; set => cep = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Cell { get => cell; set => cell = value; }
        public string Tel { get => tel; set => tel = value; }
        public int Id { get => id; set => id = value; }
    }
}
