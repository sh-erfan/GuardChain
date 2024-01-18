using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Contracts;
using GuardChain.Utils;

namespace GuardChain.Extensions
{
    public static class GuardAgainstPositiveExtensions
    {
        #region TInput
        public static IChainableGuardClause<TInput> Positive<TInput>(this IGuardClause<TInput> guard) where TInput : struct, IComparable
        {
            if (guard.Input.CompareTo(default(TInput)) > 0)
            {
                throw new ArgumentException($"Required input {guard.InputParameterName} cannot be positive.", guard.InputParameterName);
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<TInput> Positive<TInput>(this IGuardClause<TInput> guard, Type customExceptionType, params object[] customExceptionArgs) where TInput : struct, IComparable
        {
            if (guard.Input.CompareTo(default(TInput)) > 0)
            {
                Guard.ThrowCustomException(customExceptionType, customExceptionArgs);
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<TInput> Positive<TException, TInput>(this IGuardClause<TInput> guard, params object[] customExceptionArgs) where TInput : struct, IComparable where TException : Exception
        {
            return guard.Positive<TInput>(typeof(TException), customExceptionArgs);
        }

        #endregion

        #region short 

        public static IChainableGuardClause<short> Positive(this IGuardClause<short> guard)
        {
            return guard.Positive<short>();
        }

        public static IChainableGuardClause<short> Positive(this IGuardClause<short> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Positive<short>(customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<short> Positive<TException>(this IGuardClause<short> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Positive<short>(typeof(TException), customExceptionArgs);
        }

        #endregion

        #region int 

        public static IChainableGuardClause<int> Positive(this IGuardClause<int> guard)
        {
            return guard.Positive<int>();
        }

        public static IChainableGuardClause<int> Positive(this IGuardClause<int> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Positive<int>(customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<int> Positive<TException>(this IGuardClause<int> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Positive<int>(typeof(TException), customExceptionArgs);
        }

        #endregion

        #region long 

        public static IChainableGuardClause<long> Positive(this IGuardClause<long> guard)
        {
            return guard.Positive<long>();
        }

        public static IChainableGuardClause<long> Positive(this IGuardClause<long> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Positive<long>(customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<long> Positive<TException>(this IGuardClause<long> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Positive<long>(typeof(TException), customExceptionArgs);
        }

        #endregion

        #region decimal 

        public static IChainableGuardClause<decimal> Positive(this IGuardClause<decimal> guard)
        {
            return guard.Positive<decimal>();
        }

        public static IChainableGuardClause<decimal> Positive(this IGuardClause<decimal> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Positive<decimal>(customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<decimal> Positive<TException>(this IGuardClause<decimal> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Positive<decimal>(typeof(TException), customExceptionArgs);
        }

        #endregion

        #region double 

        public static IChainableGuardClause<double> Positive(this IGuardClause<double> guard)
        {
            return guard.Positive<double>();
        }

        public static IChainableGuardClause<double> Positive(this IGuardClause<double> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Positive<double>(customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<double> Positive<TException>(this IGuardClause<double> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Positive<double>(typeof(TException), customExceptionArgs);
        }

        #endregion

        #region float 

        public static IChainableGuardClause<float> Positive(this IGuardClause<float> guard)
        {
            return guard.Positive<float>();
        }

        public static IChainableGuardClause<float> Positive(this IGuardClause<float> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Positive<float>(customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<float> Positive<TException>(this IGuardClause<float> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Positive<float>(typeof(TException), customExceptionArgs);
        }

        #endregion
    }
}
