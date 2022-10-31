namespace Platform
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
            this.player = new System.Windows.Forms.PictureBox();
            this.timer = new System.Timers.Timer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Porte = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Porte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Platform.Properties.Resources.finnidle;
            this.player.Location = new System.Drawing.Point(12, 317);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(39, 62);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 25D;
            this.timer.SynchronizingObject = this;
            this.timer.Elapsed += new System.Timers.ElapsedEventHandler(this.timer_Elapsed);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Platform.Properties.Resources.plateform1;
            this.pictureBox2.Location = new System.Drawing.Point(6, 376);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(146, 397);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 22);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platformno";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(152, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 22);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "vertical_platform";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(152, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(130, 22);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platformno";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Platform.Properties.Resources.plateform;
            this.pictureBox5.Location = new System.Drawing.Point(333, 121);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(124, 22);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "platform";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Platform.Properties.Resources.plateform;
            this.pictureBox7.Location = new System.Drawing.Point(12, 192);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(124, 22);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "platform";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox6.Location = new System.Drawing.Point(490, 121);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(111, 22);
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "platform_horizon";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Platform.Properties.Resources.plateform;
            this.pictureBox8.Location = new System.Drawing.Point(585, 271);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(203, 22);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 11;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "platform";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::Platform.Properties.Resources.plateform;
            this.pictureBox9.Location = new System.Drawing.Point(377, 357);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(181, 22);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 12;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "platform";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = global::Platform.Properties.Resources.plateform;
            this.pictureBox12.Location = new System.Drawing.Point(672, 376);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(111, 22);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 15;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "platform";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = global::Platform.Properties.Resources.plateform;
            this.pictureBox13.Location = new System.Drawing.Point(677, 71);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(98, 22);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 16;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "platform";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.Location = new System.Drawing.Point(465, 121);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(19, 22);
            this.pictureBox14.TabIndex = 17;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "platformno";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.Location = new System.Drawing.Point(677, 121);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(19, 22);
            this.pictureBox15.TabIndex = 18;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "platformno";
            // 
            // pictureBox28
            // 
            this.pictureBox28.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox28.Image = global::Platform.Properties.Resources.loot;
            this.pictureBox28.Location = new System.Drawing.Point(64, 142);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(20, 18);
            this.pictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox28.TabIndex = 33;
            this.pictureBox28.TabStop = false;
            this.pictureBox28.Tag = "coin";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(299, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 53);
            this.label2.TabIndex = 39;
            this.label2.Text = "Recuperer toutes les pieces pour gagner";
            // 
            // Porte
            // 
            this.Porte.BackColor = System.Drawing.Color.Transparent;
            this.Porte.Image = global::Platform.Properties.Resources.door_open;
            this.Porte.Location = new System.Drawing.Point(721, 329);
            this.Porte.Name = "Porte";
            this.Porte.Size = new System.Drawing.Size(54, 55);
            this.Porte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Porte.TabIndex = 40;
            this.Porte.TabStop = false;
            this.Porte.Tag = "Porte";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = global::Platform.Properties.Resources.key;
            this.pictureBox11.Location = new System.Drawing.Point(377, 192);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(36, 35);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 41;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "Clefs";
            // 
            // pictureBox33
            // 
            this.pictureBox33.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox33.Image = global::Platform.Properties.Resources.enemyleft;
            this.pictureBox33.Location = new System.Drawing.Point(717, 243);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(41, 29);
            this.pictureBox33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox33.TabIndex = 42;
            this.pictureBox33.TabStop = false;
            this.pictureBox33.Tag = "enemy";
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox24.Image = global::Platform.Properties.Resources.enemyright;
            this.pictureBox24.Location = new System.Drawing.Point(429, 329);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(41, 29);
            this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox24.TabIndex = 43;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.Tag = "enemy2";
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox25.Location = new System.Drawing.Point(585, 243);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(19, 22);
            this.pictureBox25.TabIndex = 44;
            this.pictureBox25.TabStop = false;
            this.pictureBox25.Tag = "platformno";
            // 
            // pictureBox26
            // 
            this.pictureBox26.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox26.Location = new System.Drawing.Point(764, 243);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(19, 22);
            this.pictureBox26.TabIndex = 45;
            this.pictureBox26.TabStop = false;
            this.pictureBox26.Tag = "platformno";
            // 
            // pictureBox27
            // 
            this.pictureBox27.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox27.Location = new System.Drawing.Point(360, 329);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(19, 22);
            this.pictureBox27.TabIndex = 46;
            this.pictureBox27.TabStop = false;
            this.pictureBox27.Tag = "platformno";
            // 
            // pictureBox34
            // 
            this.pictureBox34.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox34.Location = new System.Drawing.Point(539, 329);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(19, 22);
            this.pictureBox34.TabIndex = 47;
            this.pictureBox34.TabStop = false;
            this.pictureBox34.Tag = "platformno";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::Platform.Properties.Resources.loot;
            this.pictureBox10.Location = new System.Drawing.Point(676, 168);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(20, 18);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 48;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "coin";
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox16.Image = global::Platform.Properties.Resources.loot;
            this.pictureBox16.Location = new System.Drawing.Point(450, 305);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(20, 18);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 49;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "coin";
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox17.Image = global::Platform.Properties.Resources.loot;
            this.pictureBox17.Location = new System.Drawing.Point(721, 37);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(20, 18);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 50;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "coin";
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox18.Image = global::Platform.Properties.Resources.loot;
            this.pictureBox18.Location = new System.Drawing.Point(201, 56);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(20, 18);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 51;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "coin";
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox20.Location = new System.Drawing.Point(-4, 435);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(807, 16);
            this.pictureBox20.TabIndex = 53;
            this.pictureBox20.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Platform.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox34);
            this.Controls.Add(this.pictureBox27);
            this.Controls.Add(this.pictureBox26);
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox33);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.Porte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox28);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Porte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBox20;

        private System.Windows.Forms.PictureBox pictureBox18;

        private System.Windows.Forms.PictureBox pictureBox17;

        private System.Windows.Forms.PictureBox pictureBox16;

        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.PictureBox pictureBox27;
        private System.Windows.Forms.PictureBox pictureBox34;

        private System.Windows.Forms.PictureBox pictureBox33;

        private System.Windows.Forms.PictureBox pictureBox11;

        private System.Windows.Forms.PictureBox Porte;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox pictureBox28;

        private System.Windows.Forms.PictureBox pictureBox10;

        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;

        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox12;

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;

        private System.Windows.Forms.PictureBox pictureBox4;

        private System.Windows.Forms.PictureBox pictureBox3;

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Timers.Timer timer;

        private System.Windows.Forms.PictureBox player;

        #endregion
    }
}