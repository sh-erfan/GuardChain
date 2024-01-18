using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GuardChain.Contracts;
using GuardChain.Utils;

namespace GuardChain.Extensions
{
    public static class GuardAgainstNullOrEmptyExtensions
    {
        #region string
       
        public static IChainableGuardClause<string> NullOrEmpty(this IGuardClause<string> guard)
        {
            guard.Null();

            if (guard.Input == string.Empty)
            {
                throw new ArgumentException($"'{guard.InputParameterName}' cannot be empty");
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<string> NullOrEmpty(this IGuardClause<string> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            guard.Null(customExceptionType, customExceptionArgs);

            if (guard.Input == string.Empty)
            {
                Guard.ThrowCustomException(customExceptionType, customExceptionArgs);
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<string> NullOrEmpty<TException>(this IGuardClause<string> guard,  params object[] customExceptionArgs) where TException: Exception
        {
            return guard.NullOrEmpty(typeof(TException), customExceptionArgs);
        }

        #endregion

        #region Guid

        public static IChainableGuardClause<Guid> NullOrEmpty(this IGuardClause<Guid> guard)
        {
            guard.Null();

            if (guard.Input == Guid.Empty)
            {
                throw new ArgumentException($"'{guard.InputParameterName}' cannot be empty");
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<Guid> NullOrEmpty(this IGuardClause<Guid> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            guard.Null(customExceptionType, customExceptionArgs);

            if (guard.Input == Guid.Empty)
            {
                Guard.ThrowCustomException(customExceptionType, customExceptionArgs);
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<Guid> NullOrEmpty<TException>(this IGuardClause<Guid> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.NullOrEmpty(typeof(TException), customExceptionArgs);
        }

        #endregion

        #region IEnumerable<TInput>

        public static IChainableGuardClause<IEnumerable<dynamic>> NullOrEmpty(this IGuardClause<IEnumerable<dynamic>> guard)
        {
            guard.Null();

            if (!guard.Input.Any())
            {
                throw new ArgumentException($"'{guard.InputParameterName}' collection cannot be empty");
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<IEnumerable<dynamic>> NullOrEmpty(this IGuardClause<IEnumerable<dynamic>> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            guard.Null(customExceptionType, customExceptionArgs);

            if (!guard.Input.Any())
            {
                Guard.ThrowCustomException(customExceptionType, customExceptionArgs);
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<IEnumerable<dynamic>> NullOrEmpty<TException>(this IGuardClause<IEnumerable<dynamic>> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.NullOrEmpty(typeof(TException), customExceptionArgs);
        }

        #endregion
    }
}
