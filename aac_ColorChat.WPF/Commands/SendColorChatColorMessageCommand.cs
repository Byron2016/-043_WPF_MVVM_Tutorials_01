using aac_ColorChat.Domain.Models;
using aac_ColorChat.WPF.Services;
using aac_ColorChat.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace aac_ColorChat.WPF.Commands
{
    public class SendColorChatColorMessageCommand : ICommand
    {
        private readonly ColorChatViewModel _viewModel;
        private readonly SignalRChatService _chatService;

        public SendColorChatColorMessageCommand(ColorChatViewModel viewModel, SignalRChatService chatService)
        {
            _viewModel = viewModel;
            _chatService = chatService;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public async void Execute(object? parameter)
        {
            // Nota: NUNCA usar async void a menos que lo use para un ICommand o en un Windows Event handler. (Si lo usa poner un try catch)
            // De otra forma usted quiere usar async task.
            try
            {
                await _chatService.SendColorMessage(new ColorChatColor()
                {
                    Red = _viewModel.Red,
                    Green = _viewModel.Green,
                    Blue = _viewModel.Blue,
                });

                _viewModel.ErrorMessage = string.Empty;
            }
            catch (Exception)
            {
                _viewModel.ErrorMessage = "Unable to send color message.";
            }
        }
    }
}
