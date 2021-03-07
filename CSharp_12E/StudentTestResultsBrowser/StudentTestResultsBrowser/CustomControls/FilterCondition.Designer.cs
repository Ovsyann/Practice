
namespace StudentTestResultsBrowser.CustomControls
{
    partial class FilterCondition
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
            this.labelProperty = new System.Windows.Forms.Label();
            this.labelOperation = new System.Windows.Forms.Label();
            this.comboBoxProperty = new System.Windows.Forms.ComboBox();
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.labelValueA = new System.Windows.Forms.Label();
            this.labelValueB = new System.Windows.Forms.Label();
            this.textBoxValueA = new System.Windows.Forms.TextBox();
            this.textBoxValueB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelProperty
            // 
            this.labelProperty.AutoSize = true;
            this.labelProperty.Location = new System.Drawing.Point(12, 13);
            this.labelProperty.Name = "labelProperty";
            this.labelProperty.Size = new System.Drawing.Size(52, 15);
            this.labelProperty.TabIndex = 0;
            this.labelProperty.Text = "Property";
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.Location = new System.Drawing.Point(199, 13);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(60, 15);
            this.labelOperation.TabIndex = 1;
            this.labelOperation.Text = "Operation";
            // 
            // comboBoxProperty
            // 
            this.comboBoxProperty.FormattingEnabled = true;
            this.comboBoxProperty.Location = new System.Drawing.Point(12, 31);
            this.comboBoxProperty.Name = "comboBoxProperty";
            this.comboBoxProperty.Size = new System.Drawing.Size(121, 23);
            this.comboBoxProperty.TabIndex = 2;
            // 
            // comboBoxOperation
            // 
            this.comboBoxOperation.FormattingEnabled = true;
            this.comboBoxOperation.Location = new System.Drawing.Point(199, 31);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.Size = new System.Drawing.Size(121, 23);
            this.comboBoxOperation.TabIndex = 3;
            // 
            // labelValueA
            // 
            this.labelValueA.AutoSize = true;
            this.labelValueA.Location = new System.Drawing.Point(12, 85);
            this.labelValueA.Name = "labelValueA";
            this.labelValueA.Size = new System.Drawing.Size(47, 15);
            this.labelValueA.TabIndex = 4;
            this.labelValueA.Text = "Value A";
            // 
            // labelValueB
            // 
            this.labelValueB.AutoSize = true;
            this.labelValueB.Location = new System.Drawing.Point(199, 85);
            this.labelValueB.Name = "labelValueB";
            this.labelValueB.Size = new System.Drawing.Size(46, 15);
            this.labelValueB.TabIndex = 5;
            this.labelValueB.Text = "Value B";
            // 
            // textBoxValueA
            // 
            this.textBoxValueA.Location = new System.Drawing.Point(12, 103);
            this.textBoxValueA.Name = "textBoxValueA";
            this.textBoxValueA.Size = new System.Drawing.Size(121, 23);
            this.textBoxValueA.TabIndex = 6;
            // 
            // textBoxValueB
            // 
            this.textBoxValueB.Location = new System.Drawing.Point(199, 103);
            this.textBoxValueB.Name = "textBoxValueB";
            this.textBoxValueB.Size = new System.Drawing.Size(121, 23);
            this.textBoxValueB.TabIndex = 7;
            // 
            // FilterCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxValueB);
            this.Controls.Add(this.textBoxValueA);
            this.Controls.Add(this.labelValueB);
            this.Controls.Add(this.labelValueA);
            this.Controls.Add(this.comboBoxOperation);
            this.Controls.Add(this.comboBoxProperty);
            this.Controls.Add(this.labelOperation);
            this.Controls.Add(this.labelProperty);
            this.Name = "FilterCondition";
            this.Size = new System.Drawing.Size(331, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProperty;
        private System.Windows.Forms.Label labelOperation;
        private System.Windows.Forms.ComboBox comboBoxProperty;
        private System.Windows.Forms.ComboBox comboBoxOperation;
        private System.Windows.Forms.Label labelValueA;
        private System.Windows.Forms.Label labelValueB;
        private System.Windows.Forms.TextBox textBoxValueA;
        private System.Windows.Forms.TextBox textBoxValueB;
    }
}
