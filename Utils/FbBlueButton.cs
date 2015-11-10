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

            FlatAppearance.BorderColor = Color.Black;
            FlatAppearance.BorderSize = 1;
        }

        private void setBackgroundColor()
        {
            Color tempRGBColor = Color.FromArgb(0x617AAC);
            BackColor = Color.FromArgb(tempRGBColor.R, tempRGBColor.G, tempRGBColor.B);
        }
    }
}
