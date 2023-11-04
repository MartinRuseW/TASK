namespace AHomeworkColorsDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void trackBars_ValueChanged(object sender, EventArgs e)
        {
            byte red, green, blue, alpha;
            red = (byte)trackBarRed.Value;
            green = (byte)trackBarGreen.Value;
            blue = (byte)trackBarBlue.Value;
            alpha = (byte)trackBarAlpha.Value;

            Color c = Color.FromArgb(alpha, red, green, blue);
            pCanvas.BackColor = c;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            trackBars_ValueChanged(this, null);
        }
    }
}