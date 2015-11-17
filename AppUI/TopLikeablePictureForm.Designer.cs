using System.Windows.Forms;

namespace AppUI
{
    public partial class TopLikeablePictureForm
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
            this.buttonNext = new Utils.FbBlueButton();
            this.buttonTopPicture = new Utils.FbBlueButton();
            this.buttonBack = new Utils.FbBlueButton();
            this.buttonExit = new Utils.FbWhiteButton();
            this.labelNumberOfLikes = new System.Windows.Forms.Label();
            this.pictureBoxCurrentPic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(281, 424);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(80, 23);
            this.buttonNext.TabIndex = 36;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonTopPicture
            // 
            this.buttonTopPicture.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonTopPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.buttonTopPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTopPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonTopPicture.ForeColor = System.Drawing.Color.White;
            this.buttonTopPicture.Location = new System.Drawing.Point(192, 424);
            this.buttonTopPicture.Name = "buttonTopPicture";
            this.buttonTopPicture.Size = new System.Drawing.Size(80, 23);
            this.buttonTopPicture.TabIndex = 35;
            this.buttonTopPicture.Text = "Reset";
            this.buttonTopPicture.UseVisualStyleBackColor = true;
            this.buttonTopPicture.Click += new System.EventHandler(this.buttonTopPicture_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(101, 424);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(80, 23);
            this.buttonBack.TabIndex = 34;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(161, 33);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(154, 27);
            this.buttonExit.TabIndex = 32;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelNumberOfLikes
            // 
            this.labelNumberOfLikes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelNumberOfLikes.AutoSize = true;
            this.labelNumberOfLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNumberOfLikes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelNumberOfLikes.Location = new System.Drawing.Point(216, 387);
            this.labelNumberOfLikes.Name = "labelNumberOfLikes";
            this.labelNumberOfLikes.Size = new System.Drawing.Size(70, 29);
            this.labelNumberOfLikes.TabIndex = 38;
            this.labelNumberOfLikes.Text = "Likes";
            // 
            // pictureBoxCurrentPic
            // 
            this.pictureBoxCurrentPic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCurrentPic.Location = new System.Drawing.Point(12, 66);
            this.pictureBoxCurrentPic.Name = "pictureBoxCurrentPic";
            this.pictureBoxCurrentPic.Size = new System.Drawing.Size(444, 315);
            this.pictureBoxCurrentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCurrentPic.TabIndex = 40;
            this.pictureBoxCurrentPic.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = global::AppUI.Properties.Resources.facebook_like_button_hand;
            this.pictureBox1.Location = new System.Drawing.Point(172, 387);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 30);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // TopLikeablePictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(469, 459);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelNumberOfLikes);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonTopPicture);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBoxCurrentPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TopLikeablePictureForm";
            this.Text = "TopLikeablePictureForm";
            this.Load += new System.EventHandler(this.buttonTopPicture_Click);
            this.Controls.SetChildIndex(this.pictureBoxCurrentPic, 0);
            this.Controls.SetChildIndex(this.buttonExit, 0);
            this.Controls.SetChildIndex(this.buttonBack, 0);
            this.Controls.SetChildIndex(this.buttonTopPicture, 0);
            this.Controls.SetChildIndex(this.buttonNext, 0);
            this.Controls.SetChildIndex(this.labelNumberOfLikes, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utils.FbBlueButton buttonNext;
        private Utils.FbBlueButton buttonTopPicture;
        private Utils.FbBlueButton buttonBack;
        private Utils.FbWhiteButton buttonExit;
        private Label labelNumberOfLikes;
        private PictureBox pictureBoxCurrentPic;
        private PictureBox pictureBox1;
    }
}