using aad_AsyncCommands.Commands;
using aad_AsyncCommands.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace aad_AsyncCommands.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        private string _statusMessage;
        public string StatusMessage
        {
            get
            {
                return _statusMessage;
            }
            set
            {
                _statusMessage = value;
                OnPropertyChanged(nameof(StatusMessage));
                OnPropertyChanged(nameof(HasStatusMessage));
            }
        }

        public bool HasStatusMessage => !string.IsNullOrEmpty(StatusMessage);

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            string strCase = "F2";

            if(strCase == "F1")
            {
                //F1
                //LoginCommand = new LoginCommand(this, new AuthenticationService());
                //F1 Agregado 9.41
                LoginCommand = new LoginCommand(this, new AuthenticationService(), (ex) => StatusMessage = ex.Message);

            }
            else if (strCase == "F2")
            {
                //F2 11.56
                LoginCommand = new AsyncRelayCommand(Login, (ex) => StatusMessage = ex.Message);
            }

        }

        private async Task Login()
        {
            //F2 12.19
            //Copiamos el contenido de LoginViewModel.ExecuteAsync y lo adaptamos
            StatusMessage = "Logging in...";

            await new AuthenticationService().Login(Username);

            StatusMessage = "Successfully logged in.";
        }


    }
}
