namespace SID
{
    partial class EditSite
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label townLabel;
            System.Windows.Forms.Label countyLabel;
            System.Windows.Forms.Label postCodeLabel;
            System.Windows.Forms.Label clientIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSite));
            this.sbi_salesdbDataSet = new SID.sbi_salesdbDataSet();
            this.siteDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siteDetailsTableAdapter = new SID.sbi_salesdbDataSetTableAdapters.SiteDetailsTableAdapter();
            this.tableAdapterManager = new SID.sbi_salesdbDataSetTableAdapters.TableAdapterManager();
            this.clientTableAdapter = new SID.sbi_salesdbDataSetTableAdapters.ClientTableAdapter();
            this.siteDetailsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.siteDetailsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.townTextBox = new System.Windows.Forms.TextBox();
            this.countyTextBox = new System.Windows.Forms.TextBox();
            this.postCodeTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobTableAdapter = new SID.sbi_salesdbDataSetTableAdapters.JobTableAdapter();
            this.jobDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            townLabel = new System.Windows.Forms.Label();
            countyLabel = new System.Windows.Forms.Label();
            postCodeLabel = new System.Windows.Forms.Label();
            clientIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sbi_salesdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteDetailsBindingNavigator)).BeginInit();
            this.siteDetailsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(9, 103);
            nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(104, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Development Name:";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(353, 46);
            address1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(54, 13);
            address1Label.TabIndex = 3;
            address1Label.Text = "Address1:";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new System.Drawing.Point(353, 66);
            address2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(54, 13);
            address2Label.TabIndex = 5;
            address2Label.Text = "Address2:";
            // 
            // townLabel
            // 
            townLabel.AutoSize = true;
            townLabel.Location = new System.Drawing.Point(373, 87);
            townLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            townLabel.Name = "townLabel";
            townLabel.Size = new System.Drawing.Size(37, 13);
            townLabel.TabIndex = 7;
            townLabel.Text = "Town:";
            // 
            // countyLabel
            // 
            countyLabel.AutoSize = true;
            countyLabel.Location = new System.Drawing.Point(365, 110);
            countyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            countyLabel.Name = "countyLabel";
            countyLabel.Size = new System.Drawing.Size(43, 13);
            countyLabel.TabIndex = 9;
            countyLabel.Text = "County:";
            // 
            // postCodeLabel
            // 
            postCodeLabel.AutoSize = true;
            postCodeLabel.Location = new System.Drawing.Point(350, 135);
            postCodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            postCodeLabel.Name = "postCodeLabel";
            postCodeLabel.Size = new System.Drawing.Size(59, 13);
            postCodeLabel.TabIndex = 11;
            postCodeLabel.Text = "Post Code:";
            // 
            // clientIDLabel
            // 
            clientIDLabel.AutoSize = true;
            clientIDLabel.Location = new System.Drawing.Point(10, 66);
            clientIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            clientIDLabel.Name = "clientIDLabel";
            clientIDLabel.Size = new System.Drawing.Size(50, 13);
            clientIDLabel.TabIndex = 13;
            clientIDLabel.Text = "Client ID:";
            // 
            // sbi_salesdbDataSet
            // 
            this.sbi_salesdbDataSet.DataSetName = "sbi_salesdbDataSet";
            this.sbi_salesdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siteDetailsBindingSource
            // 
            this.siteDetailsBindingSource.DataMember = "SiteDetails";
            this.siteDetailsBindingSource.DataSource = this.sbi_salesdbDataSet;
            // 
            // siteDetailsTableAdapter
            // 
            this.siteDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.DAMTableAdapter = null;
            this.tableAdapterManager.DeveloperTableAdapter = null;
            this.tableAdapterManager.InstallScheduleTableAdapter = null;
            this.tableAdapterManager.JobTableAdapter = null;
            this.tableAdapterManager.LineTableAdapter = null;
            this.tableAdapterManager.OITargetTableAdapter = null;
            this.tableAdapterManager.OPSPlannerTableAdapter = null;
            this.tableAdapterManager.ProductTypeTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.SalesTargetTableAdapter = null;
            this.tableAdapterManager.SAMTableAdapter = null;
            this.tableAdapterManager.SiteDetailsTableAdapter = this.siteDetailsTableAdapter;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.TeamTargetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SID.sbi_salesdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // siteDetailsBindingNavigator
            // 
            this.siteDetailsBindingNavigator.AddNewItem = null;
            this.siteDetailsBindingNavigator.BindingSource = this.siteDetailsBindingSource;
            this.siteDetailsBindingNavigator.CountItem = null;
            this.siteDetailsBindingNavigator.DeleteItem = null;
            this.siteDetailsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.siteDetailsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.siteDetailsBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.siteDetailsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.siteDetailsBindingNavigator.MoveFirstItem = null;
            this.siteDetailsBindingNavigator.MoveLastItem = null;
            this.siteDetailsBindingNavigator.MoveNextItem = null;
            this.siteDetailsBindingNavigator.MovePreviousItem = null;
            this.siteDetailsBindingNavigator.Name = "siteDetailsBindingNavigator";
            this.siteDetailsBindingNavigator.PositionItem = null;
            this.siteDetailsBindingNavigator.Size = new System.Drawing.Size(703, 27);
            this.siteDetailsBindingNavigator.TabIndex = 0;
            this.siteDetailsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // siteDetailsBindingNavigatorSaveItem
            // 
            this.siteDetailsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("siteDetailsBindingNavigatorSaveItem.Image")));
            this.siteDetailsBindingNavigatorSaveItem.Name = "siteDetailsBindingNavigatorSaveItem";
            this.siteDetailsBindingNavigatorSaveItem.Size = new System.Drawing.Size(82, 24);
            this.siteDetailsBindingNavigatorSaveItem.Text = "Save Data";
            this.siteDetailsBindingNavigatorSaveItem.Click += new System.EventHandler(this.siteDetailsBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(64, 24);
            this.toolStripButton1.Text = "Delete";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siteDetailsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(117, 101);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(209, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // address1TextBox
            // 
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siteDetailsBindingSource, "Address1", true));
            this.address1TextBox.Location = new System.Drawing.Point(412, 46);
            this.address1TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(172, 20);
            this.address1TextBox.TabIndex = 4;
            // 
            // address2TextBox
            // 
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siteDetailsBindingSource, "Address2", true));
            this.address2TextBox.Location = new System.Drawing.Point(412, 68);
            this.address2TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(172, 20);
            this.address2TextBox.TabIndex = 6;
            // 
            // townTextBox
            // 
            this.townTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siteDetailsBindingSource, "Town", true));
            this.townTextBox.Location = new System.Drawing.Point(412, 91);
            this.townTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.townTextBox.Name = "townTextBox";
            this.townTextBox.Size = new System.Drawing.Size(172, 20);
            this.townTextBox.TabIndex = 8;
            // 
            // countyTextBox
            // 
            this.countyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siteDetailsBindingSource, "County", true));
            this.countyTextBox.Location = new System.Drawing.Point(412, 115);
            this.countyTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.countyTextBox.Name = "countyTextBox";
            this.countyTextBox.Size = new System.Drawing.Size(172, 20);
            this.countyTextBox.TabIndex = 10;
            // 
            // postCodeTextBox
            // 
            this.postCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siteDetailsBindingSource, "PostCode", true));
            this.postCodeTextBox.Location = new System.Drawing.Point(412, 135);
            this.postCodeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.postCodeTextBox.Name = "postCodeTextBox";
            this.postCodeTextBox.Size = new System.Drawing.Size(172, 20);
            this.postCodeTextBox.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.siteDetailsBindingSource, "ClientID", true));
            this.comboBox1.DataSource = this.clientBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 66);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "ClientID";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.sbi_salesdbDataSet;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "SiteDetails_Job";
            this.jobBindingSource.DataSource = this.siteDetailsBindingSource;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // jobDataGridView
            // 
            this.jobDataGridView.AllowUserToAddRows = false;
            this.jobDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jobDataGridView.AutoGenerateColumns = false;
            this.jobDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.HouseType,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.JobID});
            this.jobDataGridView.DataSource = this.jobBindingSource;
            this.jobDataGridView.Location = new System.Drawing.Point(20, 170);
            this.jobDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.jobDataGridView.Name = "jobDataGridView";
            this.jobDataGridView.RowTemplate.Height = 24;
            this.jobDataGridView.Size = new System.Drawing.Size(674, 179);
            this.jobDataGridView.TabIndex = 15;
            this.jobDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jobDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SOPID";
            this.dataGridViewTextBoxColumn2.HeaderText = "SOPID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // HouseType
            // 
            this.HouseType.DataPropertyName = "HouseType";
            this.HouseType.HeaderText = "HouseType";
            this.HouseType.Name = "HouseType";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SiteID";
            this.dataGridViewTextBoxColumn3.HeaderText = "SiteID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Bedrooms";
            this.dataGridViewTextBoxColumn5.HeaderText = "Bedrooms";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Storeys";
            this.dataGridViewTextBoxColumn6.HeaderText = "Storeys";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SqFt";
            this.dataGridViewTextBoxColumn7.HeaderText = "SqFt";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PlotNumber";
            this.dataGridViewTextBoxColumn8.HeaderText = "PlotNumber";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ClientBudget";
            this.dataGridViewTextBoxColumn9.HeaderText = "ClientBudget";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Designer";
            this.dataGridViewTextBoxColumn10.HeaderText = "Designer";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Furniture";
            this.dataGridViewTextBoxColumn11.HeaderText = "Furniture";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "PasteUp";
            this.dataGridViewTextBoxColumn12.HeaderText = "PasteUp";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Lostto";
            this.dataGridViewTextBoxColumn13.HeaderText = "Lostto";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Reason";
            this.dataGridViewTextBoxColumn14.HeaderText = "Reason";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // JobID
            // 
            this.JobID.DataPropertyName = "JobID";
            this.JobID.HeaderText = "JobID";
            this.JobID.Name = "JobID";
            this.JobID.ReadOnly = true;
            this.JobID.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 133);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add New Job";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Jobs on Development";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Development Details";
            // 
            // EditSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 356);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.jobDataGridView);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(clientIDLabel);
            this.Controls.Add(postCodeLabel);
            this.Controls.Add(this.postCodeTextBox);
            this.Controls.Add(countyLabel);
            this.Controls.Add(this.countyTextBox);
            this.Controls.Add(townLabel);
            this.Controls.Add(this.townTextBox);
            this.Controls.Add(address2Label);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.siteDetailsBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditSite";
            this.Text = "EditSite";
            this.Load += new System.EventHandler(this.EditSite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sbi_salesdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteDetailsBindingNavigator)).EndInit();
            this.siteDetailsBindingNavigator.ResumeLayout(false);
            this.siteDetailsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sbi_salesdbDataSet sbi_salesdbDataSet;
        private System.Windows.Forms.BindingSource siteDetailsBindingSource;
        private sbi_salesdbDataSetTableAdapters.SiteDetailsTableAdapter siteDetailsTableAdapter;
        private sbi_salesdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator siteDetailsBindingNavigator;
        private System.Windows.Forms.ToolStripButton siteDetailsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox townTextBox;
        private System.Windows.Forms.TextBox countyTextBox;
        private System.Windows.Forms.TextBox postCodeTextBox;
        private sbi_salesdbDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private sbi_salesdbDataSetTableAdapters.JobTableAdapter jobTableAdapter;
        private System.Windows.Forms.DataGridView jobDataGridView;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobID;
    }
}