using System.Drawing;
using System.Windows.Forms;

namespace Utils
{
    public class FbForm : Form
    {
        private readonly Label m_LabelHeader;

        public Label LabelHeader
        {
            get { return this.m_LabelHeader; }
        }
        private readonly PictureBox m_PictureBoxFbIcon;
        private readonly Label m_LabelFbTextHeader;

        public FbForm()
        {
            m_LabelHeader = new Label();
            m_PictureBoxFbIcon = new PictureBox();
            m_LabelFbTextHeader = new Label();
            
            InitializeForm();
        }

        private void InitializeForm()
        {
            // 
            // labelHeader
            // 
            m_LabelHeader.Location = new Point(0, 0);
            m_LabelHeader.Name = "labelHeader";
            m_LabelHeader.BackColor = Color.FromArgb(58, 87, 149);
            // 
            // pictureBoxFbIcon
            // 
            m_PictureBoxFbIcon.Image = Properties.Resources.facebook_box_white;
            m_PictureBoxFbIcon.Location = new Point(6, 5);
            m_PictureBoxFbIcon.Name = "pictureBoxFbIcon";
            m_PictureBoxFbIcon.Size = new Size(21, 21);
            m_PictureBoxFbIcon.TabIndex = 1;
            m_PictureBoxFbIcon.TabStop = false;
            m_PictureBoxFbIcon.BackColor = Color.FromArgb(58, 87, 149);

            // 
            // labelFbTextHeader
            // 
            m_LabelFbTextHeader.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(177)));
            m_LabelFbTextHeader.ForeColor = Color.White;
            m_LabelFbTextHeader.Location = new Point(28, 5);
            m_LabelFbTextHeader.BackColor = Color.FromArgb(58, 87, 149);
            m_LabelFbTextHeader.Name = "labelFbTextHeader";
            m_LabelFbTextHeader.Size = new Size(77, 19);
            m_LabelFbTextHeader.TabIndex = 2;
            m_LabelFbTextHeader.Text = "Facebook";

            // 
            // FbForm
            // 
            BackColor = Color.White;
            Load += FbForm_Load;
            Controls.Add(m_PictureBoxFbIcon);
            Controls.Add(m_LabelFbTextHeader);
            Controls.Add(m_LabelHeader);
            
            Name = "FbForm";
            ResumeLayout(false);
        }

        private void FbForm_Load(object sender, System.EventArgs e)
        {
            m_LabelHeader.Size = new Size(Width, 29);
        }


    }
}
