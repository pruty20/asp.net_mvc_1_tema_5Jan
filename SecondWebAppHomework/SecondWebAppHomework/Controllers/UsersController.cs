using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecondWebAppHomework.Models;

namespace SecondWebAppHomework.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View("SecondIndex");
        }

        public IActionResult List(int? age)
        {
            var users = PopulateList();

            if (age.HasValue)
            {
                users = users.Where(x => x.Age == age.Value).ToList();
            }

            return View(users);

        }

        [HttpGet]
        private List<User> PopulateList()
        {
            List<User> users = new List<User>();

            users.Add(new Models.User()
            {
                Age = 30,
                FirstName = "Ion",
                LastName = "Pruteanu"

            });

            users.Add(new Models.User()
            {
                Age = 45,
                FirstName = "Gigel",
                LastName = "Marica"

            });

            users.Add(new Models.User()
            {
                Age = 66,
                FirstName = "Martin",
                LastName = "Alina"

            });

            users.Add(new Models.User()
            {
                FirstName = "Martin",
                LastName = "Alina"

            });

            return users;

        }

    }
}