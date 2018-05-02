using System.Threading.Tasks;
using Microsoft.Bot;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace samplebot
{
	public class SampleBot : IBot
	{
		public async Task OnTurn(ITurnContext turnContext)
		{
			if(turnContext.Activity.Type is ActivityTypes.ConversationUpdate)
			{
				await turnContext.SendActivity("hello");
			}
		}
	}
}