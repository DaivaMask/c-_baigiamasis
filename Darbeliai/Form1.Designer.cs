namespace Darbeliai
{
    partial class Form1
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
            System.Windows.Forms.DataGridView darbasDataGridView;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.darbasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.darbaiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.darbaiDataSet = new Darbeliai.DarbaiDataSet();
            this.darbasTableAdapter1 = new Darbeliai.DarbaiDataSetTableAdapters.DarbasTableAdapter();
            this.darbininkasTableAdapter1 = new Darbeliai.DarbaiDataSetTableAdapters.DarbininkasTableAdapter();
            this.darbaiDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.darbininkasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.darbaiDataSet1 = new Darbeliai.DarbaiDataSet();
            this.darbaiDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.darbaiDataSet2 = new Darbeliai.DarbaiDataSet();
            this.darbaiDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.darbaiDataSet11 = new Darbeliai.DarbaiDataSet1();
            this.darbasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.darbasTableAdapter = new Darbeliai.DarbaiDataSet1TableAdapters.DarbasTableAdapter();
            this.tableAdapterManager = new Darbeliai.DarbaiDataSet1TableAdapters.TableAdapterManager();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.student_addressBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atliktiToolStrip = new System.Windows.Forms.ToolStrip();
            this.atliktiToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.visiDarbaiToolStrip = new System.Windows.Forms.ToolStrip();
            this.visiDarbaiToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.daromiToolStrip = new System.Windows.Forms.ToolStrip();
            this.daromiToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            darbasDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.darbasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbininkasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(darbasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_addressBindingNavigator)).BeginInit();
            this.student_addressBindingNavigator.SuspendLayout();
            this.atliktiToolStrip.SuspendLayout();
            this.visiDarbaiToolStrip.SuspendLayout();
            this.daromiToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(708, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Naujas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // darbasBindingSource
            // 
            this.darbasBindingSource.DataMember = "Darbas";
            this.darbasBindingSource.DataSource = this.darbaiDataSetBindingSource;
            // 
            // darbaiDataSetBindingSource
            // 
            this.darbaiDataSetBindingSource.DataSource = this.darbaiDataSet;
            this.darbaiDataSetBindingSource.Position = 0;
            this.darbaiDataSetBindingSource.CurrentChanged += new System.EventHandler(this.darbaiDataSetBindingSource_CurrentChanged);
            // 
            // darbaiDataSet
            // 
            this.darbaiDataSet.DataSetName = "DarbaiDataSet";
            this.darbaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // darbasTableAdapter1
            // 
            this.darbasTableAdapter1.ClearBeforeFill = true;
            // 
            // darbininkasTableAdapter1
            // 
            this.darbininkasTableAdapter1.ClearBeforeFill = true;
            // 
            // darbaiDataSetBindingSource1
            // 
            this.darbaiDataSetBindingSource1.DataSource = this.darbaiDataSet;
            this.darbaiDataSetBindingSource1.Position = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.darbininkasBindingSource;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // darbininkasBindingSource
            // 
            this.darbininkasBindingSource.DataMember = "Darbininkas";
            this.darbininkasBindingSource.DataSource = this.darbaiDataSetBindingSource1;
            this.darbininkasBindingSource.CurrentChanged += new System.EventHandler(this.darbininkasBindingSource_CurrentChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(708, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 36);
            this.button2.TabIndex = 10;
            this.button2.Text = "Baigti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // darbaiDataSet1
            // 
            this.darbaiDataSet1.DataSetName = "DarbaiDataSet";
            this.darbaiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // darbaiDataSet1BindingSource
            // 
            this.darbaiDataSet1BindingSource.DataSource = this.darbaiDataSet1;
            this.darbaiDataSet1BindingSource.Position = 0;
            // 
            // darbaiDataSet2
            // 
            this.darbaiDataSet2.DataSetName = "DarbaiDataSet";
            this.darbaiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // darbaiDataSet2BindingSource
            // 
            this.darbaiDataSet2BindingSource.DataSource = this.darbaiDataSet2;
            this.darbaiDataSet2BindingSource.Position = 0;
            // 
            // darbaiDataSet11
            // 
            this.darbaiDataSet11.DataSetName = "DarbaiDataSet1";
            this.darbaiDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // darbasBindingSource1
            // 
            this.darbasBindingSource1.DataMember = "Darbas";
            this.darbasBindingSource1.DataSource = this.darbaiDataSet11;
            // 
            // darbasTableAdapter
            // 
            this.darbasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DarbasTableAdapter = this.darbasTableAdapter;
            this.tableAdapterManager.DarbininkasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Darbeliai.DarbaiDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // darbasDataGridView
            // 
            darbasDataGridView.AutoGenerateColumns = false;
            darbasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            darbasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            darbasDataGridView.DataSource = this.darbasBindingSource1;
            darbasDataGridView.Location = new System.Drawing.Point(12, 122);
            darbasDataGridView.Name = "darbasDataGridView";
            darbasDataGridView.RowTemplate.Height = 24;
            darbasDataGridView.Size = new System.Drawing.Size(815, 106);
            darbasDataGridView.TabIndex = 12;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click_1);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem.Image")));
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorSaveItem.Text = "Save Data";
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // student_addressBindingNavigator
            // 
            this.student_addressBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.student_addressBindingNavigator.CountItem = null;
            this.student_addressBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.student_addressBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.student_addressBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.student_addressBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSaveItem});
            this.student_addressBindingNavigator.Location = new System.Drawing.Point(271, 9);
            this.student_addressBindingNavigator.MoveFirstItem = null;
            this.student_addressBindingNavigator.MoveLastItem = null;
            this.student_addressBindingNavigator.MoveNextItem = null;
            this.student_addressBindingNavigator.MovePreviousItem = null;
            this.student_addressBindingNavigator.Name = "student_addressBindingNavigator";
            this.student_addressBindingNavigator.PositionItem = null;
            this.student_addressBindingNavigator.Size = new System.Drawing.Size(84, 27);
            this.student_addressBindingNavigator.TabIndex = 13;
            this.student_addressBindingNavigator.Text = "bindingNavigator1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Worker_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Worker_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "WorkDesc";
            this.dataGridViewTextBoxColumn3.HeaderText = "WorkDesc";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "WorkStart";
            this.dataGridViewTextBoxColumn4.HeaderText = "WorkStart";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "WorkEnd";
            this.dataGridViewTextBoxColumn5.HeaderText = "WorkEnd";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // atliktiToolStrip
            // 
            this.atliktiToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.atliktiToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.atliktiToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atliktiToolStripButton});
            this.atliktiToolStrip.Location = new System.Drawing.Point(87, 64);
            this.atliktiToolStrip.Name = "atliktiToolStrip";
            this.atliktiToolStrip.Size = new System.Drawing.Size(64, 27);
            this.atliktiToolStrip.TabIndex = 14;
            this.atliktiToolStrip.Text = "atliktiToolStrip";
            // 
            // atliktiToolStripButton
            // 
            this.atliktiToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.atliktiToolStripButton.Name = "atliktiToolStripButton";
            this.atliktiToolStripButton.Size = new System.Drawing.Size(52, 24);
            this.atliktiToolStripButton.Text = "Atlikti";
            this.atliktiToolStripButton.Click += new System.EventHandler(this.atliktiToolStripButton_Click);
            // 
            // visiDarbaiToolStrip
            // 
            this.visiDarbaiToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.visiDarbaiToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.visiDarbaiToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visiDarbaiToolStripButton});
            this.visiDarbaiToolStrip.Location = new System.Drawing.Point(9, 37);
            this.visiDarbaiToolStrip.Name = "visiDarbaiToolStrip";
            this.visiDarbaiToolStrip.Size = new System.Drawing.Size(93, 27);
            this.visiDarbaiToolStrip.TabIndex = 15;
            this.visiDarbaiToolStrip.Text = "visiDarbaiToolStrip";
            // 
            // visiDarbaiToolStripButton
            // 
            this.visiDarbaiToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.visiDarbaiToolStripButton.Name = "visiDarbaiToolStripButton";
            this.visiDarbaiToolStripButton.Size = new System.Drawing.Size(81, 24);
            this.visiDarbaiToolStripButton.Text = "VisiDarbai";
            this.visiDarbaiToolStripButton.Click += new System.EventHandler(this.visiDarbaiToolStripButton_Click);
            // 
            // daromiToolStrip
            // 
            this.daromiToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.daromiToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.daromiToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daromiToolStripButton});
            this.daromiToolStrip.Location = new System.Drawing.Point(12, 64);
            this.daromiToolStrip.Name = "daromiToolStrip";
            this.daromiToolStrip.Size = new System.Drawing.Size(75, 27);
            this.daromiToolStrip.TabIndex = 16;
            this.daromiToolStrip.Text = "daromiToolStrip";
            // 
            // daromiToolStripButton
            // 
            this.daromiToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.daromiToolStripButton.Name = "daromiToolStripButton";
            this.daromiToolStripButton.Size = new System.Drawing.Size(63, 24);
            this.daromiToolStripButton.Text = "Daromi";
            this.daromiToolStripButton.Click += new System.EventHandler(this.daromiToolStripButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(28, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(626, 150);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Vardas";
            this.Column1.Name = "Column1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 470);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.daromiToolStrip);
            this.Controls.Add(this.visiDarbaiToolStrip);
            this.Controls.Add(this.atliktiToolStrip);
            this.Controls.Add(this.student_addressBindingNavigator);
            this.Controls.Add(darbasDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Darbeliai";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.darbasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbininkasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbaiDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darbasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(darbasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_addressBindingNavigator)).EndInit();
            this.student_addressBindingNavigator.ResumeLayout(false);
            this.student_addressBindingNavigator.PerformLayout();
            this.atliktiToolStrip.ResumeLayout(false);
            this.atliktiToolStrip.PerformLayout();
            this.visiDarbaiToolStrip.ResumeLayout(false);
            this.visiDarbaiToolStrip.PerformLayout();
            this.daromiToolStrip.ResumeLayout(false);
            this.daromiToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource darbaiDataSetBindingSource;
        private DarbaiDataSet darbaiDataSet;
        private DarbaiDataSetTableAdapters.DarbasTableAdapter darbasTableAdapter1;
        private DarbaiDataSetTableAdapters.DarbininkasTableAdapter darbininkasTableAdapter1;
        private System.Windows.Forms.BindingSource darbasBindingSource;
        private System.Windows.Forms.BindingSource darbaiDataSetBindingSource1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource darbininkasBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource darbaiDataSet1BindingSource;
        private DarbaiDataSet darbaiDataSet1;
        private DarbaiDataSet darbaiDataSet2;
        private System.Windows.Forms.BindingSource darbaiDataSet2BindingSource;
        private DarbaiDataSet1 darbaiDataSet11;
        private System.Windows.Forms.BindingSource darbasBindingSource1;
        private DarbaiDataSet1TableAdapters.DarbasTableAdapter darbasTableAdapter;
        private DarbaiDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator student_addressBindingNavigator;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStrip atliktiToolStrip;
        private System.Windows.Forms.ToolStripButton atliktiToolStripButton;
        private System.Windows.Forms.ToolStrip visiDarbaiToolStrip;
        private System.Windows.Forms.ToolStripButton visiDarbaiToolStripButton;
        private System.Windows.Forms.ToolStrip daromiToolStrip;
        private System.Windows.Forms.ToolStripButton daromiToolStripButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

