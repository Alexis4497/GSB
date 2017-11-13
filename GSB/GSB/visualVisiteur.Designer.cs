namespace GSB
{
    partial class visualVisiteur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.frstNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cpBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.secteurBox = new System.Windows.Forms.ComboBox();
            this.laboBox = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.gSB_ZinadeDataSet = new GSB.GSB_ZinadeDataSet();
            this.visiteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visiteurTableAdapter = new GSB.GSB_ZinadeDataSetTableAdapters.VisiteurTableAdapter();
            this.tableAdapterManager = new GSB.GSB_ZinadeDataSetTableAdapters.TableAdapterManager();
            this.visiteurDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_ZinadeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Enabled = false;
            this.nameBox.Location = new System.Drawing.Point(103, 137);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(121, 20);
            this.nameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "VISITEURS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chercher (Nom)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(36, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NOM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(36, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "PRENOM";
            // 
            // frstNameBox
            // 
            this.frstNameBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.frstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frstNameBox.Enabled = false;
            this.frstNameBox.Location = new System.Drawing.Point(103, 163);
            this.frstNameBox.Name = "frstNameBox";
            this.frstNameBox.ReadOnly = true;
            this.frstNameBox.Size = new System.Drawing.Size(121, 20);
            this.frstNameBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(36, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ADRESSE";
            // 
            // addressBox
            // 
            this.addressBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.addressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressBox.Enabled = false;
            this.addressBox.Location = new System.Drawing.Point(103, 189);
            this.addressBox.Name = "addressBox";
            this.addressBox.ReadOnly = true;
            this.addressBox.Size = new System.Drawing.Size(151, 20);
            this.addressBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(36, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "VILLE";
            // 
            // cpBox
            // 
            this.cpBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cpBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpBox.Enabled = false;
            this.cpBox.Location = new System.Drawing.Point(103, 215);
            this.cpBox.Name = "cpBox";
            this.cpBox.ReadOnly = true;
            this.cpBox.Size = new System.Drawing.Size(45, 20);
            this.cpBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(36, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "SECTEUR";
            // 
            // cityBox
            // 
            this.cityBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cityBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cityBox.Enabled = false;
            this.cityBox.Location = new System.Drawing.Point(154, 215);
            this.cityBox.Name = "cityBox";
            this.cityBox.ReadOnly = true;
            this.cityBox.Size = new System.Drawing.Size(100, 20);
            this.cityBox.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(36, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "LABO";
            // 
            // secteurBox
            // 
            this.secteurBox.FormattingEnabled = true;
            this.secteurBox.Location = new System.Drawing.Point(103, 242);
            this.secteurBox.Name = "secteurBox";
            this.secteurBox.Size = new System.Drawing.Size(121, 21);
            this.secteurBox.TabIndex = 15;
            // 
            // laboBox
            // 
            this.laboBox.FormattingEnabled = true;
            this.laboBox.Location = new System.Drawing.Point(103, 270);
            this.laboBox.Name = "laboBox";
            this.laboBox.Size = new System.Drawing.Size(121, 21);
            this.laboBox.TabIndex = 16;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(242, 65);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(32, 23);
            this.searchBtn.TabIndex = 18;
            this.searchBtn.Text = "OK";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(81, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Sauvegarder";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Vider les champs";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(463, 289);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 21;
            this.selectButton.Text = "Selectionner";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Visible = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Location = new System.Drawing.Point(103, 67);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(121, 20);
            this.searchBox.TabIndex = 22;
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
            // visiteurDataGridView
            // 
            this.visiteurDataGridView.AllowUserToAddRows = false;
            this.visiteurDataGridView.AllowUserToDeleteRows = false;
            this.visiteurDataGridView.AutoGenerateColumns = false;
            this.visiteurDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.visiteurDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.visiteurDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.visiteurDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visiteurDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9});
            this.visiteurDataGridView.DataSource = this.visiteurBindingSource;
            this.visiteurDataGridView.Location = new System.Drawing.Point(320, 63);
            this.visiteurDataGridView.MultiSelect = false;
            this.visiteurDataGridView.Name = "visiteurDataGridView";
            this.visiteurDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.visiteurDataGridView.Size = new System.Drawing.Size(364, 220);
            this.visiteurDataGridView.TabIndex = 23;
            this.visiteurDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idLabo";
            this.dataGridViewTextBoxColumn2.HeaderText = "idLabo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nom";
            this.dataGridViewTextBoxColumn3.HeaderText = "nom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ToolTipText = "test";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "prenom";
            this.dataGridViewTextBoxColumn4.HeaderText = "prenom";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "rue";
            this.dataGridViewTextBoxColumn11.HeaderText = "rue";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "cp";
            this.dataGridViewTextBoxColumn10.HeaderText = "cp";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ville";
            this.dataGridViewTextBoxColumn7.HeaderText = "ville";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "identifiant";
            this.dataGridViewTextBoxColumn9.HeaderText = "identifiant";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(36, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "ID";
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idBox.Cursor = System.Windows.Forms.Cursors.No;
            this.idBox.Enabled = false;
            this.idBox.Location = new System.Drawing.Point(103, 108);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(121, 20);
            this.idBox.TabIndex = 25;
            // 
            // visualVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::GSB.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(696, 412);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.visiteurDataGridView);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.laboBox);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(712, 450);
            this.MinimumSize = new System.Drawing.Size(712, 450);
            this.Name = "visualVisiteur";
            this.Text = "visualVisiteur";
            this.Load += new System.EventHandler(this.visualVisiteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gSB_ZinadeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox frstNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cpBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox secteurBox;
        private System.Windows.Forms.ComboBox laboBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.TextBox searchBox;
        private GSB_ZinadeDataSet gSB_ZinadeDataSet;
        private System.Windows.Forms.BindingSource visiteurBindingSource;
        private GSB_ZinadeDataSetTableAdapters.VisiteurTableAdapter visiteurTableAdapter;
        private GSB_ZinadeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView visiteurDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox idBox;
    }
}