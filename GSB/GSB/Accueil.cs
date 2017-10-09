using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace GSB
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gSB_ZinadeDataSet.Visiteur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            //this.visiteurTableAdapter.Fill(this.gSB_ZinadeDataSet.Visiteur);
            // TODO: cette ligne de code charge les données dans la table 'gSB_ZinadeDataSet.Visiteur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            // this.visiteurTableAdapter.Fill(this.gSB_ZinadeDataSet.Visiteur);
            // TODO: cette ligne de code charge les données dans la table 'gSB_ZinadeDataSet.Visiteur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            //this.visiteurTableAdapter.Fill(this.gSB_ZinadeDataSet.Visiteur);
            
        }
        static string GetMd5Hash(MD5 MonMD5, string PasswdSaisi)
        {
            // step 1, calculate MD5 hash from input

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = MonMD5.ComputeHash(inputBytes);
            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            var filteredData = Model.MaConnexion.Visiteur.ToList()
                .Where(x => x.identifiant.Equals(identifiantTextBox.Text));
            if (filteredData.ToList().Count == 0)
            {
                MessageBox.Show("Votre identifiant est incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bsConnect.DataSource = filteredData; // application du filtre
                bsConnect.MoveFirst();
                Visiteur monuser = (Visiteur)bsConnect.Current;
                MD5 monMD5 = MD5.Create();
                string passwdCrypte = GetMd5Hash(monMD5, passwordTextBox.Text);
                string pswdc = monuser.password.Substring(2); // Pbs de l'hexa 0x sur sqlserver
                if (pswdc.Equals(passwdCrypte) || monuser.password.Equals(passwdCrypte))
                {
                    MessageBox.Show("Bienvenue sur GSB","Connexion réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Menu menu = new Menu();
                    this.Hide();
                    menu.Show();           

                }
                else
                {
                    MessageBox.Show("Votre mot de passe est incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void visiteurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.visiteurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSB_ZinadeDataSet);

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void identifiantTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
