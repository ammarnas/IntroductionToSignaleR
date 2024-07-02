using Microsoft.AspNetCore.SignalR;

namespace IntroductionToSignaleR.Hubs
{
    public class ChatHub: Hub
    {
        public async Task SendMessage(string fromUser, string message)
        {
            // All: means send to all online user
            // caller: for user call this message
            await Clients.All.SendAsync("ReceiveMessage", fromUser, message);
        }
    }
}
