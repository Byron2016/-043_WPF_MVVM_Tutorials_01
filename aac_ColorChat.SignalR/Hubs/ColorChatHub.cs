using aac_ColorChat.Domain.Models;
using Microsoft.AspNetCore.SignalR;

namespace aac_ColorChat.SignalR.Hubs
{
    public class ColorChatHub : Hub
    {
        public async Task SendColorMessage(ColorChatColor color)
        {
            await Clients.All.SendAsync("ReceiveColorMessage", color);
        }
    }
}
