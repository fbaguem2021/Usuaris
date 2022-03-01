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
    public partial class FormUsuari : Form
    {
        private List<Usuari> usuaris;
        private List<Rol> rols;
        public FormUsuari(List<Usuari> llista)
        {
            InitializeComponent();
            this.usuaris = llista;
        }

        private void FormUsuari_Load(object sender, EventArgs e)
        {
            rols = SeguretatBd.select_rols().ToList<Rol>();
            cbRols.DataSource = rols;
            cbRols.DisplayMember = "nom";
            cbRols.ValueMember = "id!";
        }

        private void btnAcceptar_Click(object sender, EventArgs e)
        {
            
        }

        private bool validateData(String _data)
        {
            switch (_data)
            {
                case "correu":
                    if (
                        tbCorreu.Text.Equals("") ||
                        !tbCorreu.Text.Contains("@") ||
                        !tbCorreu.Text.Split('@').Length.Equals(2) ||
                        !tbCorreu.Text.Split('@')[1].Contains(".")
                        )
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case "nom":
                    if ()
                case "cognoms":

                case "contrasenya":

            }
            return false;
        }
    }
}
