namespace WindowsFormsApp2
{
    partial class Form1
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
            this.GameStart = new System.Windows.Forms.Button();
            this.easy = new System.Windows.Forms.Button();
            this.medium = new System.Windows.Forms.Button();
            this.hard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.heroNameInput = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameStart
            // 
            this.GameStart.Location = new System.Drawing.Point(119, 144);
            this.GameStart.Name = "GameStart";
            this.GameStart.Size = new System.Drawing.Size(75, 27);
            this.GameStart.TabIndex = 0;
            this.GameStart.Text = "Begin";
            this.GameStart.UseVisualStyleBackColor = true;
            this.GameStart.Click += new System.EventHandler(this.GameStart_Click);
            // 
            // easy
            // 
            this.easy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.easy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.easy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.easy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easy.Location = new System.Drawing.Point(25, 72);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(75, 30);
            this.easy.TabIndex = 1;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = false;
            this.easy.Click += new System.EventHandler(this.level1_Click);
            // 
            // medium
            // 
            this.medium.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.medium.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.medium.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.medium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medium.Location = new System.Drawing.Point(119, 72);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(75, 30);
            this.medium.TabIndex = 2;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = false;
            this.medium.Click += new System.EventHandler(this.level2_Click);
            // 
            // hard
            // 
            this.hard.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.hard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.hard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hard.Location = new System.Drawing.Point(213, 72);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(75, 30);
            this.hard.TabIndex = 3;
            this.hard.Text = "Hard";
            this.hard.UseVisualStyleBackColor = false;
            this.hard.Click += new System.EventHandler(this.level3_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter your name hero:";
            // 
            // heroNameInput
            // 
            this.heroNameInput.Location = new System.Drawing.Point(184, 22);
            this.heroNameInput.Name = "heroNameInput";
            this.heroNameInput.Size = new System.Drawing.Size(104, 20);
            this.heroNameInput.TabIndex = 5;
            // 
            // outputLabel
            // 
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputLabel.Location = new System.Drawing.Point(35, 190);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(243, 49);
            this.outputLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(322, 261);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.heroNameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.GameStart);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GameStart;
        private System.Windows.Forms.Button easy;
        private System.Windows.Forms.Button medium;
        private System.Windows.Forms.Button hard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox heroNameInput;
        private System.Windows.Forms.Label outputLabel;
    }
}

