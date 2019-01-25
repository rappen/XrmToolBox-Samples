namespace D365SatSampleTool
{
    partial class SDV
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SDV));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridViews = new Cinteros.Xrm.CRMWinForm.CRMGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.entitiesDropdownControl1 = new xrmtb.XrmToolBox.Controls.EntitiesDropdownControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gridData = new Cinteros.Xrm.CRMWinForm.CRMGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFXB = new System.Windows.Forms.Button();
            this.chkLookup = new System.Windows.Forms.CheckBox();
            this.chkDbl = new System.Windows.Forms.CheckBox();
            this.chkId = new System.Windows.Forms.CheckBox();
            this.chkFriendly = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViews)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(831, 533);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridViews);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 476);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Views";
            // 
            // gridViews
            // 
            this.gridViews.AllowUserToAddRows = false;
            this.gridViews.AllowUserToDeleteRows = false;
            this.gridViews.AllowUserToOrderColumns = true;
            this.gridViews.AllowUserToResizeRows = false;
            this.gridViews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name});
            this.gridViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViews.FilterColumns = "";
            this.gridViews.Location = new System.Drawing.Point(3, 16);
            this.gridViews.Name = "gridViews";
            this.gridViews.ReadOnly = true;
            this.gridViews.RowHeadersVisible = false;
            this.gridViews.ShowFriendlyNames = true;
            this.gridViews.ShowIdColumn = false;
            this.gridViews.ShowIndexColumn = false;
            this.gridViews.Size = new System.Drawing.Size(220, 457);
            this.gridViews.TabIndex = 1;
            this.gridViews.RecordEnter += new Cinteros.Xrm.CRMWinForm.CRMRecordEventHandler(this.gridViews_RecordEnter);
            // 
            // name
            // 
            this.name.HeaderText = "View Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 86;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.entitiesDropdownControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 57);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entity";
            // 
            // entitiesDropdownControl1
            // 
            this.entitiesDropdownControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entitiesDropdownControl1.AutoLoadData = true;
            this.entitiesDropdownControl1.LanguageCode = 1033;
            this.entitiesDropdownControl1.Location = new System.Drawing.Point(6, 22);
            this.entitiesDropdownControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.entitiesDropdownControl1.Name = "entitiesDropdownControl1";
            this.entitiesDropdownControl1.Service = null;
            this.entitiesDropdownControl1.Size = new System.Drawing.Size(214, 25);
            this.entitiesDropdownControl1.SolutionFilter = null;
            this.entitiesDropdownControl1.TabIndex = 1;
            this.entitiesDropdownControl1.SelectedItemChanged += new System.EventHandler(this.EntitiesDropdownControl1_SelectedItemChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gridData);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(601, 476);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Records";
            // 
            // gridData
            // 
            this.gridData.AllowUserToAddRows = false;
            this.gridData.AllowUserToDeleteRows = false;
            this.gridData.AllowUserToOrderColumns = true;
            this.gridData.AllowUserToResizeRows = false;
            this.gridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.FilterColumns = "";
            this.gridData.Location = new System.Drawing.Point(3, 16);
            this.gridData.Name = "gridData";
            this.gridData.ReadOnly = true;
            this.gridData.RowHeadersVisible = false;
            this.gridData.ShowIdColumn = false;
            this.gridData.ShowIndexColumn = false;
            this.gridData.Size = new System.Drawing.Size(595, 457);
            this.gridData.TabIndex = 0;
            this.gridData.RecordClick += new Cinteros.Xrm.CRMWinForm.CRMRecordEventHandler(this.gridData_RecordClick);
            this.gridData.RecordDoubleClick += new Cinteros.Xrm.CRMWinForm.CRMRecordEventHandler(this.gridData_RecordDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFXB);
            this.groupBox3.Controls.Add(this.chkLookup);
            this.groupBox3.Controls.Add(this.chkDbl);
            this.groupBox3.Controls.Add(this.chkId);
            this.groupBox3.Controls.Add(this.chkFriendly);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(601, 57);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // btnFXB
            // 
            this.btnFXB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFXB.Image = ((System.Drawing.Image)(resources.GetObject("btnFXB.Image")));
            this.btnFXB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFXB.Location = new System.Drawing.Point(498, 24);
            this.btnFXB.Name = "btnFXB";
            this.btnFXB.Size = new System.Drawing.Size(97, 23);
            this.btnFXB.TabIndex = 4;
            this.btnFXB.Text = "Open in FXB";
            this.btnFXB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFXB.UseVisualStyleBackColor = true;
            this.btnFXB.Click += new System.EventHandler(this.btnFXB_Click);
            // 
            // chkLookup
            // 
            this.chkLookup.AutoSize = true;
            this.chkLookup.Location = new System.Drawing.Point(285, 30);
            this.chkLookup.Name = "chkLookup";
            this.chkLookup.Size = new System.Drawing.Size(96, 17);
            this.chkLookup.TabIndex = 3;
            this.chkLookup.Text = "Open Lookups";
            this.chkLookup.UseVisualStyleBackColor = true;
            this.chkLookup.CheckedChanged += new System.EventHandler(this.chkLookup_CheckedChanged);
            // 
            // chkDbl
            // 
            this.chkDbl.AutoSize = true;
            this.chkDbl.Location = new System.Drawing.Point(155, 30);
            this.chkDbl.Name = "chkDbl";
            this.chkDbl.Size = new System.Drawing.Size(124, 17);
            this.chkDbl.TabIndex = 2;
            this.chkDbl.Text = "Double-click to open";
            this.chkDbl.UseVisualStyleBackColor = true;
            // 
            // chkId
            // 
            this.chkId.AutoSize = true;
            this.chkId.Location = new System.Drawing.Point(84, 30);
            this.chkId.Name = "chkId";
            this.chkId.Size = new System.Drawing.Size(65, 17);
            this.chkId.TabIndex = 1;
            this.chkId.Text = "Show Id";
            this.chkId.UseVisualStyleBackColor = true;
            this.chkId.CheckedChanged += new System.EventHandler(this.chkId_CheckedChanged);
            // 
            // chkFriendly
            // 
            this.chkFriendly.AutoSize = true;
            this.chkFriendly.Location = new System.Drawing.Point(16, 30);
            this.chkFriendly.Name = "chkFriendly";
            this.chkFriendly.Size = new System.Drawing.Size(62, 17);
            this.chkFriendly.TabIndex = 0;
            this.chkFriendly.Text = "Friendly";
            this.chkFriendly.UseVisualStyleBackColor = true;
            this.chkFriendly.CheckedChanged += new System.EventHandler(this.chkFriendly_CheckedChanged);
            // 
            // SDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "SDV";
            this.PluginIcon = ((System.Drawing.Icon)(resources.GetObject("$this.PluginIcon")));
            this.Size = new System.Drawing.Size(831, 533);
            this.TabIcon = ((System.Drawing.Image)(resources.GetObject("$this.TabIcon")));
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViews)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Cinteros.Xrm.CRMWinForm.CRMGridView gridData;
        private Cinteros.Xrm.CRMWinForm.CRMGridView gridViews;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.CheckBox chkFriendly;
        private System.Windows.Forms.CheckBox chkId;
        private xrmtb.XrmToolBox.Controls.EntitiesDropdownControl entitiesDropdownControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkDbl;
        private System.Windows.Forms.CheckBox chkLookup;
        private System.Windows.Forms.Button btnFXB;
    }
}
