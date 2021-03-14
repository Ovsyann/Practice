
namespace StudentsTestsResultsBrowser
{
    partial class FormAddingFilterToList
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
            this.labelFilterName = new System.Windows.Forms.Label();
            this.textBoxFilterName = new System.Windows.Forms.TextBox();
            this.buttonAddFilter = new System.Windows.Forms.Button();
            this.buttonCancelFilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFilterName
            // 
            this.labelFilterName.AutoSize = true;
            this.labelFilterName.Location = new System.Drawing.Point(12, 9);
            this.labelFilterName.Name = "labelFilterName";
            this.labelFilterName.Size = new System.Drawing.Size(58, 13);
            this.labelFilterName.TabIndex = 0;
            this.labelFilterName.Text = "Filter name";
            // 
            // textBoxFilterName
            // 
            this.textBoxFilterName.Location = new System.Drawing.Point(12, 25);
            this.textBoxFilterName.Name = "textBoxFilterName";
            this.textBoxFilterName.Size = new System.Drawing.Size(181, 20);
            this.textBoxFilterName.TabIndex = 1;
            // 
            // buttonAddFilter
            // 
            this.buttonAddFilter.Location = new System.Drawing.Point(37, 53);
            this.buttonAddFilter.Name = "buttonAddFilter";
            this.buttonAddFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFilter.TabIndex = 2;
            this.buttonAddFilter.Text = "Add";
            this.buttonAddFilter.UseVisualStyleBackColor = true;
            this.buttonAddFilter.Click += new System.EventHandler(this.buttonAddFilter_Click);
            // 
            // buttonCancelFilter
            // 
            this.buttonCancelFilter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelFilter.Location = new System.Drawing.Point(118, 53);
            this.buttonCancelFilter.Name = "buttonCancelFilter";
            this.buttonCancelFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelFilter.TabIndex = 3;
            this.buttonCancelFilter.Text = "Cancel";
            this.buttonCancelFilter.UseVisualStyleBackColor = true;
            // 
            // FormAddingFilterToList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelFilter;
            this.ClientSize = new System.Drawing.Size(205, 88);
            this.Controls.Add(this.buttonCancelFilter);
            this.Controls.Add(this.buttonAddFilter);
            this.Controls.Add(this.textBoxFilterName);
            this.Controls.Add(this.labelFilterName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddingFilterToList";
            this.Text = "Add to filters list";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormAddingFilterToList_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFilterName;
        private System.Windows.Forms.TextBox textBoxFilterName;
        private System.Windows.Forms.Button buttonAddFilter;
        private System.Windows.Forms.Button buttonCancelFilter;
    }
}