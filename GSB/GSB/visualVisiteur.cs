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
            laboBox.Enabled = true;

            nameBox.ReadOnly = false;
            frstNameBox.ReadOnly = false;
            addressBox.ReadOnly = false;
            cpBox.ReadOnly = false;
            cityBox.ReadOnly = false;
        }
        private void selectButton_Click(object sender, EventArgs e)
        {
            idLaboBox.Text = visiteurDataGridView.CurrentRow.Cells[0].Value.ToString();
            nameBox.Text = visiteurDataGridView.CurrentRow.Cells[1].Value.ToString();
            frstNameBox.Text = visiteurDataGridView.CurrentRow.Cells[2].Value.ToString();
            cityBox.Text = visiteurDataGridView.CurrentRow.Cells[5].Value.ToString();
            cpBox.Text = visiteurDataGridView.CurrentRow.Cells[4].Value.ToString();
            addressBox.Text = visiteurDataGridView.CurrentRow.Cells[3].Value.ToString();
            idBox.Text = visiteurDataGridView.CurrentRow.Cells[6].Value.ToString();
            secteurBox.ResetText();
            var LQuery2 = from v in Model.MaConnexion.Visiteur.ToArray()
                          join s in Model.MaConnexion.Secteur.ToArray()
                          on v.idVisiteur equals s.idVisiteur
                          where v.identifiant == visiteurDataGridView.CurrentRow.Cells[6].Value.ToString()
                          select new
                          {
                              libSecteur = s.libSecteur
                          };

            foreach (var s in LQuery2)
            {                
                secteurBox.Text = s.libSecteur;               
            }
            var libLabo = from v in Model.MaConnexion.Visiteur.ToArray()
                          join l in Model.MaConnexion.Laboratoire.ToArray()
                          on v.idLabo equals l.idLabo
                          where v.identifiant == visiteurDataGridView.CurrentRow.Cells[6].Value.ToString()
                          select new
                          {
                              nomLabo = l.nomLabo
                          };

            foreach (var l in libLabo)
            {
                laboBox.Text = l.nomLabo;
            }
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
            idLaboBox.ResetText();
            visiteurDataGridView.Visible = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmDeconnect = MessageBox.Show("Voulez-vous vous sauvegarder vos modifications sur la base de données ?", "Enregistrement", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (confirmDeconnect == DialogResult.Yes)
            {

                var SavetoDB1 = from v in Model.MaConnexion.Visiteur.ToArray()                               
                               where v.identifiant == visiteurDataGridView.CurrentRow.Cells[6].Value.ToString()                               
                               select v;
                foreach (Visiteur v in SavetoDB1)
                {
                    v.nom = nameBox.Text;
                    v.prenom = frstNameBox.Text;
                    v.rue = addressBox.Text;
                    v.ville = cityBox.Text;
                    v.cp = cpBox.Text;
                    v.idLabo = int.Parse(idLaboBox.Text);
                }
                try
                {
                    Model.MaConnexion.SaveChanges();
                    MessageBox.Show("La base de données a bien été mise à jour", "Mise à jour réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur lors de la mise à jour de la base de données", "Échec de la mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                idBox.ResetText();
                searchBox.ResetText();
                nameBox.ResetText();
                frstNameBox.ResetText();
                addressBox.ResetText();
                cpBox.ResetText();
                cityBox.ResetText();
                secteurBox.ResetText();
                laboBox.ResetText();
                idLaboBox.ResetText();
                visiteurDataGridView.Visible = false;
                
            }
        }

        private void idLaboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(idLaboBox.Text) == 1)
            {
                laboBox.Text = "Swiss";
            }
            else if (int.Parse(idLaboBox.Text) == 2)
            {
                laboBox.Text = "Bourdin";
            }
            else
            {
                laboBox.Text = "Autres";
            }
            }

        private void addVisiteur_Click(object sender, EventArgs e)
        {
            var inserttoDB =    from v in Model.MaConnexion.Visiteur.ToArray()
                            where v.identifiant == visiteurDataGridView.CurrentRow.Cells[6].Value.ToString()
                            select v;
            foreach (Visiteur v in inserttoDB)
            {
                v.identifiant = (frstNameBox.Text.Substring(0, 1) + nameBox.Text).ToLower();
                v.nom = nameBox.Text;
                v.prenom = frstNameBox.Text;
                v.rue = addressBox.Text;
                v.ville = cityBox.Text;
                v.cp = cpBox.Text;
                v.idLabo = int.Parse(idLaboBox.Text);
            }
        }
    }
    }

