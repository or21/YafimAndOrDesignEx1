using System.Windows.Forms;

namespace AppUI
{
    partial class TopLikeablePictureForm
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
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonTopPicture = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelNumberOfLikesHeader = new System.Windows.Forms.Label();
            this.labelNumberOfLikes = new System.Windows.Forms.Label();
            this.pictureBoxCurrentPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentPic)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(192, 233);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(80, 23);
            this.buttonNext.TabIndex = 36;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonTopPicture
            // 
            this.buttonTopPicture.Location = new System.Drawing.Point(103, 233);
            this.buttonTopPicture.Name = "buttonTopPicture";
            this.buttonTopPicture.Size = new System.Drawing.Size(80, 23);
            this.buttonTopPicture.TabIndex = 35;
            this.buttonTopPicture.Text = "Top Picture";
            this.buttonTopPicture.UseVisualStyleBackColor = true;
            this.buttonTopPicture.Click += new System.EventHandler(this.buttonTopPicture_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 233);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(80, 23);
            this.buttonBack.TabIndex = 34;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(68, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(154, 27);
            this.buttonExit.TabIndex = 32;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelNumberOfLikesHeader
            // 
            this.labelNumberOfLikesHeader.AutoSize = true;
            this.labelNumberOfLikesHeader.Location = new System.Drawing.Point(12, 177);
            this.labelNumberOfLikesHeader.Name = "labelNumberOfLikesHeader";
            this.labelNumberOfLikesHeader.Size = new System.Drawing.Size(80, 13);
            this.labelNumberOfLikesHeader.TabIndex = 37;
            this.labelNumberOfLikesHeader.Text = "Number of likes";
            // 
            // labelNumberOfLikes
            // 
            this.labelNumberOfLikes.AutoSize = true;
            this.labelNumberOfLikes.Location = new System.Drawing.Point(98, 177);
            this.labelNumberOfLikes.Name = "labelNumberOfLikes";
            this.labelNumberOfLikes.Size = new System.Drawing.Size(16, 13);
            this.labelNumberOfLikes.TabIndex = 38;
            this.labelNumberOfLikes.Text = "---";
            // 
            // pictureBoxCurrentPic
            // 
            this.pictureBoxCurrentPic.Location = new System.Drawing.Point(12, 35);
            this.pictureBoxCurrentPic.Name = "pictureBoxCurrentPic";
            this.pictureBoxCurrentPic.Size = new System.Drawing.Size(260, 190);
            this.pictureBoxCurrentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCurrentPic.TabIndex = 40;
            this.pictureBoxCurrentPic.TabStop = false;
            // 
            // TopLikeablePictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelNumberOfLikes);
            this.Controls.Add(this.labelNumberOfLikesHeader);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonTopPicture);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBoxCurrentPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TopLikeablePictureForm";
            this.Text = "TopLikeablePictureForm";
            this.Load += new System.EventHandler(this.buttonTopPicture_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonTopPicture;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonExit;
        private Label labelNumberOfLikesHeader;
        private Label labelNumberOfLikes;
        private PictureBox pictureBoxCurrentPic;
    }
}