using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econobuy.Entities
{
    public class Produto
    {
        private int id;
        private string nome;
        private string descricao;
        private decimal valor_unidade;
        private string codigo_estoque;
        private string categoria01;
        private string categoria02;
        private string categoria03;
        private bool active;
        private bool trad_active;
        private byte[] imagem_produto;
        private int cat01ID;
        private int cat02ID;
        private int cat03ID;
        private int prodID;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public decimal Valor_unidade { get => valor_unidade; set => valor_unidade = value; }
        public string Codigo_estoque { get => codigo_estoque; set => codigo_estoque = value; }
        public string Categoria01 { get => categoria01; set => categoria01 = value; }
        public string Categoria02 { get => categoria02; set => categoria02 = value; }
        public string Categoria03 { get => categoria03; set => categoria03 = value; }
        public bool Active { get => active; set => active = value; }
        public bool Trad_active { get => trad_active; set => trad_active = value; }
        public byte[] Imagem_produto { get => imagem_produto; set => imagem_produto = value; }
        public int Cat01ID { get => cat01ID; set => cat01ID = value; }
        public int Cat02ID { get => cat02ID; set => cat02ID = value; }
        public int Cat03ID { get => cat03ID; set => cat03ID = value; }
        public int ProdID { get => prodID; set => prodID = value; }
    }
}
