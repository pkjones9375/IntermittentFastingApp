using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
//BRETT: I'm writing the code for the UserController here, working from a similar example
//in an ASP.NET exercise
namespace IntermittentFasting.Controllers
{
    public class UserController : Controller
    {
        private readonly IFastingRepository repo;

        public UserController(IFastingRepository repo)
        {
            this.repo = repo;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            //BRETT: creating the var 'users' and calling 'GetAllUsers' here
            //Remind Jeremy to write this method
            var users = repo.GetAllUsers();

            return View(users);
        }
    }
}
