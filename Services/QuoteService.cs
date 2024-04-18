using Microsoft.AspNetCore.Http.HttpResults;
using QuoteAPI.DBContext;
using QuoteAPI.DTOs;
using QuoteAPI.IServices;
using QuoteAPI.Models;

namespace QuoteAPI.Services
{
    public class QuoteService : IQuoteService
    {
        private readonly QuoteDBContext _dbContext;

        public QuoteService()
        {
            this._dbContext = new QuoteDBContext();
        }
        public List<Quote> GetAllQuotes()
        {
            try 
            {
                return _dbContext.Quotes.ToList<Quote>();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Quote> GetQuoteByAuthor(string authorName)
        {
            try
            {
                return _dbContext.Quotes.Where(obj => obj.author.ToLower().Contains( authorName.ToLower() )).ToList<Quote>();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Quote> GetQuoteByQuote(string quote)
        {
            try
            {
                return _dbContext.Quotes.Where(obj => obj.quote.ToLower().Contains(quote.ToLower())).ToList<Quote>();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Quote> GetQuoteByTags(List<string> tags)
        {
            try
            {
                var responseQuotes = new List<Quote>();
                foreach(var tag in tags)
                {
                    responseQuotes.AddRange(_dbContext.Quotes.Where(obj => obj.tags.Contains(tag)).ToList<Quote>());
                }
                return responseQuotes;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void AddQuotes(List<QuoteDTO> quotes)
        {
            try
            {
                foreach(var quote in quotes)
                {
                    var q = new Quote(quote.author, quote.tags, quote.quote)
                    {
                        id = _dbContext.Quotes.Count() + 1
                    };
                    _dbContext.Quotes.Add(q);
                    _dbContext.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public void DeleteQuote(int id)
        {
            try
            {
                var quote = _dbContext.Quotes.Find(id);
                if (quote != null)
                {
                    _dbContext.Quotes.Remove(quote);
                    _dbContext.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public Quote UpdateQuote(Quote quote)
        {
            try
            {
                var q = _dbContext.Quotes.Find(quote.id);
                if(q != null)
                {
                    q.author = quote.author;
                    q.tags = quote.tags;
                    q.quote = quote.quote;
                    _dbContext.Quotes.Update(q);
                    _dbContext.SaveChanges();
                }
                return q;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
