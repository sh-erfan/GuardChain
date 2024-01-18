using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using Newtonsoft.Json.Serialization;
using Xunit;

namespace GuardChain.Tests.GuardAgainstGreaterThanTests
{
    public class AgainstGreaterThanTestsForTInput
    {
        #region no custom exception

        [Fact]
        public void DoesNothingGivenValueLessThanLimit()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.GreaterThan<short>(2)
                .Protect(data.IntInputWithValue1).Against.GreaterThan<int>(2)
                .Protect(data.LongInputWithValue1).Against.GreaterThan<long>(2)
                .Protect(data.DecimalInputWithValue1).Against.GreaterThan<decimal>(2)
                .Protect(data.FloatInputWithValue1).Against.GreaterThan<float>(2)
                .Protect(data.DoubleInputWithValue1).Against.GreaterThan<double>(2)
                .Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyTestEnum>(MyTestEnum.Three)
                .Protect(data.DateTimeInputWithValueYesterday).Against.GreaterThan<DateTime>(data.DateTimeInputWithValueNow);
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimit()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.GreaterThan<short>(1)
                .Protect(data.IntInputWithValue1).Against.GreaterThan<int>(1)
                .Protect(data.LongInputWithValue1).Against.GreaterThan<long>(1)
                .Protect(data.DecimalInputWithValue1).Against.GreaterThan<decimal>(1)
                .Protect(data.FloatInputWithValue1).Against.GreaterThan<float>(1)
                .Protect(data.DoubleInputWithValue1).Against.GreaterThan<double>(1)
                .Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyTestEnum>(MyTestEnum.Two)
                .Protect(data.DateTimeInputWithValueNow).Against.GreaterThan<DateTime>(data.DateTimeInputWithValueNow);
        }

        [Fact]
        public void PreservesInputGivenValueLessThanLimit()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.GreaterThan<short>(2).Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.GreaterThan<int>(2).Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.GreaterThan<long>(2).Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.GreaterThan<decimal>(2).Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<float>(2).Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.GreaterThan<double>(2).Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyTestEnum>(MyTestEnum.Three).Input);
            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.GreaterThan<DateTime>(data.DateTimeInputWithValueNow).Input);
        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimit()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.GreaterThan<short>(1).Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.GreaterThan<int>(1).Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.GreaterThan<long>(1).Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.GreaterThan<decimal>(1).Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<float>(1).Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.GreaterThan<double>(1).Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyTestEnum>(MyTestEnum.Two).Input);
            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.GreaterThan<DateTime>(data.DateTimeInputWithValueNow).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueLessThanLimit()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.GreaterThan<short>(2).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.GreaterThan<int>(2).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.GreaterThan<long>(2).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.GreaterThan<decimal>(2).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.GreaterThan<float>(2).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.GreaterThan<double>(2).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.GreaterThan<MyTestEnum>(MyTestEnum.Three).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.GreaterThan<DateTime>(data.DateTimeInputWithValueNow).InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimit()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.GreaterThan<short>(1).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.GreaterThan<int>(1).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.GreaterThan<long>(1).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.GreaterThan<decimal>(1).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.GreaterThan<float>(1).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.GreaterThan<double>(1).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.GreaterThan<MyTestEnum>(MyTestEnum.Two).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.GreaterThan<DateTime>(data.DateTimeInputWithValueNow).InputParameterName);
        }

        [Fact]
        public void ThrowsArgumentExceptionGivenValueGreaterThanLimit()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.ShortInputWithValue1).Against.GreaterThan<short>(0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.IntInputWithValue1).Against.GreaterThan<int>(0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.LongInputWithValue1).Against.GreaterThan<long>(0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DecimalInputWithValue1).Against.GreaterThan<decimal>(0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<float>(0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DoubleInputWithValue1).Against.GreaterThan<double>(0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyTestEnum>(MyTestEnum.One));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.GreaterThan<DateTime>(data.DateTimeInputWithValueNow));
        }

        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenValueLessThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.GreaterThan<MyCustomException, short>(2)
                .Protect(data.IntInputWithValue1).Against.GreaterThan<MyCustomException, int>(2)
                .Protect(data.LongInputWithValue1).Against.GreaterThan<MyCustomException, long>(2)
                .Protect(data.DecimalInputWithValue1).Against.GreaterThan<MyCustomException, decimal>(2)
                .Protect(data.FloatInputWithValue1).Against.GreaterThan<MyCustomException, float>(2)
                .Protect(data.DoubleInputWithValue1).Against.GreaterThan<MyCustomException, double>(2)
                .Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyCustomException, MyTestEnum>(MyTestEnum.Three)
                .Protect(data.DateTimeInputWithValueYesterday).Against.GreaterThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow);
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.GreaterThan<MyCustomException, short>(1)
                .Protect(data.IntInputWithValue1).Against.GreaterThan<MyCustomException, int>(1)
                .Protect(data.LongInputWithValue1).Against.GreaterThan<MyCustomException, long>(1)
                .Protect(data.DecimalInputWithValue1).Against.GreaterThan<MyCustomException, decimal>(1)
                .Protect(data.FloatInputWithValue1).Against.GreaterThan<MyCustomException, float>(1)
                .Protect(data.DoubleInputWithValue1).Against.GreaterThan<MyCustomException, double>(1)
                .Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyCustomException, MyTestEnum>(MyTestEnum.Two)
                .Protect(data.DateTimeInputWithValueNow).Against.GreaterThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow);
        }

        [Fact]
        public void PreservesInputGivenValueLessThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.GreaterThan<MyCustomException, short>(2).Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.GreaterThan<MyCustomException, int>(2).Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.GreaterThan<MyCustomException, long>(2).Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.GreaterThan<MyCustomException, decimal>(2).Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<MyCustomException, float>(2).Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.GreaterThan<MyCustomException, double>(2).Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyCustomException, MyTestEnum>(MyTestEnum.Three).Input);
            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.GreaterThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow).Input);
        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.GreaterThan<MyCustomException, short>(1).Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.GreaterThan<MyCustomException, int>(1).Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.GreaterThan<MyCustomException, long>(1).Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.GreaterThan<MyCustomException, decimal>(1).Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<MyCustomException, float>(1).Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.GreaterThan<MyCustomException, double>(1).Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyCustomException, MyTestEnum>(MyTestEnum.Two).Input);
            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.GreaterThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueLessThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.GreaterThan<MyCustomException, short>(2).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.GreaterThan<MyCustomException, int>(2).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.GreaterThan<MyCustomException, long>(2).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.GreaterThan<MyCustomException, decimal>(2).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.GreaterThan<MyCustomException, float>(2).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.GreaterThan<MyCustomException, double>(2).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.GreaterThan<MyCustomException, MyTestEnum>(MyTestEnum.Three).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.GreaterThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow).InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.GreaterThan<MyCustomException, short>(1).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.GreaterThan<MyCustomException, int>(1).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.GreaterThan<MyCustomException, long>(1).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.GreaterThan<MyCustomException, decimal>(1).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.GreaterThan<MyCustomException, float>(1).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.GreaterThan<MyCustomException, double>(1).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.GreaterThan<MyCustomException, MyTestEnum>(MyTestEnum.Two).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.GreaterThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow).InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueGreaterThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue1).Against.GreaterThan<MyCustomException, short>(0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue1).Against.GreaterThan<MyCustomException, int>(0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.GreaterThan<MyCustomException, long>(0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue1).Against.GreaterThan<MyCustomException, decimal>(0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<MyCustomException, float>(0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue1).Against.GreaterThan<MyCustomException, double>(0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyCustomException, MyTestEnum>(MyTestEnum.One));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.GreaterThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow));
        }


        #endregion

        #region custom exception type as TException with constructor args


        [Fact]
        public void DoesNothingGivenValueLessThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.GreaterThan<MyCustomException, short>(2, "args1")
                .Protect(data.IntInputWithValue1).Against.GreaterThan<MyCustomException, int>(2, "args1")
                .Protect(data.LongInputWithValue1).Against.GreaterThan<MyCustomException, long>(2, "args1")
                .Protect(data.DecimalInputWithValue1).Against.GreaterThan<MyCustomException, decimal>(2, "args1")
                .Protect(data.FloatInputWithValue1).Against.GreaterThan<MyCustomException, float>(2, "args1")
                .Protect(data.DoubleInputWithValue1).Against.GreaterThan<MyCustomException, double>(2, "args1")
                .Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyCustomException, MyTestEnum>(MyTestEnum.Three, "args1")
                .Protect(data.DateTimeInputWithValueYesterday).Against.GreaterThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow, "args1");
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.GreaterThan<MyCustomException, short>(1, "args1")
                .Protect(data.IntInputWithValue1).Against.GreaterThan<MyCustomException, int>(1, "args1")
                .Protect(data.LongInputWithValue1).Against.GreaterThan<MyCustomException, long>(1, "args1")
                .Protect(data.DecimalInputWithValue1).Against.GreaterThan<MyCustomException, decimal>(1, "args1")
                .Protect(data.FloatInputWithValue1).Against.GreaterThan<MyCustomException, float>(1, "args1")
                .Protect(data.DoubleInputWithValue1).Against.GreaterThan<MyCustomException, double>(1, "args1")
                .Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyCustomException, MyTestEnum>(MyTestEnum.Two, "args1")
                .Protect(data.DateTimeInputWithValueNow).Against.GreaterThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow, "args1");
        }

        [Fact]
        public void PreservesInputGivenValueLessThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.GreaterThan<MyCustomException, short>(2, "args1").Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.GreaterThan<MyCustomException, int>(2, "args1").Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.GreaterThan<MyCustomException, long>(2, "args1").Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.GreaterThan<MyCustomException, decimal>(2, "args1").Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<MyCustomException, float>(2, "args1").Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.GreaterThan<MyCustomException, double>(2, "args1").Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyCustomException, MyTestEnum>(MyTestEnum.Three, "args1").Input);
            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.GreaterThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow, "args1").Input);
        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.GreaterThan<MyCustomException, short>(1, "args1").Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.GreaterThan<MyCustomException, int>(1, "args1").Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.GreaterThan<MyCustomException, long>(1, "args1").Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.GreaterThan<MyCustomException, decimal>(1, "args1").Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<MyCustomException, float>(1, "args1").Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.GreaterThan<MyCustomException, double>(1, "args1").Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyCustomException, MyTestEnum>(MyTestEnum.Two, "args1").Input);
            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.GreaterThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow, "args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueLessThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.GreaterThan<MyCustomException, short>(2, "args1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.GreaterThan<MyCustomException, int>(2, "args1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.GreaterThan<MyCustomException, long>(2, "args1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.GreaterThan<MyCustomException, decimal>(2, "args1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.GreaterThan<MyCustomException, float>(2, "args1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.GreaterThan<MyCustomException, double>(2, "args1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.GreaterThan<MyCustomException, MyTestEnum>(MyTestEnum.Three, "args1").InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.GreaterThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow, "args1").InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.GreaterThan<MyCustomException, short>(1, "args1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.GreaterThan<MyCustomException, int>(1, "args1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.GreaterThan<MyCustomException, long>(1, "args1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.GreaterThan<MyCustomException, decimal>(1, "args1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.GreaterThan<MyCustomException, float>(1, "args1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.GreaterThan<MyCustomException, double>(1, "args1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.GreaterThan<MyCustomException, MyTestEnum>(MyTestEnum.Two, "args1").InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.GreaterThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow, "args1").InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueGreaterThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue1).Against.GreaterThan<MyCustomException, short>(0, "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue1).Against.GreaterThan<MyCustomException, int>(0, "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.GreaterThan<MyCustomException, long>(0, "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue1).Against.GreaterThan<MyCustomException, decimal>(0, "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<MyCustomException, float>(0, "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue1).Against.GreaterThan<MyCustomException, double>(0, "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyCustomException, MyTestEnum>(MyTestEnum.One, "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.GreaterThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow, "args1"));
        }

        #endregion

        #region custom exception type as parameter
        [Fact]
        public void DoesNothingGivenValueLessThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.GreaterThan<short>(2, typeof(MyCustomException))
                .Protect(data.IntInputWithValue1).Against.GreaterThan<int>(2, typeof(MyCustomException))
                .Protect(data.LongInputWithValue1).Against.GreaterThan<long>(2 , typeof(MyCustomException))
                .Protect(data.DecimalInputWithValue1).Against.GreaterThan<decimal>(2 , typeof(MyCustomException))
                .Protect(data.FloatInputWithValue1).Against.GreaterThan<float>(2 , typeof(MyCustomException))
                .Protect(data.DoubleInputWithValue1).Against.GreaterThan<double>(2 , typeof(MyCustomException))
                .Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyTestEnum>(MyTestEnum.Three, typeof(MyCustomException))
                .Protect(data.DateTimeInputWithValueYesterday).Against.GreaterThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException));
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.GreaterThan<short>(1 , typeof(MyCustomException))
                .Protect(data.IntInputWithValue1).Against.GreaterThan<int>(1 , typeof(MyCustomException))
                .Protect(data.LongInputWithValue1).Against.GreaterThan<long>(1 , typeof(MyCustomException))
                .Protect(data.DecimalInputWithValue1).Against.GreaterThan<decimal>(1 , typeof(MyCustomException))
                .Protect(data.FloatInputWithValue1).Against.GreaterThan<float>(1 , typeof(MyCustomException))
                .Protect(data.DoubleInputWithValue1).Against.GreaterThan<double>(1 , typeof(MyCustomException))
                .Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyTestEnum>(MyTestEnum.Two, typeof(MyCustomException))
                .Protect(data.DateTimeInputWithValueNow).Against.GreaterThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException));
        }

        [Fact]
        public void PreservesInputGivenValueLessThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.GreaterThan<short>(2 , typeof(MyCustomException)).Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.GreaterThan<int>(2 , typeof(MyCustomException)).Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.GreaterThan<long>(2 , typeof(MyCustomException)).Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.GreaterThan<decimal>(2 , typeof(MyCustomException)).Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<float>(2 , typeof(MyCustomException)).Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.GreaterThan<double>(2 , typeof(MyCustomException)).Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyTestEnum>(MyTestEnum.Three, typeof(MyCustomException)).Input);
            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.GreaterThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException)).Input);
        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.GreaterThan<short>(1 , typeof(MyCustomException)).Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.GreaterThan<int>(1 , typeof(MyCustomException)).Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.GreaterThan<long>(1 , typeof(MyCustomException)).Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.GreaterThan<decimal>(1 , typeof(MyCustomException)).Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<float>(1 , typeof(MyCustomException)).Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.GreaterThan<double>(1 , typeof(MyCustomException)).Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyTestEnum>(MyTestEnum.Two, typeof(MyCustomException)).Input);
            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.GreaterThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException)).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueLessThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.GreaterThan<short>(2 , typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.GreaterThan<int>(2 , typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.GreaterThan<long>(2 , typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.GreaterThan<decimal>(2 , typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.GreaterThan<float>(2 , typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.GreaterThan<double>(2 , typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.GreaterThan<MyTestEnum>(MyTestEnum.Three, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.GreaterThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException)).InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.GreaterThan<short>(1 , typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.GreaterThan<int>(1 , typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.GreaterThan<long>(1 , typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.GreaterThan<decimal>(1 , typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.GreaterThan<float>(1 , typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.GreaterThan<double>(1 , typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.GreaterThan<MyTestEnum>(MyTestEnum.Two, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.GreaterThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException)).InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue1).Against.GreaterThan<short>(0 , typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue1).Against.GreaterThan<int>(0 , typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.GreaterThan<long>(0 , typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue1).Against.GreaterThan<decimal>(0 , typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<float>(0 , typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue1).Against.GreaterThan<double>(0 , typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyTestEnum>(MyTestEnum.One, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.GreaterThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException)));
        }


        #endregion

        #region custom exception type as parameter with constructor args


        [Fact]
        public void DoesNothingGivenValueLessThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.GreaterThan<short>(2, typeof(MyCustomException), "args1")
                .Protect(data.IntInputWithValue1).Against.GreaterThan<int>(2, typeof(MyCustomException), "args1")
                .Protect(data.LongInputWithValue1).Against.GreaterThan<long>(2, typeof(MyCustomException), "args1")
                .Protect(data.DecimalInputWithValue1).Against.GreaterThan<decimal>(2, typeof(MyCustomException), "args1")
                .Protect(data.FloatInputWithValue1).Against.GreaterThan<float>(2, typeof(MyCustomException), "args1")
                .Protect(data.DoubleInputWithValue1).Against.GreaterThan<double>(2, typeof(MyCustomException), "args1")
                .Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyTestEnum>(MyTestEnum.Three, typeof(MyCustomException), "args1")
                .Protect(data.DateTimeInputWithValueYesterday).Against.GreaterThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1");
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.GreaterThan<short>(1, typeof(MyCustomException), "args1")
                .Protect(data.IntInputWithValue1).Against.GreaterThan<int>(1, typeof(MyCustomException), "args1")
                .Protect(data.LongInputWithValue1).Against.GreaterThan<long>(1, typeof(MyCustomException), "args1")
                .Protect(data.DecimalInputWithValue1).Against.GreaterThan<decimal>(1, typeof(MyCustomException), "args1")
                .Protect(data.FloatInputWithValue1).Against.GreaterThan<float>(1, typeof(MyCustomException), "args1")
                .Protect(data.DoubleInputWithValue1).Against.GreaterThan<double>(1, typeof(MyCustomException), "args1")
                .Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyTestEnum>(MyTestEnum.Two, typeof(MyCustomException), "args1")
                .Protect(data.DateTimeInputWithValueNow).Against.GreaterThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1");
        }

        [Fact]
        public void PreservesInputGivenValueLessThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.GreaterThan<short>(2, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.GreaterThan<int>(2, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.GreaterThan<long>(2, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.GreaterThan<decimal>(2, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<float>(2, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.GreaterThan<double>(2, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyTestEnum>(MyTestEnum.Three, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.GreaterThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1").Input);
        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.GreaterThan<short>(1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.GreaterThan<int>(1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.GreaterThan<long>(1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.GreaterThan<decimal>(1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<float>(1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.GreaterThan<double>(1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyTestEnum>(MyTestEnum.Two, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.GreaterThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueLessThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.GreaterThan<short>(2, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.GreaterThan<int>(2, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.GreaterThan<long>(2, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.GreaterThan<decimal>(2, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.GreaterThan<float>(2, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.GreaterThan<double>(2, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.GreaterThan<MyTestEnum>(MyTestEnum.Three, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.GreaterThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.GreaterThan<short>(1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.GreaterThan<int>(1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.GreaterThan<long>(1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.GreaterThan<decimal>(1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.GreaterThan<float>(1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.GreaterThan<double>(1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.GreaterThan<MyTestEnum>(MyTestEnum.Two, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.GreaterThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue1).Against.GreaterThan<short>(0, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue1).Against.GreaterThan<int>(0, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.GreaterThan<long>(0, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue1).Against.GreaterThan<decimal>(0, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<float>(0, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue1).Against.GreaterThan<double>(0, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.GreaterThan<MyTestEnum>(MyTestEnum.One, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.GreaterThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1"));
        }


        #endregion


    }
}
