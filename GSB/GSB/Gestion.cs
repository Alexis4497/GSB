﻿using System;
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
    public partial class Gestion : Form
    {
        public Gestion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            visualVisiteur Fvisualvisiteur = new visualVisiteur();
            this.Hide();
            Fvisualvisiteur.Show();
        }

        private void visiteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }
    }
}