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
        private RAPPORT vRapport;
        Accueil login = new Accueil();
        public RapportVisiteur()
        {
            login.VerifConnect = true;
            if (login.VerifConnect == true)
            {
                InitializeComponent();
                button5.Hide();
                button7.Hide();
                comboBox1.Hide();
                dateTimePicker1.Hide();
                comboBox2.Hide();
                textBox2.Hide();
                button6.Hide();
                label6.Hide();
                dataGridView3.Hide();
                button8.Hide();

             /*   var filteredData = Model.MaConnexion.RAPPORT.ToList();
                bsRapport.DataSource = filteredData;

                this.rapport(); */
            }
            else
            {
                MessageBox.Show("Vous devez être connecté pour accéder à ce formulaire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                login.Show();
            }
            
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
                 textBox4.Text = unRapport.MOTIF.libMotif.ToString();
                 textBox5.Text = unRapport.bilan.ToString();
                 // textBox4.Text = unRapport..ToString();
                 bsMedecin.DataSource = Model.MaConnexion.MEDECIN.ToList()
                             .Where(x => x.idMedecin == int.Parse(unRapport.idMedecin.ToString()))
                             .Select(x => new { x.idMedecin, info = x.nom + " " + x.prenom })
                             .OrderBy(x => x.info);


                 bsMedecin2.DataSource = Model.MaConnexion.MEDECIN.ToList()
                              .Where(x => x.idMedecin == int.Parse(unRapport.idMedecin.ToString()));
                 dataGridView2.Hide();
                 dataGridView2.DataSource = bsMedecin2;


  		  
             BindingSource MonRapport = new BindingSource();		 
                comboMedecin.ValueMember = "idMedecin";
                 comboMedecin.DisplayMember = "info";
                 comboMedecin.DataSource = bsMedecin;
               
                 bsOffre.DataSource = Model.MaConnexion.OFFRIR.ToList()
                             .Select(x => new { x.idMedicament, x.quantite, x.idRapport})
                             .Where(x => x.idRapport == int.Parse(unRapport.idRapport.ToString()))  ;

                // bsPresenter.DataSource = Model.MaConnexion.RAPPORT.Presenter.tolist();
                     
              /*   foreach (BindingSource bsOffre in uneOffre)
                 {
                     bsMedicamen.DataSource = Model.MaConnexion.MEDICAMENT.ToList()
                            .Where(x => x.idMedicament == int.Parse(unRapport.idMedecin.ToString()))
                            ;
                 }*/

                 dataGridView1.DataSource = bsOffre;
                 this.vRapport = unRapport;
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


        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            Modif.Hide();
            button3.Hide();
            button5.Show();
            comboBox1.Show();
            dataGridView1.Hide();
            dataGridView3.Show();
            button4.Hide();
            dateTimePicker1.Show();
            comboBox2.Show();
            textBox2.Show();
            button6.Show();
            label6.Show();
            textBox1.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            button8.Show();

            

            bsMedecin2.DataSource = Model.MaConnexion.MOTIF.ToList();



            // textBox4.Text = unRapport..ToString();
            bsMedecin.DataSource = Model.MaConnexion.MEDECIN.ToList()
                            .Select(x => new { x.idMedecin, info = x.nom + " " + x.prenom })
                             .OrderBy(x => x.info);

            comboBox1.ValueMember = "idMotif";
            comboBox1.DisplayMember = "libMotif";
            comboBox1.DataSource = bsMedecin2;

            try
            {
                textBox6.Text = vRapport.REMPLACANT.nom;
            }catch
            {
                textBox6.Text = "Nom";
            }

            try
            {
                textBox7.Text = vRapport.REMPLACANT.prenom;
            }
            catch 
            {
                textBox7.Text = "Prenom";
            }
            try
            {
                numericUpDown1.Value = decimal.Parse(vRapport.coef.ToString());
            }
            catch
            {
                numericUpDown1.Value = decimal.Parse("1");
            }
                

            comboMedecin.ValueMember = "idMedecin";
            comboMedecin.DisplayMember = "info";
            comboMedecin.DataSource = bsMedecin;


            bsMedicamen.DataSource = Model.MaConnexion.MEDICAMENT.ToList();
            comboBox2.ValueMember = "idMedicament";
            comboBox2.DisplayMember = "nomCommercial";
            comboBox2.DataSource = bsMedicamen;

            dataGridView3.ColumnCount = 3;

            dataGridView3.Columns[0].Name = "idMedicament";
            dataGridView3.Columns[1].Name = "Nom Medicament";
            dataGridView3.Columns[2].Name = "Quantité";

            
        }

        private void button5_Click(object sender, EventArgs e){
          // enregistrement new
           

          /*  try
            {*/
                RAPPORT newRapport = new RAPPORT();
                newRapport.idMedecin = comboMedecin.SelectedIndex;
                newRapport.dateRapport = dateTimePicker1.Value;
                newRapport.idMotif =  comboBox1.SelectedIndex;
                newRapport.bilan = textBox5.Text;
                newRapport.coef = int.Parse(numericUpDown1.Value.ToString());

                REMPLACANT newRempla = new REMPLACANT();
                newRempla.nom = textBox6.Text;
                newRempla.prenom = textBox7.Text;

                newRapport.REMPLACANT = newRempla;

                Model.MaConnexion.RAPPORT.Add(newRapport);
                Model.MaConnexion.SaveChanges();

                


                int i;
                for (i = 0; i < ((dataGridView3.Rows.Count) - 1); i++)
                {
                    OFFRIR newOffrir = new OFFRIR();
                    newOffrir.idMedicament = dataGridView3.Rows[i].Cells[0].Value.ToString();
                    newOffrir.idRapport = int.Parse(newRapport.idRapport.ToString());
                    newOffrir.quantite = int.Parse(dataGridView3.Rows[i].Cells[2].Value.ToString());
                    Model.MaConnexion.OFFRIR.Add(newOffrir);
                    Model.MaConnexion.SaveChanges();

                }
               

                

                MessageBox.Show("Enregistrement fait");


        /*    }catch (Exception  erreur){
                MessageBox.Show("Erreur : " + erreur);
            }
            */




            button1.Show();
            button2.Show();
            Modif.Show();
            button3.Show();
            button5.Hide();
            comboBox1.Hide();
            dataGridView1.Show();
            button5.Hide();
            dateTimePicker1.Hide();
            dataGridView3.Hide();
            comboBox2.Hide();
            textBox2.Hide();
            button6.Hide();
            label6.Hide();

            

            rapport();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Add(comboBox2.SelectedIndex, comboBox2.Text, textBox2.Text);
        }

        private void Modif_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            Modif.Hide();
            button3.Hide();
            button7.Show();
            comboBox1.Show();
            dataGridView1.Hide();
            dataGridView3.Show();
            button4.Hide();
            dateTimePicker1.Show();
            comboBox2.Show();
            textBox2.Show();
            button6.Show();
            label6.Show();
            button8.Show();

          //  dateTimePicker1.Value(this.vRapport.dateRapport);


            bsMedecin2.DataSource = Model.MaConnexion.MOTIF.ToList();



           // comboBox1.SelectedItem() = unRapport.ToString();
            bsMedecin.DataSource = Model.MaConnexion.MEDECIN.ToList()
                            .Select(x => new { x.idMedecin, info = x.nom + " " + x.prenom })
                             .OrderBy(x => x.info);

            comboBox1.ValueMember = "idMotif";
            comboBox1.DisplayMember = "libMotif";
            comboBox1.DataSource = bsMedecin2;

           


            comboMedecin.ValueMember = "idMedecin";
            comboMedecin.DisplayMember = "info";
            comboMedecin.DataSource = bsMedecin;


            bsMedicamen.DataSource = Model.MaConnexion.MEDICAMENT.ToList();
            comboBox2.ValueMember = "idMedicament";
            comboBox2.DisplayMember = "nomCommercial";
            comboBox2.DataSource = bsMedicamen;

            dataGridView3.ColumnCount = 3;

            dataGridView3.Columns[0].Name = "idMedicament";
            dataGridView3.Columns[1].Name = "Nom Medicament";
            dataGridView3.Columns[2].Name = "Quantité";

            foreach (OFFRIR unoffrir in vRapport.OFFRIR)
            {
                dataGridView3.Rows.Add(unoffrir.idMedicament, unoffrir.MEDICAMENT.nomCommercial, unoffrir.quantite);
            }
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //enregistrement des modifs
            try
            {

                this.vRapport.idMedecin = comboMedecin.SelectedIndex;
                this.vRapport.dateRapport = dateTimePicker1.Value;
                this.vRapport.idMotif = comboBox1.SelectedIndex;
                this.vRapport.bilan = textBox5.Text;
                this.vRapport.coef = int.Parse(numericUpDown1.Value.ToString());
                this.vRapport.REMPLACANT.nom = textBox6.Text;
                this.vRapport.REMPLACANT.prenom = textBox7.Text;

                int i;
                for (i = 0; i < ((dataGridView3.Rows.Count) - 1); i++)
                {
                    OFFRIR newOffrir = new OFFRIR();
                    newOffrir.idMedicament = dataGridView3.Rows[i].Cells[0].Value.ToString();
                    newOffrir.idRapport = int.Parse(vRapport.idRapport.ToString());
                    newOffrir.quantite = int.Parse(dataGridView3.Rows[i].Cells[2].Value.ToString());
                    Model.MaConnexion.OFFRIR.Add(newOffrir);
                    Model.MaConnexion.SaveChanges();

                };

                Model.MaConnexion.SaveChanges();

                MessageBox.Show("Enregistrement fait");
               

            }
            catch (Exception erreur)
            {
                MessageBox.Show("Erreur : " + erreur);
            }





            button1.Show();
            button2.Show();
            Modif.Show();
            button3.Show();
            button5.Hide();
            comboBox1.Hide();
            dataGridView1.Show();
            button7.Hide();
            dateTimePicker1.Hide();
            dataGridView3.Hide();
            comboBox2.Hide();
            textBox2.Hide();
            button6.Hide();
            label6.Hide();



            rapport();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button1.Show();
            button2.Show();
            Modif.Show();
            button3.Show();
            button5.Hide();
            comboBox1.Hide();
            dataGridView1.Show();
            button5.Hide();
            dateTimePicker1.Hide();
            dataGridView3.Hide();
            comboBox2.Hide();
            textBox2.Hide();
            button6.Hide();
            label6.Hide();
            button7.Hide();
            button8.Hide();

            rapport();
        }



    }
}
