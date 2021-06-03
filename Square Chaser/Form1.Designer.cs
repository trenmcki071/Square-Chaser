
namespace Square_Chaser
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.winLabel = new System.Windows.Forms.Label();
            this.score1Label = new System.Windows.Forms.Label();
            this.score2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // winLabel
            // 
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.White;
            this.winLabel.Location = new System.Drawing.Point(12, 9);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(298, 236);
            this.winLabel.TabIndex = 0;
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score1Label
            // 
            this.score1Label.BackColor = System.Drawing.Color.Transparent;
            this.score1Label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.score1Label.Location = new System.Drawing.Point(14, 9);
            this.score1Label.Name = "score1Label";
            this.score1Label.Size = new System.Drawing.Size(100, 23);
            this.score1Label.TabIndex = 1;
            this.score1Label.Text = "0";
            this.score1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score2Label
            // 
            this.score2Label.BackColor = System.Drawing.Color.Transparent;
            this.score2Label.ForeColor = System.Drawing.Color.LightGreen;
            this.score2Label.Location = new System.Drawing.Point(210, 9);
            this.score2Label.Name = "score2Label";
            this.score2Label.Size = new System.Drawing.Size(100, 23);
            this.score2Label.TabIndex = 2;
            this.score2Label.Text = "0";
            this.score2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(322, 254);
            this.Controls.Add(this.score2Label);
            this.Controls.Add(this.score1Label);
            this.Controls.Add(this.winLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label score1Label;
        private System.Windows.Forms.Label score2Label;
    }
}

