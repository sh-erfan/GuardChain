using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Models;
using GuardChain.Utils;

namespace GuardChain.Extensions
{
    public static class GuardAgainstNegativeOrZeroExtensions
    {
        #region TInput
        public static IChainableGuardClause<TInput> NegativeOrZero<TInput>(this IGuardClause<TInput> guard) where TInput : struct, IComparable
        {
            if (guard.Input.CompareTo(default(TInput)) <= 0)
            {
                throw new ArgumentException($"Required input {guard.InputParameterName} cannot be negative or zero.", guard.InputParameterName);
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<TInput> NegativeOrZero<TInput>(this IGuardClause<TInput> guard, Type customExceptionType, params object[] customExceptionArgs) where TInput : struct, IComparable
        {
            if (guard.Input.CompareTo(default(TInput)) <= 0)
            {
                Guard.ThrowCustomException(customExceptionType, customExceptionArgs);
            }

            return Chain.Next(guard);
        }

        #endregion

        #region short 

        public static IChainableGuardClause<short> NegativeOrZero(this IGuardClause<short> guard)
        {
            return guard.NegativeOrZero<short>();
        }

        public static IChainableGuardClause<short> NegativeOrZero(this IGuardClause<short> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.NegativeOrZero<short>(customExceptionType, customExceptionArgs);
        }

        #endregion

        #region int 

        public static IChainableGuardClause<int> NegativeOrZero(this IGuardClause<int> guard)
        {
            return guard.NegativeOrZero<int>();
        }

        public static IChainableGuardClause<int> NegativeOrZero(this IGuardClause<int> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.NegativeOrZero<int>(customExceptionType, customExceptionArgs);
        }

        #endregion

        #region long 

        public static IChainableGuardClause<long> NegativeOrZero(this IGuardClause<long> guard)
        {
            return guard.NegativeOrZero<long>();
        }

        public static IChainableGuardClause<long> NegativeOrZero(this IGuardClause<long> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.NegativeOrZero<long>(customExceptionType, customExceptionArgs);
        }

        #endregion

        #region decimal 

        public static IChainableGuardClause<decimal> NegativeOrZero(this IGuardClause<decimal> guard)
        {
            return guard.NegativeOrZero<decimal>();
        }

        public static IChainableGuardClause<decimal> NegativeOrZero(this IGuardClause<decimal> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.NegativeOrZero<decimal>(customExceptionType, customExceptionArgs);
        }

        #endregion

        #region double 

        public static IChainableGuardClause<double> NegativeOrZero(this IGuardClause<double> guard)
        {
            return guard.NegativeOrZero<double>();
        }

        public static IChainableGuardClause<double> NegativeOrZero(this IGuardClause<double> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.NegativeOrZero<double>(customExceptionType, customExceptionArgs);
        }

        #endregion

        #region float 

        public static IChainableGuardClause<float> NegativeOrZero(this IGuardClause<float> guard)
        {
            return guard.NegativeOrZero<float>();
        }

        public static IChainableGuardClause<float> NegativeOrZero(this IGuardClause<float> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.NegativeOrZero<float>(customExceptionType, customExceptionArgs);
        }

        #endregion
    }
}
