using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_ponto.Exceptions
{
    class LoginErrorException : Exception
    {
        private const string INVALID_LOGIN = @"Erro de login. Verifique seu usuario e senha";
        private const string EXTRA = @"Complemento: ";
        public LoginErrorException()
            : base(INVALID_LOGIN)
        {
        }

        public LoginErrorException(string message)
            : base(INVALID_LOGIN + EXTRA + message)
        {
        }
    }
}
