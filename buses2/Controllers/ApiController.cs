using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace buses2.Controllers
{
    public class ApiController : Controller
    {
        public readonly AppDbContext _context;
        public ApiController(AppDbContext context)
        {
            _context = context;
        }

        protected BadRequestObjectResult ModelIsValid()
        {
            if (!ModelState.IsValid)
            {
                 throw new ValidationException();
            } else
            {
               return null;
            }
        }
    }
}
