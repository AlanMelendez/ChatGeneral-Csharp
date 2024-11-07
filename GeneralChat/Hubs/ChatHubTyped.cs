using GeneralChat.Interfaces;
using Microsoft.AspNetCore.SignalR;

namespace GeneralChat.Hubs
{
    public class ChatHubTyped : Hub<IChatClient>
    {
        public async Task SendMessage(string user, string message) 
            => await Clients.All.ReceiveMessageAsync(user, message);
        public async Task SendMessageToCaller(string user, string message)
            => await Clients.Caller.ReceiveMessageAsync($"{user}", message);
        public async Task SendMessageToGroup(string user, string message)
            => await Clients.Group("SignalRGroup").ReceiveMessageAsync(user, message);
    }
}
