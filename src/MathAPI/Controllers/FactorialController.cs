using Microsoft.AspNet.Mvc;
using System.Numerics;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MathAPI.Controllers
{
	[Route("api/[controller]")]
    public class FactorialController : Controller
    {
		// GET: api/values/5
		[HttpGet]
		public int Get()
		{
			int num = 10;
			int ans = 1;
			for (int i = 1; i <= num; i++)
			{
				ans *= i;
			}

			return ans;
		}

		// GET: api/values/5
		[HttpGet("{num}")]
		public string Get(int num)
		{
			BigInteger ans = 1;
			for (int i = 1; i <= num; i++)
			{
				ans *= i;
			}

			return ans.ToString();
		}
    }
}
