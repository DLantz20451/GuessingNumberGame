namespace GuessingNumberGame
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblGeusses = new System.Windows.Forms.Label();
            this.txtBoxGuess = new System.Windows.Forms.TextBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnReplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(140, 79);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 20);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblGeusses
            // 
            this.lblGeusses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGeusses.Location = new System.Drawing.Point(140, 41);
            this.lblGeusses.Name = "lblGeusses";
            this.lblGeusses.Size = new System.Drawing.Size(75, 20);
            this.lblGeusses.TabIndex = 0;
            // 
            // txtBoxGuess
            // 
            this.txtBoxGuess.Location = new System.Drawing.Point(12, 120);
            this.txtBoxGuess.Name = "txtBoxGuess";
            this.txtBoxGuess.Size = new System.Drawing.Size(203, 20);
            this.txtBoxGuess.TabIndex = 0;
            // 
            // lblHint
            // 
            this.lblHint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHint.Location = new System.Drawing.Point(12, 41);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(75, 20);
            this.lblHint.TabIndex = 3;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(12, 79);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 20);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "&Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnReplay
            // 
            this.btnReplay.Location = new System.Drawing.Point(12, 79);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(75, 20);
            this.btnReplay.TabIndex = 2;
            this.btnReplay.Text = "&Replay";
            this.btnReplay.UseVisualStyleBackColor = true;
            this.btnReplay.Click += new System.EventHandler(this.bntReplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Guessing Game 1 - 100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 156);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.txtBoxGuess);
            this.Controls.Add(this.lblGeusses);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblGeusses;
        private System.Windows.Forms.TextBox txtBoxGuess;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.Label label1;
    }
}

