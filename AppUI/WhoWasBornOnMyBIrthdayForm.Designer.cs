﻿namespace AppUI
{
    public partial class WhoWasBornOnMyBirthdayForm
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
            this.listBoxWhoWasBorn = new System.Windows.Forms.ListBox();
            this.fbWhiteButtonExit = new Utils.FbWhiteButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxWhoWasBorn
            // 
            this.listBoxWhoWasBorn.FormattingEnabled = true;
            this.listBoxWhoWasBorn.Location = new System.Drawing.Point(6, 32);
            this.listBoxWhoWasBorn.Name = "listBoxWhoWasBorn";
            this.listBoxWhoWasBorn.Size = new System.Drawing.Size(120, 186);
            this.listBoxWhoWasBorn.TabIndex = 4;
            this.listBoxWhoWasBorn.SelectedIndexChanged += new System.EventHandler(this.listBoxWhoWasBorn_SelectedIndexChanged);
            // 
            // fbWhiteButtonExit
            // 
            this.fbWhiteButtonExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.fbWhiteButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbWhiteButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fbWhiteButtonExit.ForeColor = System.Drawing.Color.Black;
            this.fbWhiteButtonExit.Location = new System.Drawing.Point(6, 225);
            this.fbWhiteButtonExit.Name = "fbWhiteButtonExit";
            this.fbWhiteButtonExit.Size = new System.Drawing.Size(120, 23);
            this.fbWhiteButtonExit.TabIndex = 5;
            this.fbWhiteButtonExit.Text = "Exit";
            this.fbWhiteButtonExit.UseVisualStyleBackColor = false;
            this.fbWhiteButtonExit.Click += new System.EventHandler(this.fbWhiteButtonExit_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(132, 32);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(275, 186);
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(413, 63);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInfo.Size = new System.Drawing.Size(212, 155);
            this.textBoxInfo.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelName.Location = new System.Drawing.Point(413, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(158, 17);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "FirstName LastName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(441, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "From Wikipedia, the free encyclopedia";
            // 
            // WhoWasBornOnMyBirthdayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 260);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.fbWhiteButtonExit);
            this.Controls.Add(this.listBoxWhoWasBorn);
            this.Name = "WhoWasBornOnMyBirthdayForm";
            this.Text = "WhoWasBornOnMyBirthdayForm";
            this.Controls.SetChildIndex(this.listBoxWhoWasBorn, 0);
            this.Controls.SetChildIndex(this.fbWhiteButtonExit, 0);
            this.Controls.SetChildIndex(this.pictureBox, 0);
            this.Controls.SetChildIndex(this.textBoxInfo, 0);
            this.Controls.SetChildIndex(this.labelName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWhoWasBorn;
        private Utils.FbWhiteButton fbWhiteButtonExit;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label2;
    }
}