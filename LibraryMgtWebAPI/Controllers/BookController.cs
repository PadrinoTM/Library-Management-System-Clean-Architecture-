using LibraryMgt.Application.DTOs;
using LibraryMgt.Application.Interfaces.Repositories;
using LibraryMgt.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryMgtWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        // GET: api/<BooksController>
        [HttpGet]
        public async Task<ActionResult<GenericResponse<IEnumerable<BookDTO>>>> GetAll()
        {
            return await _bookService.GetAllAsync();
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GenericResponse<BookDTO>>> GetABook(string id)
        {
            return _bookService.GetByIdAsync(id);
        }

        [HttpGet]
        public async Task<ActionResult<GenericResponse<BookDTO>>> SearchBookDesc(string desc )
        {
            return await _bookService.GetAllByDesc(desc);
        }

        [HttpGet]
        public async Task<ActionResult<GenericResponse<BookDTO>>> SearchBookGenre(string genre)
        {
            return await _bookService.GetByGenre(genre);
        }
        // POST api/<BooksController>
        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] CreateBookDTO createBookDto)
        {
            _bookService.AddAsync(createBookDto);
          /*  if (!await _bookService.Save(cancellationToken))
            {
                return BadRequest();
            }*/

            return Ok(createBookDto);
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public void Edit([FromBody] UpdateBookDTO updateDTO)
        {
            _bookService.UpdateAsync(updateDTO);    

        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _bookService.DeleteByIdA(id);
        }

    }
}
