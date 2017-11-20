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
    public partial class AjoutVisiteur : Form
    {
        string mdpNonCrypte;
        public AjoutVisiteur()
        {
            InitializeComponent();
        }

        private void AjoutVisiteur_Load(object sender, EventArgs e)
        {

        }
        static string getMd5Hash(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        public string GenererMDP(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyz1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            mdpNonCrypte = res.ToString();
            string mdpCrypte = getMd5Hash(res.ToString());
            return mdpCrypte;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            var inserttoDB = from v in Model.MaConnexion.Visiteur.ToArray()
                             //where v.identifiant == visiteurDataGridView.CurrentRow.Cells[6].Value.ToString()
                             select v;
            foreach (Visiteur v in inserttoDB)
            {
                v.identifiant = (frstNameBox.Text.Substring(0, 1) + nameBox.Text).ToLower();
                v.nom = nameBox.Text;
                v.prenom = frstNameBox.Text;
                v.rue = addressBox.Text;
                v.ville = cityBox.Text;
                v.cp = cpBox.Text;
                v.idLabo = int.Parse(idLaboBox.Text);
                v.password = GenererMDP(5);
            }
            try
            {
                Model.MaConnexion.SaveChanges();
                DialogResult confirm = MessageBox.Show("Le compte a bien été créé. Veuillez à bien noter le mot de passe, il va désormais être encrypté.\n Mot de passe :" + mdpNonCrypte, "Compte créé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (confirm == DialogResult.OK)
                {
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de la mise à jour de la base de données", "Échec de la mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
