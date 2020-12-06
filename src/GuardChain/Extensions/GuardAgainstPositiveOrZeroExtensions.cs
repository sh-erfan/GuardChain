using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Models;
using GuardChain.Utils;

namespace GuardChain.Extensions
{
    public static class GuardAgainstPositiveOrZeroExtensions
    {
        #region TInput
        public static IChainableGuardClause<TInput> PositiveOrZero<TInput>(this IGuardClause<TInput> guard) where TInput : struct, IComparable
        {
            if (guard.Input.CompareTo(default(TInput)) >= 0)
            {
                throw new ArgumentException($"Required input {guard.InputParameterName} cannot be positive or zero.", guard.InputParameterName);
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<TInput> PositiveOrZero<TInput>(this IGuardClause<TInput> guard, Type customExceptionType, params object[] customExceptionArgs) where TInput : struct, IComparable
        {
            if (guard.Input.CompareTo(default(TInput)) >= 0)
            {
                Guard.ThrowCustomException(customExceptionType, customExceptionArgs);
            }

            return Chain.Next(guard);
        }

        #endregion

        #region short 

        public static IChainableGuardClause<short> PositiveOrZero(this IGuardClause<short> guard)
        {
            return guard.PositiveOrZero<short>();
        }

        public static IChainableGuardClause<short> PositiveOrZero(this IGuardClause<short> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.PositiveOrZero<short>(customExceptionType, customExceptionArgs);
        }

        #endregion

        #region int 

        public static IChainableGuardClause<int> PositiveOrZero(this IGuardClause<int> guard)
        {
            return guard.PositiveOrZero<int>();
        }

        public static IChainableGuardClause<int> PositiveOrZero(this IGuardClause<int> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.PositiveOrZero<int>(customExceptionType, customExceptionArgs);
        }

        #endregion

        #region long 

        public static IChainableGuardClause<long> PositiveOrZero(this IGuardClause<long> guard)
        {
            return guard.PositiveOrZero<long>();
        }

        public static IChainableGuardClause<long> PositiveOrZero(this IGuardClause<long> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.PositiveOrZero<long>(customExceptionType, customExceptionArgs);
        }

        #endregion

        #region decimal 

        public static IChainableGuardClause<decimal> PositiveOrZero(this IGuardClause<decimal> guard)
        {
            return guard.PositiveOrZero<decimal>();
        }

        public static IChainableGuardClause<decimal> PositiveOrZero(this IGuardClause<decimal> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.PositiveOrZero<decimal>(customExceptionType, customExceptionArgs);
        }

        #endregion

        #region double 

        public static IChainableGuardClause<double> PositiveOrZero(this IGuardClause<double> guard)
        {
            return guard.PositiveOrZero<double>();
        }

        public static IChainableGuardClause<double> PositiveOrZero(this IGuardClause<double> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.PositiveOrZero<double>(customExceptionType, customExceptionArgs);
        }

        #endregion

        #region float 

        public static IChainableGuardClause<float> PositiveOrZero(this IGuardClause<float> guard)
        {
            return guard.PositiveOrZero<float>();
        }

        public static IChainableGuardClause<float> PositiveOrZero(this IGuardClause<float> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.PositiveOrZero<float>(customExceptionType, customExceptionArgs);
        }

        #endregion
    }
}
