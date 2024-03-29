﻿using System;
using System.Collections.Generic;
using System.Text;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("GuardChain.Tests")]
namespace GuardChain.Exceptions
{
    internal class GuardDefaultException : Exception
    {
        private const string message = "Guard not passed. Reason that you don't see CustomExceptionMessage: ";
        internal GuardDefaultException(string msg)
            :base(message + msg)
        {
            
        }

        internal GuardDefaultException(Exception innerException)
            : base("Guard not passed. Reason that you don't see CustomExceptionMessage: ", innerException)
        {

        }
    }
}
