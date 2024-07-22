namespace ProWebAPIProject.Dto
{
    public class LanguageForCreateDto
    {
        public string language { get; set; }
        public string description { get; set; }
        public DateTimeOffset created_on { get; set; }
        public string created_by { get; set; }
        public DateTimeOffset modified_on { get; set; }
        public string modified_by { get; set; }
    }
}
