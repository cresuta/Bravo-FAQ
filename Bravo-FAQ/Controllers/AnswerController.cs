using Bravo_FAQ.Models;
using Bravo_FAQ.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bravo_FAQ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {

        private readonly IAnswerRepo _answerRepo;
        public AnswerController(IAnswerRepo answerRepo)
        {
            _answerRepo = answerRepo;
        }
        // GET: api/<AnswerController>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_answerRepo.GetAll());
        }

        // POST api/<AnswerController>
        [HttpPost]
        public IActionResult Post(Answer answer)
        {
            _answerRepo.Add(answer);
            return Ok(_answerRepo.GetAll());
        }

        // PUT api/<AnswerController>
        [HttpPut("{id}")]
        public IActionResult Put(int id, Answer answer)
        {
            if (id != answer.Id)
            {
                return BadRequest();
            }
            _answerRepo.Update(answer);
            return NoContent();
        }

    }
}
