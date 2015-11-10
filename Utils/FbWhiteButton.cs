using System.Drawing;
using System.Windows.Forms;

namespace Utils
{
    public sealed class FbWhiteButton : Button
    {
        public FbWhiteButton()
        {
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 177);
            ForeColor = Color.Black;
            Name = "fbWhiteButton";
            UseVisualStyleBackColor = false;

            FlatAppearance.BorderColor = Color.Black;
            FlatAppearance.BorderSize = 1;
        }
    }
}
