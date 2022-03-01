using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuaris.Models
{
    public class Rol
    {
        public Rol(int id, string nom, bool actiu)
        {
            this.id = id;
            this.nom = nom;
            this.actiu = actiu;
        }
        public Rol() { }
        public int id { get; set; }
        public String nom { get; set; }
        public bool actiu { get; set; }


    }
}
