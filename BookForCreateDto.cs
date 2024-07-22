using Microsoft.VisualBasic;

namespace ProWebAPIProject.Dto
{
    public class BookForCreateDto
    {

        public string genre { get; set; }
        public string book_title { get; set; }
        public string author { get; set; }
        public DateOnly year_published { get; set; }
        public DateAndTime created_on { get; set; }
        public string created_by { get; set; }
        public DateAndTime modified_on { get; set; }
        public string modified_by { get; set; }
        public bool is_available { get; set; }
        public int language_id { get; set; }
    }
}
