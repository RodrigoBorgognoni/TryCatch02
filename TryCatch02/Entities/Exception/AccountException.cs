using System;
using System.Threading;
using System.Globalization;

namespace TryCatch02.Entities.Exception
{
    internal class AccountException : ApplicationException
    {
        public AccountException(string message) : base(message)
        {
        }
    }
}
