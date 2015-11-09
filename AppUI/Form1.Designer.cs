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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxFeed = new System.Windows.Forms.ListBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBoxProfie = new System.Windows.Forms.ListBox();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.buttonFeature1 = new System.Windows.Forms.Button();
            this.buttonFeature2 = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(42, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 62);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(407, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBoxFeed
            // 
            this.listBoxFeed.FormattingEnabled = true;
            this.listBoxFeed.Location = new System.Drawing.Point(229, 89);
            this.listBoxFeed.Name = "listBoxFeed";
            this.listBoxFeed.Size = new System.Drawing.Size(272, 303);
            this.listBoxFeed.TabIndex = 2;
            this.listBoxFeed.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(42, 89);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(120, 95);
            this.listBoxEvents.TabIndex = 3;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(42, 200);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(120, 82);
            this.listBoxGroups.TabIndex = 4;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(42, 297);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 95);
            this.listBox3.TabIndex = 5;
            // 
            // listBoxProfie
            // 
            this.listBoxProfie.FormattingEnabled = true;
            this.listBoxProfie.Location = new System.Drawing.Point(560, 89);
            this.listBoxProfie.Name = "listBoxProfie";
            this.listBoxProfie.Size = new System.Drawing.Size(120, 95);
            this.listBoxProfie.TabIndex = 6;
            // 
            // listBoxPages
            // 
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.Location = new System.Drawing.Point(560, 200);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(120, 82);
            this.listBoxPages.TabIndex = 7;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(560, 297);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(120, 95);
            this.listBox4.TabIndex = 8;
            // 
            // buttonFeature1
            // 
            this.buttonFeature1.Location = new System.Drawing.Point(103, 414);
            this.buttonFeature1.Name = "buttonFeature1";
            this.buttonFeature1.Size = new System.Drawing.Size(203, 23);
            this.buttonFeature1.TabIndex = 9;
            this.buttonFeature1.Text = "buttonFeature1";
            this.buttonFeature1.UseVisualStyleBackColor = true;
            // 
            // buttonFeature2
            // 
            this.buttonFeature2.Location = new System.Drawing.Point(426, 414);
            this.buttonFeature2.Name = "buttonFeature2";
            this.buttonFeature2.Size = new System.Drawing.Size(203, 23);
            this.buttonFeature2.TabIndex = 10;
            this.buttonFeature2.Text = "buttonFeature2";
            this.buttonFeature2.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(231, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 11;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(605, 32);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 12;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(426, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 13;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 464);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonFeature2);
            this.Controls.Add(this.buttonFeature1);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBoxPages);
            this.Controls.Add(this.listBoxProfie);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.listBoxFeed);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBoxFeed;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBoxProfie;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button buttonFeature1;
        private System.Windows.Forms.Button buttonFeature2;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Button buttonLogout;
    }
}

