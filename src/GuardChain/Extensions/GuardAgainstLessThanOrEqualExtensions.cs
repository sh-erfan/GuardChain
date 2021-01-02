using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Models;
using GuardChain.Utils;

namespace GuardChain.Extensions
{
    public static class GuardAgainstLessThanOrEqualExtensions
    {
        #region TInput
        public static IChainableGuardClause<TInput> LessThanOrEqual<TInput>(this IGuardClause<TInput> guard, TInput limit) where TInput : struct, IComparable
        {
            if (guard.Input.CompareTo(limit) <= 0)
            {
                throw new ArgumentException($"Required input {guard.InputParameterName} cannot be less than or equal to {nameof(limit)}.", guard.InputParameterName);
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<TInput> LessThanOrEqual<TInput>(this IGuardClause<TInput> guard, TInput limit, Type customExceptionType, params object[] customExceptionArgs) where TInput : struct, IComparable
        {
            if (guard.Input.CompareTo(limit) <= 0)
            {
                Guard.ThrowCustomException(customExceptionType, customExceptionArgs);
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<TInput> LessThanOrEqual<TException, TInput>(this IGuardClause<TInput> guard, TInput limit, params object[] customExceptionArgs) where TInput : struct, IComparable where TException: Exception
        {
            return guard.LessThanOrEqual<TInput>(limit, typeof(TException), customExceptionArgs);
        }

        #endregion

        #region short 

        public static IChainableGuardClause<short> LessThanOrEqual(this IGuardClause<short> guard, short limit)
        {
            return guard.LessThanOrEqual<short>(limit);
        }

        public static IChainableGuardClause<short> LessThanOrEqual(this IGuardClause<short> guard, short limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.LessThanOrEqual<short>(limit, customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<short> LessThanOrEqual<TException>(this IGuardClause<short> guard, short limit, params object[] customExceptionArgs) where TException: Exception
        {
            return guard.LessThanOrEqual<short>(limit, typeof(TException), customExceptionArgs);
        }

        #endregion

        #region int 

        public static IChainableGuardClause<int> LessThanOrEqual(this IGuardClause<int> guard, int limit)
        {
            return guard.LessThanOrEqual<int>(limit);
        }

        public static IChainableGuardClause<int> LessThanOrEqual(this IGuardClause<int> guard, int limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.LessThanOrEqual<int>(limit, customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<int> LessThanOrEqual<TException>(this IGuardClause<int> guard, int limit, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.LessThanOrEqual<int>(limit, typeof(TException), customExceptionArgs);
        }

        #endregion

        #region long 

        public static IChainableGuardClause<long> LessThanOrEqual(this IGuardClause<long> guard, long limit)
        {
            return guard.LessThanOrEqual<long>(limit);
        }

        public static IChainableGuardClause<long> LessThanOrEqual(this IGuardClause<long> guard, long limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.LessThanOrEqual<long>(limit, customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<long> LessThanOrEqual<TException>(this IGuardClause<long> guard, long limit, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.LessThanOrEqual<long>(limit, typeof(TException), customExceptionArgs);
        }

        #endregion

        #region decimal 

        public static IChainableGuardClause<decimal> LessThanOrEqual(this IGuardClause<decimal> guard, decimal limit)
        {
            return guard.LessThanOrEqual<decimal>(limit);
        }

        public static IChainableGuardClause<decimal> LessThanOrEqual(this IGuardClause<decimal> guard, decimal limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.LessThanOrEqual<decimal>(limit, customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<decimal> LessThanOrEqual<TException>(this IGuardClause<decimal> guard, decimal limit, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.LessThanOrEqual<decimal>(limit, typeof(TException), customExceptionArgs);
        }

        #endregion

        #region double 

        public static IChainableGuardClause<double> LessThanOrEqual(this IGuardClause<double> guard, double limit)
        {
            return guard.LessThanOrEqual<double>(limit);
        }

        public static IChainableGuardClause<double> LessThanOrEqual(this IGuardClause<double> guard, double limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.LessThanOrEqual<double>(limit, customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<double> LessThanOrEqual<TException>(this IGuardClause<double> guard, double limit, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.LessThanOrEqual<double>(limit, typeof(TException), customExceptionArgs);
        }

        #endregion

        #region float 

        public static IChainableGuardClause<float> LessThanOrEqual(this IGuardClause<float> guard, float limit)
        {
            return guard.LessThanOrEqual<float>(limit);
        }

        public static IChainableGuardClause<float> LessThanOrEqual(this IGuardClause<float> guard, float limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.LessThanOrEqual<float>(limit, customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<float> LessThanOrEqual<TException>(this IGuardClause<float> guard, float limit, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.LessThanOrEqual<float>(limit, typeof(TException), customExceptionArgs);
        }

        #endregion
    }
}
