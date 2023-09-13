using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Data;
using BookStore.Models;
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
        [HttpGet("all")]
        public IActionResult Get()
        {
            // Replace this with a call to the database to get all books and return them as JSON
            var books = _dbContext.Books.ToList();
            return Ok(books);
            
             
        }

        // GET: api/Books/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            // fetch a book by id and return it as JSON
            var book = _dbContext.Books.Find(id);
            return Ok(book);
        }

        // POST: api/Books
        [HttpPost]
        public IActionResult Post([FromBody] Book book)
        {
            // check if the book is valid
            if (ModelState.IsValid)
            {
                // add the book to the database
                _dbContext.Books.Add(book);
                _dbContext.SaveChanges();
                // return a 201 response, which means the item was created
                return  CreatedAtAction(nameof(Get), new { id = book.Id }, book);
            }
            else
            {
                // return a 400 response with validation errors
                return BadRequest(ModelState);
                
            }
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
