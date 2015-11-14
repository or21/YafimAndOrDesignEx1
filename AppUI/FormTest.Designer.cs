namespace AppUI
{
    partial class FormTest
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
            this.SuspendLayout();
            // 
            // listBoxWhoWasBorn
            // 
            this.listBoxWhoWasBorn.FormattingEnabled = true;
            this.listBoxWhoWasBorn.Location = new System.Drawing.Point(83, 126);
            this.listBoxWhoWasBorn.Name = "listBoxWhoWasBorn";
            this.listBoxWhoWasBorn.Size = new System.Drawing.Size(120, 95);
            this.listBoxWhoWasBorn.TabIndex = 4;
            // 
            // fbWhiteButtonExit
            // 
            this.fbWhiteButtonExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.fbWhiteButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbWhiteButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fbWhiteButtonExit.ForeColor = System.Drawing.Color.Black;
            this.fbWhiteButtonExit.Location = new System.Drawing.Point(83, 226);
            this.fbWhiteButtonExit.Name = "fbWhiteButtonExit";
            this.fbWhiteButtonExit.Size = new System.Drawing.Size(120, 23);
            this.fbWhiteButtonExit.TabIndex = 5;
            this.fbWhiteButtonExit.Text = "Exit";
            this.fbWhiteButtonExit.UseVisualStyleBackColor = false;
            this.fbWhiteButtonExit.Click += new System.EventHandler(this.fbWhiteButtonExit_Click);
            // 
            // WhoWasBornOnMyBirthdayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.fbWhiteButtonExit);
            this.Controls.Add(this.listBoxWhoWasBorn);
            this.Name = "WhoWasBornOnMyBirthdayForm";
            this.Text = "WhoWasBornOnMyBirthdayForm";
            this.Controls.SetChildIndex(this.listBoxWhoWasBorn, 0);
            this.Controls.SetChildIndex(this.fbWhiteButtonExit, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWhoWasBorn;
        private Utils.FbWhiteButton fbWhiteButtonExit;
    }
}