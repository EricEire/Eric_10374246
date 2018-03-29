namespace Eric_10374246
{
    partial class DataGridForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDNEWSTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITSTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETESTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fINDSTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATABASEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWDATABASEHISTORYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITLOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.advProDataSet = new Eric_10374246.AdvProDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new Eric_10374246.AdvProDataSetTableAdapters.StudentTableAdapter();
            this.studentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advProDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.dATABASEToolStripMenuItem,
            this.eXITLOGOUTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1128, 28);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTUDENTToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // sTUDENTToolStripMenuItem
            // 
            this.sTUDENTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDNEWSTUDENTToolStripMenuItem,
            this.eDITSTUDENTToolStripMenuItem,
            this.dELETESTUDENTToolStripMenuItem,
            this.fINDSTUDENTToolStripMenuItem});
            this.sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            this.sTUDENTToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.sTUDENTToolStripMenuItem.Text = "STUDENT";
            // 
            // aDDNEWSTUDENTToolStripMenuItem
            // 
            this.aDDNEWSTUDENTToolStripMenuItem.Name = "aDDNEWSTUDENTToolStripMenuItem";
            this.aDDNEWSTUDENTToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.aDDNEWSTUDENTToolStripMenuItem.Text = "ADD NEW STUDENT";
            this.aDDNEWSTUDENTToolStripMenuItem.Click += new System.EventHandler(this.aDDNEWSTUDENTToolStripMenuItem_Click);
            // 
            // eDITSTUDENTToolStripMenuItem
            // 
            this.eDITSTUDENTToolStripMenuItem.Name = "eDITSTUDENTToolStripMenuItem";
            this.eDITSTUDENTToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.eDITSTUDENTToolStripMenuItem.Text = "EDIT STUDENT";
            // 
            // dELETESTUDENTToolStripMenuItem
            // 
            this.dELETESTUDENTToolStripMenuItem.Name = "dELETESTUDENTToolStripMenuItem";
            this.dELETESTUDENTToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.dELETESTUDENTToolStripMenuItem.Text = "DELETE STUDENT";
            // 
            // fINDSTUDENTToolStripMenuItem
            // 
            this.fINDSTUDENTToolStripMenuItem.Name = "fINDSTUDENTToolStripMenuItem";
            this.fINDSTUDENTToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.fINDSTUDENTToolStripMenuItem.Text = "FIND STUDENT";
            // 
            // dATABASEToolStripMenuItem
            // 
            this.dATABASEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vIEWDATABASEHISTORYToolStripMenuItem});
            this.dATABASEToolStripMenuItem.Name = "dATABASEToolStripMenuItem";
            this.dATABASEToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.dATABASEToolStripMenuItem.Text = "DATABASE";
            // 
            // vIEWDATABASEHISTORYToolStripMenuItem
            // 
            this.vIEWDATABASEHISTORYToolStripMenuItem.Name = "vIEWDATABASEHISTORYToolStripMenuItem";
            this.vIEWDATABASEHISTORYToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.vIEWDATABASEHISTORYToolStripMenuItem.Text = "VIEW DATABASE HISTORY";
            // 
            // eXITLOGOUTToolStripMenuItem
            // 
            this.eXITLOGOUTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGOUTToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.eXITLOGOUTToolStripMenuItem.Name = "eXITLOGOUTToolStripMenuItem";
            this.eXITLOGOUTToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.eXITLOGOUTToolStripMenuItem.Text = "EXIT/LOG OUT";
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.lOGOUTToolStripMenuItem.Text = "LOG OUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.eXITToolStripMenuItem.Text = "EXIT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentNoDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNoDataGridViewTextBoxColumn,
            this.addressLine1DataGridViewTextBoxColumn,
            this.addressLine2DataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.countyDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.courseLevelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1039, 391);
            this.dataGridView1.TabIndex = 29;
            // 
            // advProDataSet
            // 
            this.advProDataSet.DataSetName = "AdvProDataSet";
            this.advProDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.advProDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // studentNoDataGridViewTextBoxColumn
            // 
            this.studentNoDataGridViewTextBoxColumn.DataPropertyName = "StudentNo";
            this.studentNoDataGridViewTextBoxColumn.HeaderText = "StudentNo";
            this.studentNoDataGridViewTextBoxColumn.Name = "studentNoDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneNoDataGridViewTextBoxColumn
            // 
            this.phoneNoDataGridViewTextBoxColumn.DataPropertyName = "PhoneNo";
            this.phoneNoDataGridViewTextBoxColumn.HeaderText = "PhoneNo";
            this.phoneNoDataGridViewTextBoxColumn.Name = "phoneNoDataGridViewTextBoxColumn";
            // 
            // addressLine1DataGridViewTextBoxColumn
            // 
            this.addressLine1DataGridViewTextBoxColumn.DataPropertyName = "AddressLine1";
            this.addressLine1DataGridViewTextBoxColumn.HeaderText = "AddressLine1";
            this.addressLine1DataGridViewTextBoxColumn.Name = "addressLine1DataGridViewTextBoxColumn";
            // 
            // addressLine2DataGridViewTextBoxColumn
            // 
            this.addressLine2DataGridViewTextBoxColumn.DataPropertyName = "AddressLine2";
            this.addressLine2DataGridViewTextBoxColumn.HeaderText = "AddressLine2";
            this.addressLine2DataGridViewTextBoxColumn.Name = "addressLine2DataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // countyDataGridViewTextBoxColumn
            // 
            this.countyDataGridViewTextBoxColumn.DataPropertyName = "County";
            this.countyDataGridViewTextBoxColumn.HeaderText = "County";
            this.countyDataGridViewTextBoxColumn.Name = "countyDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // courseLevelDataGridViewTextBoxColumn
            // 
            this.courseLevelDataGridViewTextBoxColumn.DataPropertyName = "CourseLevel";
            this.courseLevelDataGridViewTextBoxColumn.HeaderText = "CourseLevel";
            this.courseLevelDataGridViewTextBoxColumn.Name = "courseLevelDataGridViewTextBoxColumn";
            // 
            // DataGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 451);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DataGridForm";
            this.Text = "DataGridForm";
            this.Load += new System.EventHandler(this.DataGridForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advProDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWSTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITSTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETESTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fINDSTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dATABASEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWDATABASEHISTORYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITLOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AdvProDataSet advProDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private AdvProDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseLevelDataGridViewTextBoxColumn;
    }
}