﻿using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalR_Concept_AppInApp.Hubs
{
    public class SimpleHub : Hub
    {
        public async Task Send(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}