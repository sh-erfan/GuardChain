using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Contracts;
using GuardChain.Utils;

namespace GuardChain.Extensions
{
    public static class GuardAgainstNullOrWhitespaceExtensions
    {
        #region string 

        public static IChainableGuardClause<string> NullOrWhiteSpace(this IGuardClause<string> guard)
        {
            guard.NullOrEmpty();

            if (string.IsNullOrWhiteSpace(guard.Input))
            {
                throw new ArgumentException($"'{guard.InputParameterName}' string cannot be all white spaces");
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<string> NullOrWhiteSpace(this IGuardClause<string> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            guard.NullOrEmpty(customExceptionType, customExceptionArgs);

            if (string.IsNullOrWhiteSpace(guard.Input))
            {
                Guard.ThrowCustomException(customExceptionType, customExceptionArgs);
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<string> NullOrWhiteSpace<TException>(this IGuardClause<string> guard, params object[] customExceptionArgs) where TException: Exception
        {
            return guard.NullOrWhiteSpace(typeof(TException), customExceptionArgs);
        }

        #endregion
    }
}
