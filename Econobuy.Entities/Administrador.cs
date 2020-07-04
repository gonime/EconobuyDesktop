using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econobuy.Entities
{
    public class Administrador : Usuario
    {
        private bool cadastro_mercado;
        private bool cadastro_administrador;
        private bool consulta_mercado;
        private bool remover_avaliacao;

        public bool Cadastro_mercado { get => cadastro_mercado; set => cadastro_mercado = value; }
        public bool Cadastro_administrador { get => cadastro_administrador; set => cadastro_administrador = value; }
        public bool Consulta_mercado { get => consulta_mercado; set => consulta_mercado = value; }
        public bool Remover_avaliacao { get => remover_avaliacao; set => remover_avaliacao = value; }
    }
}
