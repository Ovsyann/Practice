
namespace StudentsTestsResultsBrowser.CustomControls
{
    partial class FilterConditionUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterConditionUserControl));
            this.labelProperty = new System.Windows.Forms.Label();
            this.labelOperations = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxOperations = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelValueA = new System.Windows.Forms.Label();
            this.labelValueB = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRemoveCondition = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelProperty
            // 
            this.labelProperty.AutoSize = true;
            this.labelProperty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelProperty.Location = new System.Drawing.Point(4, 13);
            this.labelProperty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProperty.Name = "labelProperty";
            this.labelProperty.Size = new System.Drawing.Size(133, 17);
            this.labelProperty.TabIndex = 0;
            this.labelProperty.Text = "Property";
            // 
            // labelOperations
            // 
            this.labelOperations.AutoSize = true;
            this.labelOperations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelOperations.Location = new System.Drawing.Point(145, 13);
            this.labelOperations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOperations.Name = "labelOperations";
            this.labelOperations.Size = new System.Drawing.Size(134, 17);
            this.labelOperations.TabIndex = 1;
            this.labelOperations.Text = "Operations";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(4, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBoxOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxOperations.FormattingEnabled = true;
            this.comboBoxOperations.Location = new System.Drawing.Point(147, 34);
            this.comboBoxOperations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxOperations.Name = "comboBox2";
            this.comboBoxOperations.Size = new System.Drawing.Size(132, 24);
            this.comboBoxOperations.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 94);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(147, 94);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 5;
            // 
            // labelValueA
            // 
            this.labelValueA.AutoSize = true;
            this.labelValueA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelValueA.Location = new System.Drawing.Point(4, 73);
            this.labelValueA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValueA.Name = "labelValueA";
            this.labelValueA.Size = new System.Drawing.Size(133, 17);
            this.labelValueA.TabIndex = 6;
            this.labelValueA.Text = "Value A";
            // 
            // labelValueB
            // 
            this.labelValueB.AutoSize = true;
            this.labelValueB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelValueB.Location = new System.Drawing.Point(145, 73);
            this.labelValueB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValueB.Name = "labelValueB";
            this.labelValueB.Size = new System.Drawing.Size(134, 17);
            this.labelValueB.TabIndex = 7;
            this.labelValueB.Text = "Value B";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelProperty, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelValueA, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelValueB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxOperations, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelOperations, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(283, 122);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // buttonRemoveCondition
            // 
            this.buttonRemoveCondition.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveCondition.Image")));
            this.buttonRemoveCondition.Location = new System.Drawing.Point(260, 0);
            this.buttonRemoveCondition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRemoveCondition.Name = "buttonRemoveCondition";
            this.buttonRemoveCondition.Size = new System.Drawing.Size(20, 18);
            this.buttonRemoveCondition.TabIndex = 8;
            this.buttonRemoveCondition.UseVisualStyleBackColor = true;
            this.buttonRemoveCondition.Click += new System.EventHandler(this.buttonRemoveCondition_Click);
            // 
            // FilterConditionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.buttonRemoveCondition);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FilterConditionUserControl";
            this.Size = new System.Drawing.Size(283, 122);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelProperty;
        private System.Windows.Forms.Label labelOperations;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxOperations;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelValueA;
        private System.Windows.Forms.Label labelValueB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonRemoveCondition;
    }
}
