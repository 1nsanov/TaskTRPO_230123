namespace Database.BaseEntity
{
    public class Status
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }

        public Status()
        {
            IsSuccess = true;
        }

        public Status(string errorMessage)
        {
            IsSuccess = false;
            ErrorMessage = errorMessage;
        }
    }
}
