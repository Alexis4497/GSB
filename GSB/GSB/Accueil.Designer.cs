namespace GSB
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label identifiantLabel;
            System.Windows.Forms.Label passwordLabel;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gSB_ZinadeDataSet = new GSB.GSB_ZinadeDataSet();
            this.visiteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visiteurTableAdapter = new GSB.GSB_ZinadeDataSetTableAdapters.VisiteurTableAdapter();
            this.tableAdapterManager = new GSB.GSB_ZinadeDataSetTableAdapters.TableAdapterManager();
            this.identifiantTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            identifiantLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_ZinadeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // identifiantLabel
            // 
            identifiantLabel.AutoSize = true;
            identifiantLabel.Location = new System.Drawing.Point(60, 185);
            identifiantLabel.Name = "identifiantLabel";
            identifiantLabel.Size = new System.Drawing.Size(55, 13);
            identifiantLabel.TabIndex = 8;
            identifiantLabel.Text = "identifiant:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(60, 228);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(55, 13);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "password:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(294, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // personneToolStripMenuItem
            // 
            this.personneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visiteurToolStripMenuItem,
            this.médecinToolStripMenuItem});
            this.personneToolStripMenuItem.Name = "personneToolStripMenuItem";
            this.personneToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.personneToolStripMenuItem.Text = "Personne";
            // 
            // visiteurToolStripMenuItem
            // 
            this.visiteurToolStripMenuItem.Name = "visiteurToolStripMenuItem";
            this.visiteurToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.visiteurToolStripMenuItem.Text = "Visiteur";
            // 
            // médecinToolStripMenuItem
            // 
            this.médecinToolStripMenuItem.Name = "médecinToolStripMenuItem";
            this.médecinToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.médecinToolStripMenuItem.Text = "Médecin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GSB.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(63, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
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
            // identifiantTextBox
            // 
            this.identifiantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visiteurBindingSource, "identifiant", true));
            this.identifiantTextBox.Location = new System.Drawing.Point(121, 182);
            this.identifiantTextBox.Name = "identifiantTextBox";
            this.identifiantTextBox.Size = new System.Drawing.Size(116, 20);
            this.identifiantTextBox.TabIndex = 9;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visiteurBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(121, 225);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '•';
            this.passwordTextBox.Size = new System.Drawing.Size(116, 20);
            this.passwordTextBox.TabIndex = 10;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Fermer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(294, 332);
            this.Controls.Add(this.button2);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(identifiantLabel);
            this.Controls.Add(this.identifiantTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(310, 370);
            this.MinimumSize = new System.Drawing.Size(310, 370);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_ZinadeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visiteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médecinToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private GSB_ZinadeDataSet gSB_ZinadeDataSet;
        private System.Windows.Forms.BindingSource visiteurBindingSource;
        private GSB_ZinadeDataSetTableAdapters.VisiteurTableAdapter visiteurTableAdapter;
        private GSB_ZinadeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox identifiantTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button button2;
    }
}

