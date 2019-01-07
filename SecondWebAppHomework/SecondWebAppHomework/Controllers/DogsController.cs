using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecondWebAppHomework.Models;

namespace SecondWebAppHomework.Controllers
{
    public class DogsController : Controller
    {
        public IActionResult Index(Color? color, Gender? gender)
        {
            var dogs = PopulateList();

            if (color.HasValue && gender.HasValue)
            {
                dogs = dogs.Where(x => x.AnimalColor == color.Value && x.AnimalGender == gender.Value).ToList();
            }
            else if (color.HasValue)
            {
                dogs = dogs.Where(x => x.AnimalColor == color.Value).ToList();
            }
            else if (gender.HasValue)
            {
                dogs = dogs.Where(x => x.AnimalGender == gender.Value).ToList();
            }

            return View(dogs);
        }

        private List<Dog> PopulateList()
        {
            List<Dog> dogs = new List<Dog>
            {
                new Dog()
                {
                    AnimalName = "Puffy",
                    AnimalGender = Gender.Male,
                    AnimalColor = Color.Black
                },
                new Dog()
                {
                    AnimalName = "Micky",
                    AnimalGender = Gender.Male,
                    AnimalColor = Color.White
                },
                new Dog()
                {
                    AnimalName = "Micky",
                    AnimalGender = Gender.Male,
                    AnimalColor = Color.Yellow
                },
                new Dog()
                {
                    AnimalName = "Misha",
                    AnimalGender = Gender.Female,
                    AnimalColor = Color.Yellow
                }
            };

            return dogs;
        }



    }
}