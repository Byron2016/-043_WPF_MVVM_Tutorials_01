using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aad_AsyncCommands.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public async Task Login(string username)
        {
            await Task.Delay(5000);
        }
    }
}
