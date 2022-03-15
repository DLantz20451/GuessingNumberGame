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
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnStartReplay = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 124);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 20);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblGeusses
            // 
            this.lblGeusses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGeusses.Location = new System.Drawing.Point(140, 17);
            this.lblGeusses.Name = "lblGeusses";
            this.lblGeusses.Size = new System.Drawing.Size(75, 20);
            this.lblGeusses.TabIndex = 0;
            // 
            // txtBoxGuess
            // 
            this.txtBoxGuess.Location = new System.Drawing.Point(12, 17);
            this.txtBoxGuess.Name = "txtBoxGuess";
            this.txtBoxGuess.Size = new System.Drawing.Size(75, 20);
            this.txtBoxGuess.TabIndex = 0;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(140, 124);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 20);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "&Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnStartReplay
            // 
            this.btnStartReplay.Location = new System.Drawing.Point(12, 64);
            this.btnStartReplay.Name = "btnStartReplay";
            this.btnStartReplay.Size = new System.Drawing.Size(75, 34);
            this.btnStartReplay.TabIndex = 2;
            this.btnStartReplay.Text = "Start/Replay";
            this.btnStartReplay.UseVisualStyleBackColor = true;
            this.btnStartReplay.Click += new System.EventHandler(this.btnStartReplay_Click);
            // 
            // lblHint
            // 
            this.lblHint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHint.Location = new System.Drawing.Point(140, 64);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(75, 34);
            this.lblHint.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 211);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.btnStartReplay);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtBoxGuess);
            this.Controls.Add(this.lblGeusses);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblGeusses;
        private System.Windows.Forms.TextBox txtBoxGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnStartReplay;
        private System.Windows.Forms.Label lblHint;
    }
}

