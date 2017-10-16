using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GSB
{
    public partial class RapportVisiteur : Form
    {
        public RapportVisiteur()
        {
            InitializeComponent();
        }

       
        private void RapportVisiteur_Load(object sender, EventArgs e)
        {
            var filteredData = Model.MaConnexion.RAPPORT.ToList();
                            // .Select(x => new { x.idMedecin, info = x.nom + " " + x.prenom })		                //.Where(x => x.idMedecin == int.Parse(comboMedecin.SelectedValue.ToString()))
                        // .OrderBy(x => x.info);


            bsRapport.DataSource = filteredData;

             this.rapport();

            /*

            bsMedecin.DataSource = Model.MaConnexion.MEDECIN.ToList()
                            .Select(x => new { x.idMedecin, info = x.nom + " " + x.prenom })
                            .OrderBy(x => x.info);


            comboMedecin.ValueMember = "idMedecin";
            comboMedecin.DisplayMember = "info";
            comboMedecin.DataSource = bsMedecin;

            bsMedecin.DataSource = Model.MaConnexion.RAPPORT.ToList();
            */
        }

        public void rapport()
        {
            try  {
               // MessageBox.Show("test");
                 RAPPORT unRapport = (RAPPORT)bsRapport.Current;
                 textBox1.Text = unRapport.idRapport.ToString();
                 textBox3.Text = unRapport.dateRapport.ToString();
                 // textBox4.Text = unRapport..ToString();
                 bsMedecin.DataSource = Model.MaConnexion.MEDECIN.ToList()
                             .Where(x => x.idMedecin == int.Parse(unRapport.idMedecin.ToString()))
                             .Select(x => new { x.idMedecin, info = x.nom + " " + x.prenom })
                             .OrderBy(x => x.info);
  		  
  		  
             BindingSource MonRapport = new BindingSource();		 
                comboMedecin.ValueMember = "idMedecin";
                 comboMedecin.DisplayMember = "info";
                 comboMedecin.DataSource = bsMedecin;
             }
             catch
             {
                 textBox1.Text = "Aucun";
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bsRapport.MoveNext();
            this.rapport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bsRapport.MovePrevious();
            this.rapport();
        }
    }
}
