using UI.Enums;

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
            OpenViewForm(FormViewTypeEnum.Ticket);
        }

        private void ViewMenuRoute_Click(object sender, EventArgs e)
        {
            OpenViewForm(FormViewTypeEnum.Route);
        }

        private void ViewMenuBus_Click(object sender, EventArgs e)
        {
            OpenViewForm(FormViewTypeEnum.Bus);
        }

        private void ViewMenuDriver_Click(object sender, EventArgs e)
        {
            OpenViewForm(FormViewTypeEnum.Driver);
        }

        private void ViewMenuSupervisor_Click(object sender, EventArgs e)
        {
            OpenViewForm(FormViewTypeEnum.Supervisor);
        }

        private static void OpenViewForm(FormViewTypeEnum type)
        {
            var viewFormTicket = new ViewForm(type);
            viewFormTicket.Show();
        }
    }
}