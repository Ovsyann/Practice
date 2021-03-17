
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
            this.comboBoxProperty = new System.Windows.Forms.ComboBox();
            this.comboBoxOperations = new System.Windows.Forms.ComboBox();
            this.textBoxValueA = new System.Windows.Forms.TextBox();
            this.textBoxValueB = new System.Windows.Forms.TextBox();
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
            this.labelProperty.Location = new System.Drawing.Point(3, 11);
            this.labelProperty.Name = "labelProperty";
            this.labelProperty.Size = new System.Drawing.Size(100, 13);
            this.labelProperty.TabIndex = 0;
            this.labelProperty.Text = "Property";
            // 
            // labelOperations
            // 
            this.labelOperations.AutoSize = true;
            this.labelOperations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelOperations.Location = new System.Drawing.Point(109, 11);
            this.labelOperations.Name = "labelOperations";
            this.labelOperations.Size = new System.Drawing.Size(100, 13);
            this.labelOperations.TabIndex = 1;
            this.labelOperations.Text = "Operations";
            // 
            // comboBoxProperty
            // 
            this.comboBoxProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProperty.FormattingEnabled = true;
            this.comboBoxProperty.Location = new System.Drawing.Point(3, 27);
            this.comboBoxProperty.Name = "comboBoxProperty";
            this.comboBoxProperty.Size = new System.Drawing.Size(100, 21);
            this.comboBoxProperty.TabIndex = 2;
            // 
            // comboBoxOperations
            // 
            this.comboBoxOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxOperations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperations.FormattingEnabled = true;
            this.comboBoxOperations.Location = new System.Drawing.Point(109, 27);
            this.comboBoxOperations.Name = "comboBoxOperations";
            this.comboBoxOperations.Size = new System.Drawing.Size(100, 21);
            this.comboBoxOperations.TabIndex = 3;
            // 
            // textBoxValueA
            // 
            this.textBoxValueA.Location = new System.Drawing.Point(3, 75);
            this.textBoxValueA.Name = "textBoxValueA";
            this.textBoxValueA.Size = new System.Drawing.Size(100, 20);
            this.textBoxValueA.TabIndex = 4;
            // 
            // textBoxValueB
            // 
            this.textBoxValueB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxValueB.Location = new System.Drawing.Point(109, 75);
            this.textBoxValueB.Name = "textBoxValueB";
            this.textBoxValueB.Size = new System.Drawing.Size(100, 20);
            this.textBoxValueB.TabIndex = 5;
            // 
            // labelValueA
            // 
            this.labelValueA.AutoSize = true;
            this.labelValueA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelValueA.Location = new System.Drawing.Point(3, 59);
            this.labelValueA.Name = "labelValueA";
            this.labelValueA.Size = new System.Drawing.Size(100, 13);
            this.labelValueA.TabIndex = 6;
            this.labelValueA.Text = "Value A";
            // 
            // labelValueB
            // 
            this.labelValueB.AutoSize = true;
            this.labelValueB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelValueB.Location = new System.Drawing.Point(109, 59);
            this.labelValueB.Name = "labelValueB";
            this.labelValueB.Size = new System.Drawing.Size(100, 13);
            this.labelValueB.TabIndex = 7;
            this.labelValueB.Text = "Value B";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelProperty, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxValueA, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelValueA, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelValueB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxValueB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxProperty, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxOperations, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelOperations, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(212, 99);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // buttonRemoveCondition
            // 
            this.buttonRemoveCondition.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveCondition.Image")));
            this.buttonRemoveCondition.Location = new System.Drawing.Point(195, 0);
            this.buttonRemoveCondition.Name = "buttonRemoveCondition";
            this.buttonRemoveCondition.Size = new System.Drawing.Size(15, 15);
            this.buttonRemoveCondition.TabIndex = 8;
            this.buttonRemoveCondition.UseVisualStyleBackColor = true;
            this.buttonRemoveCondition.Click += new System.EventHandler(this.buttonRemoveCondition_Click);
            // 
            // FilterConditionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.buttonRemoveCondition);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FilterConditionUserControl";
            this.Size = new System.Drawing.Size(212, 99);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelProperty;
        private System.Windows.Forms.Label labelOperations;
        private System.Windows.Forms.ComboBox comboBoxProperty;
        private System.Windows.Forms.ComboBox comboBoxOperations;
        private System.Windows.Forms.TextBox textBoxValueA;
        private System.Windows.Forms.TextBox textBoxValueB;
        private System.Windows.Forms.Label labelValueA;
        private System.Windows.Forms.Label labelValueB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonRemoveCondition;
    }
}
