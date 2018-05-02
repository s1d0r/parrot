using System.Threading.Tasks;
using Microsoft.Bot;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using parrot;

namespace samplebot
{
	public class SampleBot : IBot
	{
		private readonly ParrotService parrot;
		public SampleBot(ParrotService parrot)
		{
			this.parrot = parrot;
		}

		public async Task OnTurn(ITurnContext turnContext)
		{
			if (turnContext.Activity.Type is ActivityTypes.ConversationUpdate)
			{
				await turnContext.SendActivity("hello");
			}
			if (turnContext.Activity.Type is ActivityTypes.Message)
			{
				parrot.OnTurn(turnContext);
			}
		}
	}
}