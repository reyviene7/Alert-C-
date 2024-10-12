using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Alert
{
    public class ToggleSwitch : Control
    {
        private bool isOn;
        private int radius = 20;

        public ToggleSwitch()
        {
            Width = 100;
            Height = 40;
            isOn = false;
            DoubleBuffered = true;
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Click += ToggleSwitch_Click;
        }

        public string OnLabel { get; set; } = "ON";

        public string OffLabel { get; set; } = "OFF";
        public Color OnColor { get; set; } = Color.Green;
        public Color OffColor { get; set; } = Color.Red;
        public Color SwitchColor { get; set; } = Color.White;
        public Color LabelColor { get; set; } = Color.White;

        public bool IsOn
        {
            get { return isOn; }
            set { isOn = value;Invalidate(); }
        }

        public int Radius
        {
            get { return radius; }
            set
            {
                if (value <= 5) radius = 6;
                else if (value > Height) radius = Height;
                else radius = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set => base.ForeColor = value;
        }
        private void ToggleSwitch_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ToggleSwitch clicked!");

            IsOn = !isOn;
            OnToggleChanged(EventArgs.Empty);
        }

        protected virtual void OnToggleChanged(EventArgs e) => ToggleChanged?.Invoke(this, e);
        public event EventHandler ToggleChanged;

        private GraphicsPath CreateRoundeRectablePath(Rectangle rect, int corner)
        {
            var path = new GraphicsPath();
            var diameter = corner * 2;
            var arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));

            path.AddArc(arcRect, 180, 90);
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect,270,90);
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect,0,90);
            arcRect.X = rect.Left;
            path.AddArc(arcRect,90,90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(BackColor);

            var toggleColor = IsOn ? OnColor : OffColor;
            var switchRect = new Rectangle(0, 0, Width - 1, Height - 1);
            var toggleRect =
                IsOn ? new Rectangle(Width / 2, 0, Width / 2, Height) : new Rectangle(0, 0, Width / 2, Height);
            using (var path = CreateRoundeRectablePath(switchRect, radius))
                e.Graphics.FillPath(new SolidBrush(toggleColor), path);
            int switchPadding = 5;
            int switchSize = Height - switchPadding * 2;
            var buttonRect = IsOn
                ? new Rectangle(Width - switchSize - switchPadding, switchPadding, switchSize, switchSize)
                : new Rectangle(switchPadding, switchPadding, switchSize, switchSize);
            using (var buttomPath = CreateRoundeRectablePath(buttonRect, radius - 5))e.Graphics.FillPath(new SolidBrush(SwitchColor),buttomPath);
            string label = IsOn ? OnLabel : OffLabel;
            var labelSize = e.Graphics.MeasureString(label, Font);

            float labelX = IsOn ? 10 : Width - labelSize.Width - 10;
            float labelY = (Height - labelSize.Height) / 2;
            e.Graphics.DrawString(label,Font, new SolidBrush(LabelColor), new PointF(labelX, labelY));
        }
    }
}
