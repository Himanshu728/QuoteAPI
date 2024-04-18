using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace QuoteAPI.Models
{
    public class Quote
    {
        public Quote(string author, List<string> tags, string quote)
        {
            this.author = author;
            this.tags = tags;
            this.quote = quote;
        }

        [Key]
        public int id { get; set; }
        [Required]
        public string author { get; set; }
        [Required]
        public List<string> tags { get; set; }
        [Required]
        public string quote { get; set; }
    }
}
