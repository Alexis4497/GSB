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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox2.Hide();
        }

        private void labelTypevehicule_Click(object sender, EventArgs e)
        {
            labelTypevehicule.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
