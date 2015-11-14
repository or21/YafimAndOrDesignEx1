using System.Drawing;
using System.Windows.Forms;

namespace Utils
{
    public sealed class FbBlueButton : Button
    {
        public FbBlueButton()
        {
            setBackgroundColor();
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 177);
            ForeColor = Color.White;
            Name = "fbBlueButton";
            UseVisualStyleBackColor = false;

            FlatAppearance.BorderColor = Color.Blue;
            FlatAppearance.BorderSize = 1;
        }

        private void setBackgroundColor()
        {
            Color tempRgbColor = Color.FromArgb(0x617AAC);
            BackColor = Color.FromArgb(tempRgbColor.R, tempRgbColor.G, tempRgbColor.B);
        }
    }
}
