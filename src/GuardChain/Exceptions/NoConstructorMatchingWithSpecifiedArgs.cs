using System;
using System.Collections.Generic;
using System.Text;

namespace GuardChain.Exceptions
{
    internal class NoConstructorMatchingWithSpecifiedArgs : Exception
    {
        private const string message =
            "Guard not passed. You don't see your custom exception message because the type '{0}' has no constructor matching args specified.";
        internal NoConstructorMatchingWithSpecifiedArgs(string customExceptionTypeName)
            : base(string.Format(message, customExceptionTypeName))
        {

        }
    }
}
