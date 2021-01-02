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

        public static IChainableGuardClause<TInput> NegativeOrZero<TException, TInput>(this IGuardClause<TInput> guard, params object[] customExceptionArgs) where TInput : struct, IComparable where TException: Exception
        {
            return guard.NegativeOrZero<TInput>(typeof(TException), customExceptionArgs);
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

        public static IChainableGuardClause<short> NegativeOrZero<TException>(this IGuardClause<short> guard, params object[] customExceptionArgs) where TException: Exception
        {
            return guard.NegativeOrZero<short>(typeof(TException), customExceptionArgs);
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

        public static IChainableGuardClause<int> NegativeOrZero<TException>(this IGuardClause<int> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.NegativeOrZero<int>(typeof(TException), customExceptionArgs);
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

        public static IChainableGuardClause<long> NegativeOrZero<TException>(this IGuardClause<long> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.NegativeOrZero<long>(typeof(TException), customExceptionArgs);
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

        public static IChainableGuardClause<decimal> NegativeOrZero<TException>(this IGuardClause<decimal> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.NegativeOrZero<decimal>(typeof(TException), customExceptionArgs);
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

        public static IChainableGuardClause<double> NegativeOrZero<TException>(this IGuardClause<double> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.NegativeOrZero<double>(typeof(TException), customExceptionArgs);
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

        public static IChainableGuardClause<float> NegativeOrZero<TException>(this IGuardClause<float> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.NegativeOrZero<float>(typeof(TException), customExceptionArgs);
        }

        #endregion
    }
}
