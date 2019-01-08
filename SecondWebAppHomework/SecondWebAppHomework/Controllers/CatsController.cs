using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecondWebAppHomework.Models;

namespace SecondWebAppHomework.Controllers
{
    public class CatsController : Controller
    {
        public IActionResult Index(Color? color, Gender? gender)
        {
            var cats = PopulateList();

            if (color.HasValue)
            {
                cats = cats.Where(x => x.AnimalColor == color.Value).ToList();
            }

            if (gender.HasValue)
            {
                cats = cats.Where(x => x.AnimalGender == gender.Value).ToList();
            }

            return View(cats);
        }

        private List<Cat> PopulateList()
        {
            List<Cat> cats = new List<Cat>
            {
                new Cat()
                {
                    AnimalName = "Cathy",
                    AnimalGender = Gender.Male,
                    AnimalColor = Color.Black
                },
                new Cat()
                {
                    AnimalName = "Kitty",
                    AnimalGender = Gender.Female,
                    AnimalColor = Color.White
                },
                new Cat()
                {
                    AnimalName = "Micky",
                    AnimalGender = Gender.Male,
                    AnimalColor = Color.Yellow
                }


            };

            return cats;

        }
    }
}