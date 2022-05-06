using Bravo_FAQ.Models;
using Bravo_FAQ.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bravo_FAQ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {

        private readonly IQuestionRepo _questionRepo;
        public QuestionController(IQuestionRepo questionRepo)
        {
            _questionRepo = questionRepo;
        }
        // GET: api/<QuestionController>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_questionRepo.GetAll());
        }

        // POST api/<QuestionController>
        [HttpPost]
        public IActionResult Post(Question question)
        {
            _questionRepo.Add(question);
            return Ok(_questionRepo.GetAll());
        }
        
        // PUT api/<QuestionController>
        [HttpPut("{id}")]
        public IActionResult Put(int id, Question question)
        {
            if (id != question.Id)
            {
                return BadRequest();
            }
            _questionRepo.Update(question);
            return NoContent();
        }

    }
}
