using Microsoft.AspNetCore.Mvc;
using parrot;

namespace samplebot.Controllers
{
	[Route("api/[controller]")]
	public class ParrotController : ParrotAPIController
	{
		public ParrotController(ParrotContext parrotContext) : base(parrotContext)
		{
		}
	}
}