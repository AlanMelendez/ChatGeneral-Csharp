using Microsoft.AspNetCore.SignalR;

namespace GeneralChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            var IdConnection = Context.ConnectionId;
            Console.WriteLine($"ConnectionId: {IdConnection}");
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

    }
}
