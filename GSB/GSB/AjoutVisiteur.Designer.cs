namespace GSB
{
    partial class AjoutVisiteur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtLabo = new System.Windows.Forms.TextBox();
            this.chkLabo = new System.Windows.Forms.ComboBox();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.chkSecteur = new System.Windows.Forms.ComboBox();
            this.lblLabo = new System.Windows.Forms.Label();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.imgGSB = new System.Windows.Forms.PictureBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.gSB_ZinadeDataSet = new GSB.GSB_ZinadeDataSet();
            this.visiteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visiteurTableAdapter = new GSB.GSB_ZinadeDataSetTableAdapters.VisiteurTableAdapter();
            this.tableAdapterManager = new GSB.GSB_ZinadeDataSetTableAdapters.TableAdapterManager();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgGSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_ZinadeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLabo
            // 
            this.txtLabo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtLabo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLabo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtLabo.Enabled = false;
            this.txtLabo.Location = new System.Drawing.Point(127, 317);
            this.txtLabo.Name = "txtLabo";
            this.txtLabo.ReadOnly = true;
            this.txtLabo.Size = new System.Drawing.Size(78, 20);
            this.txtLabo.TabIndex = 45;
            // 
            // chkLabo
            // 
            this.chkLabo.FormattingEnabled = true;
            this.chkLabo.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.chkLabo.Location = new System.Drawing.Point(84, 316);
            this.chkLabo.Name = "chkLabo";
            this.chkLabo.Size = new System.Drawing.Size(37, 21);
            this.chkLabo.TabIndex = 44;
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Location = new System.Drawing.Point(32, 363);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(97, 23);
            this.btnSauvegarder.TabIndex = 41;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // chkSecteur
            // 
            this.chkSecteur.AccessibleDescription = "";
            this.chkSecteur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkSecteur.FormattingEnabled = true;
            this.chkSecteur.Location = new System.Drawing.Point(84, 287);
            this.chkSecteur.Name = "chkSecteur";
            this.chkSecteur.Size = new System.Drawing.Size(121, 21);
            this.chkSecteur.TabIndex = 40;
            // 
            // lblLabo
            // 
            this.lblLabo.AutoSize = true;
            this.lblLabo.BackColor = System.Drawing.Color.Transparent;
            this.lblLabo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLabo.Location = new System.Drawing.Point(17, 316);
            this.lblLabo.Name = "lblLabo";
            this.lblLabo.Size = new System.Drawing.Size(39, 13);
            this.lblLabo.TabIndex = 39;
            this.lblLabo.Text = "LABO";
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.BackColor = System.Drawing.Color.Transparent;
            this.lblSecteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecteur.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSecteur.Location = new System.Drawing.Point(17, 290);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(65, 13);
            this.lblSecteur.TabIndex = 38;
            this.lblSecteur.Text = "SECTEUR";
            // 
            // txtVille
            // 
            this.txtVille.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVille.Location = new System.Drawing.Point(135, 261);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(100, 20);
            this.txtVille.TabIndex = 37;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.BackColor = System.Drawing.Color.Transparent;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblVille.Location = new System.Drawing.Point(17, 264);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(41, 13);
            this.lblVille.TabIndex = 36;
            this.lblVille.Text = "VILLE";
            // 
            // txtCp
            // 
            this.txtCp.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCp.Location = new System.Drawing.Point(84, 261);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(45, 20);
            this.txtCp.TabIndex = 35;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.BackColor = System.Drawing.Color.Transparent;
            this.lblAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAdresse.Location = new System.Drawing.Point(17, 238);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(65, 13);
            this.lblAdresse.TabIndex = 34;
            this.lblAdresse.Text = "ADRESSE";
            // 
            // txtAdresse
            // 
            this.txtAdresse.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdresse.Location = new System.Drawing.Point(84, 235);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(151, 20);
            this.txtAdresse.TabIndex = 33;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.BackColor = System.Drawing.Color.Transparent;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPrenom.Location = new System.Drawing.Point(17, 212);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(60, 13);
            this.lblPrenom.TabIndex = 32;
            this.lblPrenom.Text = "PRENOM";
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrenom.Location = new System.Drawing.Point(84, 209);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(121, 20);
            this.txtPrenom.TabIndex = 31;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNom.Location = new System.Drawing.Point(17, 186);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 30;
            this.lblNom.Text = "NOM";
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Location = new System.Drawing.Point(84, 183);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(121, 20);
            this.txtNom.TabIndex = 29;
            // 
            // imgGSB
            // 
            this.imgGSB.Image = global::GSB.Properties.Resources.logo;
            this.imgGSB.Location = new System.Drawing.Point(47, 25);
            this.imgGSB.Name = "imgGSB";
            this.imgGSB.Size = new System.Drawing.Size(174, 132);
            this.imgGSB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGSB.TabIndex = 46;
            this.imgGSB.TabStop = false;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitre.Location = new System.Drawing.Point(62, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(143, 13);
            this.lblTitre.TabIndex = 47;
            this.lblTitre.Text = "AJOUT D\'UN VISITEUR";
            // 
            // gSB_ZinadeDataSet
            // 
            this.gSB_ZinadeDataSet.DataSetName = "GSB_ZinadeDataSet";
            this.gSB_ZinadeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visiteurBindingSource
            // 
            this.visiteurBindingSource.DataMember = "Visiteur";
            this.visiteurBindingSource.DataSource = this.gSB_ZinadeDataSet;
            // 
            // visiteurTableAdapter
            // 
            this.visiteurTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EtatTableAdapter = null;
            this.tableAdapterManager.FAMILLETableAdapter = null;
            this.tableAdapterManager.fichefraisTableAdapter = null;
            this.tableAdapterManager.FraisForfaitTableAdapter = null;
            this.tableAdapterManager.LaboratoireTableAdapter = null;
            this.tableAdapterManager.LigneFraisForfaitTableAdapter = null;
            this.tableAdapterManager.LigneFraisHorsForfaitTableAdapter = null;
            this.tableAdapterManager.MEDECINTableAdapter = null;
            this.tableAdapterManager.MEDICAMENTTableAdapter = null;
            this.tableAdapterManager.MOTIFTableAdapter = null;
            this.tableAdapterManager.OFFRIRTableAdapter = null;
            this.tableAdapterManager.RAPPORTTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.SecteurTableAdapter = null;
            this.tableAdapterManager.SPECIALITETableAdapter = null;
            this.tableAdapterManager.TravaillerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GSB.GSB_ZinadeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisiteurTableAdapter = this.visiteurTableAdapter;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(136, 363);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 23);
            this.btnClear.TabIndex = 42;
            this.btnClear.Text = "Vider les champs";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AjoutVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 407);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.imgGSB);
            this.Controls.Add(this.txtLabo);
            this.Controls.Add(this.chkLabo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.chkSecteur);
            this.Controls.Add(this.lblLabo);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.txtCp);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtNom);
            this.MaximumSize = new System.Drawing.Size(282, 445);
            this.MinimumSize = new System.Drawing.Size(282, 445);
            this.Name = "AjoutVisiteur";
            this.Text = "AjoutVisiteur";
            this.Load += new System.EventHandler(this.AjoutVisiteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgGSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_ZinadeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLabo;
        private System.Windows.Forms.ComboBox chkLabo;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.ComboBox chkSecteur;
        private System.Windows.Forms.Label lblLabo;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.PictureBox imgGSB;
        private System.Windows.Forms.Label lblTitre;
        private GSB_ZinadeDataSet gSB_ZinadeDataSet;
        private System.Windows.Forms.BindingSource visiteurBindingSource;
        private GSB_ZinadeDataSetTableAdapters.VisiteurTableAdapter visiteurTableAdapter;
        private GSB_ZinadeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnClear;
    }
}