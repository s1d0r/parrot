using System;
using System.Threading.Tasks;
using Microsoft.Bot;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace parrot
{
	public class ParrotBot : IBot
	{
		public ParrotService Parrot { get; private set; }

		public ParrotBot(ParrotService parrot)
		{
			this.Parrot = parrot;
		}

		public async Task OnTurn(ITurnContext context)
		{
			if (context.Activity.Type is ActivityTypes.Message) await Message(context);
			if (context.Activity.Type is ActivityTypes.ConversationUpdate) await ConversationUpdate(context);
			if (context.Activity.Type is ActivityTypes.ContactRelationUpdate) await ContactRelationUpdate(context);
			if (context.Activity.Type is ActivityTypes.Typing) await Typing(context);
			if (context.Activity.Type is ActivityTypes.Ping) await Ping(context);
			if (context.Activity.Type is ActivityTypes.EndOfConversation) await EndOfConversation(context);
			if (context.Activity.Type is ActivityTypes.Event) await Event(context);
			if (context.Activity.Type is ActivityTypes.Invoke) await Invoke(context);
			if (context.Activity.Type is ActivityTypes.DeleteUserData) await DeleteUserData(context);
			if (context.Activity.Type is ActivityTypes.MessageUpdate) await MessageUpdate(context);
			if (context.Activity.Type is ActivityTypes.MessageDelete) await MessageDelete(context);
			if (context.Activity.Type is ActivityTypes.InstallationUpdate) await InstallationUpdate(context);
			if (context.Activity.Type is ActivityTypes.MessageReaction) await MessageReaction(context);
			if (context.Activity.Type is ActivityTypes.Suggestion) await Suggestion(context);
			if (context.Activity.Type is ActivityTypes.Trace) await Trace(context);
		}

		public virtual async Task Trace(ITurnContext context)
		{
			throw new NotImplementedException();
		}

		public virtual async Task MessageReaction(ITurnContext context)
		{
			throw new NotImplementedException();
		}

		public virtual async Task Suggestion(ITurnContext context)
		{
			throw new NotImplementedException();
		}

		public virtual async Task InstallationUpdate(ITurnContext context)
		{
			throw new NotImplementedException();
		}

		public virtual async Task MessageDelete(ITurnContext context)
		{
			throw new NotImplementedException();
		}

		public virtual async Task MessageUpdate(ITurnContext context)
		{
			throw new NotImplementedException();
		}

		public virtual async Task DeleteUserData(ITurnContext context)
		{
			throw new NotImplementedException();
		}

		public virtual async Task Invoke(ITurnContext context)
		{
			throw new NotImplementedException();
		}

		public virtual async Task Event(ITurnContext context)
		{
			throw new NotImplementedException();
		}

		public virtual async Task EndOfConversation(ITurnContext context)
		{
			throw new NotImplementedException();
		}

		public virtual async Task Ping(ITurnContext context)
		{
			throw new NotImplementedException();
		}

		public virtual async Task Typing(ITurnContext context)
		{
			throw new NotImplementedException();
		}

		public virtual async Task ContactRelationUpdate(ITurnContext context)
		{
			throw new NotImplementedException();
		}

		public virtual async Task ConversationUpdate(ITurnContext context)
		{
			throw new NotImplementedException();
		}

		public virtual async Task Message(ITurnContext context)
		{
			await Parrot.OnTurn(context);
		}
	}
}