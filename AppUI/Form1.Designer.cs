namespace AppUI
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
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.listBoxCheckIn = new System.Windows.Forms.ListBox();
            this.listBoxProfie = new System.Windows.Forms.ListBox();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.buttonFeature1 = new System.Windows.Forms.Button();
            this.buttonFeature2 = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.listBoxFeed = new System.Windows.Forms.ListBox();
            this.labelCheckIn = new System.Windows.Forms.Label();
            this.labelEvents = new System.Windows.Forms.Label();
            this.labelPages = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelFeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(35, 12);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(110, 71);
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxPost
            // 
            this.textBoxPost.HideSelection = false;
            this.textBoxPost.Location = new System.Drawing.Point(206, 54);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(304, 20);
            this.textBoxPost.TabIndex = 1;
            this.textBoxPost.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(12, 115);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(154, 121);
            this.listBoxEvents.TabIndex = 3;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // listBoxCheckIn
            // 
            this.listBoxCheckIn.FormattingEnabled = true;
            this.listBoxCheckIn.Location = new System.Drawing.Point(12, 271);
            this.listBoxCheckIn.Name = "listBoxCheckIn";
            this.listBoxCheckIn.Size = new System.Drawing.Size(154, 121);
            this.listBoxCheckIn.TabIndex = 4;
            this.listBoxCheckIn.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // listBoxProfie
            // 
            this.listBoxProfie.FormattingEnabled = true;
            this.listBoxProfie.Location = new System.Drawing.Point(566, 115);
            this.listBoxProfie.Name = "listBoxProfie";
            this.listBoxProfie.Size = new System.Drawing.Size(154, 121);
            this.listBoxProfie.TabIndex = 6;
            this.listBoxProfie.SelectedIndexChanged += new System.EventHandler(this.listBoxProfie_SelectedIndexChanged);
            // 
            // listBoxPages
            // 
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.Location = new System.Drawing.Point(566, 271);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(154, 121);
            this.listBoxPages.TabIndex = 7;
            // 
            // buttonFeature1
            // 
            this.buttonFeature1.Location = new System.Drawing.Point(82, 414);
            this.buttonFeature1.Name = "buttonFeature1";
            this.buttonFeature1.Size = new System.Drawing.Size(203, 23);
            this.buttonFeature1.TabIndex = 9;
            this.buttonFeature1.Text = "buttonFeature1";
            this.buttonFeature1.UseVisualStyleBackColor = true;
            // 
            // buttonFeature2
            // 
            this.buttonFeature2.Location = new System.Drawing.Point(452, 414);
            this.buttonFeature2.Name = "buttonFeature2";
            this.buttonFeature2.Size = new System.Drawing.Size(203, 23);
            this.buttonFeature2.TabIndex = 10;
            this.buttonFeature2.Text = "buttonFeature2";
            this.buttonFeature2.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(239, 25);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 11;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(527, 52);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 12;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(403, 25);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 13;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // listBoxFeed
            // 
            this.listBoxFeed.FormattingEnabled = true;
            this.listBoxFeed.Location = new System.Drawing.Point(190, 115);
            this.listBoxFeed.Name = "listBoxFeed";
            this.listBoxFeed.Size = new System.Drawing.Size(347, 277);
            this.listBoxFeed.TabIndex = 2;
            this.listBoxFeed.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelCheckIn
            // 
            this.labelCheckIn.AutoSize = true;
            this.labelCheckIn.Location = new System.Drawing.Point(61, 255);
            this.labelCheckIn.Name = "labelCheckIn";
            this.labelCheckIn.Size = new System.Drawing.Size(50, 13);
            this.labelCheckIn.TabIndex = 14;
            this.labelCheckIn.Text = "Check In";
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Location = new System.Drawing.Point(61, 99);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(40, 13);
            this.labelEvents.TabIndex = 15;
            this.labelEvents.Text = "Events";
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(625, 255);
            this.labelPages.Name = "labelPages";
            this.labelPages.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPages.Size = new System.Drawing.Size(37, 13);
            this.labelPages.TabIndex = 16;
            this.labelPages.Text = "Pages";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(614, 99);
            this.labelData.Name = "labelData";
            this.labelData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelData.Size = new System.Drawing.Size(60, 13);
            this.labelData.TabIndex = 17;
            this.labelData.Text = "Profile data";
            // 
            // labelFeed
            // 
            this.labelFeed.AutoSize = true;
            this.labelFeed.Location = new System.Drawing.Point(335, 99);
            this.labelFeed.Name = "labelFeed";
            this.labelFeed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFeed.Size = new System.Drawing.Size(58, 13);
            this.labelFeed.TabIndex = 18;
            this.labelFeed.Text = "News feed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 464);
            this.Controls.Add(this.labelFeed);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.labelCheckIn);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonFeature2);
            this.Controls.Add(this.buttonFeature1);
            this.Controls.Add(this.listBoxPages);
            this.Controls.Add(this.listBoxProfie);
            this.Controls.Add(this.listBoxCheckIn);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.listBoxFeed);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.pictureBoxProfile);
            this.Name = "Form1";
            this.Text = "FormGroups";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxCheckIn;
        private System.Windows.Forms.ListBox listBoxProfie;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.Button buttonFeature1;
        private System.Windows.Forms.Button buttonFeature2;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ListBox listBoxFeed;
        private System.Windows.Forms.Label labelCheckIn;
        private System.Windows.Forms.Label labelEvents;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelFeed;
    }
}

