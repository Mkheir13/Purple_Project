namespace pong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CpuScore = new System.Windows.Forms.Label();
            this.PlayerScore = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.playertwo = new System.Windows.Forms.PictureBox();
            this.playerone = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Timers.Timer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playertwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CpuScore);
            this.panel1.Controls.Add(this.PlayerScore);
            this.panel1.Controls.Add(this.ball);
            this.panel1.Controls.Add(this.playertwo);
            this.panel1.Controls.Add(this.playerone);
            this.panel1.Location = new System.Drawing.Point(4, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 400);
            this.panel1.TabIndex = 0;
            this.panel1.Tag = "panel";
            // 
            // CpuScore
            // 
            this.CpuScore.BackColor = System.Drawing.Color.Transparent;
            this.CpuScore.ForeColor = System.Drawing.Color.OrangeRed;
            this.CpuScore.Location = new System.Drawing.Point(428, 35);
            this.CpuScore.Name = "CpuScore";
            this.CpuScore.Size = new System.Drawing.Size(19, 23);
            this.CpuScore.TabIndex = 4;
            this.CpuScore.Tag = "CpuScore";
            this.CpuScore.Text = "Score ";
            // 
            // PlayerScore
            // 
            this.PlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.PlayerScore.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PlayerScore.Location = new System.Drawing.Point(301, 35);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(18, 23);
            this.PlayerScore.TabIndex = 3;
            this.PlayerScore.Tag = "PlayerScore";
            this.PlayerScore.Text = "Score";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.Control;
            this.ball.Location = new System.Drawing.Point(373, 200);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(22, 22);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            this.ball.Tag = "ball";
            // 
            // playertwo
            // 
            this.playertwo.BackColor = System.Drawing.SystemColors.Control;
            this.playertwo.Location = new System.Drawing.Point(731, 156);
            this.playertwo.Name = "playertwo";
            this.playertwo.Size = new System.Drawing.Size(30, 90);
            this.playertwo.TabIndex = 1;
            this.playertwo.TabStop = false;
            this.playertwo.Tag = "player";
            // 
            // playerone
            // 
            this.playerone.BackColor = System.Drawing.SystemColors.Control;
            this.playerone.Location = new System.Drawing.Point(7, 156);
            this.playerone.Name = "playerone";
            this.playerone.Size = new System.Drawing.Size(30, 90);
            this.playerone.TabIndex = 0;
            this.playerone.TabStop = false;
            this.playerone.Tag = "player";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playertwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label CpuScore;

        private System.Windows.Forms.Label PlayerScore;

        private System.Timers.Timer timer1;

        private System.Windows.Forms.PictureBox ball;

        private System.Windows.Forms.PictureBox playertwo;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox playerone;

        #endregion
    }
}