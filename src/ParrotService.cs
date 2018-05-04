using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;

namespace parrot
{
    public class ParrotService
    {
        ParrotContext db;

        public ParrotService(ParrotContext parrotContext)
        {
            db=parrotContext;
        }

        public async Task OnTurn(ITurnContext context)
        {
            var question=context.Activity.Text;
            var parrotKnowledge=FindQuestion(db.ParrotKnowledge.ToList(), question);

            if(parrotKnowledge!=null){
                if(parrotKnowledge.Answer!=null||parrotKnowledge.Answer!=""){
                    await context.SendActivity(parrotKnowledge.Answer);
                }
            }
        }

        private ParrotKnowledge FindQuestion(List<ParrotKnowledge> list, string question)
        {
            return list.Find(x=>x.Quesion==question);
        }
    }
}