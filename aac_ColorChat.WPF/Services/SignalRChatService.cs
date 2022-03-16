using aac_ColorChat.Domain.Models;
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

        public event Action<ColorChatColor> ColorMessageReceived;

        public SignalRChatService(HubConnection connection)
        {
            _connection = connection;
        }

        public async Task Connect()
        {
            await _connection.StartAsync();
        }

        public async Task SendColorMessage(ColorChatColor color)
        {
            // SendColorMessage fue definido en el servidor como un método de clase ColorChatHub
            // El segundo parámetro color debe cuadrar con el parámetro que usa el método antes indicado.
            await _connection.SendAsync("SendColorMessage", color);
        }
    }
}
