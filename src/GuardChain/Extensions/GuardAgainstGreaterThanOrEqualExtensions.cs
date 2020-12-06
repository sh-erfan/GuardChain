﻿using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Models;
using GuardChain.Utils;

namespace GuardChain.Extensions
{
    public static class GuardAgainstGreaterThanOrEqualExtensions
    {
        #region TInput
        public static IChainableGuardClause<TInput> GreaterThanOrEqual<TInput>(this IGuardClause<TInput> guard, TInput limit) where TInput : struct, IComparable
        {
            if (guard.Input.CompareTo(limit) >= 0)
            {
                throw new ArgumentException($"Required input {guard.InputParameterName} cannot be greater than or equal to {nameof(limit)}.", guard.InputParameterName);
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<TInput> GreaterThanOrEqual<TInput>(this IGuardClause<TInput> guard, TInput limit, Type customExceptionType, params object[] customExceptionArgs) where TInput : struct, IComparable
        {
            if (guard.Input.CompareTo(limit) >= 0)
            {
                Guard.ThrowCustomException(customExceptionType, customExceptionArgs);
            }

            return Chain.Next(guard);
        }

        #endregion

        #region short 

        public static IChainableGuardClause<short> GreaterThanOrEqual(this IGuardClause<short> guard, short limit)
        {
            return guard.GreaterThanOrEqual<short>(limit);
        }

        public static IChainableGuardClause<short> GreaterThanOrEqual(this IGuardClause<short> guard, short limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.GreaterThanOrEqual<short>(limit, customExceptionType, customExceptionArgs);
        }

        #endregion

        #region int 

        public static IChainableGuardClause<int> GreaterThanOrEqual(this IGuardClause<int> guard, int limit)
        {
            return guard.GreaterThanOrEqual<int>(limit);
        }

        public static IChainableGuardClause<int> GreaterThanOrEqual(this IGuardClause<int> guard, int limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.GreaterThanOrEqual<int>(limit, customExceptionType, customExceptionArgs);
        }

        #endregion

        #region long 

        public static IChainableGuardClause<long> GreaterThanOrEqual(this IGuardClause<long> guard, long limit)
        {
            return guard.GreaterThanOrEqual<long>(limit);
        }

        public static IChainableGuardClause<long> GreaterThanOrEqual(this IGuardClause<long> guard, long limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.GreaterThanOrEqual<long>(limit, customExceptionType, customExceptionArgs);
        }

        #endregion

        #region decimal 

        public static IChainableGuardClause<decimal> GreaterThanOrEqual(this IGuardClause<decimal> guard, decimal limit)
        {
            return guard.GreaterThanOrEqual<decimal>(limit);
        }

        public static IChainableGuardClause<decimal> GreaterThanOrEqual(this IGuardClause<decimal> guard, decimal limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.GreaterThanOrEqual<decimal>(limit, customExceptionType, customExceptionArgs);
        }

        #endregion

        #region double 

        public static IChainableGuardClause<double> GreaterThanOrEqual(this IGuardClause<double> guard, double limit)
        {
            return guard.GreaterThanOrEqual<double>(limit);
        }

        public static IChainableGuardClause<double> GreaterThanOrEqual(this IGuardClause<double> guard, double limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.GreaterThanOrEqual<double>(limit, customExceptionType, customExceptionArgs);
        }

        #endregion

        #region float 

        public static IChainableGuardClause<float> GreaterThanOrEqual(this IGuardClause<float> guard, float limit)
        {
            return guard.GreaterThanOrEqual<float>(limit);
        }

        public static IChainableGuardClause<float> GreaterThanOrEqual(this IGuardClause<float> guard, float limit, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.GreaterThanOrEqual<float>(limit, customExceptionType, customExceptionArgs);
        }

        #endregion
    }
}

