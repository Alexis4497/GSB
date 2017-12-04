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
            System.Windows.Forms.Label lblId;
            System.Windows.Forms.Label lblMdp;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnValider = new System.Windows.Forms.Button();
            this.gSB_ZinadeDataSet = new GSB.GSB_ZinadeDataSet();
            this.visiteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visiteurTableAdapter = new GSB.GSB_ZinadeDataSetTableAdapters.VisiteurTableAdapter();
            this.tableAdapterManager = new GSB.GSB_ZinadeDataSetTableAdapters.TableAdapterManager();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.imgGSB = new System.Windows.Forms.PictureBox();
            this.bsConnect = new System.Windows.Forms.BindingSource(this.components);
            lblId = new System.Windows.Forms.Label();
            lblMdp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_ZinadeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConnect)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new System.Drawing.Point(57, 185);
            lblId.Name = "lblId";
            lblId.Size = new System.Drawing.Size(58, 13);
            lblId.TabIndex = 8;
            lblId.Text = "identifiant :";
            // 
            // lblMdp
            // 
            lblMdp.AutoSize = true;
            lblMdp.Location = new System.Drawing.Point(39, 228);
            lblMdp.Name = "lblMdp";
            lblMdp.Size = new System.Drawing.Size(76, 13);
            lblMdp.TabIndex = 9;
            lblMdp.Text = "mot de passe :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(294, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(63, 272);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 31);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click_1);
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
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visiteurBindingSource, "identifiant", true));
            this.txtId.Location = new System.Drawing.Point(121, 182);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(116, 20);
            this.txtId.TabIndex = 9;
            this.txtId.Text = "test";
            // 
            // txtMdp
            // 
            this.txtMdp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visiteurBindingSource, "password", true));
            this.txtMdp.Location = new System.Drawing.Point(121, 225);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '•';
            this.txtMdp.Size = new System.Drawing.Size(116, 20);
            this.txtMdp.TabIndex = 10;
            this.txtMdp.Text = "test";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(162, 272);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 31);
            this.btnFermer.TabIndex = 11;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click_1);
            // 
            // imgGSB
            // 
            this.imgGSB.Image = global::GSB.Properties.Resources.logo;
            this.imgGSB.Location = new System.Drawing.Point(63, 27);
            this.imgGSB.Name = "imgGSB";
            this.imgGSB.Size = new System.Drawing.Size(174, 132);
            this.imgGSB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGSB.TabIndex = 6;
            this.imgGSB.TabStop = false;
            // 
            // Accueil
            // 
            this.AcceptButton = this.btnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(294, 332);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(lblMdp);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.imgGSB);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(310, 370);
            this.MinimumSize = new System.Drawing.Size(310, 370);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gSB_ZinadeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConnect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.PictureBox imgGSB;
        private GSB_ZinadeDataSet gSB_ZinadeDataSet;
        private System.Windows.Forms.BindingSource visiteurBindingSource;
        private GSB_ZinadeDataSetTableAdapters.VisiteurTableAdapter visiteurTableAdapter;
        private GSB_ZinadeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.BindingSource bsConnect;
    }
}

