using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuaris.Models;

namespace Usuaris
{
    public partial class FormInici : Form
    {
        public static List<Usuari> listaUsuarios = new List<Usuari>();
        public static Usuari loggedUser;
        public FormInici()
        {
            FormLogin login = new FormLogin();
            login.ShowDialog();

            if (login.isCorrect())
            {
                loggedUser = login.loggedUser;
            }

            InitializeComponent();

        }

    }
}
