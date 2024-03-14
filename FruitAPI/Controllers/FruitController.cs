using FruitData;
using Microsoft.AspNetCore.Mvc;

namespace FruitAPI.Controllers
{
    [Route("api/Fruits/[action]")]
    public class FruitController : Controller
    {
        [HttpGet]
        public IActionResult GetFruits()
        {
            List<Fruit> temp = _fruits;
            return Ok(_fruits);
        }

        private static List<Fruit> _fruits = new List<Fruit>()
        {
            // Coconut
            new Fruit { Weight = 2.2, Color = "Brown", Price = .99, DatePicked = new DateTime(2024,3,1), HasSeeds = false, FruitType = Fruit.fruits.Coconut },
            new Fruit { Weight = 2.0, Color = "Brown", Price = .98, DatePicked = new DateTime(2024,2,1), HasSeeds = false, FruitType = Fruit.fruits.Coconut },
            // Strawberry
            new Fruit { Weight = 1.0, Color = "Red", Price = 1.99, DatePicked = new DateTime(2024,3,10), HasSeeds = false, FruitType = Fruit.fruits.Strawberry },
            new Fruit { Weight = 1.5, Color = "Red", Price = 2.50, DatePicked = new DateTime(2024,3,11), HasSeeds = false, FruitType = Fruit.fruits.Strawberry },
            // Apple
            new Fruit { Weight = .25, Color = "Green", Price = .50, DatePicked = new DateTime(2024,3,10), HasSeeds = true, FruitType = Fruit.fruits.Apple },
            new Fruit { Weight = .75, Color = "Green", Price = 1.50, DatePicked = new DateTime(2024,3,11), HasSeeds = true, FruitType = Fruit.fruits.Apple },
            // Kiwi
            new Fruit { Weight = 1.0, Color = "Brown", Price = 1.00, DatePicked = new DateTime(2024,3,1), HasSeeds = true, FruitType = Fruit.fruits.Kiwi },
            new Fruit { Weight = 1.25, Color = "Brown", Price = 1.25, DatePicked = new DateTime(2024,3,2), HasSeeds = true, FruitType = Fruit.fruits.Kiwi },
            // Cherry
            new Fruit { Weight = 1.0, Color = "Red", Price = 1.60, DatePicked = new DateTime(2024,3,3), HasSeeds = true, FruitType = Fruit.fruits.Cherry },
            new Fruit { Weight = 1.50, Color = "Red", Price = 1.90, DatePicked = new DateTime(2024,3,4), HasSeeds = true, FruitType = Fruit.fruits.Cherry },
            // Banana
            new Fruit { Weight = .25, Color = "Yellow", Price = 1.00, DatePicked = new DateTime(2024,3,5), HasSeeds = false, FruitType = Fruit.fruits.Banana },
            new Fruit { Weight = .50, Color = "Yellow", Price = 2.00, DatePicked = new DateTime(2024,3,6), HasSeeds = false, FruitType = Fruit.fruits.Banana }
        };
    }
}
