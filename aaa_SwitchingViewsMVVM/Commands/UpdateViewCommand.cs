using aaa_SwitchingViewsMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace aaa_SwitchingViewsMVVM.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private readonly MainViewModel _viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (parameter.ToString() == "Home")
            {
                _viewModel.SelectedViewMode = new HomeViewModel();

            }
            else if (parameter.ToString() == "Account")
            {
                _viewModel.SelectedViewMode = new AccountViewModel();

            }
        }
    }
}
