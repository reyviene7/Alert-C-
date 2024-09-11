using System;
using System.Drawing;
using System.Windows.Forms;

namespace Alert
{
    public partial class FrmAlert : Form
    {
        public FrmAlert()
        {
            InitializeComponent();
        }

        void AlertBoxArtan(Color backColor, Color color, string title, string text, Image icon)
        {
            FrmAlertBox fRM = new FrmAlertBox();
            fRM.BackColor = backColor;
            fRM.ColorAlertBox = color;
            fRM.TitleAlertBox = title;
            fRM.TextAlertBox = text;
            fRM.IconeAlertBox = icon;
            fRM.ShowDialog();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            AlertBoxArtan(Color.LightBlue, Color.DodgerBlue, "Information", "Operation is in progress.", Properties.Resources.Information);
        }

        private void BtnWarning_Click(object sender, EventArgs e)
        {
            AlertBoxArtan(Color.LightGoldenrodYellow, Color.Goldenrod, "Warning", "Are you confident in the operation?", Properties.Resources.Warning);
        }

        private void BtnError_Click(object sender, EventArgs e)
        {
            AlertBoxArtan(Color.LightPink, Color.DarkRed, "Error", "Operation encountered problem!!", Properties.Resources.Error);
        }

        private void BtnSuccess_Click(object sender, EventArgs e)
        {
            AlertBoxArtan(Color.LightGreen,Color.SeaGreen, "Success","Operation completed Successfully.", Properties.Resources.Success);
        }
    }
}
