using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class LoginService
    {
        private ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            this._loginRepository = loginRepository;
        }

        public bool login(string username, string password)
        {
            return this._loginRepository.Login(username, password);
        }
    }
}
