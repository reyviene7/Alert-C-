using System;
using System.Drawing;
using System.Windows.Forms;

namespace Alert
{
    public partial class FrmAlertBox : Form
    {
        public FrmAlertBox()
        {
            InitializeComponent();
        }

        public Color BackColorAlertBox
        {
            get { return this.BackColor; }
            set
            {
                this.BackColor = value;
            }
        }
        public Color ColorAlertBox
        {
            get { return this.LinAlertBox.BackColor; }
            set
            {
                this.LinAlertBox.BackColor = LblTitleAlertBox.ForeColor = LblTextAlertBox.ForeColor = value;
            }
        }
        public Image IconeAlertBox
        {
            get { return PicAlertBox.Image; }
            set
            {
                PicAlertBox.Image = value;
            }
        }
        public string TitleAlertBox
        {
            get { return LblTitleAlertBox.Text; }
            set
            {
                LblTitleAlertBox.Text = value;
            }
        }
        public string TextAlertBox
        {
            get { return LblTextAlertBox.Text; }
            set
            {
                LblTextAlertBox.Text = value;
            }
        }

        private void PositionAlertBox()
        {
            int xPos = 0;
            int yPos = 0;
            xPos = Screen.GetWorkingArea(this).Width;
            yPos = Screen.GetWorkingArea(this).Height;
            this.Location = new Point(xPos - this.Width, yPos - this.Height);
        }
        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            LinAlertBox.Width += 2;

            if (LinAlertBox.Width >= 500) // Ensure it checks for "greater or equal" to handle overshoots
            {
                timerAnimation.Stop(); // Stop the timer
                this.Close(); // Close the alert box
            }
        }

        private void FrmAlertBox_Load(object sender, EventArgs e)
        {
            PositionAlertBox();
            timerAnimation.Start(); // Start the timer once, not in a loop
        }
    }
}
