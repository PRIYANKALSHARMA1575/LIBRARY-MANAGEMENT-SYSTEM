namespace ProWebAPI.Model
{
    public class Order_detailsModel
    {

        public string? book_id { get; set; }
        public string? member_id { get; set; }
        public string? purchase_date { get; set; }
        public string? due_date { get; set; }

        public string? created_on { get; set; }
        public string? created_by { get; set; }
        public string? modified_on { get; set; }
        public string? modified_by { get; set; }
        public string? is_active { get; set; }
    }
}
