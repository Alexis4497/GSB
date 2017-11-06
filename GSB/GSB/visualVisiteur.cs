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

 
        private void selectButton_Click(object sender, EventArgs e)
        {
            nameBox.Text = visiteurDataGridView.CurrentRow.Cells[1].Value.ToString();
            frstNameBox.Text = visiteurDataGridView.CurrentRow.Cells[2].Value.ToString();
            cityBox.Text = visiteurDataGridView.CurrentRow.Cells[4].Value.ToString();
            cpBox.Text = visiteurDataGridView.CurrentRow.Cells[5].Value.ToString();
            addressBox.Text = visiteurDataGridView.CurrentRow.Cells[3].Value.ToString();
            idBox.Text = visiteurDataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var LQuery = Model.MaConnexion.Visiteur.ToArray()
                           .Where(x => x.nom.ToLower().Contains(searchBox.Text))
                           .Select(x => new { x.idLabo, x.nom, x.prenom, x.ville, x.cp, x.rue, x.identifiant, })
                           .OrderBy(x => x.nom);
            visiteurBindingSource.DataSource = LQuery;
            visiteurDataGridView.DataSource = visiteurBindingSource;

            visiteurDataGridView.Columns[0].HeaderText = "IDLABO";
            visiteurDataGridView.Columns[1].HeaderText = "NOM";
            visiteurDataGridView.Columns[2].HeaderText = "PRENOM";
            visiteurDataGridView.Columns[3].HeaderText = "RUE";
            visiteurDataGridView.Columns[4].HeaderText = "CP";
            visiteurDataGridView.Columns[5].HeaderText = "VILLE";
            visiteurDataGridView.Columns[6].HeaderText = "ID";
            visiteurDataGridView.Visible = true;
            selectButton.Visible = true;
            nameBox.Enabled = true;
            frstNameBox.Enabled = true;
            addressBox.Enabled = true;
            cpBox.Enabled = true;
            cityBox.Enabled = true;
            secteurBox.Enabled = true;
            laboBox.Enabled = true;

            nameBox.ReadOnly = false;
            frstNameBox.ReadOnly = false;
            addressBox.ReadOnly = false;
            cpBox.ReadOnly = false;
            cityBox.ReadOnly = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            idBox.ResetText();
            searchBox.ResetText();
            nameBox.ResetText();
            frstNameBox.ResetText();
            addressBox.ResetText();
            cpBox.ResetText();
            cityBox.ResetText();
            secteurBox.ResetText();
            laboBox.ResetText();
        }

        
    }
}
