using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuaris.Models
{
    public class Usuari
    {
        public Usuari
            (int id, string correu, string nom, string cognoms, string contrasenya, bool actiu, int rols_id)
        {
            this.id = id;
            this.correu = correu;
            this.nom = nom;
            this.cognoms = cognoms;
            this.contrasenya = contrasenya;
            this.actiu = actiu;
            this.rols_id = rols_id;
        }
        public Usuari() {  }
        public int id { get; set; }
        public String correu { get; set; }
        public String nom { get; set; }
        public String cognoms { get; set; }
        public String contrasenya { get; set; }
        public bool actiu { get; set; }
        public int rols_id { get; set; }
        public String rol { get; set; }

        public String hash(String psswd)
        {
            return BCrypt.Net.BCrypt.EnhancedHashPassword(psswd);
        }
    }
}
