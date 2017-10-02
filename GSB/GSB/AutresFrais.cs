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
    public partial class AutresFrais : Form
    {
        public AutresFrais()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            monthCalendar1.ResetText();
            textBox1.ResetText();
            textBox2.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
