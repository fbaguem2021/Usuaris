using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuaris.Models
{
    public static class Bd
    {
        public static SqlConnection connection = new SqlConnection
            ("Server=192.168.56.102; Database=seguretat;User Id=SA; Password=Politecnics_0;");
    }
}
