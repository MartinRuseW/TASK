namespace CCancellationDemo
{
    public partial class MainForm : Form
    {
        SortingService sortingService;

        public MainForm()
        {
            InitializeComponent();
            sortingService = new SortingService(50_000);
            sortingService.WorkCompleted = WorkCompleted;
        }

        private void WorkCompleted()
        {
            Invoke(() =>
            {
                panelSortUI.Visible = false;
                MessageBox.Show("Work completed.");
            });
        }

        private void bStartSorting_Click(object sender, EventArgs e)
        {
            sortingService.Start();
            panelSortUI.Visible = true;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            sortingService.Cancel();
            panelSortUI.Visible = false;
        }
    }
}