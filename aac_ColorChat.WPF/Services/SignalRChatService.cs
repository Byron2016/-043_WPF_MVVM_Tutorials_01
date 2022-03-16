using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aac_ColorChat.WPF.Services
{
    public class SignalRChatService
    {
        private readonly HubConnection _connection;

        public SignalRChatService(HubConnection connection)
        {
            _connection = connection;
        }
    }
}
