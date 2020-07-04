using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econobuy.Entities
{
    public class Mercado : Usuario
    {
        private bool advert;
        private string cpnj;
        private byte[] imagem_Mercado;

        public bool Advert { get => advert; set => advert = value; }
        public string Cpnj { get => cpnj; set => cpnj = value; }
        public byte[] Imagem_Mercado { get => imagem_Mercado; set => imagem_Mercado = value; }
    }
}
