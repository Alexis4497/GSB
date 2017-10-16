﻿using System;
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

            var filteredData = Model.MaConnexion.RAPPORT.ToList()
                //.Where(x => x.idMedecin == int.Parse(comboMedecin.SelectedValue.ToString()))
                    ;

            bsRapport.DataSource = filteredData;

            this.rapport();
            



        }
        public void rapport()
        {
            


            //BindingSource MonRapport = new BindingSource();

           // MonRapport.DataSource = bsRapport;
           // bsRapport.MoveFirst();

            try
            {
               // MessageBox.Show("test");
                RAPPORT unRapport = (RAPPORT)bsRapport.Current;
                textBox1.Text = unRapport.idRapport.ToString();
                textBox3.Text = unRapport.dateRapport.ToString();
                // textBox4.Text = unRapport..ToString();
                bsMedecin.DataSource = Model.MaConnexion.MEDECIN.ToList()
                            .Where(x => x.idMedecin == int.Parse(unRapport.idMedecin.ToString()))
                            .Select(x => new { x.idMedecin, info = x.nom + " " + x.prenom })
                            .OrderBy(x => x.info);


                comboMedecin.ValueMember = "idMedecin";
                comboMedecin.DisplayMember = "info";
                comboMedecin.DataSource = bsMedecin;
            }
            catch
            {
                textBox1.Text = "Aucun";
            }

			
            
        }


        private void comboMedecin_SelectedIndexChanged(object sender, EventArgs e)
        {
          
           

            
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

            bsMedecin.DataSource = Model.MaConnexion.RAPPORT.ToList();

        }

        private void bsMedecin_CurrentChanged(object sender, EventArgs e)
        {
            bsMedecin.DataSource = Model.MaConnexion.MEDECIN.ToList();
            MEDECIN vcurrent = (MEDECIN)bsMedecin.Current;
           // bsRapport = vcurrent.RAPPORT.ToList();

        }

    }
}
