using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GuardChain.Models;
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

        #endregion

        #region IEnumerable<TInput>

        public static IChainableGuardClause<IEnumerable<TInput>> NullOrEmpty<TInput>(this IGuardClause<IEnumerable<TInput>> guard)
        {
            guard.Null();

            if (!guard.Input.Any())
            {
                throw new ArgumentException($"'{guard.InputParameterName}' collection cannot be empty");
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<IEnumerable<TInput>> NullOrEmpty<TInput>(this IGuardClause<IEnumerable<TInput>> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            guard.Null(customExceptionType, customExceptionArgs);

            if (!guard.Input.Any())
            {
                Guard.ThrowCustomException(customExceptionType, customExceptionArgs);
            }

            return Chain.Next(guard);
        }

        #endregion
    }
}
