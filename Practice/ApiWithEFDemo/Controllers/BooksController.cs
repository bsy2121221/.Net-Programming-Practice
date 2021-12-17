using ApiWithEFDemo.Model;
using ApiWithEFDemo.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.JsonPatch;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace ApiWithEFDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        [HttpGet("")]
        public async Task<IActionResult> GetAllBook()
        {
            var books = await _bookRepository.GetAllBookAsync();
            return Ok(books);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById([FromRoute] int id)
        {
            var book = await _bookRepository.GetBookByIdAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }
        [HttpPost("")]
        public async Task<IActionResult> AddBooks([FromBody]BookModel bookModel)
        {
            var id = await _bookRepository.AddBooksAsync(bookModel);
            return CreatedAtAction(nameof(GetBookById), new { id=id, Controller = "books" }, id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook([FromBody]BookModel bookModel,[FromRoute]int id)
        {
           await _bookRepository.UpdateBookAsync(id, bookModel);
            return Ok();
        }
        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateBookPatch([FromBody] JsonPatchDocument bookModel, [FromRoute] int id)
        {
            await _bookRepository.PatchBookAsync(id, bookModel);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            await _bookRepository.DeleteDataAsync(id);
            return Ok();
        }

    }
}
