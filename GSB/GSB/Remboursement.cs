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
    public partial class Remboursement : Form
    {
        private GSB_ZinadeDataSet maConnexion;
        public Remboursement()
        {
            

            InitializeComponent();
            maConnexion = new GSB_ZinadeDataSet();
            gSB_ZinadeDataSet = maConnexion;
            
        }
       
        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void labelTypevehicule_Click(object sender, EventArgs e)
        {
            //labelTypevehicule.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ouvrir la page AutresFrais
           FraisSupp fFraisSupp = new FraisSupp();
            fFraisSupp.Show();
           
            //Change directement les labels de la form Remboursements par les données saisies dans la form FraisSupp 
            label17.Text = fFraisSupp.dateChoisie;
            label18.Text = fFraisSupp.textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {


            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
            textBox6.ResetText();
            textBox7.ResetText();
            textBox8.ResetText();
            textBox9.ResetText();
            textBox10.ResetText();
            textBox11.ResetText();
            textBox12.ResetText();
            textBox13.ResetText();
            textBox14.ResetText();
            textBox15.ResetText();
        }
        
        private void Remboursement_Load(object sender, EventArgs e)
        {
           


        }


        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
           
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            maConnexion = new GSB_ZinadeDataSet();

            FraisForfait unFrais = new FraisForfait();
            unFrais.libelle = textBox12.Text;
            

           MessageBox.Show("Votre fiche de frais à bien été enregistrée");
            
        }
       
        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
      


        }

        private void button4_Click(object sender, EventArgs e)
        {
            double totalNuitee = 0;
            double totalRepas = 0;
            double totalKm = 0;
            double totalFinal = 0;
            double totalFraisSupp = 0;
            totalNuitee += int.Parse(textBox4.Text) * int.Parse(textBox1.Text);
            totalRepas += int.Parse(textBox5.Text) * int.Parse(textBox2.Text);
            totalKm += int.Parse(textBox6.Text) * int.Parse(textBox3.Text);
            totalFraisSupp += int.Parse(textBox15.Text);
            totalFinal += totalKm + totalNuitee + totalRepas + totalFraisSupp;

            try
            {
                textBox8.Text = totalNuitee.ToString();
                textBox7.Text = totalRepas.ToString();
                textBox9.Text = totalKm.ToString();
                textBox10.Text = totalFinal.ToString();
            }
            catch
            {


            }
 }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void mesFichesDeFraisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void fichesDeFraisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double totalNuitee = 0;
            double totalRepas = 0;
            double totalKm = 0;
            double totalFinal = 0;
           
            totalNuitee += int.Parse(textBox4.Text) * int.Parse(textBox1.Text);
            totalRepas += int.Parse(textBox5.Text) * int.Parse(textBox2.Text);
            totalKm += int.Parse(textBox6.Text) * int.Parse(textBox3.Text);
           
            totalFinal += totalKm + totalNuitee + totalRepas;

            try
            {
                textBox8.Text = totalNuitee.ToString();
                textBox7.Text = totalRepas.ToString();
                textBox9.Text = totalKm.ToString();
               
            }
            catch
            {


            }
        
    }

        /*private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chiffres uniquement");
            }
            base.OnKeyPress(e);

            
        }*/
    }
    }


