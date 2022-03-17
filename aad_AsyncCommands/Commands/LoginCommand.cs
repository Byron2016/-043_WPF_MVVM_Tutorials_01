using aad_AsyncCommands.Services;
using aad_AsyncCommands.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aad_AsyncCommands.Commands
{
    public class LoginCommand : AsyncCommandBase
    {
        private readonly LoginViewModel _loginViewModel;
        private readonly IAuthenticationService _authenticationService;

        public LoginCommand(LoginViewModel loginViewModel, IAuthenticationService authenticationService, Action<Exception> onException) : base(onException)
        {
            //Nota: Action<Exception> onException) : base(onException) es agregado en 9.24
            _loginViewModel = loginViewModel;
            _authenticationService = authenticationService;
        }

        protected override async Task ExecuteAsync(object? parameter)
        {
            _loginViewModel.StatusMessage = "Logging in...";

            throw new Exception("Login Failed...");
            await _authenticationService.Login(_loginViewModel.Username);

            _loginViewModel.StatusMessage = "Successfully logged in.";
        }
    }
}
