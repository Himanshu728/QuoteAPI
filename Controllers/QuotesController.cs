using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuoteAPI.DTOs;
using QuoteAPI.IServices;
using QuoteAPI.Models;

namespace QuoteAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class QuotesController : ControllerBase
    {
        private readonly IQuoteService _quoteService;

        public QuotesController(IQuoteService quoteService)
        {
            this._quoteService = quoteService;
        }

        [HttpGet]
        public IActionResult GetAllQoutes()
        {
            try
            {
                return Ok(_quoteService.GetAllQuotes());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetQuoteByAuthor([FromQuery] string authorName)
        {
            try
            {
                return Ok(_quoteService.GetQuoteByAuthor(authorName));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult GetQuoteByQuote([FromBody] string quote)
        {
            try
            {
                return Ok(_quoteService.GetQuoteByQuote(quote));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult GetQuoteByTags(List<string> tags)
        {
            try
            {
                return Ok(_quoteService.GetQuoteByTags(tags));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddQuotes([FromBody] List<QuoteDTO> quotes)
        {
            try
            {
                return Ok(_quoteService.AddQuotes(quotes));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult DeleteQuote([FromQuery] int id)
        {
            try
            {
                return Ok(_quoteService.DeleteQuote(id));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult UpdateQuote([FromBody] Quote quote)
        {
            try
            {
                return Ok(_quoteService.UpdateQuote(quote));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
