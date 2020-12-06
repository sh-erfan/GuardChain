using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Models;
using GuardChain.Utils;

namespace GuardChain.Extensions
{
    public static class GuardAgainstNegativeExtensions
    {
        #region TInput
        public static IChainableGuardClause<TInput> Negative<TInput>(this IGuardClause<TInput> guard) where TInput : struct, IComparable
        {
            if (guard.Input.CompareTo(default(TInput)) < 0)
            {
                throw new ArgumentException($"Required input {guard.InputParameterName} cannot be negative.", guard.InputParameterName);
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<TInput> Negative<TInput>(this IGuardClause<TInput> guard, Type customExceptionType, params object[] customExceptionArgs) where TInput : struct, IComparable
        {
            if (guard.Input.CompareTo(default(TInput)) < 0)
            {
                Guard.ThrowCustomException(customExceptionType, customExceptionArgs);
            }

            return Chain.Next(guard);
        }

        #endregion

        #region short 

        public static IChainableGuardClause<short> Negative(this IGuardClause<short> guard)
        {
            return guard.Negative<short>();
        }

        public static IChainableGuardClause<short> Negative(this IGuardClause<short> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Negative<short>(customExceptionType, customExceptionArgs);
        }

        #endregion

        #region int 

        public static IChainableGuardClause<int> Negative(this IGuardClause<int> guard)
        {
            return guard.Negative<int>();
        }

        public static IChainableGuardClause<int> Negative(this IGuardClause<int> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Negative<int>(customExceptionType, customExceptionArgs);
        }

        #endregion

        #region long 

        public static IChainableGuardClause<long> Negative(this IGuardClause<long> guard)
        {
            return guard.Negative<long>();
        }

        public static IChainableGuardClause<long> Negative(this IGuardClause<long> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Negative<long>(customExceptionType, customExceptionArgs);
        }

        #endregion

        #region decimal 

        public static IChainableGuardClause<decimal> Negative(this IGuardClause<decimal> guard)
        {
            return guard.Negative<decimal>();
        }

        public static IChainableGuardClause<decimal> Negative(this IGuardClause<decimal> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Negative<decimal>(customExceptionType, customExceptionArgs);
        }

        #endregion

        #region double 

        public static IChainableGuardClause<double> Negative(this IGuardClause<double> guard)
        {
            return guard.Negative<double>();
        }

        public static IChainableGuardClause<double> Negative(this IGuardClause<double> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Negative<double>(customExceptionType, customExceptionArgs);
        }

        #endregion

        #region float 

        public static IChainableGuardClause<float> Negative(this IGuardClause<float> guard)
        {
            return guard.Negative<float>();
        }

        public static IChainableGuardClause<float> Negative(this IGuardClause<float> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Negative<float>(customExceptionType, customExceptionArgs);
        }

        #endregion
    }
}
