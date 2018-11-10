using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaApp.Entidades
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Estado { get; set; }
    }
}
