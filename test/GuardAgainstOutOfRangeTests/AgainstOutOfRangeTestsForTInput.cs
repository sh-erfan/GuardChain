using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuardChain.Tests.GuardAgainstOutOfRangeTests
{
    public class AgainstOutOfRangeTestsForTInput
    {
        #region no custom exception

        [Fact]
        public void DoesNothingGivenInRangeValue()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue0).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1)
                .Protect(data.IntInputWithValue0).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1)
                .Protect(data.LongInputWithValue0).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1)
                .Protect(data.DecimalInputWithValue0).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1)
                .Protect(data.FloatInputWithValue0).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1)
                .Protect(data.DoubleInputWithValue0).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1)
                .Protect(data.EnumInputWithValueZero).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo)
                .Protect(data.DateTimeInputWithValueNow).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow);

        }


        [Fact]
        public void PreservesInputGiveInfRangeValue()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue0, Guard.Protect(data.ShortInputWithValue0).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).Input);
            Assert.Equal(data.IntInputWithValue0, Guard.Protect(data.IntInputWithValue0).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1).Input);
            Assert.Equal(data.LongInputWithValue0, Guard.Protect(data.LongInputWithValue0).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1).Input);
            Assert.Equal(data.DecimalInputWithValue0, Guard.Protect(data.DecimalInputWithValue0).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1).Input);
            Assert.Equal(data.FloatInputWithValue0, Guard.Protect(data.FloatInputWithValue0).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1).Input);
            Assert.Equal(data.DoubleInputWithValue0, Guard.Protect(data.DoubleInputWithValue0).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1).Input);
            Assert.Equal(data.EnumInputWithValueZero, Guard.Protect(data.EnumInputWithValueZero).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo).Input);
            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNonOutOfRangeValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue0), Guard.Protect(data.ShortInputWithValue0, nameof(data.ShortInputWithValue0)).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue0), Guard.Protect(data.IntInputWithValue0, nameof(data.IntInputWithValue0)).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue0), Guard.Protect(data.LongInputWithValue0, nameof(data.LongInputWithValue0)).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue0), Guard.Protect(data.DecimalInputWithValue0, nameof(data.DecimalInputWithValue0)).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue0), Guard.Protect(data.FloatInputWithValue0, nameof(data.FloatInputWithValue0)).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue0), Guard.Protect(data.DoubleInputWithValue0, nameof(data.DoubleInputWithValue0)).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueZero), Guard.Protect(data.EnumInputWithValueZero, nameof(data.EnumInputWithValueZero)).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).InputParameterName);
        }

        [Fact]
        public void DoesNothingGivenLowerBoundValue()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValueMinus1).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1)
                .Protect(data.IntInputWithValueMinus1).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1)
                .Protect(data.LongInputWithValueMinus1).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1)
                .Protect(data.DecimalInputWithValueMinus1).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1)
                .Protect(data.FloatInputWithValueMinus1).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1)
                .Protect(data.DoubleInputWithValueMinus1).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1)
                .Protect(data.EnumInputWithValueMinusOne).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo)
                .Protect(data.DateTimeInputWithValueYesterday).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow);

        }


        [Fact]
        public void PreservesInputGivenLowerBoundValue()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).Input);
            Assert.Equal(data.IntInputWithValueMinus1, Guard.Protect(data.IntInputWithValueMinus1).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1).Input);
            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1).Input);
            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1).Input);
            Assert.Equal(data.FloatInputWithValueMinus1, Guard.Protect(data.FloatInputWithValueMinus1).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1).Input);
            Assert.Equal(data.DoubleInputWithValueMinus1, Guard.Protect(data.DoubleInputWithValueMinus1).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1).Input);
            Assert.Equal(data.EnumInputWithValueMinusOne, Guard.Protect(data.EnumInputWithValueMinusOne).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo).Input);
            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenLowerBoundValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValueMinus1), Guard.Protect(data.IntInputWithValueMinus1, nameof(data.IntInputWithValueMinus1)).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValueMinus1), Guard.Protect(data.FloatInputWithValueMinus1, nameof(data.FloatInputWithValueMinus1)).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValueMinus1), Guard.Protect(data.DoubleInputWithValueMinus1, nameof(data.DoubleInputWithValueMinus1)).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueMinusOne), Guard.Protect(data.EnumInputWithValueMinusOne, nameof(data.EnumInputWithValueMinusOne)).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).InputParameterName);
        }

        [Fact]
        public void DoesNothingGivenUpperBoundValue()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1)
                .Protect(data.IntInputWithValue1).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1)
                .Protect(data.LongInputWithValue1).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1)
                .Protect(data.DecimalInputWithValue1).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1)
                .Protect(data.FloatInputWithValue1).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1)
                .Protect(data.DoubleInputWithValue1).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1)
                .Protect(data.EnumInputWithValueTwo).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo)
                .Protect(data.DateTimeInputWithValueTomorrow).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow);

        }


        [Fact]
        public void PreservesInputGivenUpperBoundValue()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1).Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1).Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1).Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1).Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1).Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo).Input);
            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenUpperBoundValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).InputParameterName);
        }


        [Fact]
        public void ThrowsArgumentOutOfRangeExceptionGivenOutOfRangeValue()
        {
            var data = new TestData();

            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Protect(data.ShortInputWithValue100).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Protect(data.IntInputWithValue100).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Protect(data.LongInputWithValue100).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Protect(data.DecimalInputWithValue100).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Protect(data.FloatInputWithValue100).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Protect(data.DoubleInputWithValue100).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Protect(data.EnumInputWithValueOneHundred).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Protect(data.DateTimeInputWithValueOneHundredDaysAhead).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow));
        }

        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenInRangeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue0).Against.OutOfRange<MyCustomException, short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1)
                .Protect(data.IntInputWithValue0).Against.OutOfRange<MyCustomException, int>(data.IntInputWithValueMinus1, data.IntInputWithValue1)
                .Protect(data.LongInputWithValue0).Against.OutOfRange<MyCustomException, long>(data.LongInputWithValueMinus1, data.LongInputWithValue1)
                .Protect(data.DecimalInputWithValue0).Against.OutOfRange<MyCustomException, decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1)
                .Protect(data.FloatInputWithValue0).Against.OutOfRange<MyCustomException, float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1)
                .Protect(data.DoubleInputWithValue0).Against.OutOfRange<MyCustomException, double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1)
                .Protect(data.EnumInputWithValueZero).Against.OutOfRange<MyCustomException, MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo)
                .Protect(data.DateTimeInputWithValueNow).Against.OutOfRange<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow);

        }


        [Fact]
        public void PreservesInputGiveInfRangeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue0, Guard.Protect(data.ShortInputWithValue0).Against.OutOfRange<MyCustomException, short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).Input);
            Assert.Equal(data.IntInputWithValue0, Guard.Protect(data.IntInputWithValue0).Against.OutOfRange<MyCustomException, int>(data.IntInputWithValueMinus1, data.IntInputWithValue1).Input);
            Assert.Equal(data.LongInputWithValue0, Guard.Protect(data.LongInputWithValue0).Against.OutOfRange<MyCustomException, long>(data.LongInputWithValueMinus1, data.LongInputWithValue1).Input);
            Assert.Equal(data.DecimalInputWithValue0, Guard.Protect(data.DecimalInputWithValue0).Against.OutOfRange<MyCustomException, decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1).Input);
            Assert.Equal(data.FloatInputWithValue0, Guard.Protect(data.FloatInputWithValue0).Against.OutOfRange<MyCustomException, float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1).Input);
            Assert.Equal(data.DoubleInputWithValue0, Guard.Protect(data.DoubleInputWithValue0).Against.OutOfRange<MyCustomException, double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1).Input);
            Assert.Equal(data.EnumInputWithValueZero, Guard.Protect(data.EnumInputWithValueZero).Against.OutOfRange<MyCustomException, MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo).Input);
            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfRange<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNonOutOfRangeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue0), Guard.Protect(data.ShortInputWithValue0, nameof(data.ShortInputWithValue0)).Against.OutOfRange<MyCustomException, short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue0), Guard.Protect(data.IntInputWithValue0, nameof(data.IntInputWithValue0)).Against.OutOfRange<MyCustomException, int>(data.IntInputWithValueMinus1, data.IntInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue0), Guard.Protect(data.LongInputWithValue0, nameof(data.LongInputWithValue0)).Against.OutOfRange<MyCustomException, long>(data.LongInputWithValueMinus1, data.LongInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue0), Guard.Protect(data.DecimalInputWithValue0, nameof(data.DecimalInputWithValue0)).Against.OutOfRange<MyCustomException, decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue0), Guard.Protect(data.FloatInputWithValue0, nameof(data.FloatInputWithValue0)).Against.OutOfRange<MyCustomException, float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue0), Guard.Protect(data.DoubleInputWithValue0, nameof(data.DoubleInputWithValue0)).Against.OutOfRange<MyCustomException, double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueZero), Guard.Protect(data.EnumInputWithValueZero, nameof(data.EnumInputWithValueZero)).Against.OutOfRange<MyCustomException, MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.OutOfRange<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).InputParameterName);
        }

        [Fact]
        public void DoesNothingGivenLowerBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValueMinus1).Against.OutOfRange<MyCustomException, short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1)
                .Protect(data.IntInputWithValueMinus1).Against.OutOfRange<MyCustomException, int>(data.IntInputWithValueMinus1, data.IntInputWithValue1)
                .Protect(data.LongInputWithValueMinus1).Against.OutOfRange<MyCustomException, long>(data.LongInputWithValueMinus1, data.LongInputWithValue1)
                .Protect(data.DecimalInputWithValueMinus1).Against.OutOfRange<MyCustomException, decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1)
                .Protect(data.FloatInputWithValueMinus1).Against.OutOfRange<MyCustomException, float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1)
                .Protect(data.DoubleInputWithValueMinus1).Against.OutOfRange<MyCustomException, double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1)
                .Protect(data.EnumInputWithValueMinusOne).Against.OutOfRange<MyCustomException, MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo)
                .Protect(data.DateTimeInputWithValueYesterday).Against.OutOfRange<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow);

        }


        [Fact]
        public void PreservesInputGivenLowerBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.OutOfRange<MyCustomException, short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).Input);
            Assert.Equal(data.IntInputWithValueMinus1, Guard.Protect(data.IntInputWithValueMinus1).Against.OutOfRange<MyCustomException, int>(data.IntInputWithValueMinus1, data.IntInputWithValue1).Input);
            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.OutOfRange<MyCustomException, long>(data.LongInputWithValueMinus1, data.LongInputWithValue1).Input);
            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.OutOfRange<MyCustomException, decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1).Input);
            Assert.Equal(data.FloatInputWithValueMinus1, Guard.Protect(data.FloatInputWithValueMinus1).Against.OutOfRange<MyCustomException, float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1).Input);
            Assert.Equal(data.DoubleInputWithValueMinus1, Guard.Protect(data.DoubleInputWithValueMinus1).Against.OutOfRange<MyCustomException, double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1).Input);
            Assert.Equal(data.EnumInputWithValueMinusOne, Guard.Protect(data.EnumInputWithValueMinusOne).Against.OutOfRange<MyCustomException, MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo).Input);
            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.OutOfRange<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenLowerBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.OutOfRange<MyCustomException, short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValueMinus1), Guard.Protect(data.IntInputWithValueMinus1, nameof(data.IntInputWithValueMinus1)).Against.OutOfRange<MyCustomException, int>(data.IntInputWithValueMinus1, data.IntInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.OutOfRange<MyCustomException, long>(data.LongInputWithValueMinus1, data.LongInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.OutOfRange<MyCustomException, decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValueMinus1), Guard.Protect(data.FloatInputWithValueMinus1, nameof(data.FloatInputWithValueMinus1)).Against.OutOfRange<MyCustomException, float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValueMinus1), Guard.Protect(data.DoubleInputWithValueMinus1, nameof(data.DoubleInputWithValueMinus1)).Against.OutOfRange<MyCustomException, double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueMinusOne), Guard.Protect(data.EnumInputWithValueMinusOne, nameof(data.EnumInputWithValueMinusOne)).Against.OutOfRange<MyCustomException, MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.OutOfRange<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).InputParameterName);
        }

        [Fact]
        public void DoesNothingGivenUpperBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.OutOfRange<MyCustomException, short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1)
                .Protect(data.IntInputWithValue1).Against.OutOfRange<MyCustomException, int>(data.IntInputWithValueMinus1, data.IntInputWithValue1)
                .Protect(data.LongInputWithValue1).Against.OutOfRange<MyCustomException, long>(data.LongInputWithValueMinus1, data.LongInputWithValue1)
                .Protect(data.DecimalInputWithValue1).Against.OutOfRange<MyCustomException, decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1)
                .Protect(data.FloatInputWithValue1).Against.OutOfRange<MyCustomException, float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1)
                .Protect(data.DoubleInputWithValue1).Against.OutOfRange<MyCustomException, double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1)
                .Protect(data.EnumInputWithValueTwo).Against.OutOfRange<MyCustomException, MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo)
                .Protect(data.DateTimeInputWithValueTomorrow).Against.OutOfRange<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow);

        }


        [Fact]
        public void PreservesInputGivenUpperBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.OutOfRange<MyCustomException, short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.OutOfRange<MyCustomException, int>(data.IntInputWithValueMinus1, data.IntInputWithValue1).Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.OutOfRange<MyCustomException, long>(data.LongInputWithValueMinus1, data.LongInputWithValue1).Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.OutOfRange<MyCustomException, decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1).Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.OutOfRange<MyCustomException, float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1).Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.OutOfRange<MyCustomException, double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1).Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.OutOfRange<MyCustomException, MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo).Input);
            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.OutOfRange<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenUpperBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.OutOfRange<MyCustomException, short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.OutOfRange<MyCustomException, int>(data.IntInputWithValueMinus1, data.IntInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.OutOfRange<MyCustomException, long>(data.LongInputWithValueMinus1, data.LongInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.OutOfRange<MyCustomException, decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.OutOfRange<MyCustomException, float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.OutOfRange<MyCustomException, double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.OutOfRange<MyCustomException, MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.OutOfRange<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).InputParameterName);
        }


        [Fact]
        public void ThrowsArgumentOutOfRangeExceptionGivenOutOfRangeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue100).Against.OutOfRange<MyCustomException, short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue100).Against.OutOfRange<MyCustomException, int>(data.IntInputWithValueMinus1, data.IntInputWithValue1));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue100).Against.OutOfRange<MyCustomException, long>(data.LongInputWithValueMinus1, data.LongInputWithValue1));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue100).Against.OutOfRange<MyCustomException, decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue100).Against.OutOfRange<MyCustomException, float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue100).Against.OutOfRange<MyCustomException, double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueOneHundred).Against.OutOfRange<MyCustomException, MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueOneHundredDaysAhead).Against.OutOfRange<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow));
        }

        #endregion

        #region custom exception type as TException with constructor args

        [Fact]
        public void DoesNothingGivenInRangeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue0).Against.OutOfRange<MyCustomException, short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, "ags1")
                .Protect(data.IntInputWithValue0).Against.OutOfRange<MyCustomException, int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, "ags1")
                .Protect(data.LongInputWithValue0).Against.OutOfRange<MyCustomException, long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, "ags1")
                .Protect(data.DecimalInputWithValue0).Against.OutOfRange<MyCustomException, decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, "ags1")
                .Protect(data.FloatInputWithValue0).Against.OutOfRange<MyCustomException, float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, "ags1")
                .Protect(data.DoubleInputWithValue0).Against.OutOfRange<MyCustomException, double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, "ags1")
                .Protect(data.EnumInputWithValueZero).Against.OutOfRange<MyCustomException, MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, "ags1")
                .Protect(data.DateTimeInputWithValueNow).Against.OutOfRange<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, "ags1");

        }


        [Fact]
        public void PreservesInputGiveInfRangeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue0, Guard.Protect(data.ShortInputWithValue0).Against.OutOfRange<MyCustomException, short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, "ags1").Input);
            Assert.Equal(data.IntInputWithValue0, Guard.Protect(data.IntInputWithValue0).Against.OutOfRange<MyCustomException, int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, "ags1").Input);
            Assert.Equal(data.LongInputWithValue0, Guard.Protect(data.LongInputWithValue0).Against.OutOfRange<MyCustomException, long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, "ags1").Input);
            Assert.Equal(data.DecimalInputWithValue0, Guard.Protect(data.DecimalInputWithValue0).Against.OutOfRange<MyCustomException, decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, "ags1").Input);
            Assert.Equal(data.FloatInputWithValue0, Guard.Protect(data.FloatInputWithValue0).Against.OutOfRange<MyCustomException, float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, "ags1").Input);
            Assert.Equal(data.DoubleInputWithValue0, Guard.Protect(data.DoubleInputWithValue0).Against.OutOfRange<MyCustomException, double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, "ags1").Input);
            Assert.Equal(data.EnumInputWithValueZero, Guard.Protect(data.EnumInputWithValueZero).Against.OutOfRange<MyCustomException, MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, "ags1").Input);
            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfRange<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, "ags1").Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNonOutOfRangeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue0), Guard.Protect(data.ShortInputWithValue0, nameof(data.ShortInputWithValue0)).Against.OutOfRange<MyCustomException, short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, "ags1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue0), Guard.Protect(data.IntInputWithValue0, nameof(data.IntInputWithValue0)).Against.OutOfRange<MyCustomException, int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, "ags1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue0), Guard.Protect(data.LongInputWithValue0, nameof(data.LongInputWithValue0)).Against.OutOfRange<MyCustomException, long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, "ags1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue0), Guard.Protect(data.DecimalInputWithValue0, nameof(data.DecimalInputWithValue0)).Against.OutOfRange<MyCustomException, decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, "ags1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue0), Guard.Protect(data.FloatInputWithValue0, nameof(data.FloatInputWithValue0)).Against.OutOfRange<MyCustomException, float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, "ags1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue0), Guard.Protect(data.DoubleInputWithValue0, nameof(data.DoubleInputWithValue0)).Against.OutOfRange<MyCustomException, double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, "ags1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueZero), Guard.Protect(data.EnumInputWithValueZero, nameof(data.EnumInputWithValueZero)).Against.OutOfRange<MyCustomException, MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, "ags1").InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.OutOfRange<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, "ags1").InputParameterName);
        }

        [Fact]
        public void DoesNothingGivenLowerBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValueMinus1).Against.OutOfRange<MyCustomException, short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, "ags1")
                .Protect(data.IntInputWithValueMinus1).Against.OutOfRange<MyCustomException, int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, "ags1")
                .Protect(data.LongInputWithValueMinus1).Against.OutOfRange<MyCustomException, long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, "ags1")
                .Protect(data.DecimalInputWithValueMinus1).Against.OutOfRange<MyCustomException, decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, "ags1")
                .Protect(data.FloatInputWithValueMinus1).Against.OutOfRange<MyCustomException, float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, "ags1")
                .Protect(data.DoubleInputWithValueMinus1).Against.OutOfRange<MyCustomException, double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, "ags1")
                .Protect(data.EnumInputWithValueMinusOne).Against.OutOfRange<MyCustomException, MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, "ags1")
                .Protect(data.DateTimeInputWithValueYesterday).Against.OutOfRange<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, "ags1");

        }


        [Fact]
        public void PreservesInputGivenLowerBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.OutOfRange<MyCustomException, short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, "ags1").Input);
            Assert.Equal(data.IntInputWithValueMinus1, Guard.Protect(data.IntInputWithValueMinus1).Against.OutOfRange<MyCustomException, int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, "ags1").Input);
            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.OutOfRange<MyCustomException, long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, "ags1").Input);
            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.OutOfRange<MyCustomException, decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, "ags1").Input);
            Assert.Equal(data.FloatInputWithValueMinus1, Guard.Protect(data.FloatInputWithValueMinus1).Against.OutOfRange<MyCustomException, float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, "ags1").Input);
            Assert.Equal(data.DoubleInputWithValueMinus1, Guard.Protect(data.DoubleInputWithValueMinus1).Against.OutOfRange<MyCustomException, double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, "ags1").Input);
            Assert.Equal(data.EnumInputWithValueMinusOne, Guard.Protect(data.EnumInputWithValueMinusOne).Against.OutOfRange<MyCustomException, MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, "ags1").Input);
            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.OutOfRange<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, "ags1").Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenLowerBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.OutOfRange<MyCustomException, short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, "ags1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValueMinus1), Guard.Protect(data.IntInputWithValueMinus1, nameof(data.IntInputWithValueMinus1)).Against.OutOfRange<MyCustomException, int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, "ags1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.OutOfRange<MyCustomException, long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, "ags1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.OutOfRange<MyCustomException, decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, "ags1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValueMinus1), Guard.Protect(data.FloatInputWithValueMinus1, nameof(data.FloatInputWithValueMinus1)).Against.OutOfRange<MyCustomException, float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, "ags1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValueMinus1), Guard.Protect(data.DoubleInputWithValueMinus1, nameof(data.DoubleInputWithValueMinus1)).Against.OutOfRange<MyCustomException, double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, "ags1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueMinusOne), Guard.Protect(data.EnumInputWithValueMinusOne, nameof(data.EnumInputWithValueMinusOne)).Against.OutOfRange<MyCustomException, MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, "ags1").InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.OutOfRange<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, "ags1").InputParameterName);
        }

        [Fact]
        public void DoesNothingGivenUpperBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.OutOfRange<MyCustomException, short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, "ags1")
                .Protect(data.IntInputWithValue1).Against.OutOfRange<MyCustomException, int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, "ags1")
                .Protect(data.LongInputWithValue1).Against.OutOfRange<MyCustomException, long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, "ags1")
                .Protect(data.DecimalInputWithValue1).Against.OutOfRange<MyCustomException, decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, "ags1")
                .Protect(data.FloatInputWithValue1).Against.OutOfRange<MyCustomException, float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, "ags1")
                .Protect(data.DoubleInputWithValue1).Against.OutOfRange<MyCustomException, double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, "ags1")
                .Protect(data.EnumInputWithValueTwo).Against.OutOfRange<MyCustomException, MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, "ags1")
                .Protect(data.DateTimeInputWithValueTomorrow).Against.OutOfRange<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, "ags1");

        }


        [Fact]
        public void PreservesInputGivenUpperBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.OutOfRange<MyCustomException, short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, "ags1").Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.OutOfRange<MyCustomException, int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, "ags1").Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.OutOfRange<MyCustomException, long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, "ags1").Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.OutOfRange<MyCustomException, decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, "ags1").Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.OutOfRange<MyCustomException, float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, "ags1").Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.OutOfRange<MyCustomException, double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, "ags1").Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.OutOfRange<MyCustomException, MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, "ags1").Input);
            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.OutOfRange<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, "ags1").Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenUpperBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.OutOfRange<MyCustomException, short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, "ags1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.OutOfRange<MyCustomException, int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, "ags1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.OutOfRange<MyCustomException, long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, "ags1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.OutOfRange<MyCustomException, decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, "ags1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.OutOfRange<MyCustomException, float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, "ags1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.OutOfRange<MyCustomException, double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, "ags1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.OutOfRange<MyCustomException, MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, "ags1").InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.OutOfRange<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, "ags1").InputParameterName);
        }


        [Fact]
        public void ThrowsArgumentOutOfRangeExceptionGivenOutOfRangeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue100).Against.OutOfRange<MyCustomException, short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, "ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue100).Against.OutOfRange<MyCustomException, int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, "ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue100).Against.OutOfRange<MyCustomException, long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, "ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue100).Against.OutOfRange<MyCustomException, decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, "ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue100).Against.OutOfRange<MyCustomException, float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, "ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue100).Against.OutOfRange<MyCustomException, double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, "ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueOneHundred).Against.OutOfRange<MyCustomException, MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, "ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueOneHundredDaysAhead).Against.OutOfRange<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, "ags1"));
        }

        #endregion

        #region custom exception type as parameter

        [Fact]
        public void DoesNothingGivenInRangeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue0).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException))
                .Protect(data.IntInputWithValue0).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, typeof(MyCustomException))
                .Protect(data.LongInputWithValue0).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, typeof(MyCustomException))
                .Protect(data.DecimalInputWithValue0).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, typeof(MyCustomException))
                .Protect(data.FloatInputWithValue0).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, typeof(MyCustomException))
                .Protect(data.DoubleInputWithValue0).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, typeof(MyCustomException))
                .Protect(data.EnumInputWithValueZero).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, typeof(MyCustomException))
                .Protect(data.DateTimeInputWithValueNow).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException));

        }


        [Fact]
        public void PreservesInputGiveInfRangeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue0, Guard.Protect(data.ShortInputWithValue0).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException)).Input);
            Assert.Equal(data.IntInputWithValue0, Guard.Protect(data.IntInputWithValue0).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, typeof(MyCustomException)).Input);
            Assert.Equal(data.LongInputWithValue0, Guard.Protect(data.LongInputWithValue0).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, typeof(MyCustomException)).Input);
            Assert.Equal(data.DecimalInputWithValue0, Guard.Protect(data.DecimalInputWithValue0).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, typeof(MyCustomException)).Input);
            Assert.Equal(data.FloatInputWithValue0, Guard.Protect(data.FloatInputWithValue0).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, typeof(MyCustomException)).Input);
            Assert.Equal(data.DoubleInputWithValue0, Guard.Protect(data.DoubleInputWithValue0).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, typeof(MyCustomException)).Input);
            Assert.Equal(data.EnumInputWithValueZero, Guard.Protect(data.EnumInputWithValueZero).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, typeof(MyCustomException)).Input);
            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException)).Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNonOutOfRangeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue0), Guard.Protect(data.ShortInputWithValue0, nameof(data.ShortInputWithValue0)).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue0), Guard.Protect(data.IntInputWithValue0, nameof(data.IntInputWithValue0)).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue0), Guard.Protect(data.LongInputWithValue0, nameof(data.LongInputWithValue0)).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue0), Guard.Protect(data.DecimalInputWithValue0, nameof(data.DecimalInputWithValue0)).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue0), Guard.Protect(data.FloatInputWithValue0, nameof(data.FloatInputWithValue0)).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue0), Guard.Protect(data.DoubleInputWithValue0, nameof(data.DoubleInputWithValue0)).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueZero), Guard.Protect(data.EnumInputWithValueZero, nameof(data.EnumInputWithValueZero)).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException)).InputParameterName);
        }

        [Fact]
        public void DoesNothingGivenLowerBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValueMinus1).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException))
                .Protect(data.IntInputWithValueMinus1).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, typeof(MyCustomException))
                .Protect(data.LongInputWithValueMinus1).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, typeof(MyCustomException))
                .Protect(data.DecimalInputWithValueMinus1).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, typeof(MyCustomException))
                .Protect(data.FloatInputWithValueMinus1).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, typeof(MyCustomException))
                .Protect(data.DoubleInputWithValueMinus1).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, typeof(MyCustomException))
                .Protect(data.EnumInputWithValueMinusOne).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, typeof(MyCustomException))
                .Protect(data.DateTimeInputWithValueYesterday).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException));

        }


        [Fact]
        public void PreservesInputGivenLowerBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException)).Input);
            Assert.Equal(data.IntInputWithValueMinus1, Guard.Protect(data.IntInputWithValueMinus1).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, typeof(MyCustomException)).Input);
            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, typeof(MyCustomException)).Input);
            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, typeof(MyCustomException)).Input);
            Assert.Equal(data.FloatInputWithValueMinus1, Guard.Protect(data.FloatInputWithValueMinus1).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, typeof(MyCustomException)).Input);
            Assert.Equal(data.DoubleInputWithValueMinus1, Guard.Protect(data.DoubleInputWithValueMinus1).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, typeof(MyCustomException)).Input);
            Assert.Equal(data.EnumInputWithValueMinusOne, Guard.Protect(data.EnumInputWithValueMinusOne).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, typeof(MyCustomException)).Input);
            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException)).Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenLowerBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValueMinus1), Guard.Protect(data.IntInputWithValueMinus1, nameof(data.IntInputWithValueMinus1)).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValueMinus1), Guard.Protect(data.FloatInputWithValueMinus1, nameof(data.FloatInputWithValueMinus1)).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValueMinus1), Guard.Protect(data.DoubleInputWithValueMinus1, nameof(data.DoubleInputWithValueMinus1)).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueMinusOne), Guard.Protect(data.EnumInputWithValueMinusOne, nameof(data.EnumInputWithValueMinusOne)).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException)).InputParameterName);
        }

        [Fact]
        public void DoesNothingGivenUpperBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException))
                .Protect(data.IntInputWithValue1).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, typeof(MyCustomException))
                .Protect(data.LongInputWithValue1).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, typeof(MyCustomException))
                .Protect(data.DecimalInputWithValue1).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, typeof(MyCustomException))
                .Protect(data.FloatInputWithValue1).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, typeof(MyCustomException))
                .Protect(data.DoubleInputWithValue1).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, typeof(MyCustomException))
                .Protect(data.EnumInputWithValueTwo).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, typeof(MyCustomException))
                .Protect(data.DateTimeInputWithValueTomorrow).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException));

        }


        [Fact]
        public void PreservesInputGivenUpperBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException)).Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, typeof(MyCustomException)).Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, typeof(MyCustomException)).Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, typeof(MyCustomException)).Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, typeof(MyCustomException)).Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, typeof(MyCustomException)).Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, typeof(MyCustomException)).Input);
            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException)).Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenUpperBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException)).InputParameterName);
        }


        [Fact]
        public void ThrowsCustomExceptionGivenOutOfRangeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue100).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue100).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue100).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue100).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue100).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue100).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueOneHundred).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueOneHundredDaysAhead).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException)));
        }


        #endregion

        #region custom exception type as parameter with constructor args

        [Fact]
        public void DoesNothingGivenInRangeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue0).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException), "args1")
                .Protect(data.IntInputWithValue0).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, typeof(MyCustomException), "args1")
                .Protect(data.LongInputWithValue0).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, typeof(MyCustomException), "args1")
                .Protect(data.DecimalInputWithValue0).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, typeof(MyCustomException), "args1")
                .Protect(data.FloatInputWithValue0).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, typeof(MyCustomException), "args1")
                .Protect(data.DoubleInputWithValue0).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, typeof(MyCustomException), "args1")
                .Protect(data.EnumInputWithValueZero).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, typeof(MyCustomException), "args1")
                .Protect(data.DateTimeInputWithValueNow).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException), "args1");

        }


        [Fact]
        public void PreservesInputGiveInfRangeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue0, Guard.Protect(data.ShortInputWithValue0).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.IntInputWithValue0, Guard.Protect(data.IntInputWithValue0).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.LongInputWithValue0, Guard.Protect(data.LongInputWithValue0).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DecimalInputWithValue0, Guard.Protect(data.DecimalInputWithValue0).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.FloatInputWithValue0, Guard.Protect(data.FloatInputWithValue0).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DoubleInputWithValue0, Guard.Protect(data.DoubleInputWithValue0).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.EnumInputWithValueZero, Guard.Protect(data.EnumInputWithValueZero).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException), "args1").Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNonOutOfRangeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue0), Guard.Protect(data.ShortInputWithValue0, nameof(data.ShortInputWithValue0)).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue0), Guard.Protect(data.IntInputWithValue0, nameof(data.IntInputWithValue0)).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue0), Guard.Protect(data.LongInputWithValue0, nameof(data.LongInputWithValue0)).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue0), Guard.Protect(data.DecimalInputWithValue0, nameof(data.DecimalInputWithValue0)).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue0), Guard.Protect(data.FloatInputWithValue0, nameof(data.FloatInputWithValue0)).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue0), Guard.Protect(data.DoubleInputWithValue0, nameof(data.DoubleInputWithValue0)).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueZero), Guard.Protect(data.EnumInputWithValueZero, nameof(data.EnumInputWithValueZero)).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void DoesNothingGivenLowerBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValueMinus1).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException), "args1")
                .Protect(data.IntInputWithValueMinus1).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, typeof(MyCustomException), "args1")
                .Protect(data.LongInputWithValueMinus1).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, typeof(MyCustomException), "args1")
                .Protect(data.DecimalInputWithValueMinus1).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, typeof(MyCustomException), "args1")
                .Protect(data.FloatInputWithValueMinus1).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, typeof(MyCustomException), "args1")
                .Protect(data.DoubleInputWithValueMinus1).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, typeof(MyCustomException), "args1")
                .Protect(data.EnumInputWithValueMinusOne).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, typeof(MyCustomException), "args1")
                .Protect(data.DateTimeInputWithValueYesterday).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException), "args1");

        }


        [Fact]
        public void PreservesInputGivenLowerBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.IntInputWithValueMinus1, Guard.Protect(data.IntInputWithValueMinus1).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.FloatInputWithValueMinus1, Guard.Protect(data.FloatInputWithValueMinus1).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DoubleInputWithValueMinus1, Guard.Protect(data.DoubleInputWithValueMinus1).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.EnumInputWithValueMinusOne, Guard.Protect(data.EnumInputWithValueMinusOne).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException), "args1").Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenLowerBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValueMinus1), Guard.Protect(data.IntInputWithValueMinus1, nameof(data.IntInputWithValueMinus1)).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValueMinus1), Guard.Protect(data.FloatInputWithValueMinus1, nameof(data.FloatInputWithValueMinus1)).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValueMinus1), Guard.Protect(data.DoubleInputWithValueMinus1, nameof(data.DoubleInputWithValueMinus1)).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueMinusOne), Guard.Protect(data.EnumInputWithValueMinusOne, nameof(data.EnumInputWithValueMinusOne)).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void DoesNothingGivenUpperBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException), "args1")
                .Protect(data.IntInputWithValue1).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, typeof(MyCustomException), "args1")
                .Protect(data.LongInputWithValue1).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, typeof(MyCustomException), "args1")
                .Protect(data.DecimalInputWithValue1).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, typeof(MyCustomException), "args1")
                .Protect(data.FloatInputWithValue1).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, typeof(MyCustomException), "args1")
                .Protect(data.DoubleInputWithValue1).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, typeof(MyCustomException), "args1")
                .Protect(data.EnumInputWithValueTwo).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, typeof(MyCustomException), "args1")
                .Protect(data.DateTimeInputWithValueTomorrow).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException), "args1");

        }


        [Fact]
        public void PreservesInputGivenUpperBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException), "args1").Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenUpperBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException), "args1").InputParameterName);
        }


        [Fact]
        public void ThrowsCustomExceptionGivenOutOfRangeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue100).Against.OutOfRange<short>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue100).Against.OutOfRange<int>(data.IntInputWithValueMinus1, data.IntInputWithValue1, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue100).Against.OutOfRange<long>(data.LongInputWithValueMinus1, data.LongInputWithValue1, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue100).Against.OutOfRange<decimal>(data.DecimalInputWithValueMinus1, data.DecimalInputWithValue1, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue100).Against.OutOfRange<float>(data.FloatInputWithValueMinus1, data.FloatInputWithValue1, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue100).Against.OutOfRange<double>(data.DoubleInputWithValueMinus1, data.DoubleInputWithValue1, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueOneHundred).Against.OutOfRange<MyTestEnum>(data.EnumInputWithValueMinusOne, data.EnumInputWithValueTwo, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueOneHundredDaysAhead).Against.OutOfRange<DateTime>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException), "args1"));
        }

        #endregion
    }
}
