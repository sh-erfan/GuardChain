using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using Xunit;

namespace GuardChain.Tests.GuardAgainstLessThanTests
{
    public class AgainstLessThanTestsForTInput
    {
        #region no custom exception

        [Fact]
        public void DoesNothingGivenValueGreaterThanLimit()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.LessThan<short>(0)
                .Protect(data.IntInputWithValue1).Against.LessThan<int>(0)
                .Protect(data.LongInputWithValue1).Against.LessThan<long>(0)
                .Protect(data.DecimalInputWithValue1).Against.LessThan<decimal>(0)
                .Protect(data.FloatInputWithValue1).Against.LessThan<float>(0)
                .Protect(data.DoubleInputWithValue1).Against.LessThan<double>(0)
                .Protect(data.EnumInputWithValueTwo).Against.LessThan<MyTestEnum>(MyTestEnum.One)
                .Protect(data.DateTimeInputWithValueTomorrow).Against.LessThan<DateTime>(data.DateTimeInputWithValueNow);
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimit()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.LessThan<short>(1)
                .Protect(data.IntInputWithValue1).Against.LessThan<int>(1)
                .Protect(data.LongInputWithValue1).Against.LessThan<long>(1)
                .Protect(data.DecimalInputWithValue1).Against.LessThan<decimal>(1)
                .Protect(data.FloatInputWithValue1).Against.LessThan<float>(1)
                .Protect(data.DoubleInputWithValue1).Against.LessThan<double>(1)
                .Protect(data.EnumInputWithValueTwo).Against.LessThan<MyTestEnum>(MyTestEnum.Two)
                .Protect(data.DateTimeInputWithValueNow).Against.LessThan<DateTime>(data.DateTimeInputWithValueNow);
        }

        [Fact]
        public void PreservesInputGivenValueGreaterThanLimit()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.LessThan<short>(0).Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.LessThan<int>(0).Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.LessThan<long>(0).Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.LessThan<decimal>(0).Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.LessThan<float>(0).Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.LessThan<double>(0).Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.LessThan<MyTestEnum>(MyTestEnum.One).Input);
            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.LessThan<DateTime>(data.DateTimeInputWithValueNow).Input);
        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimit()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.LessThan<short>(1).Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.LessThan<int>(1).Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.LessThan<long>(1).Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.LessThan<decimal>(1).Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.LessThan<float>(1).Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.LessThan<double>(1).Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.LessThan<MyTestEnum>(MyTestEnum.Two).Input);
            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.LessThan<DateTime>(data.DateTimeInputWithValueNow).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueGreaterThanLimit()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.LessThan<short>(0).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.LessThan<int>(0).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.LessThan<long>(0).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.LessThan<decimal>(0).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.LessThan<float>(0).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.LessThan<double>(0).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.LessThan<MyTestEnum>(MyTestEnum.One).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.LessThan<DateTime>(data.DateTimeInputWithValueNow).InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimit()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.LessThan<short>(1).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.LessThan<int>(1).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.LessThan<long>(1).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.LessThan<decimal>(1).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.LessThan<float>(1).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.LessThan<double>(1).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.LessThan<MyTestEnum>(MyTestEnum.Two).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.LessThan<DateTime>(data.DateTimeInputWithValueNow).InputParameterName);
        }

        [Fact]
        public void ThrowsArgumentExceptionGivenValueLessThanLimit()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.ShortInputWithValue1).Against.LessThan<short>(2));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.IntInputWithValue1).Against.LessThan<int>(2));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.LongInputWithValue1).Against.LessThan<long>(2));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DecimalInputWithValue1).Against.LessThan<decimal>(2));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.FloatInputWithValue1).Against.LessThan<float>(2));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DoubleInputWithValue1).Against.LessThan<double>(2));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.LessThan<MyTestEnum>(MyTestEnum.Three));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DateTimeInputWithValueYesterday).Against.LessThan<DateTime>(data.DateTimeInputWithValueNow));
        }

        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenValueGreaterThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.LessThan<MyCustomException, short>(0)
                .Protect(data.IntInputWithValue1).Against.LessThan<MyCustomException, int>(0)
                .Protect(data.LongInputWithValue1).Against.LessThan<MyCustomException, long>(0)
                .Protect(data.DecimalInputWithValue1).Against.LessThan<MyCustomException, decimal>(0)
                .Protect(data.FloatInputWithValue1).Against.LessThan<MyCustomException, float>(0)
                .Protect(data.DoubleInputWithValue1).Against.LessThan<MyCustomException, double>(0)
                .Protect(data.EnumInputWithValueTwo).Against.LessThan<MyCustomException, MyTestEnum>(MyTestEnum.One)
                .Protect(data.DateTimeInputWithValueTomorrow).Against.LessThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow);
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.LessThan<MyCustomException, short>(1)
                .Protect(data.IntInputWithValue1).Against.LessThan<MyCustomException, int>(1)
                .Protect(data.LongInputWithValue1).Against.LessThan<MyCustomException, long>(1)
                .Protect(data.DecimalInputWithValue1).Against.LessThan<MyCustomException, decimal>(1)
                .Protect(data.FloatInputWithValue1).Against.LessThan<MyCustomException, float>(1)
                .Protect(data.DoubleInputWithValue1).Against.LessThan<MyCustomException, double>(1)
                .Protect(data.EnumInputWithValueTwo).Against.LessThan<MyCustomException, MyTestEnum>(MyTestEnum.Two)
                .Protect(data.DateTimeInputWithValueNow).Against.LessThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow);
        }

        [Fact]
        public void PreservesInputGivenValueGreaterThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.LessThan<MyCustomException, short>(0).Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.LessThan<MyCustomException, int>(0).Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.LessThan<MyCustomException, long>(0).Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.LessThan<MyCustomException, decimal>(0).Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.LessThan<MyCustomException, float>(0).Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.LessThan<MyCustomException, double>(0).Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.LessThan<MyCustomException, MyTestEnum>(MyTestEnum.One).Input);
            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.LessThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow).Input);
        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.LessThan<MyCustomException, short>(1).Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.LessThan<MyCustomException, int>(1).Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.LessThan<MyCustomException, long>(1).Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.LessThan<MyCustomException, decimal>(1).Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.LessThan<MyCustomException, float>(1).Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.LessThan<MyCustomException, double>(1).Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.LessThan<MyCustomException, MyTestEnum>(MyTestEnum.Two).Input);
            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.LessThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueGreaterThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.LessThan<MyCustomException, short>(0).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.LessThan<MyCustomException, int>(0).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.LessThan<MyCustomException, long>(0).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.LessThan<MyCustomException, decimal>(0).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.LessThan<MyCustomException, float>(0).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.LessThan<MyCustomException, double>(0).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.LessThan<MyCustomException, MyTestEnum>(MyTestEnum.One).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.LessThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow).InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.LessThan<MyCustomException, short>(1).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.LessThan<MyCustomException, int>(1).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.LessThan<MyCustomException, long>(1).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.LessThan<MyCustomException, decimal>(1).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.LessThan<MyCustomException, float>(1).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.LessThan<MyCustomException, double>(1).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.LessThan<MyCustomException, MyTestEnum>(MyTestEnum.Two).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.LessThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow).InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueLessThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue1).Against.LessThan<MyCustomException, short>(2));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue1).Against.LessThan<MyCustomException, int>(2));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.LessThan<MyCustomException, long>(2));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue1).Against.LessThan<MyCustomException, decimal>(2));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.LessThan<MyCustomException, float>(2));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue1).Against.LessThan<MyCustomException, double>(2));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.LessThan<MyCustomException, MyTestEnum>(MyTestEnum.Three));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueYesterday).Against.LessThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow));
        }

        #endregion

        #region custom exception type as TException with constructor args

        [Fact]
        public void DoesNothingGivenValueGreaterThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.LessThan<MyCustomException, short>(0, "args1")
                .Protect(data.IntInputWithValue1).Against.LessThan<MyCustomException, int>(0, "args1")
                .Protect(data.LongInputWithValue1).Against.LessThan<MyCustomException, long>(0, "args1")
                .Protect(data.DecimalInputWithValue1).Against.LessThan<MyCustomException, decimal>(0, "args1")
                .Protect(data.FloatInputWithValue1).Against.LessThan<MyCustomException, float>(0, "args1")
                .Protect(data.DoubleInputWithValue1).Against.LessThan<MyCustomException, double>(0, "args1")
                .Protect(data.EnumInputWithValueTwo).Against.LessThan<MyCustomException, MyTestEnum>(MyTestEnum.One, "args1")
                .Protect(data.DateTimeInputWithValueTomorrow).Against.LessThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow, "args1");
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.LessThan<MyCustomException, short>(1, "args1")
                .Protect(data.IntInputWithValue1).Against.LessThan<MyCustomException, int>(1, "args1")
                .Protect(data.LongInputWithValue1).Against.LessThan<MyCustomException, long>(1, "args1")
                .Protect(data.DecimalInputWithValue1).Against.LessThan<MyCustomException, decimal>(1, "args1")
                .Protect(data.FloatInputWithValue1).Against.LessThan<MyCustomException, float>(1, "args1")
                .Protect(data.DoubleInputWithValue1).Against.LessThan<MyCustomException, double>(1, "args1")
                .Protect(data.EnumInputWithValueTwo).Against.LessThan<MyCustomException, MyTestEnum>(MyTestEnum.Two, "args1")
                .Protect(data.DateTimeInputWithValueNow).Against.LessThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow, "args1");
        }

        [Fact]
        public void PreservesInputGivenValueGreaterThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.LessThan<MyCustomException, short>(0, "args1").Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.LessThan<MyCustomException, int>(0, "args1").Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.LessThan<MyCustomException, long>(0, "args1").Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.LessThan<MyCustomException, decimal>(0, "args1").Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.LessThan<MyCustomException, float>(0, "args1").Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.LessThan<MyCustomException, double>(0, "args1").Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.LessThan<MyCustomException, MyTestEnum>(MyTestEnum.One, "args1").Input);
            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.LessThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow, "args1").Input);
        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.LessThan<MyCustomException, short>(1, "args1").Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.LessThan<MyCustomException, int>(1, "args1").Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.LessThan<MyCustomException, long>(1, "args1").Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.LessThan<MyCustomException, decimal>(1, "args1").Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.LessThan<MyCustomException, float>(1, "args1").Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.LessThan<MyCustomException, double>(1, "args1").Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.LessThan<MyCustomException, MyTestEnum>(MyTestEnum.Two, "args1").Input);
            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.LessThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow, "args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueGreaterThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.LessThan<MyCustomException, short>(0, "args1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.LessThan<MyCustomException, int>(0, "args1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.LessThan<MyCustomException, long>(0, "args1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.LessThan<MyCustomException, decimal>(0, "args1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.LessThan<MyCustomException, float>(0, "args1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.LessThan<MyCustomException, double>(0, "args1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.LessThan<MyCustomException, MyTestEnum>(MyTestEnum.One, "args1").InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.LessThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow, "args1").InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.LessThan<MyCustomException, short>(1, "args1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.LessThan<MyCustomException, int>(1, "args1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.LessThan<MyCustomException, long>(1, "args1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.LessThan<MyCustomException, decimal>(1, "args1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.LessThan<MyCustomException, float>(1, "args1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.LessThan<MyCustomException, double>(1, "args1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.LessThan<MyCustomException, MyTestEnum>(MyTestEnum.Two, "args1").InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.LessThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow, "args1").InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueLessThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue1).Against.LessThan<MyCustomException, short>(2, "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue1).Against.LessThan<MyCustomException, int>(2, "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.LessThan<MyCustomException, long>(2, "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue1).Against.LessThan<MyCustomException, decimal>(2, "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.LessThan<MyCustomException, float>(2, "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue1).Against.LessThan<MyCustomException, double>(2, "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.LessThan<MyCustomException, MyTestEnum>(MyTestEnum.Three));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueYesterday).Against.LessThan<MyCustomException, DateTime>(data.DateTimeInputWithValueNow, "args1"));
        }

        #endregion

        #region custom exception type as parameter

        [Fact]
        public void DoesNothingGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.LessThan<short>(0, typeof(MyCustomException))
                .Protect(data.IntInputWithValue1).Against.LessThan<int>(0, typeof(MyCustomException))
                .Protect(data.LongInputWithValue1).Against.LessThan<long>(0, typeof(MyCustomException))
                .Protect(data.DecimalInputWithValue1).Against.LessThan<decimal>(0, typeof(MyCustomException))
                .Protect(data.FloatInputWithValue1).Against.LessThan<float>(0, typeof(MyCustomException))
                .Protect(data.DoubleInputWithValue1).Against.LessThan<double>(0, typeof(MyCustomException))
                .Protect(data.EnumInputWithValueTwo).Against.LessThan<MyTestEnum>(MyTestEnum.One, typeof(MyCustomException))
                .Protect(data.DateTimeInputWithValueTomorrow).Against.LessThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException));
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.LessThan<short>(1, typeof(MyCustomException))
                .Protect(data.IntInputWithValue1).Against.LessThan<int>(1, typeof(MyCustomException))
                .Protect(data.LongInputWithValue1).Against.LessThan<long>(1, typeof(MyCustomException))
                .Protect(data.DecimalInputWithValue1).Against.LessThan<decimal>(1, typeof(MyCustomException))
                .Protect(data.FloatInputWithValue1).Against.LessThan<float>(1, typeof(MyCustomException))
                .Protect(data.DoubleInputWithValue1).Against.LessThan<double>(1, typeof(MyCustomException))
                .Protect(data.EnumInputWithValueTwo).Against.LessThan<MyTestEnum>(MyTestEnum.Two, typeof(MyCustomException))
                .Protect(data.DateTimeInputWithValueNow).Against.LessThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException));
        }

        [Fact]
        public void PreservesInputGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.LessThan<short>(0, typeof(MyCustomException)).Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.LessThan<int>(0, typeof(MyCustomException)).Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.LessThan<long>(0, typeof(MyCustomException)).Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.LessThan<decimal>(0, typeof(MyCustomException)).Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.LessThan<float>(0, typeof(MyCustomException)).Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.LessThan<double>(0, typeof(MyCustomException)).Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.LessThan<MyTestEnum>(MyTestEnum.One, typeof(MyCustomException)).Input);
            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.LessThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException)).Input);
        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.LessThan<short>(1, typeof(MyCustomException)).Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.LessThan<int>(1, typeof(MyCustomException)).Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.LessThan<long>(1, typeof(MyCustomException)).Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.LessThan<decimal>(1, typeof(MyCustomException)).Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.LessThan<float>(1, typeof(MyCustomException)).Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.LessThan<double>(1, typeof(MyCustomException)).Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.LessThan<MyTestEnum>(MyTestEnum.Two, typeof(MyCustomException)).Input);
            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.LessThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException)).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.LessThan<short>(0, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.LessThan<int>(0, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.LessThan<long>(0, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.LessThan<decimal>(0, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.LessThan<float>(0, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.LessThan<double>(0, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.LessThan<MyTestEnum>(MyTestEnum.One, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.LessThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException)).InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.LessThan<short>(1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.LessThan<int>(1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.LessThan<long>(1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.LessThan<decimal>(1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.LessThan<float>(1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.LessThan<double>(1, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.LessThan<MyTestEnum>(MyTestEnum.Two, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.LessThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException)).InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueLessThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue1).Against.LessThan<short>(2, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue1).Against.LessThan<int>(2, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.LessThan<long>(2, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue1).Against.LessThan<decimal>(2, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.LessThan<float>(2, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue1).Against.LessThan<double>(2, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.LessThan<MyTestEnum>(MyTestEnum.Three, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueYesterday).Against.LessThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException)));
        }

        #endregion

        #region custom exception type as parameter with constructor args

        [Fact]
        public void DoesNothingGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.LessThan<short>(0, typeof(MyCustomException), "args1")
                .Protect(data.IntInputWithValue1).Against.LessThan<int>(0, typeof(MyCustomException), "args1")
                .Protect(data.LongInputWithValue1).Against.LessThan<long>(0, typeof(MyCustomException), "args1")
                .Protect(data.DecimalInputWithValue1).Against.LessThan<decimal>(0, typeof(MyCustomException), "args1")
                .Protect(data.FloatInputWithValue1).Against.LessThan<float>(0, typeof(MyCustomException), "args1")
                .Protect(data.DoubleInputWithValue1).Against.LessThan<double>(0, typeof(MyCustomException), "args1")
                .Protect(data.EnumInputWithValueTwo).Against.LessThan<MyTestEnum>(MyTestEnum.One, typeof(MyCustomException), "args1")
                .Protect(data.DateTimeInputWithValueTomorrow).Against.LessThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1");
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.LessThan<short>(1, typeof(MyCustomException), "args1")
                .Protect(data.IntInputWithValue1).Against.LessThan<int>(1, typeof(MyCustomException), "args1")
                .Protect(data.LongInputWithValue1).Against.LessThan<long>(1, typeof(MyCustomException), "args1")
                .Protect(data.DecimalInputWithValue1).Against.LessThan<decimal>(1, typeof(MyCustomException), "args1")
                .Protect(data.FloatInputWithValue1).Against.LessThan<float>(1, typeof(MyCustomException), "args1")
                .Protect(data.DoubleInputWithValue1).Against.LessThan<double>(1, typeof(MyCustomException), "args1")
                .Protect(data.EnumInputWithValueTwo).Against.LessThan<MyTestEnum>(MyTestEnum.Two, typeof(MyCustomException), "args1")
                .Protect(data.DateTimeInputWithValueNow).Against.LessThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1");
        }

        [Fact]
        public void PreservesInputGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.LessThan<short>(0, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.LessThan<int>(0, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.LessThan<long>(0, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.LessThan<decimal>(0, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.LessThan<float>(0, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.LessThan<double>(0, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.LessThan<MyTestEnum>(MyTestEnum.One, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.LessThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1").Input);
        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.LessThan<short>(1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.LessThan<int>(1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.LessThan<long>(1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.LessThan<decimal>(1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.LessThan<float>(1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.LessThan<double>(1, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.LessThan<MyTestEnum>(MyTestEnum.Two, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.LessThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.LessThan<short>(0, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.LessThan<int>(0, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.LessThan<long>(0, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.LessThan<decimal>(0, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.LessThan<float>(0, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.LessThan<double>(0, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.LessThan<MyTestEnum>(MyTestEnum.One, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.LessThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.LessThan<short>(1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.LessThan<int>(1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.LessThan<long>(1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.LessThan<decimal>(1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.LessThan<float>(1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.LessThan<double>(1, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.LessThan<MyTestEnum>(MyTestEnum.Two, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.LessThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueLessThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue1).Against.LessThan<short>(2, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue1).Against.LessThan<int>(2, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.LessThan<long>(2, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue1).Against.LessThan<decimal>(2, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.LessThan<float>(2, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue1).Against.LessThan<double>(2, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.LessThan<MyTestEnum>(MyTestEnum.Three, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueYesterday).Against.LessThan<DateTime>(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1"));
        }


        #endregion

    }
}
