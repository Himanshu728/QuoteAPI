namespace QuoteAPI.DTOs
{
    public class QuoteDTO
    {
        public string author { get; set; }
        public List<string> tags { get; set; }
        public string quote { get; set; }
    }
}
