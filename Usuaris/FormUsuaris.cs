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
    public partial class FormUsuaris : Form
    {
        private List<Usuari> llista;
        public FormUsuaris()
        {
            InitializeComponent();
        }
        private void FormUsuaris_Load(object sender, EventArgs e)
        {
            llista = SeguretatBd.select_users().ToList<Usuari>();
            dgUsuaris.AutoGenerateColumns = false;
            dgUsuaris.DataSource = llista;
        }
        private void msiAfegir_Click(object sender, EventArgs e)
        {
            FormUsuari f = new FormUsuari(llista);
            f.ShowDialog();
        }

        private void msiEsboorrar_Click(object sender, EventArgs e)
        {

        }

        private void msiSortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
