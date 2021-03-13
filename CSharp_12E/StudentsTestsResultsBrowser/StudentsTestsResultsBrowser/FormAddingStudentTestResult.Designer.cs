
namespace StudentsTestsResultsBrowser
{
    partial class FormAddingStudentTestResult
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
            this.tableLayoutPanelOuter = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxStudent = new System.Windows.Forms.GroupBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.groupBoxTestResult = new System.Windows.Forms.GroupBox();
            this.numericUpDownTestScore = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerTestDate = new System.Windows.Forms.DateTimePicker();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelTestDate = new System.Windows.Forms.Label();
            this.labelTestName = new System.Windows.Forms.Label();
            this.tableLayoutPanelInner = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxTestName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelOuter.SuspendLayout();
            this.groupBoxStudent.SuspendLayout();
            this.groupBoxTestResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTestScore)).BeginInit();
            this.tableLayoutPanelInner.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelOuter
            // 
            this.tableLayoutPanelOuter.ColumnCount = 1;
            this.tableLayoutPanelOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelOuter.Controls.Add(this.groupBoxStudent, 0, 0);
            this.tableLayoutPanelOuter.Controls.Add(this.groupBoxTestResult, 0, 1);
            this.tableLayoutPanelOuter.Controls.Add(this.tableLayoutPanelInner, 0, 2);
            this.tableLayoutPanelOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOuter.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelOuter.Name = "tableLayoutPanelOuter";
            this.tableLayoutPanelOuter.RowCount = 3;
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOuter.Size = new System.Drawing.Size(312, 262);
            this.tableLayoutPanelOuter.TabIndex = 0;
            // 
            // groupBoxStudent
            // 
            this.groupBoxStudent.Controls.Add(this.textBoxLastName);
            this.groupBoxStudent.Controls.Add(this.textBoxFirstName);
            this.groupBoxStudent.Controls.Add(this.labelLastName);
            this.groupBoxStudent.Controls.Add(this.labelFirstName);
            this.groupBoxStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxStudent.Location = new System.Drawing.Point(3, 3);
            this.groupBoxStudent.Name = "groupBoxStudent";
            this.groupBoxStudent.Size = new System.Drawing.Size(306, 72);
            this.groupBoxStudent.TabIndex = 0;
            this.groupBoxStudent.TabStop = false;
            this.groupBoxStudent.Text = "Student";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(68, 48);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(229, 20);
            this.textBoxLastName.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(68, 24);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(229, 20);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(6, 51);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Lastname:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(6, 27);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(55, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Firstname:";
            // 
            // groupBoxTestResult
            // 
            this.groupBoxTestResult.Controls.Add(this.textBoxTestName);
            this.groupBoxTestResult.Controls.Add(this.numericUpDownTestScore);
            this.groupBoxTestResult.Controls.Add(this.dateTimePickerTestDate);
            this.groupBoxTestResult.Controls.Add(this.labelScore);
            this.groupBoxTestResult.Controls.Add(this.labelTestDate);
            this.groupBoxTestResult.Controls.Add(this.labelTestName);
            this.groupBoxTestResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTestResult.Location = new System.Drawing.Point(3, 81);
            this.groupBoxTestResult.Name = "groupBoxTestResult";
            this.groupBoxTestResult.Size = new System.Drawing.Size(306, 125);
            this.groupBoxTestResult.TabIndex = 1;
            this.groupBoxTestResult.TabStop = false;
            this.groupBoxTestResult.Text = "Test result";
            // 
            // numericUpDownTestScore
            // 
            this.numericUpDownTestScore.Location = new System.Drawing.Point(68, 78);
            this.numericUpDownTestScore.Name = "numericUpDownTestScore";
            this.numericUpDownTestScore.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownTestScore.TabIndex = 6;
            // 
            // dateTimePickerTestDate
            // 
            this.dateTimePickerTestDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTestDate.Location = new System.Drawing.Point(68, 51);
            this.dateTimePickerTestDate.Name = "dateTimePickerTestDate";
            this.dateTimePickerTestDate.Size = new System.Drawing.Size(229, 20);
            this.dateTimePickerTestDate.TabIndex = 5;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(6, 80);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(38, 13);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Score:";
            // 
            // labelTestDate
            // 
            this.labelTestDate.AutoSize = true;
            this.labelTestDate.Location = new System.Drawing.Point(6, 54);
            this.labelTestDate.Name = "labelTestDate";
            this.labelTestDate.Size = new System.Drawing.Size(55, 13);
            this.labelTestDate.TabIndex = 1;
            this.labelTestDate.Text = "Test date:";
            // 
            // labelTestName
            // 
            this.labelTestName.AutoSize = true;
            this.labelTestName.Location = new System.Drawing.Point(6, 28);
            this.labelTestName.Name = "labelTestName";
            this.labelTestName.Size = new System.Drawing.Size(60, 13);
            this.labelTestName.TabIndex = 0;
            this.labelTestName.Text = "Test name:";
            // 
            // tableLayoutPanelInner
            // 
            this.tableLayoutPanelInner.ColumnCount = 2;
            this.tableLayoutPanelInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInner.Controls.Add(this.buttonCancel, 1, 0);
            this.tableLayoutPanelInner.Controls.Add(this.buttonAdd, 0, 0);
            this.tableLayoutPanelInner.Location = new System.Drawing.Point(3, 212);
            this.tableLayoutPanelInner.Name = "tableLayoutPanelInner";
            this.tableLayoutPanelInner.RowCount = 1;
            this.tableLayoutPanelInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelInner.Size = new System.Drawing.Size(306, 33);
            this.tableLayoutPanelInner.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.Location = new System.Drawing.Point(156, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(147, 27);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(147, 27);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxTestName
            // 
            this.textBoxTestName.Location = new System.Drawing.Point(68, 25);
            this.textBoxTestName.Name = "textBoxTestName";
            this.textBoxTestName.Size = new System.Drawing.Size(229, 20);
            this.textBoxTestName.TabIndex = 4;
            // 
            // FormAddingStudentTestResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 262);
            this.Controls.Add(this.tableLayoutPanelOuter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddingStudentTestResult";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Add new student test result";
            this.tableLayoutPanelOuter.ResumeLayout(false);
            this.groupBoxStudent.ResumeLayout(false);
            this.groupBoxStudent.PerformLayout();
            this.groupBoxTestResult.ResumeLayout(false);
            this.groupBoxTestResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTestScore)).EndInit();
            this.tableLayoutPanelInner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOuter;
        private System.Windows.Forms.GroupBox groupBoxStudent;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.GroupBox groupBoxTestResult;
        private System.Windows.Forms.NumericUpDown numericUpDownTestScore;
        private System.Windows.Forms.DateTimePicker dateTimePickerTestDate;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelTestDate;
        private System.Windows.Forms.Label labelTestName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInner;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxTestName;
    }
}