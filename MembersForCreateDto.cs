namespace ProWebAPIProject.Dto
{
    public class MembersForCreateDto
    {
        public string address { get; set; }
        public string email { get; set; }
        public string contact_no { get; set; }
        public DateTimeOffset created_on { get; set; }
        public string created_by { get; set; }
        public DateTimeOffset modified_on { get; set; }
        public string modified_by { get; set; }
        public bool is_available { get; set; }
    }
}
