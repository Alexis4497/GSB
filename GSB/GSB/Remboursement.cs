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
        public Remboursement()
        {
            InitializeComponent();
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
           // AutresFrais FautresFrais = new AutresFrais();
           // FautresFrais.Show();
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
                textBox10.Text = totalFinal.ToString();
            }
            catch
            {

                
            }



        }
    }
   
}
