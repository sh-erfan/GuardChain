using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;
using GuardChain.Models;
using GuardChain.Utils;

namespace GuardChain.Extensions
{
    public static class GuardAgainstOutOfRangeExtensions
    {
        #region TInput

        public static IChainableGuardClause<TInput> OutOfRange<TInput>(this IGuardClause<TInput> guard, TInput rangeFrom, TInput rangeTo)
        {
            var comparer = Comparer<TInput>.Default;

            if (comparer.Compare(rangeFrom, rangeTo) > 0)
            {
                throw new ArgumentException($"{nameof(rangeFrom)} cannot be larger than {nameof(rangeTo)}");
            }

            if (comparer.Compare(guard.Input, rangeFrom) < 0 || comparer.Compare(guard.Input, rangeTo) > 0)
            {
                throw new ArgumentOutOfRangeException($"{guard.InputParameterName} was out of range");
            }

            return Chain.Next(guard);
        }



        public static IChainableGuardClause<TInput> OutOfRange<TInput>(this IGuardClause<TInput> guard, TInput rangeFrom, TInput rangeTo, Type customExceptionType, params object[] customTypeArgs)
        {
            var comparer = Comparer<TInput>.Default;

            if (comparer.Compare(rangeFrom, rangeTo) > 0)
            {
                throw new ArgumentException($"{rangeFrom} cannot be larger than {rangeTo}");
            }

            if (comparer.Compare(guard.Input, rangeFrom) < 0 || comparer.Compare(guard.Input, rangeTo) > 0)
            {
                Guard.ThrowCustomException(customExceptionType, customTypeArgs);
            }

            return Chain.Next(guard);
        }


        #endregion

        #region short

        public static IChainableGuardClause<short> OutOfRange(this IGuardClause<short> guard, short rangeFrom, short rangeTo)
        {
            return guard.OutOfRange<short>(rangeFrom, rangeTo);
        }

        public static IChainableGuardClause<short> OutOfRange(this IGuardClause<short> guard, short rangeFrom, short rangeTo, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.OutOfRange<short>(rangeFrom, rangeTo, customExceptionType, customExceptionArgs);
        }

        #endregion


        #region int

        public static IChainableGuardClause<int> OutOfRange(this IGuardClause<int> guard, int rangeFrom, int rangeTo)
        {
            return guard.OutOfRange<int>(rangeFrom, rangeTo);
        }

        public static IChainableGuardClause<int> OutOfRange(this IGuardClause<int> guard, int rangeFrom, int rangeTo, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.OutOfRange<int>(rangeFrom, rangeTo, customExceptionType, customExceptionArgs);
        }

        #endregion

        #region long

        public static IChainableGuardClause<long> OutOfRange(this IGuardClause<long> guard, long rangeFrom, long rangeTo)
        {
            return guard.OutOfRange<long>(rangeFrom, rangeTo);
        }

        public static IChainableGuardClause<long> OutOfRange(this IGuardClause<long> guard, long rangeFrom, long rangeTo, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.OutOfRange<long>(rangeFrom, rangeTo, customExceptionType, customExceptionArgs);
        }

        #endregion

        #region decimal

        public static IChainableGuardClause<decimal> OutOfRange(this IGuardClause<decimal> guard, decimal rangeFrom, decimal rangeTo)
        {
            return guard.OutOfRange<decimal>(rangeFrom, rangeTo);
        }

        public static IChainableGuardClause<decimal> OutOfRange(this IGuardClause<decimal> guard, decimal rangeFrom, decimal rangeTo, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.OutOfRange<decimal>(rangeFrom, rangeTo, customExceptionType, customExceptionArgs);
        }

        #endregion

        #region double

        public static IChainableGuardClause<double> OutOfRange(this IGuardClause<double> guard, double rangeFrom, double rangeTo)
        {
            return guard.OutOfRange<double>(rangeFrom, rangeTo);
        }

        public static IChainableGuardClause<double> OutOfRange(this IGuardClause<double> guard, double rangeFrom, double rangeTo, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.OutOfRange<double>(rangeFrom, rangeTo, customExceptionType, customExceptionArgs);
        }

        #endregion

        #region float

        public static IChainableGuardClause<float> OutOfRange(this IGuardClause<float> guard, float rangeFrom, float rangeTo)
        {
            return guard.OutOfRange<float>(rangeFrom, rangeTo);
        }

        public static IChainableGuardClause<float> OutOfRange(this IGuardClause<float> guard, float rangeFrom, float rangeTo, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.OutOfRange<float>(rangeFrom, rangeTo, customExceptionType, customExceptionArgs);
        }

        #endregion

        #region DateTime

        public static IChainableGuardClause<DateTime> OutOfRange(this IGuardClause<DateTime> guard, DateTime rangeFrom, DateTime rangeTo)
        {
            return guard.OutOfRange<DateTime>(rangeFrom, rangeTo);
        }

        public static IChainableGuardClause<DateTime> OutOfRange(this IGuardClause<DateTime> guard, DateTime rangeFrom, DateTime rangeTo, Type customExceptionType, params object[] customExceptionArgs)
        {
            return guard.OutOfRange<DateTime>(rangeFrom, rangeTo, customExceptionType, customExceptionArgs);
        }

        #endregion


        #region Enum

        public static IChainableGuardClause<TInput> OutOfRange<TInput>(this IGuardClause<TInput> guard) where TInput : struct, Enum
        {
            if (!Enum.IsDefined(typeof(TInput), guard.Input))
            {
                throw new InvalidEnumArgumentException(guard.InputParameterName, Convert.ToInt32(guard.Input), typeof(TInput));
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<TInput> OutOfRange<TInput>(this IGuardClause<TInput> guard, Type customExceptionType, params object[] customExceptionArgs) where TInput : struct, Enum
        {
            if (!Enum.IsDefined(typeof(TInput), guard.Input))
            {
                Guard.ThrowCustomException(customExceptionType, customExceptionArgs);
            }

            return Chain.Next(guard);
        }


        public static IChainableGuardClause<int> OutOfRange<TInput>(this IGuardClause<int> guard) where TInput : struct, Enum
        {
            if (!Enum.IsDefined(typeof(TInput), guard.Input))
            {
                throw new InvalidEnumArgumentException(guard.InputParameterName, Convert.ToInt32(guard.Input), typeof(TInput));
            }

            return Chain.Next(guard);
        }

        public static IChainableGuardClause<int> OutOfRange<TInput>(this IGuardClause<int> guard, Type customExceptionType, params object[] customExceptionArgs) where TInput : struct, Enum
        {
            if (!Enum.IsDefined(typeof(TInput), guard.Input))
            {
                Guard.ThrowCustomException(customExceptionType, customExceptionArgs);
            }

            return Chain.Next(guard);
        }

        #endregion


        #region Sql DateTime

        public static IGuardClause<DateTime> OutOfSqlDateRange(this IGuardClause<DateTime> guard)
        {
            const long sqlMinDateTicks = 552877920000000000; // min date is 1/1/1753 in sql. Why? check https://stackoverflow.com/q/3310569/7565464 if you are curious like me
            const long sqlMaxDateTicks = 3155378975999970000;// max date is 12/31/9999 is sql

            return guard.OutOfRange<DateTime>(new DateTime(sqlMinDateTicks), new DateTime(sqlMaxDateTicks));
        }

        public static IGuardClause<DateTime> OutOfSqlDateRange(this IGuardClause<DateTime> guard, Type customExceptionType, params object[] customExceptionArgs)
        {
            const long sqlMinDateTicks = 552877920000000000; // min date is 1/1/1753 in sql. Why? check https://stackoverflow.com/q/3310569/7565464 if you are curious like me
            const long sqlMaxDateTicks = 3155378975999970000;// max date is 12/31/9999 is sql

            return guard.OutOfRange<DateTime>(new DateTime(sqlMinDateTicks), new DateTime(sqlMaxDateTicks), customExceptionType, customExceptionArgs);
        }

        #endregion

    }
}
