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
    public partial class visualVisiteur : Form
    {
        public visualVisiteur()
        {
            InitializeComponent();
        }

        private void visualVisiteur_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gSB_ZinadeDataSet.Visiteur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.visiteurTableAdapter.Fill(this.gSB_ZinadeDataSet.Visiteur);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void visiteurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.visiteurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gSB_ZinadeDataSet);

        }

        private void visiteurDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var LQuery = Model.MaConnexion.Visiteur.ToList()
                           .Where(x => x.nom.ToLower().Contains(searchBox.Text))
                           .Select(x => new { x.idLabo, x.nom, x.prenom, x.ville, x.identifiant, })
                           .OrderBy(x => x.nom);
            visiteurBindingSource.DataSource = LQuery;
            visiteurDataGridView.DataSource = visiteurBindingSource;
            var rowVisiteur = visiteurBindingSource.Current;
            nameBox.Text = rowVisiteur.ToString();

            visiteurDataGridView.Columns[0].HeaderText = "IDLABO";
            visiteurDataGridView.Columns[1].HeaderText = "NOM";
            visiteurDataGridView.Columns[2].HeaderText = "PRENOM";
            visiteurDataGridView.Columns[3].HeaderText = "VILLE";
            visiteurDataGridView.Columns[4].HeaderText = "IDENT";


        }
    }
}
