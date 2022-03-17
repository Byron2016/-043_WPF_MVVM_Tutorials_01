using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace aab_EventCommandsMVVM_.Commands
{
    public class SelectedTodoItemsChangedCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //Poner debug acá y cada vez q se selecciona un elemento va a llamar a este.
        }
    }
}
