using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Models;
using GuardChain.Utils;

namespace GuardChain.Extensions
{
    public static class GuardAgainstDefaultExtensions
    {
        #region TInput

        public static IChainableGuardClause<TInput> Default<TInput>(this IGuardClause<TInput> guard)
        {
            if (EqualityComparer<TInput>.Default.Equals(guard.Input, default(TInput)!) || guard.Input is null)
            {
                throw new ArgumentException($"Parameter [{guard.InputParameterName}] is default value for type {typeof(TInput).Name}", guard.InputParameterName);
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<TInput> Default<TInput>(this IGuardClause<TInput> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            if (EqualityComparer<TInput>.Default.Equals(guard.Input, default(TInput)!) || guard.Input is null)
            {
                Guard.ThrowCustomException(customExceptionType, customExceptionArgs);
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<TInput> Default<TException, TInput>(this IGuardClause<TInput> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Default(typeof(TException), customExceptionArgs);
        }

        #endregion

        #region short

        public static IChainableGuardClause<short> Default(this IGuardClause<short> guard)
        {
            return guard.Default<short>();
        }

        public static IChainableGuardClause<short> Default(this IGuardClause<short> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Default<short>(customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<short> Default<TException>(this IGuardClause<short> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Default<short>(typeof(TException), customExceptionArgs);
        }

        #endregion

        #region int

        public static IChainableGuardClause<int> Default(this IGuardClause<int> guard)
        {
            return guard.Default<int>();
        }

        public static IChainableGuardClause<int> Default(this IGuardClause<int> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Default<int>(customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<int> Default<TException>(this IGuardClause<int> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Default<int>(typeof(TException), customExceptionArgs);
        }

        #endregion

        #region long

        public static IChainableGuardClause<long> Default(this IGuardClause<long> guard)
        {
            return guard.Default<long>();
        }

        public static IChainableGuardClause<long> Default(this IGuardClause<long> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Default<long>(customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<long> Default<TException>(this IGuardClause<long> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Default<long>(typeof(TException), customExceptionArgs);
        }

        #endregion

        #region decimal

        public static IChainableGuardClause<decimal> Default(this IGuardClause<decimal> guard)
        {
            return guard.Default<decimal>();
        }

        public static IChainableGuardClause<decimal> Default(this IGuardClause<decimal> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Default<decimal>(customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<decimal> Default<TException>(this IGuardClause<decimal> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Default<decimal>(typeof(TException), customExceptionArgs);
        }

        #endregion

        #region double

        public static IChainableGuardClause<double> Default(this IGuardClause<double> guard)
        {
            return guard.Default<double>();
        }

        public static IChainableGuardClause<double> Default(this IGuardClause<double> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Default<double>(customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<double> Default<TException>(this IGuardClause<double> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Default<double>(typeof(TException), customExceptionArgs);
        }

        #endregion

        #region float

        public static IChainableGuardClause<float> Default(this IGuardClause<float> guard)
        {
            return guard.Default<float>();
        }

        public static IChainableGuardClause<float> Default(this IGuardClause<float> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Default<float>(customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<float> Default<TException>(this IGuardClause<float> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Default<float>(typeof(TException), customExceptionArgs);
        }

        #endregion

        #region DateTime

        public static IChainableGuardClause<DateTime> Default(this IGuardClause<DateTime> guard)
        {
            return guard.Default<DateTime>();
        }

        public static IChainableGuardClause<DateTime> Default(this IGuardClause<DateTime> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Default<DateTime>(customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<DateTime> Default<TException>(this IGuardClause<DateTime> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Default<DateTime>(typeof(TException), customExceptionArgs);
        }

        #endregion
    }
}
