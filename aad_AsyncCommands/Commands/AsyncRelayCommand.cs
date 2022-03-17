using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aad_AsyncCommands.Commands
{
    public class AsyncRelayCommand : AsyncCommandBase
    {
        public AsyncRelayCommand(Action<Exception> onException) : base(onException)
        {
        }

        protected override Task ExecuteAsync(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
