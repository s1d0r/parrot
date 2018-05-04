using System.Threading.Tasks;
using Microsoft.Bot;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using parrot;

namespace samplebot
{
	public class SampleBot : ParrotBot
	{
		public SampleBot(ParrotService parrot) : base(parrot)
		{
		}
	}
}