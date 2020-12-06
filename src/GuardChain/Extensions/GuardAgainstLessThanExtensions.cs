using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Models;
using GuardChain.Utils;

namespace GuardChain.Extensions
{
    public static class GuardAgainstLessThanExtensions
    {
        #region TInput
        public static IChainableGuardClause<TInput> LessThan<TInput>(this IGuardClause<TInput> guard, TInput limit) where TInput : struct, IComparable
        {
            if (guard.Input.CompareTo(limit) < 0)
            {
                throw new ArgumentException($"Required input {guard.InputParameterName} cannot be less than {nameof(limit)}.", guard.InputParameterName);
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<TInput> LessThan<TInput>(this IGuardClause<TInput> guard, TInput limit, Type customExceptionType, params object[] customExceptionArgs) where TInput : struct, IComparable
        {
            if (guard.Input.CompareTo(limit) < 0)
            {
                Guard.ThrowCustomException(customExceptionType, customExceptionArgs);
            }

            return Chain.Next(guard);
        }

        #endregion

        #region short 

        public static IChainableGuardClause<short> LessThan(this IGuardClause<short> guard, short limit)
        {
            return guard.LessThan<short>(limit);
        }

        public static IChainableGuardClause<short> LessThan(this IGuardClause<short> guard, short limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.LessThan<short>(limit, customExceptionType, customExceptionArgs);
        }

        #endregion

        #region int 

        public static IChainableGuardClause<int> LessThan(this IGuardClause<int> guard, int limit)
        {
            return guard.LessThan<int>(limit);
        }

        public static IChainableGuardClause<int> LessThan(this IGuardClause<int> guard, int limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.LessThan<int>(limit, customExceptionType, customExceptionArgs);
        }

        #endregion

        #region long 

        public static IChainableGuardClause<long> LessThan(this IGuardClause<long> guard, long limit)
        {
            return guard.LessThan<long>(limit);
        }

        public static IChainableGuardClause<long> LessThan(this IGuardClause<long> guard, long limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.LessThan<long>(limit, customExceptionType, customExceptionArgs);
        }

        #endregion

        #region decimal 

        public static IChainableGuardClause<decimal> LessThan(this IGuardClause<decimal> guard, decimal limit)
        {
            return guard.LessThan<decimal>(limit);
        }

        public static IChainableGuardClause<decimal> LessThan(this IGuardClause<decimal> guard, decimal limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.LessThan<decimal>(limit, customExceptionType, customExceptionArgs);
        }

        #endregion

        #region double 

        public static IChainableGuardClause<double> LessThan(this IGuardClause<double> guard, double limit)
        {
            return guard.LessThan<double>(limit);
        }

        public static IChainableGuardClause<double> LessThan(this IGuardClause<double> guard, double limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.LessThan<double>(limit, customExceptionType, customExceptionArgs);
        }

        #endregion

        #region float 

        public static IChainableGuardClause<float> LessThan(this IGuardClause<float> guard, float limit)
        {
            return guard.LessThan<float>(limit);
        }

        public static IChainableGuardClause<float> LessThan(this IGuardClause<float> guard, float limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.LessThan<float>(limit, customExceptionType, customExceptionArgs);
        }

        #endregion
    }
}
