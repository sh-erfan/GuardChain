using System;
using System.Collections.Generic;
using System.Text;

namespace GuardChain.Exceptions
{
    internal class CustomExceptionTypeIsNotAnException : Exception
    {
        private const string message = "Guard not passed. You don't see your custom exception message because the type '{0}' is not an exception.";
        internal CustomExceptionTypeIsNotAnException(string customExceptionTypeName)
            : base(string.Format(message, customExceptionTypeName))

        {

        }
    }
}
