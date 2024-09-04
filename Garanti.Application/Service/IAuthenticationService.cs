using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garanti.Application.Service
{
    public interface IAuthenticationService
    {
        string GenerateToken(string email);
    }
}
