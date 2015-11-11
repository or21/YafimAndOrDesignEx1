namespace AppUI
{
    partial class Form1
    {
        /// <summary>רגע
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
            this.buttonGetTopPictures = new System.Windows.Forms.Button();
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
            this.pictureBoxProfile.Location = new System.Drawing.Point(48, 32);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(120, 84);
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Click += new System.EventHandler(this.pictureBoxProfile_Click);
            // 
            // textBoxPost
            // 
            this.textBoxPost.HideSelection = false;
            this.textBoxPost.Location = new System.Drawing.Point(225, 86);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(304, 20);
            this.textBoxPost.TabIndex = 1;
            this.textBoxPost.Click += new System.EventHandler(this.textBoxPost_Click);
            this.textBoxPost.TextChanged += new System.EventHandler(this.textBoxPost_TextChanged);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(31, 147);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(154, 121);
            this.listBoxEvents.TabIndex = 3;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // listBoxCheckIn
            // 
            this.listBoxCheckIn.FormattingEnabled = true;
            this.listBoxCheckIn.Location = new System.Drawing.Point(31, 303);
            this.listBoxCheckIn.Name = "listBoxCheckIn";
            this.listBoxCheckIn.Size = new System.Drawing.Size(154, 121);
            this.listBoxCheckIn.TabIndex = 4;
            this.listBoxCheckIn.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // listBoxProfie
            // 
            this.listBoxProfie.FormattingEnabled = true;
            this.listBoxProfie.Location = new System.Drawing.Point(585, 147);
            this.listBoxProfie.Name = "listBoxProfie";
            this.listBoxProfie.Size = new System.Drawing.Size(154, 121);
            this.listBoxProfie.TabIndex = 6;
            this.listBoxProfie.SelectedIndexChanged += new System.EventHandler(this.listBoxProfie_SelectedIndexChanged);
            // 
            // listBoxPages
            // 
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.Location = new System.Drawing.Point(585, 303);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(154, 121);
            this.listBoxPages.TabIndex = 7;
            this.listBoxPages.SelectedIndexChanged += new System.EventHandler(this.listBoxPages_SelectedIndexChanged);
            // 
            // buttonGetTopPictures
            // 
            this.buttonGetTopPictures.Location = new System.Drawing.Point(104, 446);
            this.buttonGetTopPictures.Name = "buttonGetTopPictures";
            this.buttonGetTopPictures.Size = new System.Drawing.Size(196, 23);
            this.buttonGetTopPictures.TabIndex = 9;
            this.buttonGetTopPictures.Text = "Get Top 5 Likeable Pictures";
            this.buttonGetTopPictures.UseVisualStyleBackColor = true;
            this.buttonGetTopPictures.Click += new System.EventHandler(this.buttonFeature1_Click);
            // 
            // buttonFeature2
            // 
            this.buttonFeature2.Location = new System.Drawing.Point(478, 446);
            this.buttonFeature2.Name = "buttonFeature2";
            this.buttonFeature2.Size = new System.Drawing.Size(203, 23);
            this.buttonFeature2.TabIndex = 10;
            this.buttonFeature2.Text = "buttonFeature2";
            this.buttonFeature2.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(247, 45);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 11;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(546, 84);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 12;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(426, 45);
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
            this.listBoxFeed.Location = new System.Drawing.Point(209, 147);
            this.listBoxFeed.Name = "listBoxFeed";
            this.listBoxFeed.Size = new System.Drawing.Size(347, 277);
            this.listBoxFeed.TabIndex = 2;
            this.listBoxFeed.SelectedIndexChanged += new System.EventHandler(this.listBoxFeed_SelectedIndexChanged);
            // 
            // labelCheckIn
            // 
            this.labelCheckIn.AutoSize = true;
            this.labelCheckIn.Location = new System.Drawing.Point(80, 287);
            this.labelCheckIn.Name = "labelCheckIn";
            this.labelCheckIn.Size = new System.Drawing.Size(50, 13);
            this.labelCheckIn.TabIndex = 14;
            this.labelCheckIn.Text = "Check In";
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Location = new System.Drawing.Point(80, 131);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(40, 13);
            this.labelEvents.TabIndex = 15;
            this.labelEvents.Text = "Events";
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(644, 287);
            this.labelPages.Name = "labelPages";
            this.labelPages.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPages.Size = new System.Drawing.Size(37, 13);
            this.labelPages.TabIndex = 16;
            this.labelPages.Text = "Pages";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(633, 131);
            this.labelData.Name = "labelData";
            this.labelData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelData.Size = new System.Drawing.Size(60, 13);
            this.labelData.TabIndex = 17;
            this.labelData.Text = "Profile data";
            // 
            // labelFeed
            // 
            this.labelFeed.AutoSize = true;
            this.labelFeed.Location = new System.Drawing.Point(354, 131);
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
            this.ClientSize = new System.Drawing.Size(774, 490);
            this.Controls.Add(this.labelFeed);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.labelCheckIn);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonFeature2);
            this.Controls.Add(this.buttonGetTopPictures);
            this.Controls.Add(this.listBoxPages);
            this.Controls.Add(this.listBoxProfie);
            this.Controls.Add(this.listBoxCheckIn);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.listBoxFeed);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.pictureBoxProfile);
            this.Name = "Form1";
            this.Text = "FormGroups";
            this.Controls.SetChildIndex(this.pictureBoxProfile, 0);
            this.Controls.SetChildIndex(this.textBoxPost, 0);
            this.Controls.SetChildIndex(this.listBoxFeed, 0);
            this.Controls.SetChildIndex(this.listBoxEvents, 0);
            this.Controls.SetChildIndex(this.listBoxCheckIn, 0);
            this.Controls.SetChildIndex(this.listBoxProfie, 0);
            this.Controls.SetChildIndex(this.listBoxPages, 0);
            this.Controls.SetChildIndex(this.buttonGetTopPictures, 0);
            this.Controls.SetChildIndex(this.buttonFeature2, 0);
            this.Controls.SetChildIndex(this.buttonLogin, 0);
            this.Controls.SetChildIndex(this.buttonPost, 0);
            this.Controls.SetChildIndex(this.buttonLogout, 0);
            this.Controls.SetChildIndex(this.labelCheckIn, 0);
            this.Controls.SetChildIndex(this.labelEvents, 0);
            this.Controls.SetChildIndex(this.labelPages, 0);
            this.Controls.SetChildIndex(this.labelData, 0);
            this.Controls.SetChildIndex(this.labelFeed, 0);
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
        private System.Windows.Forms.Button buttonGetTopPictures;
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

