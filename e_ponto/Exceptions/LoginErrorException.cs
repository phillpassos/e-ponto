using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_ponto.Exceptions
{
    class LoginErrorException : Exception
    {
        private const string InvalidLogin = @"Erro de login. Verifique seu usuario e senha";
        public LoginErrorException() : base(InvalidLogin)
        {
        }
    }
}
