using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Models;
using GuardChain.Utils;

namespace GuardChain.Extensions
{
    public static class GuardAgainstDefaultExtensions
    {
        #region TInput

        public static IChainableGuardClause<TInput> Default<TInput>(this IGuardClause<TInput> guard)
        {
            if (EqualityComparer<TInput>.Default.Equals(guard.Input, default(TInput)!) || guard.Input is null)
            {
                throw new ArgumentException($"Parameter [{guard.InputParameterName}] is default value for type {typeof(TInput).Name}", guard.InputParameterName);
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<TInput> Default<TInput>(this IGuardClause<TInput> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            if (EqualityComparer<TInput>.Default.Equals(guard.Input, default(TInput)!) || guard.Input is null)
            {
                Guard.ThrowCustomException(customExceptionType, customExceptionArgs);
            }

            return Chain.Next(guard);
        }

        #endregion
    }
}
