using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB
{
    public partial class Gestion : Form
    {
        Accueil login = new Accueil();
        public Gestion()
        {
            if (login.VerifConnect == true)
            {
                InitializeComponent();
            }
            else
            {
                MessageBox.Show("Vous devez être connecté pour accéder à ce formulaire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                login.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            visualVisiteur Fvisualvisiteur = new visualVisiteur();
            this.Hide();
            Fvisualvisiteur.Show();
        }

        private void visiteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void Gestion_Load(object sender, EventArgs e)
        {

        }
    }
}
