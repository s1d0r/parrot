using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace parrot
{
    public class ParrotMiddleware : IMiddleware
    {
        public async Task OnTurn(ITurnContext context, MiddlewareSet.NextDelegate next)
        {
            if (context.Activity.Type is ActivityTypes.Message)
            {
                await context.SendActivity("parrot middleware");
            }
        }
    }
}
