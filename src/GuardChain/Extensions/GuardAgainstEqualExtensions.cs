using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Contracts;
using GuardChain.Utils;

namespace GuardChain.Extensions
{
    public static class GuardAgainstEqualExtensions
    {
        #region TInput

        public static IChainableGuardClause<TInput> Equal<TInput>(this IGuardClause<TInput> guard, TInput target)
        {
            if ((guard.Input is null && target is null) || target.Equals(guard.Input))
            {
                throw new ArgumentException($"Required input {guard.InputParameterName} cannot be equal to target");
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<TInput> Equal<TInput>(this IGuardClause<TInput> guard, TInput target, Type customExceptionType, params object[] customExceptionArgs)
        {
            if ((guard.Input is null && target is null) || target.Equals(guard.Input))
            {
                Guard.ThrowCustomException(customExceptionType, customExceptionArgs);
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<TInput> Equal<TException, TInput>(this IGuardClause<TInput> guard, TInput target, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Equal(target, typeof(TException), customExceptionArgs);
        }

        #endregion

        #region short 

        public static IChainableGuardClause<short> Equal(this IGuardClause<short> guard, short target)
        {
            return guard.Equal<short>(target);
        }

        public static IChainableGuardClause<short> Equal(this IGuardClause<short> guard, short target, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Equal<short>(target, customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<short> Equal<TException>(this IGuardClause<short> guard, short target, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Equal<short>(target, typeof(TException), customExceptionArgs);
        }

        #endregion

        #region int 

        public static IChainableGuardClause<int> Equal(this IGuardClause<int> guard, int target)
        {
            return guard.Equal<int>(target);
        }

        public static IChainableGuardClause<int> Equal(this IGuardClause<int> guard, int target, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Equal<int>(target, customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<int> Equal<TException>(this IGuardClause<int> guard, int target, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Equal<int>(target, typeof(TException), customExceptionArgs);
        }

        #endregion

        #region long 

        public static IChainableGuardClause<long> Equal(this IGuardClause<long> guard, long target)
        {
            return guard.Equal<long>(target);
        }

        public static IChainableGuardClause<long> Equal(this IGuardClause<long> guard, long target, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Equal<long>(target, customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<long> Equal<TException>(this IGuardClause<long> guard, long target, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Equal<long>(target, typeof(TException), customExceptionArgs);
        }

        #endregion

        #region decimal 

        public static IChainableGuardClause<decimal> Equal(this IGuardClause<decimal> guard, decimal target)
        {
            return guard.Equal<decimal>(target);
        }

        public static IChainableGuardClause<decimal> Equal(this IGuardClause<decimal> guard, decimal target, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Equal<decimal>(target, customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<decimal> Equal<TException>(this IGuardClause<decimal> guard, decimal target, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Equal<decimal>(target, typeof(TException), customExceptionArgs);
        }

        #endregion

        #region double 

        public static IChainableGuardClause<double> Equal(this IGuardClause<double> guard, double target)
        {
            return guard.Equal<double>(target);
        }

        public static IChainableGuardClause<double> Equal(this IGuardClause<double> guard, double target, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Equal<double>(target, customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<double> Equal<TException>(this IGuardClause<double> guard, double target, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Equal<double>(target, typeof(TException), customExceptionArgs);
        }

        #endregion

        #region float 

        public static IChainableGuardClause<float> Equal(this IGuardClause<float> guard, float target)
        {
            return guard.Equal<float>(target);
        }

        public static IChainableGuardClause<float> Equal(this IGuardClause<float> guard, float target, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Equal<float>(target, customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<float> Equal<TException>(this IGuardClause<float> guard, float target, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Equal<float>(target, typeof(TException), customExceptionArgs);
        }

        #endregion

        #region DateTime 

        public static IChainableGuardClause<DateTime> Equal(this IGuardClause<DateTime> guard, DateTime target)
        {
            return guard.Equal<DateTime>(target);
        }

        public static IChainableGuardClause<DateTime> Equal(this IGuardClause<DateTime> guard, DateTime target, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.Equal<DateTime>(target, customExceptionType, customExceptionArgs);
        }

        public static IChainableGuardClause<DateTime> Equal<TException>(this IGuardClause<DateTime> guard, DateTime target, params object[] customExceptionArgs) where TException : Exception
        {
            return guard.Equal<DateTime>(target, typeof(TException), customExceptionArgs);
        }

        #endregion



    }
}
