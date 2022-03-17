using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aad_AsyncCommands.Services
{
    public interface IAuthenticationService
    {
        Task Login(string username);
    }
}
