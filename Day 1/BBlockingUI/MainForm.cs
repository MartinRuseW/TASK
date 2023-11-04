using System.Net;

namespace BBlockingUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bGetQotD_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string quod = client.DownloadString("https://nvp-functions.azurewebsites.net/api/qotd?slow=true");
            label1.Text = quod;
        }
    }
}