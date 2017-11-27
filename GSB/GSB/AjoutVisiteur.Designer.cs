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
            this.laboBox = new System.Windows.Forms.TextBox();
            this.idLaboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.secteurBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cpBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.frstNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gSB_ZinadeDataSet = new GSB.GSB_ZinadeDataSet();
            this.visiteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visiteurTableAdapter = new GSB.GSB_ZinadeDataSetTableAdapters.VisiteurTableAdapter();
            this.tableAdapterManager = new GSB.GSB_ZinadeDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_ZinadeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // laboBox
            // 
            this.laboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.laboBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.laboBox.Enabled = false;
            this.laboBox.Location = new System.Drawing.Point(127, 317);
            this.laboBox.Name = "laboBox";
            this.laboBox.ReadOnly = true;
            this.laboBox.Size = new System.Drawing.Size(78, 20);
            this.laboBox.TabIndex = 45;
            // 
            // idLaboBox
            // 
            this.idLaboBox.FormattingEnabled = true;
            this.idLaboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.idLaboBox.Location = new System.Drawing.Point(84, 316);
            this.idLaboBox.Name = "idLaboBox";
            this.idLaboBox.Size = new System.Drawing.Size(37, 21);
            this.idLaboBox.TabIndex = 44;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(136, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 42;
            this.button3.Text = "Vider les champs";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(32, 363);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(97, 23);
            this.saveButton.TabIndex = 41;
            this.saveButton.Text = "Sauvegarder";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // secteurBox
            // 
            this.secteurBox.AccessibleDescription = "";
            this.secteurBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.secteurBox.FormattingEnabled = true;
            this.secteurBox.Location = new System.Drawing.Point(84, 287);
            this.secteurBox.Name = "secteurBox";
            this.secteurBox.Size = new System.Drawing.Size(121, 21);
            this.secteurBox.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(17, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "LABO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(17, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "SECTEUR";
            // 
            // cityBox
            // 
            this.cityBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cityBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cityBox.Location = new System.Drawing.Point(135, 261);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(100, 20);
            this.cityBox.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(17, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "VILLE";
            // 
            // cpBox
            // 
            this.cpBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cpBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpBox.Location = new System.Drawing.Point(84, 261);
            this.cpBox.Name = "cpBox";
            this.cpBox.Size = new System.Drawing.Size(45, 20);
            this.cpBox.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(17, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "ADRESSE";
            // 
            // addressBox
            // 
            this.addressBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.addressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressBox.Location = new System.Drawing.Point(84, 235);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(151, 20);
            this.addressBox.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(17, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "PRENOM";
            // 
            // frstNameBox
            // 
            this.frstNameBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.frstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frstNameBox.Location = new System.Drawing.Point(84, 209);
            this.frstNameBox.Name = "frstNameBox";
            this.frstNameBox.Size = new System.Drawing.Size(121, 20);
            this.frstNameBox.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(17, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "NOM";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Location = new System.Drawing.Point(84, 183);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(121, 20);
            this.nameBox.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GSB.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(47, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "AJOUT D\'UN VISITEUR";
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
            // AjoutVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.laboBox);
            this.Controls.Add(this.idLaboBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.secteurBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cpBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.frstNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameBox);
            this.Name = "AjoutVisiteur";
            this.Text = "AjoutVisiteur";
            this.Load += new System.EventHandler(this.AjoutVisiteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_ZinadeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox laboBox;
        private System.Windows.Forms.ComboBox idLaboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox secteurBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cpBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox frstNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private GSB_ZinadeDataSet gSB_ZinadeDataSet;
        private System.Windows.Forms.BindingSource visiteurBindingSource;
        private GSB_ZinadeDataSetTableAdapters.VisiteurTableAdapter visiteurTableAdapter;
        private GSB_ZinadeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}