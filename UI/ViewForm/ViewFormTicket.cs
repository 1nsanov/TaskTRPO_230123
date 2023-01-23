using Database;
using Database.Services;
using System.Windows.Forms;
using UI.FormFill;

namespace UI
{
    public partial class ViewFormTicket : Form
    {
        private TicketService _ticketService;
        public ViewFormTicket()
        {
            InitializeComponent();
        }

        private void ViewFormTicket_Load(object sender, EventArgs e)
        {
            var db = new AppDbContext();
            _ticketService = new TicketService(db);

            UpdateTicketList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var formTicket = new FormTicket();
            formTicket.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateTicketList();
        }

        private void UpdateTicketList()
        {
            dataGridViewTickets.DataSource = _ticketService.GetList();
        }

        private void dataGridViewTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                var row = dataGridViewTickets.Rows[e.RowIndex];
                var id = int.Parse(row.Cells["Id"].Value.ToString());
                var ticket = _ticketService.Get(id);
                var temp = ticket;
                // Do something with the selected row
                // ...
            }
        }
    }
}
