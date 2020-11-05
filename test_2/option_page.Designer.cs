namespace test_2
{
    partial class option_page
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
            this.option_menu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_sound = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.option_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // option_menu
            // 
            this.option_menu.BackgroundImage = global::test_2.Properties.Resources.option_menu;
            this.option_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.option_menu.Controls.Add(this.pictureBox1);
            this.option_menu.Controls.Add(this.btn_sound);
            this.option_menu.Controls.Add(this.trackBar1);
            this.option_menu.Location = new System.Drawing.Point(183, 12);
            this.option_menu.Name = "option_menu";
            this.option_menu.Size = new System.Drawing.Size(570, 603);
            this.option_menu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::test_2.Properties.Resources.sound_on;
            this.pictureBox1.Location = new System.Drawing.Point(487, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // btn_sound
            // 
            this.btn_sound.Image = global::test_2.Properties.Resources.sound_on;
            this.btn_sound.Location = new System.Drawing.Point(254, 359);
            this.btn_sound.Name = "btn_sound";
            this.btn_sound.Size = new System.Drawing.Size(50, 50);
            this.btn_sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_sound.TabIndex = 1;
            this.btn_sound.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.Location = new System.Drawing.Point(178, 251);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(192, 69);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // option_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 644);
            this.Controls.Add(this.option_menu);
            this.MaximumSize = new System.Drawing.Size(940, 700);
            this.MinimumSize = new System.Drawing.Size(940, 700);
            this.Name = "option_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "option_page";
            this.Load += new System.EventHandler(this.option_page_Load);
            this.option_menu.ResumeLayout(false);
            this.option_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel option_menu;
        private System.Windows.Forms.PictureBox btn_sound;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}