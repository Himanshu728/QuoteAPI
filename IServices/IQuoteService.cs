using QuoteAPI.DTOs;
using QuoteAPI.Models;

namespace QuoteAPI.IServices
{
    public interface IQuoteService
    {
        public List<Quote> GetAllQuotes();
        public List<Quote> GetQuoteByAuthor(string authorName);
        public List<Quote> GetQuoteByTags(List<string> tags);
        public List<Quote> GetQuoteByQuote(string quote);
        public void AddQuotes(List<QuoteDTO> quotes);
        public void DeleteQuote(int id);
        public Quote UpdateQuote(Quote quote);
    }
}
