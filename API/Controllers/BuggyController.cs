using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly DataContext _context;
        public BuggyController(DataContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet("auth")]
        public ActionResult<string> GetSecret(){
            return "secret Text";
        }

        [HttpGet("not-found")]
        public ActionResult<AppUser> GetNotFound(){
           
           var thing = _context.Users.Find(-1);

           if (thing == null) return NotFound("Não encontrado!");

           return Ok(thing);
        }

        [HttpGet("server-error")]
        public ActionResult<string> GerServerError(){
             
            var thing = _context.Users.Find(-1);

            var thingToReturn = thing.ToString();
            
            return thingToReturn;
        }

        [HttpGet("bad-request")]
        public ActionResult<AppUser> GetBadRequest(){
            return BadRequest("Está não foi uma boa solicitação.");
        }
    }
}