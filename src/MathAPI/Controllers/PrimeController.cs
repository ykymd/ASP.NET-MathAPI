using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MathAPI.Controllers
{
	[Route("api/[controller]")]
    public class PrimeController : Controller
    {
        // GET: api/values
        [HttpGet]
        public string Get()
        {
            return "It works!";
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
			ulong i;
			ulong j;
			int cnt = 0;

			for (i = 1; ; i++)
			{
				int k = 0;
				for (j = 1; j <= i; j++)
				{
					if (i % j == 0) k++;
				}

				if (k == 2) cnt++;
				if (cnt == id) break;
			}

			return i.ToString();
        }
    }
}
