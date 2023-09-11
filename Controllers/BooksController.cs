using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public BooksController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/Books
        [HttpGet]
        public IActionResult Get()
        {
            // Replace this with a call to the database to get all books and return them as JSON
            var books = _dbContext.Books.ToList();
            return Ok(books);
            
             
        }

        // GET: api/Books/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            // Replace this with a call to the database to get a book with the given id
            return "This endpoint returns a book with the given id";
        }

        // POST: api/Books
        [HttpPost]
        public void Post([FromBody] string value)
        {
            // Replace this with a call to the database to add a new book
        }

        // PUT: api/Books/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
