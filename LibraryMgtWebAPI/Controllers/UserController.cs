using LibraryMgt.Application.DTOs;
using LibraryMgt.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryMgtWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
         
        public UserController (IUserService userService)
        {
            _userService = userService; 
        }
            // GET: api/<BooksController>

        [HttpGet]
        public async Task<ActionResult<GenericResponse<IEnumerable<UserDTO>>>> GetAll()
        {
            return await _userService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public ActionResult<GenericResponse<UserDTO>> GetAUser(string id)
        {
            return _userService.GetByIdAsync(id);   
        }

        // POST api/<BooksController>
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDTO createUserDto)
        {
            _userService.AddAsync(createUserDto);
            /*  if (!await _bookService.Save(cancellationToken))
              {
                  return BadRequest();
              }*/

            return Ok(createUserDto);
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public void Edit([FromQuery] UpdateUserDTO updateDTO)
        {
            _userService.UpdateAsync(updateDTO);

        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _userService.DeleteByIdA(id);
        }


    }
    }

