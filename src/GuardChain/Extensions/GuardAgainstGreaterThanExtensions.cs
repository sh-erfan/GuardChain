using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Models;
using GuardChain.Utils;

namespace GuardChain.Extensions
{
    public static class GuardAgainstGreaterThanExtensions
    {
        #region TInput
        public static IChainableGuardClause<TInput> GreaterThan<TInput>(this IGuardClause<TInput> guard, TInput limit) where TInput : struct, IComparable
        {
            if (guard.Input.CompareTo(limit) > 0)
            {
                throw new ArgumentException($"Required input {guard.InputParameterName} cannot be greater than {nameof(limit)}.", guard.InputParameterName);
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<TInput> GreaterThan<TInput>(this IGuardClause<TInput> guard, TInput limit, Type customExceptionType, params object[] customExceptionArgs) where TInput : struct, IComparable
        {
            if (guard.Input.CompareTo(limit) > 0)
            {
                Guard.ThrowCustomException(customExceptionType, customExceptionArgs);
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<TInput> GreaterThan<TException, TInput>(this IGuardClause<TInput> guard, TInput limit, params object[] customExceptionArgs) where TInput : struct, IComparable where TException : Exception
        {
            return guard.GreaterThan(limit, typeof(TException), customExceptionArgs);
        }

        #endregion

        #region short 

        public static IChainableGuardClause<short> GreaterThan(this IGuardClause<short> guard, short limit)
        {
            return guard.GreaterThan<short>(limit);
        }

        public static IChainableGuardClause<short> GreaterThan(this IGuardClause<short> guard, short limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.GreaterThan<short>(limit, customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<short> GreaterThan<TException>(this IGuardClause<short> guard, short limit, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.GreaterThan<short>(limit, typeof(TException), customExceptionArgs);
        }

        #endregion

        #region int 

        public static IChainableGuardClause<int> GreaterThan(this IGuardClause<int> guard, int limit)
        {
            return guard.GreaterThan<int>(limit);
        }

        public static IChainableGuardClause<int> GreaterThan(this IGuardClause<int> guard, int limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.GreaterThan<int>(limit, customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<int> GreaterThan<TException>(this IGuardClause<int> guard, int limit, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.GreaterThan<int>(limit, typeof(TException), customExceptionArgs);
        }

        #endregion

        #region long 

        public static IChainableGuardClause<long> GreaterThan(this IGuardClause<long> guard, long limit)
        {
            return guard.GreaterThan<long>(limit);
        }

        public static IChainableGuardClause<long> GreaterThan(this IGuardClause<long> guard, long limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.GreaterThan<long>(limit, customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<long> GreaterThan<TException>(this IGuardClause<long> guard, long limit, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.GreaterThan<long>(limit, typeof(TException), customExceptionArgs);
        }

        #endregion

        #region decimal 

        public static IChainableGuardClause<decimal> GreaterThan(this IGuardClause<decimal> guard, decimal limit)
        {
            return guard.GreaterThan<decimal>(limit);
        }

        public static IChainableGuardClause<decimal> GreaterThan(this IGuardClause<decimal> guard, decimal limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.GreaterThan<decimal>(limit, customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<decimal> GreaterThan<TException>(this IGuardClause<decimal> guard, decimal limit, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.GreaterThan<decimal>(limit, typeof(TException), customExceptionArgs);
        }

        #endregion

        #region double 

        public static IChainableGuardClause<double> GreaterThan(this IGuardClause<double> guard, double limit)
        {
            return guard.GreaterThan<double>(limit);
        }

        public static IChainableGuardClause<double> GreaterThan(this IGuardClause<double> guard, double limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.GreaterThan<double>(limit, customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<double> GreaterThan<TException>(this IGuardClause<double> guard, double limit, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.GreaterThan<double>(limit, typeof(TException), customExceptionArgs);
        }

        #endregion

        #region float 

        public static IChainableGuardClause<float> GreaterThan(this IGuardClause<float> guard, float limit)
        {
            return guard.GreaterThan<float>(limit);
        }

        public static IChainableGuardClause<float> GreaterThan(this IGuardClause<float> guard, float limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.GreaterThan<float>(limit, customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<float> GreaterThan<TException>(this IGuardClause<float> guard, float limit, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.GreaterThan<float>(limit, typeof(TException), customExceptionArgs);
        }

        #endregion
    }
}