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
            this.visiteurTableAdapter.Fill(this.gSB_ZinadeDataSet.Visiteur);
            // TODO: cette ligne de code charge les données dans la table 'gSB_ZinadeDataSet.Visiteur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.visiteurTableAdapter.Fill(this.gSB_ZinadeDataSet.Visiteur);
            // TODO: cette ligne de code charge les données dans la table 'gSB_ZinadeDataSet.Visiteur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.visiteurTableAdapter.Fill(this.gSB_ZinadeDataSet.Visiteur);
            menuStrip1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
