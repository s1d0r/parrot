using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace parrot
{
	public class ParrotAPIController : Controller
	{
		private ParrotContext db;

		protected ParrotAPIController(ParrotContext parrotContext)
		{
			db = parrotContext;
		}

		[HttpGet]
		public IEnumerable<ParrotKnowledge> Get()
		{
			return db.ParrotKnowledge.ToList();
		}

		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			var parrotKnowledge = db.ParrotKnowledge.FirstOrDefault(x => x.Id == id);
			if (parrotKnowledge == null)
				return NotFound();
			return new ObjectResult(parrotKnowledge);
		}

		[HttpPut]
		public IActionResult Put([FromBody]ParrotKnowledge parrotKnowledge)
		{
			if (parrotKnowledge == null)
			{
				return BadRequest();
			}
			if (!db.ParrotKnowledge.Any(x => x.Id == parrotKnowledge.Id))
			{
				return NotFound();
			}
			db.Update(parrotKnowledge);
			db.SaveChanges();
			return Ok(parrotKnowledge);
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			var parrottKnowledge = db.ParrotKnowledge.FirstOrDefault(x => x.Id == id);
			if (parrottKnowledge == null)
			{
				return NotFound();
			}
			db.ParrotKnowledge.Remove(parrottKnowledge);
			db.SaveChanges();
			return Ok(parrottKnowledge);
		}
	}
}