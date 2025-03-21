namespace RestaurantWebsite.Models
{
    public class ReservationModel
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Time { get; set; } = string.Empty;
        public int GuestsCount { get; set; }
    }
}
