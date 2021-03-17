
namespace StudentsTestsResultsBrowser
{
    partial class FormStudentTestsBrowser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentTestsBrowser));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOpenTestResults = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSaveTestResults = new System.Windows.Forms.ToolStripMenuItem();
            this.itemClearTestReaults = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAddStudentTestResult = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOpenFilters = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSaveFiltersAs = new System.Windows.Forms.ToolStripMenuItem();
            this.itemClearFilters = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.filterConditionsList = new StudentsTestsResultsBrowser.CustomControls.FilterConditionsListUserControl();
            this.buttonApplyFilter = new System.Windows.Forms.Button();
            this.buttonAddToFiltersList = new System.Windows.Forms.Button();
            this.buttonAddCondition = new System.Windows.Forms.Button();
            this.buttonClearConditions = new System.Windows.Forms.Button();
            this.groupBoxFilterConditions = new System.Windows.Forms.GroupBox();
            this.dataGridViewFilterConditions = new System.Windows.Forms.DataGridView();
            this.PropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxSort = new System.Windows.Forms.GroupBox();
            this.groupBoxGrouping = new System.Windows.Forms.GroupBox();
            this.comboBoxFirstProperty = new System.Windows.Forms.ComboBox();
            this.radioButtonDesc = new System.Windows.Forms.RadioButton();
            this.radioButtonAsc = new System.Windows.Forms.RadioButton();
            this.groupBoxThenBy = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2Asc = new System.Windows.Forms.RadioButton();
            this.comboBoxPropertyB = new System.Windows.Forms.ComboBox();
            this.groupBoxLimit = new System.Windows.Forms.GroupBox();
            this.labelItems = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBoxOnlyTake = new System.Windows.Forms.CheckBox();
            this.groupBoxFiltersList = new System.Windows.Forms.GroupBox();
            this.buttonApplyCheckedFilter = new System.Windows.Forms.Button();
            this.buttonSaveFilters = new System.Windows.Forms.Button();
            this.buttonOpenFilters = new System.Windows.Forms.Button();
            this.buttonClearList = new System.Windows.Forms.Button();
            this.listBoxFiltersList = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.groupBoxFilter.SuspendLayout();
            this.groupBoxFilterConditions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilterConditions)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBoxSort.SuspendLayout();
            this.groupBoxGrouping.SuspendLayout();
            this.groupBoxThenBy.SuspendLayout();
            this.groupBoxLimit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBoxFiltersList.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFile,
            this.itemEdit,
            this.itemFilter});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemFile
            // 
            this.itemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemOpenTestResults,
            this.itemSaveTestResults,
            this.itemClearTestReaults,
            this.itemExit});
            this.itemFile.Name = "itemFile";
            this.itemFile.Size = new System.Drawing.Size(46, 26);
            this.itemFile.Text = "File";
            // 
            // itemOpenTestResults
            // 
            this.itemOpenTestResults.Image = ((System.Drawing.Image)(resources.GetObject("itemOpenTestResults.Image")));
            this.itemOpenTestResults.Name = "itemOpenTestResults";
            this.itemOpenTestResults.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.itemOpenTestResults.Size = new System.Drawing.Size(255, 26);
            this.itemOpenTestResults.Text = "Open test results";
            this.itemOpenTestResults.Click += new System.EventHandler(this.itemOpenTestResults_Click);
            // 
            // itemSaveTestResults
            // 
            this.itemSaveTestResults.Image = ((System.Drawing.Image)(resources.GetObject("itemSaveTestResults.Image")));
            this.itemSaveTestResults.Name = "itemSaveTestResults";
            this.itemSaveTestResults.Size = new System.Drawing.Size(255, 26);
            this.itemSaveTestResults.Text = "Save test results";
            this.itemSaveTestResults.Click += new System.EventHandler(this.itemSaveTestResults_Click);
            // 
            // itemClearTestReaults
            // 
            this.itemClearTestReaults.Name = "itemClearTestReaults";
            this.itemClearTestReaults.Size = new System.Drawing.Size(255, 26);
            this.itemClearTestReaults.Text = "Clear test results";
            // 
            // itemExit
            // 
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(255, 26);
            this.itemExit.Text = "Exit";
            // 
            // itemEdit
            // 
            this.itemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAddStudentTestResult});
            this.itemEdit.Name = "itemEdit";
            this.itemEdit.Size = new System.Drawing.Size(49, 26);
            this.itemEdit.Text = "Edit";
            // 
            // itemAddStudentTestResult
            // 
            this.itemAddStudentTestResult.Name = "itemAddStudentTestResult";
            this.itemAddStudentTestResult.Size = new System.Drawing.Size(250, 26);
            this.itemAddStudentTestResult.Text = "Add student test result...";
            this.itemAddStudentTestResult.Click += new System.EventHandler(this.itemAddStudentTestResult_Click);
            // 
            // itemFilter
            // 
            this.itemFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemOpenFilters,
            this.itemSaveFiltersAs,
            this.itemClearFilters});
            this.itemFilter.Name = "itemFilter";
            this.itemFilter.Size = new System.Drawing.Size(56, 26);
            this.itemFilter.Text = "Filter";
            // 
            // itemOpenFilters
            // 
            this.itemOpenFilters.Name = "itemOpenFilters";
            this.itemOpenFilters.Size = new System.Drawing.Size(191, 26);
            this.itemOpenFilters.Text = "Open filters...";
            // 
            // itemSaveFiltersAs
            // 
            this.itemSaveFiltersAs.Name = "itemSaveFiltersAs";
            this.itemSaveFiltersAs.Size = new System.Drawing.Size(191, 26);
            this.itemSaveFiltersAs.Text = "Save filters as...";
            // 
            // itemClearFilters
            // 
            this.itemClearFilters.Name = "itemClearFilters";
            this.itemClearFilters.Size = new System.Drawing.Size(191, 26);
            this.itemClearFilters.Text = "Clear filters";
            this.itemClearFilters.Click += new System.EventHandler(this.itemClearFilters_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 333F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewResults, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxFilter, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxFilterConditions, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 521);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.AllowUserToAddRows = false;
            this.dataGridViewResults.AllowUserToDeleteRows = false;
            this.dataGridViewResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.TestName,
            this.TestDate,
            this.Score});
            this.dataGridViewResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResults.Location = new System.Drawing.Point(4, 2);
            this.dataGridViewResults.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.RowHeadersVisible = false;
            this.dataGridViewResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewResults.RowTemplate.Height = 29;
            this.dataGridViewResults.Size = new System.Drawing.Size(859, 351);
            this.dataGridViewResults.TabIndex = 0;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // TestName
            // 
            this.TestName.HeaderText = "Test name";
            this.TestName.MinimumWidth = 6;
            this.TestName.Name = "TestName";
            this.TestName.ReadOnly = true;
            // 
            // TestDate
            // 
            this.TestDate.HeaderText = "Test date";
            this.TestDate.MinimumWidth = 6;
            this.TestDate.Name = "TestDate";
            this.TestDate.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.MinimumWidth = 6;
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.filterConditionsList);
            this.groupBoxFilter.Controls.Add(this.buttonApplyFilter);
            this.groupBoxFilter.Controls.Add(this.buttonAddToFiltersList);
            this.groupBoxFilter.Controls.Add(this.buttonAddCondition);
            this.groupBoxFilter.Controls.Add(this.buttonClearConditions);
            this.groupBoxFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFilter.Location = new System.Drawing.Point(871, 2);
            this.groupBoxFilter.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBoxFilter.Size = new System.Drawing.Size(325, 351);
            this.groupBoxFilter.TabIndex = 1;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter";
            // 
            // filterConditionsList
            // 
            this.filterConditionsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterConditionsList.Location = new System.Drawing.Point(0, 49);
            this.filterConditionsList.Margin = new System.Windows.Forms.Padding(5);
            this.filterConditionsList.Name = "filterConditionsList";
            this.filterConditionsList.Size = new System.Drawing.Size(325, 268);
            this.filterConditionsList.TabIndex = 4;
            this.filterConditionsList.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.filterConditionsList_ControlAdded);
            // 
            // buttonApplyFilter
            // 
            this.buttonApplyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonApplyFilter.Location = new System.Drawing.Point(212, 322);
            this.buttonApplyFilter.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonApplyFilter.Name = "buttonApplyFilter";
            this.buttonApplyFilter.Size = new System.Drawing.Size(105, 23);
            this.buttonApplyFilter.TabIndex = 3;
            this.buttonApplyFilter.Text = "Apply";
            this.buttonApplyFilter.UseVisualStyleBackColor = true;
            this.buttonApplyFilter.Click += new System.EventHandler(this.buttonApplyFilter_Click);
            // 
            // buttonAddToFiltersList
            // 
            this.buttonAddToFiltersList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddToFiltersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddToFiltersList.Location = new System.Drawing.Point(3, 322);
            this.buttonAddToFiltersList.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonAddToFiltersList.Name = "buttonAddToFiltersList";
            this.buttonAddToFiltersList.Size = new System.Drawing.Size(105, 23);
            this.buttonAddToFiltersList.TabIndex = 2;
            this.buttonAddToFiltersList.Text = "Add to filters list";
            this.buttonAddToFiltersList.UseVisualStyleBackColor = true;
            this.buttonAddToFiltersList.Click += new System.EventHandler(this.buttonAddToFiltersList_Click);
            // 
            // buttonAddCondition
            // 
            this.buttonAddCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCondition.Location = new System.Drawing.Point(216, 20);
            this.buttonAddCondition.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonAddCondition.Name = "buttonAddCondition";
            this.buttonAddCondition.Size = new System.Drawing.Size(105, 23);
            this.buttonAddCondition.TabIndex = 1;
            this.buttonAddCondition.Text = "Add conditions";
            this.buttonAddCondition.UseVisualStyleBackColor = true;
            this.buttonAddCondition.Click += new System.EventHandler(this.buttonAddCondition_Click);
            // 
            // buttonClearConditions
            // 
            this.buttonClearConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearConditions.Location = new System.Drawing.Point(3, 20);
            this.buttonClearConditions.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonClearConditions.Name = "buttonClearConditions";
            this.buttonClearConditions.Size = new System.Drawing.Size(105, 23);
            this.buttonClearConditions.TabIndex = 0;
            this.buttonClearConditions.Text = "Clear conditions";
            this.buttonClearConditions.UseVisualStyleBackColor = true;
            this.buttonClearConditions.Click += new System.EventHandler(this.itemClearFilters_Click);
            // 
            // groupBoxFilterConditions
            // 
            this.groupBoxFilterConditions.Controls.Add(this.dataGridViewFilterConditions);
            this.groupBoxFilterConditions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFilterConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFilterConditions.Location = new System.Drawing.Point(871, 357);
            this.groupBoxFilterConditions.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBoxFilterConditions.Name = "groupBoxFilterConditions";
            this.groupBoxFilterConditions.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBoxFilterConditions.Size = new System.Drawing.Size(325, 162);
            this.groupBoxFilterConditions.TabIndex = 2;
            this.groupBoxFilterConditions.TabStop = false;
            this.groupBoxFilterConditions.Text = "Filter conditions";
            // 
            // dataGridViewFilterConditions
            // 
            this.dataGridViewFilterConditions.AllowUserToAddRows = false;
            this.dataGridViewFilterConditions.AllowUserToDeleteRows = false;
            this.dataGridViewFilterConditions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewFilterConditions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFilterConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilterConditions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropertyName,
            this.OperationName,
            this.ValueA,
            this.ValueB});
            this.dataGridViewFilterConditions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFilterConditions.Location = new System.Drawing.Point(4, 18);
            this.dataGridViewFilterConditions.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridViewFilterConditions.Name = "dataGridViewFilterConditions";
            this.dataGridViewFilterConditions.RowHeadersVisible = false;
            this.dataGridViewFilterConditions.RowHeadersWidth = 51;
            this.dataGridViewFilterConditions.RowTemplate.Height = 29;
            this.dataGridViewFilterConditions.Size = new System.Drawing.Size(317, 142);
            this.dataGridViewFilterConditions.TabIndex = 1;
            // 
            // PropertyName
            // 
            this.PropertyName.HeaderText = "Property";
            this.PropertyName.MinimumWidth = 6;
            this.PropertyName.Name = "PropertyName";
            this.PropertyName.ReadOnly = true;
            this.PropertyName.Width = 91;
            // 
            // OperationName
            // 
            this.OperationName.HeaderText = "Operation";
            this.OperationName.MinimumWidth = 6;
            this.OperationName.Name = "OperationName";
            this.OperationName.ReadOnly = true;
            // 
            // ValueA
            // 
            this.ValueA.HeaderText = "Value A";
            this.ValueA.MinimumWidth = 6;
            this.ValueA.Name = "ValueA";
            this.ValueA.ReadOnly = true;
            this.ValueA.Width = 86;
            // 
            // ValueB
            // 
            this.ValueB.HeaderText = "Value B";
            this.ValueB.MinimumWidth = 6;
            this.ValueB.Name = "ValueB";
            this.ValueB.ReadOnly = true;
            this.ValueB.Width = 86;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxFiltersList, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 357);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(859, 162);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBoxSort, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBoxLimit, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableLayoutPanel3.MinimumSize = new System.Drawing.Size(252, 132);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.93865F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.06135F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(292, 158);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBoxSort
            // 
            this.groupBoxSort.Controls.Add(this.groupBoxGrouping);
            this.groupBoxSort.Controls.Add(this.groupBoxThenBy);
            this.groupBoxSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSort.Location = new System.Drawing.Point(4, 2);
            this.groupBoxSort.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBoxSort.MinimumSize = new System.Drawing.Size(244, 87);
            this.groupBoxSort.Name = "groupBoxSort";
            this.groupBoxSort.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBoxSort.Size = new System.Drawing.Size(284, 106);
            this.groupBoxSort.TabIndex = 0;
            this.groupBoxSort.TabStop = false;
            this.groupBoxSort.Text = "Sort";
            // 
            // groupBoxGrouping
            // 
            this.groupBoxGrouping.Controls.Add(this.comboBoxFirstProperty);
            this.groupBoxGrouping.Controls.Add(this.radioButtonDesc);
            this.groupBoxGrouping.Controls.Add(this.radioButtonAsc);
            this.groupBoxGrouping.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxGrouping.Location = new System.Drawing.Point(4, 18);
            this.groupBoxGrouping.Name = "groupBoxGrouping";
            this.groupBoxGrouping.Size = new System.Drawing.Size(136, 86);
            this.groupBoxGrouping.TabIndex = 2;
            this.groupBoxGrouping.TabStop = false;
            this.groupBoxGrouping.Text = "GroupBy";
            // 
            // comboBoxFirstProperty
            // 
            this.comboBoxFirstProperty.FormattingEnabled = true;
            this.comboBoxFirstProperty.Location = new System.Drawing.Point(6, 22);
            this.comboBoxFirstProperty.Name = "comboBoxFirstProperty";
            this.comboBoxFirstProperty.Size = new System.Drawing.Size(121, 25);
            this.comboBoxFirstProperty.TabIndex = 4;
            // 
            // radioButtonDesc
            // 
            this.radioButtonDesc.AutoSize = true;
            this.radioButtonDesc.Location = new System.Drawing.Point(64, 59);
            this.radioButtonDesc.Name = "radioButtonDesc";
            this.radioButtonDesc.Size = new System.Drawing.Size(61, 21);
            this.radioButtonDesc.TabIndex = 2;
            this.radioButtonDesc.TabStop = true;
            this.radioButtonDesc.Text = "Desc";
            this.radioButtonDesc.UseVisualStyleBackColor = true;
            // 
            // radioButtonAsc
            // 
            this.radioButtonAsc.AutoSize = true;
            this.radioButtonAsc.Location = new System.Drawing.Point(6, 59);
            this.radioButtonAsc.Name = "radioButtonAsc";
            this.radioButtonAsc.Size = new System.Drawing.Size(52, 21);
            this.radioButtonAsc.TabIndex = 1;
            this.radioButtonAsc.TabStop = true;
            this.radioButtonAsc.Text = "Asc";
            this.radioButtonAsc.UseVisualStyleBackColor = true;
            // 
            // groupBoxThenBy
            // 
            this.groupBoxThenBy.Controls.Add(this.radioButton1);
            this.groupBoxThenBy.Controls.Add(this.radioButton2Asc);
            this.groupBoxThenBy.Controls.Add(this.comboBoxPropertyB);
            this.groupBoxThenBy.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxThenBy.Location = new System.Drawing.Point(146, 18);
            this.groupBoxThenBy.Name = "groupBoxThenBy";
            this.groupBoxThenBy.Size = new System.Drawing.Size(134, 86);
            this.groupBoxThenBy.TabIndex = 1;
            this.groupBoxThenBy.TabStop = false;
            this.groupBoxThenBy.Text = "ThenBy";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(65, 59);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 21);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Desc";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2Asc
            // 
            this.radioButton2Asc.AutoSize = true;
            this.radioButton2Asc.Location = new System.Drawing.Point(7, 59);
            this.radioButton2Asc.Name = "radioButton2Asc";
            this.radioButton2Asc.Size = new System.Drawing.Size(52, 21);
            this.radioButton2Asc.TabIndex = 4;
            this.radioButton2Asc.TabStop = true;
            this.radioButton2Asc.Text = "Asc";
            this.radioButton2Asc.UseVisualStyleBackColor = true;
            // 
            // comboBoxPropertyB
            // 
            this.comboBoxPropertyB.FormattingEnabled = true;
            this.comboBoxPropertyB.Location = new System.Drawing.Point(7, 22);
            this.comboBoxPropertyB.Name = "comboBoxPropertyB";
            this.comboBoxPropertyB.Size = new System.Drawing.Size(121, 25);
            this.comboBoxPropertyB.TabIndex = 3;
            // 
            // groupBoxLimit
            // 
            this.groupBoxLimit.Controls.Add(this.labelItems);
            this.groupBoxLimit.Controls.Add(this.numericUpDown1);
            this.groupBoxLimit.Controls.Add(this.checkBoxOnlyTake);
            this.groupBoxLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxLimit.Location = new System.Drawing.Point(4, 112);
            this.groupBoxLimit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBoxLimit.MinimumSize = new System.Drawing.Size(244, 36);
            this.groupBoxLimit.Name = "groupBoxLimit";
            this.groupBoxLimit.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBoxLimit.Size = new System.Drawing.Size(284, 44);
            this.groupBoxLimit.TabIndex = 1;
            this.groupBoxLimit.TabStop = false;
            this.groupBoxLimit.Text = "Limit";
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Location = new System.Drawing.Point(168, 18);
            this.labelItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(41, 17);
            this.labelItems.TabIndex = 2;
            this.labelItems.Text = "items";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = true;
            this.numericUpDown1.Location = new System.Drawing.Point(105, 14);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 23);
            this.numericUpDown1.TabIndex = 1;
            // 
            // checkBoxOnlyTake
            // 
            this.checkBoxOnlyTake.AutoSize = true;
            this.checkBoxOnlyTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxOnlyTake.Location = new System.Drawing.Point(3, 17);
            this.checkBoxOnlyTake.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.checkBoxOnlyTake.Name = "checkBoxOnlyTake";
            this.checkBoxOnlyTake.Size = new System.Drawing.Size(90, 21);
            this.checkBoxOnlyTake.TabIndex = 0;
            this.checkBoxOnlyTake.Text = "Only take";
            this.checkBoxOnlyTake.UseVisualStyleBackColor = true;
            // 
            // groupBoxFiltersList
            // 
            this.groupBoxFiltersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFiltersList.Controls.Add(this.buttonApplyCheckedFilter);
            this.groupBoxFiltersList.Controls.Add(this.buttonSaveFilters);
            this.groupBoxFiltersList.Controls.Add(this.buttonOpenFilters);
            this.groupBoxFiltersList.Controls.Add(this.buttonClearList);
            this.groupBoxFiltersList.Controls.Add(this.listBoxFiltersList);
            this.groupBoxFiltersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFiltersList.Location = new System.Drawing.Point(304, 2);
            this.groupBoxFiltersList.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBoxFiltersList.MinimumSize = new System.Drawing.Size(513, 158);
            this.groupBoxFiltersList.Name = "groupBoxFiltersList";
            this.groupBoxFiltersList.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBoxFiltersList.Size = new System.Drawing.Size(551, 158);
            this.groupBoxFiltersList.TabIndex = 1;
            this.groupBoxFiltersList.TabStop = false;
            this.groupBoxFiltersList.Text = "Filters list";
            // 
            // buttonApplyCheckedFilter
            // 
            this.buttonApplyCheckedFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApplyCheckedFilter.Location = new System.Drawing.Point(440, 112);
            this.buttonApplyCheckedFilter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonApplyCheckedFilter.Name = "buttonApplyCheckedFilter";
            this.buttonApplyCheckedFilter.Size = new System.Drawing.Size(100, 28);
            this.buttonApplyCheckedFilter.TabIndex = 4;
            this.buttonApplyCheckedFilter.Text = "Apply filter";
            this.buttonApplyCheckedFilter.UseVisualStyleBackColor = true;
            this.buttonApplyCheckedFilter.Click += new System.EventHandler(this.buttonApplyCheckedFilter_Click);
            // 
            // buttonSaveFilters
            // 
            this.buttonSaveFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveFilters.Location = new System.Drawing.Point(332, 113);
            this.buttonSaveFilters.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveFilters.Name = "buttonSaveFilters";
            this.buttonSaveFilters.Size = new System.Drawing.Size(100, 28);
            this.buttonSaveFilters.TabIndex = 3;
            this.buttonSaveFilters.Text = "Save filters";
            this.buttonSaveFilters.UseVisualStyleBackColor = true;
            this.buttonSaveFilters.Click += new System.EventHandler(this.buttonSaveFilters_Click);
            // 
            // buttonOpenFilters
            // 
            this.buttonOpenFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpenFilters.Location = new System.Drawing.Point(116, 113);
            this.buttonOpenFilters.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenFilters.Name = "buttonOpenFilters";
            this.buttonOpenFilters.Size = new System.Drawing.Size(100, 28);
            this.buttonOpenFilters.TabIndex = 2;
            this.buttonOpenFilters.Text = "Open filters";
            this.buttonOpenFilters.UseVisualStyleBackColor = true;
            this.buttonOpenFilters.Click += new System.EventHandler(this.buttonOpenFilters_Click);
            // 
            // buttonClearList
            // 
            this.buttonClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClearList.Location = new System.Drawing.Point(8, 113);
            this.buttonClearList.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClearList.Name = "buttonClearList";
            this.buttonClearList.Size = new System.Drawing.Size(100, 28);
            this.buttonClearList.TabIndex = 1;
            this.buttonClearList.Text = "Clear list";
            this.buttonClearList.UseVisualStyleBackColor = true;
            // 
            // listBoxFiltersList
            // 
            this.listBoxFiltersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFiltersList.FormattingEnabled = true;
            this.listBoxFiltersList.ItemHeight = 17;
            this.listBoxFiltersList.Location = new System.Drawing.Point(5, 20);
            this.listBoxFiltersList.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFiltersList.MinimumSize = new System.Drawing.Size(497, 72);
            this.listBoxFiltersList.Name = "listBoxFiltersList";
            this.listBoxFiltersList.Size = new System.Drawing.Size(535, 72);
            this.listBoxFiltersList.TabIndex = 0;
            // 
            // FormStudentTestsBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 551);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FormStudentTestsBrowser";
            this.Text = "FormStudentTestsBrowser";
            this.Load += new System.EventHandler(this.FormStudentTestsBrowser_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilterConditions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilterConditions)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBoxSort.ResumeLayout(false);
            this.groupBoxGrouping.ResumeLayout(false);
            this.groupBoxGrouping.PerformLayout();
            this.groupBoxThenBy.ResumeLayout(false);
            this.groupBoxThenBy.PerformLayout();
            this.groupBoxLimit.ResumeLayout(false);
            this.groupBoxLimit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBoxFiltersList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemFile;
        private System.Windows.Forms.ToolStripMenuItem itemEdit;
        private System.Windows.Forms.ToolStripMenuItem itemFilter;
        private System.Windows.Forms.ToolStripMenuItem itemOpenTestResults;
        private System.Windows.Forms.ToolStripMenuItem itemSaveTestResults;
        private System.Windows.Forms.ToolStripMenuItem itemClearTestReaults;
        private System.Windows.Forms.ToolStripMenuItem itemExit;
        private System.Windows.Forms.ToolStripMenuItem itemAddStudentTestResult;
        private System.Windows.Forms.ToolStripMenuItem itemOpenFilters;
        private System.Windows.Forms.ToolStripMenuItem itemSaveFiltersAs;
        private System.Windows.Forms.ToolStripMenuItem itemClearFilters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Button buttonApplyFilter;
        private System.Windows.Forms.Button buttonAddToFiltersList;
        private System.Windows.Forms.Button buttonAddCondition;
        private System.Windows.Forms.Button buttonClearConditions;
        private System.Windows.Forms.GroupBox groupBoxFilterConditions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBoxSort;
        private System.Windows.Forms.GroupBox groupBoxLimit;
        private System.Windows.Forms.CheckBox checkBoxOnlyTake;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBoxFiltersList;
        private System.Windows.Forms.ListBox listBoxFiltersList;
        private StudentsTestsResultsBrowser.CustomControls.FilterConditionsListUserControl filterConditionsList;
        private System.Windows.Forms.DataGridView dataGridViewFilterConditions;
        private System.Windows.Forms.Button buttonApplyCheckedFilter;
        private System.Windows.Forms.Button buttonSaveFilters;
        private System.Windows.Forms.Button buttonOpenFilters;
        private System.Windows.Forms.Button buttonClearList;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueB;
        private System.Windows.Forms.GroupBox groupBoxThenBy;
        private System.Windows.Forms.GroupBox groupBoxGrouping;
        private System.Windows.Forms.RadioButton radioButtonDesc;
        private System.Windows.Forms.RadioButton radioButtonAsc;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2Asc;
        private System.Windows.Forms.ComboBox comboBoxPropertyB;
        private System.Windows.Forms.ComboBox comboBoxFirstProperty;
    }
}

