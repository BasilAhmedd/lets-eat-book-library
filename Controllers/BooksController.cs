using lets_eat_book_library.DTOs.BookDTOs;
using lets_eat_book_library.Repo.BookRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lets_eat_book_library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepo _bookRepo;
        public BooksController(IBookRepo bookRepo)
        {
            _bookRepo = bookRepo;
        }

        [HttpPost("All")]
        public IActionResult AddAll(Book_Add_And_Get_All_DTO dto)
        {
            if (ModelState.IsValid)
            {
                _bookRepo.AddAll(dto);
                return Created();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public IActionResult AddById(Book_Add_All_By_ID_DTO dto)
        {
            if (ModelState.IsValid)
            {
                _bookRepo.AddById(dto);
                return Created();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        public IActionResult DeleteById(int id)
        {
            if (ModelState.IsValid)
            {
                _bookRepo.Delete(id);
                return NoContent();
            }
            else
            {
                return BadRequest();
            }

        }
        [HttpGet("All")]
        public IActionResult GetAll() { 
          
            
            return Ok(_bookRepo.GetAll());
         
        } 
        [HttpGet("{id}")]
        public IActionResult GetAllById(int id) {

            if (ModelState.IsValid)
            {
                return Ok(_bookRepo.GetById(id));

            }
            
                return NotFound();
            
        }

        [HttpPut("all")]
        public IActionResult updateAll(Book_Add_And_Get_All_DTO dto, int id)
        {
            if (ModelState.IsValid)
            {
                _bookRepo.UpdateAll(dto, id);
                return Accepted();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
