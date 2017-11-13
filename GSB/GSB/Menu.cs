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
    public partial class Menu : Form
    {
        Accueil login = new Accueil();

        public Menu()
        {
           
            if (login.VerifConnect == true)
            {
                InitializeComponent();
                nom.Text = login.InfoUser;
            }
            else
            {
                MessageBox.Show("Vous devez être connecté pour accéder à ce formulaire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                login.Show();
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gestion gestion = new Gestion();
            this.Hide();
            gestion.Show();
        }

        private void disconnect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult confirmDeconnect = MessageBox.Show("Voulez-vous vous déconnecter ?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (confirmDeconnect == DialogResult.Yes)
            {
                login.VerifConnect = false;
                this.Hide();
                login.Show();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
