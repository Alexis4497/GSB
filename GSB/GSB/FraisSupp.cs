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
    public partial class FraisSupp : Form
    {
        
        public string dateChoisie;
        public FraisSupp()
        {
            InitializeComponent();
        }
        
        private void label5_Click(object sender, EventArgs e)
        {

        }
       public string getdateChoisie()
        {
            return this.dateChoisie;
        }

        public void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateChoisie = monthCalendar1.SelectionRange.Start.ToShortDateString();
           
            textBox5.Text = dateChoisie;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            monthCalendar1.ResetText();
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalAutresFrais;
            totalAutresFrais = int.Parse(textBox2.Text) * int.Parse(textBox3.Text);
            textBox4.Text = totalAutresFrais.ToString();
        }
        public string libelleFrais;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            libelleFrais = textBox1.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        
        public string quantiteFs;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            quantiteFs = textBox2.Text;
        }
        public string prixFs;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            quantiteFs = textBox3.Text;
        }

        private void ajoutFrais_Click(object sender, EventArgs e)
        {
            Remboursement fRemboursement = new Remboursement() ;
            fRemboursement.textBox11.Text = textBox5.Text;
            fRemboursement.textBox12.Text = textBox1.Text;
            fRemboursement.textBox13.Text = textBox2.Text;
            fRemboursement.textBox14.Text = textBox3.Text;
            fRemboursement.textBox15.Text = textBox4.Text;
          
            
            MessageBox.Show("Votre Frais Supplémentaire à bien été ajouté !");
            fRemboursement.Show();
            this.Close();
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        public string datefs;
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            datefs = textBox5.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           DialogResult confirmAnnuler = MessageBox.Show("Êtes vous sûr de vouloir annuler la saisie en cours ?", "Annuler", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
           if(confirmAnnuler == DialogResult.OK)
            {
                this.Close();
            }
           else if (confirmAnnuler == DialogResult.Cancel)
            {
                FraisSupp fFraisSupp = new FraisSupp();
                fFraisSupp.Close();
            }
        }
    }
}
