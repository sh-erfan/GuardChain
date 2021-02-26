using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Models;
using GuardChain.Utils;

namespace GuardChain.Extensions
{
    public static class GuardAgainstZeroExtensions
    {
        #region TInput
        public static IChainableGuardClause<TInput> Zero<TInput>(this IGuardClause<TInput> guard) where TInput : struct, IComparable
        {
            if (EqualityComparer<TInput>.Default.Equals(guard.Input, default(TInput)))
            {
                throw new ArgumentException($"Required input {guard.InputParameterName} cannot be zero.", guard.InputParameterName);
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<TInput> Zero<TInput>(this IGuardClause<TInput> guard, Type customExceptionType, params object[] customExceptionArgs) where TInput : struct, IComparable
        {
            if (Math.Abs(guard.Input.CompareTo(default(TInput))) == 0)
            {
                Guard.ThrowCustomException(customExceptionType, customExceptionArgs);
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<TInput> Zero<TException, TInput>(this IGuardClause<TInput> guard, params object[] customExceptionArgs) where TInput : struct, IComparable where TException : Exception
        {
            return guard.Zero<TInput>(typeof(TException), customExceptionArgs);
        }

        #endregion

        #region short 

        public static IChainableGuardClause<short> Zero(this IGuardClause<short> guard)
        {
            return guard.Zero<short>();
        }

        public static IChainableGuardClause<short> Zero(this IGuardClause<short> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Zero<short>(customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<short> Zero<TException>(this IGuardClause<short> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Zero<short>(typeof(TException), customExceptionArgs);
        }

        #endregion

        #region int 

        public static IChainableGuardClause<int> Zero(this IGuardClause<int> guard)
        {
            return guard.Zero<int>();
        }

        public static IChainableGuardClause<int> Zero(this IGuardClause<int> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Zero<int>(customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<int> Zero<TException>(this IGuardClause<int> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Zero<int>(typeof(TException), customExceptionArgs);
        }

        #endregion

        #region long 

        public static IChainableGuardClause<long> Zero(this IGuardClause<long> guard)
        {
            return guard.Zero<long>();
        }

        public static IChainableGuardClause<long> Zero(this IGuardClause<long> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Zero<long>(customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<long> Zero<TException>(this IGuardClause<long> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Zero<long>(typeof(TException), customExceptionArgs);
        }

        #endregion

        #region decimal 

        public static IChainableGuardClause<decimal> Zero(this IGuardClause<decimal> guard)
        {
            return guard.Zero<decimal>();
        }

        public static IChainableGuardClause<decimal> Zero(this IGuardClause<decimal> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Zero<decimal>(customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<decimal> Zero<TException>(this IGuardClause<decimal> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Zero<decimal>(typeof(TException), customExceptionArgs);
        }

        #endregion

        #region double 

        public static IChainableGuardClause<double> Zero(this IGuardClause<double> guard)
        {
            return guard.Zero<double>();
        }

        public static IChainableGuardClause<double> Zero(this IGuardClause<double> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Zero<double>(customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<double> Zero<TException>(this IGuardClause<double> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Zero<double>(typeof(TException), customExceptionArgs);
        }

        #endregion

        #region float 

        public static IChainableGuardClause<float> Zero(this IGuardClause<float> guard)
        {
            return guard.Zero<float>();
        }

        public static IChainableGuardClause<float> Zero(this IGuardClause<float> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Zero<float>(customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<float> Zero<TException>(this IGuardClause<float> guard, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Zero<float>(typeof(TException), customExceptionArgs);
        }

        #endregion
    }
}
