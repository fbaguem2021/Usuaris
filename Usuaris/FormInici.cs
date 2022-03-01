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
            InitializeComponent();
        }
        private void FormInici_Load(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.ShowDialog();
        }

        private void menuItemSortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItemUsuaris_Click(object sender, EventArgs e)
        {
            FormUsuaris f = new FormUsuaris();
            f.ShowDialog();
        }

    }
}
