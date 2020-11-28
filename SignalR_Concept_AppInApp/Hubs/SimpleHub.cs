using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalR_Concept_AppInApp.Hubs
{
    public class SimpleHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }

        public async Task Send(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
