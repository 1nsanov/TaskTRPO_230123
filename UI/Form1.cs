namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ViewMenuTicket_Click(object sender, EventArgs e)
        {
            var viewFormTicket = new ViewFormTicket();
            viewFormTicket.Show();
        }
    }
}