namespace test_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menu = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.btn_option = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_option)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(57, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu.Controls.Add(this.btn_exit);
            this.menu.Controls.Add(this.btn_option);
            this.menu.Controls.Add(this.btn_start);
            this.menu.Location = new System.Drawing.Point(231, 57);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(444, 550);
            this.menu.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::test_2.Properties.Resources.exit_normal;
            this.btn_exit.Location = new System.Drawing.Point(131, 363);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(158, 76);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_exit.TabIndex = 2;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            this.btn_exit.MouseHover += new System.EventHandler(this.btn_exit_MouseHover);
            // 
            // btn_option
            // 
            this.btn_option.Image = global::test_2.Properties.Resources.option_normal;
            this.btn_option.Location = new System.Drawing.Point(131, 256);
            this.btn_option.Name = "btn_option";
            this.btn_option.Size = new System.Drawing.Size(158, 76);
            this.btn_option.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_option.TabIndex = 1;
            this.btn_option.TabStop = false;
            this.btn_option.Click += new System.EventHandler(this.btn_option_Click);
            this.btn_option.MouseLeave += new System.EventHandler(this.btn_option_MouseLeave);
            this.btn_option.MouseHover += new System.EventHandler(this.btn_option_MouseHover);
            // 
            // btn_start
            // 
            this.btn_start.Image = global::test_2.Properties.Resources.start_normal;
            this.btn_start.Location = new System.Drawing.Point(131, 137);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(158, 76);
            this.btn_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_start.TabIndex = 0;
            this.btn_start.TabStop = false;
            this.btn_start.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_start_MouseClick);
            this.btn_start.MouseLeave += new System.EventHandler(this.btn_start_MouseLeave);
            this.btn_start.MouseHover += new System.EventHandler(this.btn_start_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test_2.Properties.Resources.Untitled_1;
            this.ClientSize = new System.Drawing.Size(918, 644);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menu);
            this.MaximumSize = new System.Drawing.Size(940, 700);
            this.MinimumSize = new System.Drawing.Size(940, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_option)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.PictureBox btn_start;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.PictureBox btn_option;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

