
namespace StudentsTestsResultsBrowser.CustomControls
{
    partial class FilterConditionsListUserControl
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
            this.layoutPanelControl = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // layoutPanelControl
            // 
            this.layoutPanelControl.AutoScroll = true;
            this.layoutPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanelControl.Location = new System.Drawing.Point(0, 0);
            this.layoutPanelControl.Name = "layoutPanelControl";
            this.layoutPanelControl.Size = new System.Drawing.Size(240, 182);
            this.layoutPanelControl.TabIndex = 0;
            this.layoutPanelControl.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.layoutPanelControl_ControlAdded);
            // 
            // FilterConditionsListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutPanelControl);
            this.Name = "FilterConditionsListUserControl";
            this.Size = new System.Drawing.Size(240, 182);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layoutPanelControl;
    }
}
