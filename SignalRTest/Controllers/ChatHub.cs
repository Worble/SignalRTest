﻿using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRTest.Controllers
{
    public class ChatHub : Hub
    {
        public async Task Send(string message)
        {
            await this.Clients.All.InvokeAsync("Send", message);
        }
    }
}
