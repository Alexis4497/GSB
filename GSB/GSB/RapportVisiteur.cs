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

            bsMedecin.DataSource = Model.MaConnexion.MEDECIN.ToList()
                            .Select(x => new { x.idMedecin, info = x.nom + " " + x.prenom })
                            .OrderBy(x => x.info);


            comboMedecin.ValueMember = "idMedecin";
            comboMedecin.DisplayMember = "info";
            comboMedecin.DataSource = bsMedecin;



        }
    }
}
