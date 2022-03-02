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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private Usuari login()
        {
            Usuari[] usersList = SeguretatBd.select_users();
            Usuari usuari;

            foreach (Usuari usr in usersList)
            {
                if (check(textBox_correu.Text, textBox_contrasenya.Text, usr))
                {
                    return usr;
                }
            }

            return null;
        }
        private bool check(String correu, String contrasenya, Usuari toCheck)
        {
            bool retornar;
            if (correu.Equals(toCheck.correu))
            {
                if (BCrypt.Net.BCrypt.EnhancedVerify(contrasenya, toCheck.contrasenya))
                {
                    return true;
                }
            }
            return false;
        }

        /* ================================================================================ EVENTOS ================================================================================ */

        private void button_acceptar_Click(object sender, EventArgs e)
        {
            FormInici.loggedUser = login();
            if ( !FormInici.loggedUser.Equals(null))
            {
                this.Close();
            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
