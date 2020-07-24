namespace TanksGame
{
    partial class GameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pBGameField = new System.Windows.Forms.PictureBox();
            this.timeRefresh = new System.Windows.Forms.Timer(this.components);
            this.btnParameters = new System.Windows.Forms.Button();
            this.tbEnemy = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBonus = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMapWidth = new System.Windows.Forms.TrackBar();
            this.tbMapHeight = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBGameField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMapWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMapHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // pBGameField
            // 
            this.pBGameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBGameField.Location = new System.Drawing.Point(-1, -2);
            this.pBGameField.Name = "pBGameField";
            this.pBGameField.Size = new System.Drawing.Size(710, 352);
            this.pBGameField.TabIndex = 0;
            this.pBGameField.TabStop = false;
            // 
            // timeRefresh
            // 
            this.timeRefresh.Tick += new System.EventHandler(this.timeRefresh_Tick);
            // 
            // btnParameters
            // 
            this.btnParameters.Location = new System.Drawing.Point(596, 356);
            this.btnParameters.Name = "btnParameters";
            this.btnParameters.Size = new System.Drawing.Size(102, 34);
            this.btnParameters.TabIndex = 2;
            this.btnParameters.Text = "Sent parameters to game";
            this.btnParameters.UseVisualStyleBackColor = true;
            this.btnParameters.Click += new System.EventHandler(this.btnParameters_Click);
            // 
            // tbEnemy
            // 
            this.tbEnemy.Location = new System.Drawing.Point(88, 356);
            this.tbEnemy.Maximum = 6;
            this.tbEnemy.Minimum = 3;
            this.tbEnemy.Name = "tbEnemy";
            this.tbEnemy.Size = new System.Drawing.Size(104, 45);
            this.tbEnemy.TabIndex = 3;
            this.tbEnemy.Value = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enemies count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bonuses count";
            // 
            // tbBonus
            // 
            this.tbBonus.Location = new System.Drawing.Point(299, 356);
            this.tbBonus.Maximum = 6;
            this.tbBonus.Minimum = 3;
            this.tbBonus.Name = "tbBonus";
            this.tbBonus.Size = new System.Drawing.Size(104, 45);
            this.tbBonus.TabIndex = 5;
            this.tbBonus.Value = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Speed";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(463, 356);
            this.tbSpeed.Maximum = 6;
            this.tbSpeed.Minimum = 3;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(104, 45);
            this.tbSpeed.TabIndex = 7;
            this.tbSpeed.Value = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Map width";
            // 
            // tbMapWidth
            // 
            this.tbMapWidth.Location = new System.Drawing.Point(88, 407);
            this.tbMapWidth.Maximum = 6;
            this.tbMapWidth.Minimum = 3;
            this.tbMapWidth.Name = "tbMapWidth";
            this.tbMapWidth.Size = new System.Drawing.Size(104, 45);
            this.tbMapWidth.TabIndex = 9;
            this.tbMapWidth.Value = 3;
            // 
            // tbMapHeight
            // 
            this.tbMapHeight.Location = new System.Drawing.Point(299, 407);
            this.tbMapHeight.Maximum = 6;
            this.tbMapHeight.Minimum = 3;
            this.tbMapHeight.Name = "tbMapHeight";
            this.tbMapHeight.Size = new System.Drawing.Size(104, 45);
            this.tbMapHeight.TabIndex = 11;
            this.tbMapHeight.Value = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Map height";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "StartGame";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMapHeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMapWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBonus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEnemy);
            this.Controls.Add(this.btnParameters);
            this.Controls.Add(this.pBGameField);
            this.Name = "GameForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBGameField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMapWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMapHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBGameField;
        private System.Windows.Forms.Timer timeRefresh;
        private System.Windows.Forms.Button btnParameters;
        private System.Windows.Forms.TrackBar tbEnemy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbBonus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbMapWidth;
        private System.Windows.Forms.TrackBar tbMapHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

