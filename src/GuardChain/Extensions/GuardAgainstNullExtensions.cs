using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using GuardChain.Contracts;
using GuardChain.Utils;

namespace GuardChain.Extensions
{
    public static class GuardAgainstNullExtensions
    {
        #region TInput

        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if protected input is null.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="guard"></param>
        /// <returns><see cref="IChainableGuardClause{TInput}"/> if protected input is not null.</returns>
        public static IChainableGuardClause<TInput> Null<TInput>(this IGuardClause<TInput> guard)
        {
            if (guard.Input == null)
            {
                throw new ArgumentNullException(guard.InputParameterName);
            }

            return Chain.Next(guard);
        }

        

        /// <summary>
        /// Throws exception of type <param name="customExceptionType"></param> if protected input is null.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="guard"></param>
        /// <param name="customExceptionType">Type of custom exception to be thrown if protected input is null.</param>
        /// <param name="customExceptionArgs">constructor parameters of type <param name="customExceptionType">.</param></param>
        /// <returns></returns>
        public static IChainableGuardClause<TInput> Null<TInput>(this IGuardClause<TInput> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            if (guard.Input == null)
            {
                Guard.ThrowCustomException(customExceptionType, customExceptionArgs);
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<TInput> Null<TException, TInput>(this IGuardClause<TInput> guard, params object[] customExceptionArgs) where TException: Exception
        {
           return guard.Null(typeof(TException), customExceptionArgs);
        }

        #endregion

        #region Object

        public static IChainableGuardClause<object> Null(this IGuardClause<object> guard)
        {
            return guard.Null<object>();
        }

        public static IChainableGuardClause<object> Null(this IGuardClause<object> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Null<object>(customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<object> Null<TException>(this IGuardClause<object> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Null<object>( typeof(TException), customExceptionArgs);
        }


        #endregion


    }
}
