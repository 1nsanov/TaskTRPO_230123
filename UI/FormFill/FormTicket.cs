using Database;
using Database.Domain;
using Database.Services;

namespace UI.FormFill
{
    public partial class FormTicket : Form
    {
        public FormTicket()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var ticket = new Ticket()
            {
                Place = (int)valuePlace.Value,
                Price = valuePrice.Value,
                Credits = valueCredits.Checked,
                Date = valueDate.Value.ToUniversalTime(),
                FullName = valueFullName.Text,
                PassportCode = valuePassportCode.Text
            };

            var service = new TicketService(new AppDbContext());
            var status = service.Create(ticket);

            var msg = status.IsSuccess ? "Билет успешно добавлен." : status.ErrorMessage;
            var res = MessageBox.Show(msg, "Ok", MessageBoxButtons.OKCancel);

            if (res == DialogResult.OK && status.IsSuccess)
                Close();
        }
    }
}
