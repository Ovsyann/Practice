
namespace StudentTestResultsBrowser
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonApplyFilter = new System.Windows.Forms.Button();
            this.buttonAddToFiltersList = new System.Windows.Forms.Button();
            this.buttonAddCondition = new System.Windows.Forms.Button();
            this.buttonClearConditions = new System.Windows.Forms.Button();
            this.groupBoxFilterConditions = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxSort = new System.Windows.Forms.GroupBox();
            this.rBThenByDesc = new System.Windows.Forms.RadioButton();
            this.rBThenByAsc = new System.Windows.Forms.RadioButton();
            this.rBOrderByDesc = new System.Windows.Forms.RadioButton();
            this.rBOrderByAsc = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelThenBy = new System.Windows.Forms.Label();
            this.labelOrderBy = new System.Windows.Forms.Label();
            this.groupBoxLimit = new System.Windows.Forms.GroupBox();
            this.checkBoxOnlyTake = new System.Windows.Forms.CheckBox();
            this.groupBoxFiltersList = new System.Windows.Forms.GroupBox();
            this.listBoxFilters = new System.Windows.Forms.ListBox();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnOpenFilters = new System.Windows.Forms.Button();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.btnSaveFilters = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelItems = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxFilter.SuspendLayout();
            this.groupBoxFilterConditions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBoxSort.SuspendLayout();
            this.groupBoxLimit.SuspendLayout();
            this.groupBoxFiltersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
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
            this.itemFile.Size = new System.Drawing.Size(37, 20);
            this.itemFile.Text = "File";
            // 
            // itemOpenTestResults
            // 
            this.itemOpenTestResults.Image = ((System.Drawing.Image)(resources.GetObject("itemOpenTestResults.Image")));
            this.itemOpenTestResults.Name = "itemOpenTestResults";
            this.itemOpenTestResults.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.itemOpenTestResults.Size = new System.Drawing.Size(205, 22);
            this.itemOpenTestResults.Text = "Open test results";
            // 
            // itemSaveTestResults
            // 
            this.itemSaveTestResults.Image = ((System.Drawing.Image)(resources.GetObject("itemSaveTestResults.Image")));
            this.itemSaveTestResults.Name = "itemSaveTestResults";
            this.itemSaveTestResults.Size = new System.Drawing.Size(205, 22);
            this.itemSaveTestResults.Text = "Save test results";
            // 
            // itemClearTestReaults
            // 
            this.itemClearTestReaults.Name = "itemClearTestReaults";
            this.itemClearTestReaults.Size = new System.Drawing.Size(205, 22);
            this.itemClearTestReaults.Text = "Clear test results";
            // 
            // itemExit
            // 
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(205, 22);
            this.itemExit.Text = "Exit";
            // 
            // itemEdit
            // 
            this.itemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAddStudentTestResult});
            this.itemEdit.Name = "itemEdit";
            this.itemEdit.Size = new System.Drawing.Size(39, 20);
            this.itemEdit.Text = "Edit";
            // 
            // itemAddStudentTestResult
            // 
            this.itemAddStudentTestResult.Name = "itemAddStudentTestResult";
            this.itemAddStudentTestResult.Size = new System.Drawing.Size(202, 22);
            this.itemAddStudentTestResult.Text = "Add student test result...";
            // 
            // itemFilter
            // 
            this.itemFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemOpenFilters,
            this.itemSaveFiltersAs,
            this.itemClearFilters});
            this.itemFilter.Name = "itemFilter";
            this.itemFilter.Size = new System.Drawing.Size(45, 20);
            this.itemFilter.Text = "Filter";
            // 
            // itemOpenFilters
            // 
            this.itemOpenFilters.Name = "itemOpenFilters";
            this.itemOpenFilters.Size = new System.Drawing.Size(153, 22);
            this.itemOpenFilters.Text = "Open filters...";
            // 
            // itemSaveFiltersAs
            // 
            this.itemSaveFiltersAs.Name = "itemSaveFiltersAs";
            this.itemSaveFiltersAs.Size = new System.Drawing.Size(153, 22);
            this.itemSaveFiltersAs.Text = "Save filters as...";
            // 
            // itemClearFilters
            // 
            this.itemClearFilters.Name = "itemClearFilters";
            this.itemClearFilters.Size = new System.Drawing.Size(153, 22);
            this.itemClearFilters.Text = "Clear filters";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxFilter, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxFilterConditions, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.61925F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.38075F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(869, 465);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(602, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.AutoSize = true;
            this.groupBoxFilter.Controls.Add(this.flowLayoutPanel1);
            this.groupBoxFilter.Controls.Add(this.buttonApplyFilter);
            this.groupBoxFilter.Controls.Add(this.buttonAddToFiltersList);
            this.groupBoxFilter.Controls.Add(this.buttonAddCondition);
            this.groupBoxFilter.Controls.Add(this.buttonClearConditions);
            this.groupBoxFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxFilter.Location = new System.Drawing.Point(611, 2);
            this.groupBoxFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFilter.MinimumSize = new System.Drawing.Size(191, 315);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFilter.Size = new System.Drawing.Size(255, 315);
            this.groupBoxFilter.TabIndex = 1;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(253, 207);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // buttonApplyFilter
            // 
            this.buttonApplyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonApplyFilter.Location = new System.Drawing.Point(159, 257);
            this.buttonApplyFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonApplyFilter.Name = "buttonApplyFilter";
            this.buttonApplyFilter.Size = new System.Drawing.Size(92, 22);
            this.buttonApplyFilter.TabIndex = 3;
            this.buttonApplyFilter.Text = "Apply";
            this.buttonApplyFilter.UseVisualStyleBackColor = true;
            // 
            // buttonAddToFiltersList
            // 
            this.buttonAddToFiltersList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddToFiltersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddToFiltersList.Location = new System.Drawing.Point(2, 257);
            this.buttonAddToFiltersList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddToFiltersList.Name = "buttonAddToFiltersList";
            this.buttonAddToFiltersList.Size = new System.Drawing.Size(92, 22);
            this.buttonAddToFiltersList.TabIndex = 2;
            this.buttonAddToFiltersList.Text = "Add to filters list";
            this.buttonAddToFiltersList.UseVisualStyleBackColor = true;
            // 
            // buttonAddCondition
            // 
            this.buttonAddCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddCondition.Location = new System.Drawing.Point(159, 18);
            this.buttonAddCondition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddCondition.Name = "buttonAddCondition";
            this.buttonAddCondition.Size = new System.Drawing.Size(92, 22);
            this.buttonAddCondition.TabIndex = 1;
            this.buttonAddCondition.Text = "Add conditions";
            this.buttonAddCondition.UseVisualStyleBackColor = true;
            // 
            // buttonClearConditions
            // 
            this.buttonClearConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClearConditions.Location = new System.Drawing.Point(2, 18);
            this.buttonClearConditions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClearConditions.Name = "buttonClearConditions";
            this.buttonClearConditions.Size = new System.Drawing.Size(92, 22);
            this.buttonClearConditions.TabIndex = 0;
            this.buttonClearConditions.Text = "Clear conditions";
            this.buttonClearConditions.UseVisualStyleBackColor = true;
            // 
            // groupBoxFilterConditions
            // 
            this.groupBoxFilterConditions.Controls.Add(this.dataGridView2);
            this.groupBoxFilterConditions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFilterConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxFilterConditions.Location = new System.Drawing.Point(611, 321);
            this.groupBoxFilterConditions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFilterConditions.Name = "groupBoxFilterConditions";
            this.groupBoxFilterConditions.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFilterConditions.Size = new System.Drawing.Size(255, 142);
            this.groupBoxFilterConditions.TabIndex = 2;
            this.groupBoxFilterConditions.TabStop = false;
            this.groupBoxFilterConditions.Text = "Filter conditions";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(249, 127);
            this.dataGridView2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 255F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxFiltersList, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 321);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(602, 142);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBoxSort, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBoxLimit, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.93865F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.06135F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(249, 138);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBoxSort
            // 
            this.groupBoxSort.Controls.Add(this.rBThenByDesc);
            this.groupBoxSort.Controls.Add(this.rBThenByAsc);
            this.groupBoxSort.Controls.Add(this.rBOrderByDesc);
            this.groupBoxSort.Controls.Add(this.rBOrderByAsc);
            this.groupBoxSort.Controls.Add(this.comboBox2);
            this.groupBoxSort.Controls.Add(this.comboBox1);
            this.groupBoxSort.Controls.Add(this.labelThenBy);
            this.groupBoxSort.Controls.Add(this.labelOrderBy);
            this.groupBoxSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSort.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSort.Location = new System.Drawing.Point(3, 2);
            this.groupBoxSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSort.MinimumSize = new System.Drawing.Size(243, 80);
            this.groupBoxSort.Name = "groupBoxSort";
            this.groupBoxSort.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSort.Size = new System.Drawing.Size(243, 92);
            this.groupBoxSort.TabIndex = 0;
            this.groupBoxSort.TabStop = false;
            this.groupBoxSort.Text = "Asc";
            // 
            // rBThenByDesc
            // 
            this.rBThenByDesc.AutoSize = true;
            this.rBThenByDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rBThenByDesc.Location = new System.Drawing.Point(193, 58);
            this.rBThenByDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBThenByDesc.Name = "rBThenByDesc";
            this.rBThenByDesc.Size = new System.Drawing.Size(50, 17);
            this.rBThenByDesc.TabIndex = 7;
            this.rBThenByDesc.TabStop = true;
            this.rBThenByDesc.Text = "Desc";
            this.rBThenByDesc.UseVisualStyleBackColor = true;
            // 
            // rBThenByAsc
            // 
            this.rBThenByAsc.AutoSize = true;
            this.rBThenByAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rBThenByAsc.Location = new System.Drawing.Point(137, 58);
            this.rBThenByAsc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBThenByAsc.Name = "rBThenByAsc";
            this.rBThenByAsc.Size = new System.Drawing.Size(43, 17);
            this.rBThenByAsc.TabIndex = 6;
            this.rBThenByAsc.TabStop = true;
            this.rBThenByAsc.Text = "Asc";
            this.rBThenByAsc.UseVisualStyleBackColor = true;
            // 
            // rBOrderByDesc
            // 
            this.rBOrderByDesc.AutoSize = true;
            this.rBOrderByDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rBOrderByDesc.Location = new System.Drawing.Point(62, 58);
            this.rBOrderByDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBOrderByDesc.Name = "rBOrderByDesc";
            this.rBOrderByDesc.Size = new System.Drawing.Size(50, 17);
            this.rBOrderByDesc.TabIndex = 5;
            this.rBOrderByDesc.TabStop = true;
            this.rBOrderByDesc.Text = "Desc";
            this.rBOrderByDesc.UseVisualStyleBackColor = true;
            // 
            // rBOrderByAsc
            // 
            this.rBOrderByAsc.AutoSize = true;
            this.rBOrderByAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rBOrderByAsc.Location = new System.Drawing.Point(6, 58);
            this.rBOrderByAsc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBOrderByAsc.Name = "rBOrderByAsc";
            this.rBOrderByAsc.Size = new System.Drawing.Size(43, 17);
            this.rBOrderByAsc.TabIndex = 4;
            this.rBOrderByAsc.TabStop = true;
            this.rBOrderByAsc.Text = "Asc";
            this.rBOrderByAsc.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(133, 33);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(105, 20);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(2, 33);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // labelThenBy
            // 
            this.labelThenBy.AutoSize = true;
            this.labelThenBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelThenBy.Location = new System.Drawing.Point(130, 12);
            this.labelThenBy.Name = "labelThenBy";
            this.labelThenBy.Size = new System.Drawing.Size(46, 13);
            this.labelThenBy.TabIndex = 1;
            this.labelThenBy.Text = "Then by";
            // 
            // labelOrderBy
            // 
            this.labelOrderBy.AutoSize = true;
            this.labelOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOrderBy.Location = new System.Drawing.Point(2, 12);
            this.labelOrderBy.Name = "labelOrderBy";
            this.labelOrderBy.Size = new System.Drawing.Size(47, 13);
            this.labelOrderBy.TabIndex = 0;
            this.labelOrderBy.Text = "Order by";
            // 
            // groupBoxLimit
            // 
            this.groupBoxLimit.Controls.Add(this.labelItems);
            this.groupBoxLimit.Controls.Add(this.numericUpDown1);
            this.groupBoxLimit.Controls.Add(this.checkBoxOnlyTake);
            this.groupBoxLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxLimit.Location = new System.Drawing.Point(3, 98);
            this.groupBoxLimit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLimit.MinimumSize = new System.Drawing.Size(243, 33);
            this.groupBoxLimit.Name = "groupBoxLimit";
            this.groupBoxLimit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLimit.Size = new System.Drawing.Size(243, 38);
            this.groupBoxLimit.TabIndex = 1;
            this.groupBoxLimit.TabStop = false;
            this.groupBoxLimit.Text = "Limit";
            // 
            // checkBoxOnlyTake
            // 
            this.checkBoxOnlyTake.AutoSize = true;
            this.checkBoxOnlyTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxOnlyTake.Location = new System.Drawing.Point(6, 16);
            this.checkBoxOnlyTake.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxOnlyTake.Name = "checkBoxOnlyTake";
            this.checkBoxOnlyTake.Size = new System.Drawing.Size(71, 17);
            this.checkBoxOnlyTake.TabIndex = 0;
            this.checkBoxOnlyTake.Text = "Only take";
            this.checkBoxOnlyTake.UseVisualStyleBackColor = true;
            // 
            // groupBoxFiltersList
            // 
            this.groupBoxFiltersList.Controls.Add(this.btnSaveFilters);
            this.groupBoxFiltersList.Controls.Add(this.btnApplyFilters);
            this.groupBoxFiltersList.Controls.Add(this.btnOpenFilters);
            this.groupBoxFiltersList.Controls.Add(this.btnClearList);
            this.groupBoxFiltersList.Controls.Add(this.listBoxFilters);
            this.groupBoxFiltersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFiltersList.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxFiltersList.Location = new System.Drawing.Point(258, 2);
            this.groupBoxFiltersList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFiltersList.MinimumSize = new System.Drawing.Size(190, 138);
            this.groupBoxFiltersList.Name = "groupBoxFiltersList";
            this.groupBoxFiltersList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFiltersList.Size = new System.Drawing.Size(341, 138);
            this.groupBoxFiltersList.TabIndex = 1;
            this.groupBoxFiltersList.TabStop = false;
            this.groupBoxFiltersList.Text = "Filters list";
            // 
            // listBoxFilters
            // 
            this.listBoxFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxFilters.FormattingEnabled = true;
            this.listBoxFilters.ItemHeight = 12;
            this.listBoxFilters.Location = new System.Drawing.Point(3, 14);
            this.listBoxFilters.Name = "listBoxFilters";
            this.listBoxFilters.Size = new System.Drawing.Size(335, 64);
            this.listBoxFilters.TabIndex = 0;
            // 
            // btnClearList
            // 
            this.btnClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearList.Location = new System.Drawing.Point(3, 83);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(75, 23);
            this.btnClearList.TabIndex = 1;
            this.btnClearList.Text = "Clear list";
            this.btnClearList.UseVisualStyleBackColor = true;
            // 
            // btnOpenFilters
            // 
            this.btnOpenFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenFilters.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenFilters.Location = new System.Drawing.Point(3, 109);
            this.btnOpenFilters.Name = "btnOpenFilters";
            this.btnOpenFilters.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFilters.TabIndex = 2;
            this.btnOpenFilters.Text = "Open filters";
            this.btnOpenFilters.UseVisualStyleBackColor = true;
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyFilters.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnApplyFilters.Location = new System.Drawing.Point(263, 83);
            this.btnApplyFilters.Name = "btnApplyFilters";
            this.btnApplyFilters.Size = new System.Drawing.Size(75, 23);
            this.btnApplyFilters.TabIndex = 3;
            this.btnApplyFilters.Text = "Apply";
            this.btnApplyFilters.UseVisualStyleBackColor = true;
            // 
            // btnSaveFilters
            // 
            this.btnSaveFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveFilters.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveFilters.Location = new System.Drawing.Point(263, 109);
            this.btnSaveFilters.Name = "btnSaveFilters";
            this.btnSaveFilters.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFilters.TabIndex = 4;
            this.btnSaveFilters.Text = "Save filters";
            this.btnSaveFilters.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = true;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.Location = new System.Drawing.Point(83, 13);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelItems.Location = new System.Drawing.Point(130, 17);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(31, 13);
            this.labelItems.TabIndex = 2;
            this.labelItems.Text = "items";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilterConditions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBoxSort.ResumeLayout(false);
            this.groupBoxSort.PerformLayout();
            this.groupBoxLimit.ResumeLayout(false);
            this.groupBoxLimit.PerformLayout();
            this.groupBoxFiltersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Button buttonApplyFilter;
        private System.Windows.Forms.Button buttonAddToFiltersList;
        private System.Windows.Forms.Button buttonAddCondition;
        private System.Windows.Forms.Button buttonClearConditions;
        private System.Windows.Forms.GroupBox groupBoxFilterConditions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBoxSort;
        private System.Windows.Forms.RadioButton rBThenByDesc;
        private System.Windows.Forms.RadioButton rBThenByAsc;
        private System.Windows.Forms.RadioButton rBOrderByDesc;
        private System.Windows.Forms.RadioButton rBOrderByAsc;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelThenBy;
        private System.Windows.Forms.Label labelOrderBy;
        private System.Windows.Forms.GroupBox groupBoxLimit;
        private System.Windows.Forms.CheckBox checkBoxOnlyTake;
        private System.Windows.Forms.GroupBox groupBoxFiltersList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnSaveFilters;
        private System.Windows.Forms.Button btnApplyFilters;
        private System.Windows.Forms.Button btnOpenFilters;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.ListBox listBoxFilters;
    }
}

