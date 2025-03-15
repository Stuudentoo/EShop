using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NiggaController : ControllerBase
    {
        private static readonly int[] numbers = new[]
        {
            1,2,3,4,5,6,7,8,9,10
        };

        private static readonly string[] condition = new[]
        {
            "yes","barely","good_nigga_dead_nigga","enough_to steal"
        };
        private readonly ILogger<NiggaController> _nigger;
        
        public NiggaController(ILogger<NiggaController> nigger)
        {
            _nigger = nigger;
        }
        
        // GET: api/<ValuesController>
        [HttpGet(Name ="GetNigga")]
        public IEnumerable<Nigga> Get()
        {
            return Enumerable.Range(1,5).Select(index=>new Nigga
            {
                nigga_condition = condition[Random.Shared.Next(condition.Length-1)],
                nigga_capture_date=DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                nigga_prison_number = numbers[Random.Shared.Next(numbers.Length-1)]
            })
                .ToArray();
                }

    }
}
