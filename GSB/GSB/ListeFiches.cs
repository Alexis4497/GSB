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
    public partial class ListeFiches : Form
    {
        private GSB_ZinadeDataSet maConnexion;
        public ListeFiches()
        {
            InitializeComponent();
            maConnexion = new GSB_ZinadeDataSet();
            bindingSource1.DataSource = maConnexion.fichefrais.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListeFiches_Load(object sender, EventArgs e)
        {
           
        }
    }
}
