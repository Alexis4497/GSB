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
    public partial class FraisSupp : Remboursement
    {
        
        public string dateChoisie;
        public FraisSupp()
        {
            
            InitializeComponent();
            dateChoisie = monthCalendar1.SelectionRange.Start.ToShortDateString();
           
          

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
           
           
            label6.Text = dateChoisie;
           
            
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            monthCalendar1.ResetText();
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
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
            
        }
    }
}
