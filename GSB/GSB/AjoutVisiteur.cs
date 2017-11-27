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
            // TODO: cette ligne de code charge les données dans la table 'gSB_ZinadeDataSet.Visiteur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.visiteurTableAdapter.Fill(this.gSB_ZinadeDataSet.Visiteur);

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
        public string GenererId()
        {
            bool existID = false;
            const string validNumber = "1234567890";
            const string validAlpha = "abcdefghijklmnopqrstuvwxyz";
            StringBuilder res1 = new StringBuilder();
            StringBuilder res2 = new StringBuilder();
            StringBuilder res3 = new StringBuilder();
            Random rnd = new Random();
            var alph = res1.Append(validAlpha[rnd.Next(validAlpha.Length)]);
            var num1 = res2.Append(validNumber[rnd.Next(validNumber.Length)]).ToString();
            var num2 = res3.Append(validNumber[rnd.Next(validNumber.Length)]).ToString();
            var idVis = alph + num1 + num2;
            var verifId = from v in Model.MaConnexion.Visiteur.ToArray()
                          where v.idVisiteur == idVis
                          select v;
            foreach (Visiteur v in verifId)
            {
                existID = true;
            }
            if (existID == false)
            {
                return idVis;
            }
            else
            {
                GenererId();
            }
            return null;
            
        }
        //public string genererPseudo()
        private void saveButton_Click(object sender, EventArgs e)
        {

            Visiteur visit = new Visiteur()
            {
                idVisiteur = GenererId(),
                identifiant = (frstNameBox.Text.Substring(0, 1) + nameBox.Text).ToLower(),
                nom = nameBox.Text,
                prenom = frstNameBox.Text,
                rue = addressBox.Text,
                ville = cityBox.Text,
                cp = cpBox.Text,
                idLabo = int.Parse(idLaboBox.Text),
                password = GenererMDP(5)
            };


            Model.MaConnexion.Visiteur.Add(visit);
            try
            {
                Model.MaConnexion.SaveChanges();
                DialogResult confirm = MessageBox.Show("Le compte a bien été créé. Veuillez noter le mot de passe, il va désormais être encrypté.\n Mot de passe :" + mdpNonCrypte, "Compte créé", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void visiteurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.visiteurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSB_ZinadeDataSet);

        }

        
    }
}
