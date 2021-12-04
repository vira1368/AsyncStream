using AsyncStream.Models;
using Microsoft.AspNetCore.Mvc;

namespace AsyncStream.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private static readonly string[] FirstNames = new[] { "Amin", "Fatemeh", "Reza", "Sara", "Maryam", "Hamid" };

        private static readonly string[] LastNames = new[] { "Saffarnejad", "Deris", "Alipour", "Rezvani", "Mousavi" };

        [HttpGet]
        public async IAsyncEnumerable<Person> GetData()
        {
            var random = new Random();
            for (var i = 1; i <= 15; i++)
            {
                await Task.Delay(random.Next(1000));
                yield return new Person
                {
                    Id = i,
                    FirstName = FirstNames[random.Next(FirstNames.Length)],
                    LastName = LastNames[random.Next(LastNames.Length)],
                    Age = random.Next(15, 35)
                };
            }
        }
    }
}
