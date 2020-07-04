using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econobuy.Entities
{
    public class Usuario
    {
        private int id;
        private string user;
        private string senha;
        private string name;
        private string requests;
        private bool active;
        private string email;

        public int Id { get => id; set => id = value; }
        public string User { get => user; set => user = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Name { get => name; set => name = value; }
        public string Requests { get => requests; set => requests = value; }
        public bool Active { get => active; set => active = value; }
        public string Email { get => email; set => email = value; }
    }
}
