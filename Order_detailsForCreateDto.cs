namespace ProWebAPIProject.Dto
{
    public class Order_detailsForCreateDto
    {
        public int book_id { get; set; }
        public int member_id { get; set; }
        public DateTimeOffset purchase_date { get; set; }
        public DateTimeOffset due_date { get; set; }

        public DateTimeOffset created_on { get; set; }
        public string created_by { get; set; }
        public DateTimeOffset modified_on { get; set; }
        public string modified_by { get; set; }
        public bool is_active { get; set; }
    }
}
