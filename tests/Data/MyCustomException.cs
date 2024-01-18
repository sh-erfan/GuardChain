using System;
using System.Collections.Generic;
using System.Text;

namespace GuardChain.Tests.Data
{
    class MyCustomException : Exception
    {
        public MyCustomException() : base()
        {

        }

        public MyCustomException(string message) : base(message)
        {

        }
    }
}
