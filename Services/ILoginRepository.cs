using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public interface ILoginRepository
    {
        bool Login(string username, string password);
    }
}
