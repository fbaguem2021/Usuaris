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
            cbRols.ValueMember = "id";
        }

        private void btnAcceptar_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                Usuari usr = new Usuari();
                usr.correu = tbCorreu.Text;
                usr.nom = tbNom.Text;
                usr.cognoms = tbCognoms.Text;
                usr.contrasenya = BCrypt.Net.BCrypt.EnhancedHashPassword(tbContrasenya.Text);
                usr.actiu = chbActiu.Checked;
                usr.rols_id = (int)cbRols.SelectedValue;
                SeguretatBd.insertat_usuari(usr);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validateData()
        {
            bool correuIsCorrect = 
                tbCorreu.Text.Length <= 45 &&
                !tbCorreu.Text.Equals("") &&
                tbCorreu.Text.Contains("@") &&
                tbCorreu.Text.Split('@').Length.Equals(2) &&
                tbCorreu.Text.Split('@')[1].Contains(".");

            bool nomIsCorrect =
                tbNom.Text.Length <= 45 &&
                !tbNom.Text.Equals("") &&
                !tbNom.Text.Any(char.IsDigit) &&
                !tbNom.Text.Contains(" ");

            bool cognomsIsCorrect =
                tbCognoms.Text.Length <= 45 &&
                !tbCognoms.Text.Equals("") &&
                !tbCognoms.Text.Any(char.IsDigit);

            bool contrasenyaIsCorrect =
                tbContrasenya.Text.Length <= 256 &&
                tbContrasenya.Text.Length >= 8;

            bool contrasenyaRepIsCorrect =
                tbRepContrasenya.Text.Equals(tbContrasenya.Text);

            if (correuIsCorrect && nomIsCorrect && cognomsIsCorrect && contrasenyaIsCorrect && contrasenyaRepIsCorrect)
            {
                return true;
            }
            else
            {
                String err = "";

                if (!correuIsCorrect)
                {
                    err += "El correo introducido no es valido. Requerda que no puede estar vacio, debe tener un @ y un dominio+"+"\n";
                }
                if (!nomIsCorrect)
                {
                    err += "El nombre introducido no es valido. Requerda que no puede tener numeros ni espacios, y no puede estar vacio" + "\n";
                }
                if (!cognomsIsCorrect)
                {
                    err += "Los apellidos introducidos no son validos. Recuerda que no pueden tener numeros ni estar vacio" + "\n";
                }
                if (!contrasenyaIsCorrect)
                {
                    err += "La contrasenya introducida es erronea. Requerda que deve tener minimo 8 caracteres" + "\n";
                }
                if (!contrasenyaRepIsCorrect)
                {
                    err += "La contrasenya introducida y la repetida deven ser iguales";
                }
                MessageBox.Show(err, "¡ ERROR !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
