using Database;
using Database.Services;
using UI.Enums;
using UI.FormFill;

namespace UI
{
    public partial class ViewForm : Form
    {
        private FormViewTypeEnum? _formViewType = null;
        private TicketService _ticketService;
        private BusService _busService;
        private RouteService _routeService;
        private DriverService _driverService;
        private SupervisorService _supervisorService;
        public ViewForm()
        {
            InitializeComponent();
        }

        public ViewForm(FormViewTypeEnum formViewType)
        {
            InitializeComponent();
            _formViewType = formViewType;
        }

        private void ViewFormTicket_Load(object sender, EventArgs e)
        {
            InitServices();
            UpdateTicketList();
        }

        private void InitServices()
        {
            var db = new AppDbContext();
            _ticketService = new TicketService(db);
            _busService = new BusService(db);
            _routeService = new RouteService(db);
            _driverService = new DriverService(db);
            _supervisorService = new SupervisorService(db);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (_formViewType)
            {
                case FormViewTypeEnum.Ticket:
                    var formTicket = new FormTicket();
                    formTicket.Show();
                    break;
                case FormViewTypeEnum.Route:
                    break;
                case FormViewTypeEnum.Bus:
                    break;
                case FormViewTypeEnum.Driver:
                    break;
                case FormViewTypeEnum.Supervisor:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
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
                var row = dataGridViewTickets.Rows[e.RowIndex];
                var id = int.Parse(row.Cells[0].Value.ToString());
                var ticket = _ticketService.Get(id);
            }
        }
    }
}
