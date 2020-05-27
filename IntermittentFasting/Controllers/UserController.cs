using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntermittentFasting.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
//BRETT: I'm writing the code for the UserController here, working from a similar example
//in an ASP.NET exercise
namespace IntermittentFasting.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository repo;

        public UserController(IUserRepository repo)
        {
            this.repo = repo;
        }
        // GET: /<controller>/
        public IActionResult Index()
        //Each of these public methods corresponds with a View
        {
            //BRETT: creating the var 'users' and calling 'GetAllUsers' here
            var users = repo.GetAllUsers();

            return View(users); //Returns the View of Index
        }


        //Enable user to View a user by entering its UserID
        public IActionResult ViewUser(int id)
        {
            var user = repo.GetUser(id);

            return View(user);
        }


        //Entering the UpdateUser(int id) method here:
        public IActionResult UpdateUser(int id)
        {
            User user = repo.GetUser(id);

            //**Write the UpdateUser() in UserRepository, maybe IUserRepository**
            repo.UpdateUser(user);

            if (user == null)
            {
                return View("UserNotFound");
            }
            return View(user);
        }

        //Entering the UpdateUser() that should link back to User Views
        public IActionResult UpdateUserToDatabase(User user)
        {
            repo.UpdateUser(user);

            //This Redirect returns another method: "ViewUser()"
            return RedirectToAction("ViewUser", new { id = user.UserID });
        }
       
        //Step 2: Insert new user into Intermittent Fasting database:
        public IActionResult InsertUserToDatabase(User userToInsert)
        {
            repo.InsertUser(userToInsert);

            return RedirectToAction("Index");
        }

        //Delete user, using the webpage to access the database:
        public IActionResult DeleteUser(User user)
        {
            repo.DeleteUser(user);

            return RedirectToAction("Index");
        }
    }
}
