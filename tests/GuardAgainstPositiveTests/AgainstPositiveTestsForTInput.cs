using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using Xunit;

namespace GuardChain.Tests.GuardAgainstPositiveTests
{
    public class AgainstPositiveTestsForTInput
    {
        #region no custom exception

        [Fact]
        public void DoesNothingGivenNegativeValue()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValueMinus1).Against.Positive<short>()
                .Protect(data.IntInputWithValueMinus1).Against.Positive<int>()
                .Protect(data.LongInputWithValueMinus1).Against.Positive<long>()
                .Protect(data.DecimalInputWithValueMinus1).Against.Positive<decimal>()
                .Protect(data.FloatInputWithValueMinus1).Against.Positive<float>()
                .Protect(data.DoubleInputWithValueMinus1).Against.Positive<double>()
                .Protect(data.EnumInputWithValueMinusOne).Against.Positive<MyTestEnum>();
        }

        [Fact]
        public void DoesNothingGivenZeroValue()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue0).Against.Positive<short>()
                .Protect(data.IntInputWithValue0).Against.Positive<int>()
                .Protect(data.LongInputWithValue0).Against.Positive<long>()
                .Protect(data.DecimalInputWithValue0).Against.Positive<decimal>()
                .Protect(data.FloatInputWithValue0).Against.Positive<float>()
                .Protect(data.DoubleInputWithValue0).Against.Positive<double>()
                .Protect(data.EnumInputWithValueZero).Against.Positive<MyTestEnum>();
        }

        [Fact]
        public void PreservesInputGivenNegativeValue()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.Positive<short>().Input);
            Assert.Equal(data.IntInputWithValueMinus1, Guard.Protect(data.IntInputWithValueMinus1).Against.Positive<int>().Input);
            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.Positive<long>().Input);
            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.Positive<decimal>().Input);
            Assert.Equal(data.FloatInputWithValueMinus1, Guard.Protect(data.FloatInputWithValueMinus1).Against.Positive<float>().Input);
            Assert.Equal(data.DoubleInputWithValueMinus1, Guard.Protect(data.DoubleInputWithValueMinus1).Against.Positive<double>().Input);
            Assert.Equal(data.EnumInputWithValueMinusOne, Guard.Protect(data.EnumInputWithValueMinusOne).Against.Positive<MyTestEnum>().Input);
        }

        [Fact]
        public void PreservesInputGivenZeroValue()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue0, Guard.Protect(data.ShortInputWithValue0).Against.Positive<short>().Input);
            Assert.Equal(data.IntInputWithValue0, Guard.Protect(data.IntInputWithValue0).Against.Positive<int>().Input);
            Assert.Equal(data.LongInputWithValue0, Guard.Protect(data.LongInputWithValue0).Against.Positive<long>().Input);
            Assert.Equal(data.DecimalInputWithValue0, Guard.Protect(data.DecimalInputWithValue0).Against.Positive<decimal>().Input);
            Assert.Equal(data.FloatInputWithValue0, Guard.Protect(data.FloatInputWithValue0).Against.Positive<float>().Input);
            Assert.Equal(data.DoubleInputWithValue0, Guard.Protect(data.DoubleInputWithValue0).Against.Positive<double>().Input);
            Assert.Equal(data.EnumInputWithValueZero, Guard.Protect(data.EnumInputWithValueZero).Against.Positive<MyTestEnum>().Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNegativeValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.Positive<short>().InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValueMinus1), Guard.Protect(data.IntInputWithValueMinus1, nameof(data.IntInputWithValueMinus1)).Against.Positive<int>().InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.Positive<long>().InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.Positive<decimal>().InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValueMinus1), Guard.Protect(data.FloatInputWithValueMinus1, nameof(data.FloatInputWithValueMinus1)).Against.Positive<float>().InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValueMinus1), Guard.Protect(data.DoubleInputWithValueMinus1, nameof(data.DoubleInputWithValueMinus1)).Against.Positive<double>().InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueMinusOne), Guard.Protect(data.EnumInputWithValueMinusOne, nameof(data.EnumInputWithValueMinusOne)).Against.Positive<MyTestEnum>().InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenZeroValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue0), Guard.Protect(data.ShortInputWithValue0, nameof(data.ShortInputWithValue0)).Against.Positive<short>().InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue0), Guard.Protect(data.IntInputWithValue0, nameof(data.IntInputWithValue0)).Against.Positive<int>().InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue0), Guard.Protect(data.LongInputWithValue0, nameof(data.LongInputWithValue0)).Against.Positive<long>().InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue0), Guard.Protect(data.DecimalInputWithValue0, nameof(data.DecimalInputWithValue0)).Against.Positive<decimal>().InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue0), Guard.Protect(data.FloatInputWithValue0, nameof(data.FloatInputWithValue0)).Against.Positive<float>().InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue0), Guard.Protect(data.DoubleInputWithValue0, nameof(data.DoubleInputWithValue0)).Against.Positive<double>().InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueZero), Guard.Protect(data.EnumInputWithValueZero, nameof(data.EnumInputWithValueZero)).Against.Positive<MyTestEnum>().InputParameterName);
        }

        [Fact]
        public void ThrowsArgumentExceptionGivenPositiveValue()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.ShortInputWithValue1).Against.Positive<short>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.IntInputWithValue1).Against.Positive<int>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.LongInputWithValue1).Against.Positive<long>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DecimalInputWithValue1).Against.Positive<decimal>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.FloatInputWithValue1).Against.Positive<float>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DoubleInputWithValue1).Against.Positive<double>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.Positive<MyTestEnum>());
        }


        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValueMinus1).Against.Positive<MyCustomException, short>()
                .Protect(data.IntInputWithValueMinus1).Against.Positive<MyCustomException, int>()
                .Protect(data.LongInputWithValueMinus1).Against.Positive<MyCustomException, long>()
                .Protect(data.DecimalInputWithValueMinus1).Against.Positive<MyCustomException, decimal>()
                .Protect(data.FloatInputWithValueMinus1).Against.Positive<MyCustomException, float>()
                .Protect(data.DoubleInputWithValueMinus1).Against.Positive<MyCustomException, double>()
                .Protect(data.EnumInputWithValueMinusOne).Against.Positive<MyCustomException, MyTestEnum>();
        }

        [Fact]
        public void DoesNothingGivenZeroValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue0).Against.Positive<MyCustomException, short>()
                .Protect(data.IntInputWithValue0).Against.Positive<MyCustomException, int>()
                .Protect(data.LongInputWithValue0).Against.Positive<MyCustomException, long>()
                .Protect(data.DecimalInputWithValue0).Against.Positive<MyCustomException, decimal>()
                .Protect(data.FloatInputWithValue0).Against.Positive<MyCustomException, float>()
                .Protect(data.DoubleInputWithValue0).Against.Positive<MyCustomException, double>()
                .Protect(data.EnumInputWithValueZero).Against.Positive<MyCustomException, MyTestEnum>();
        }

        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.Positive<MyCustomException, short>().Input);
            Assert.Equal(data.IntInputWithValueMinus1, Guard.Protect(data.IntInputWithValueMinus1).Against.Positive<MyCustomException, int>().Input);
            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.Positive<MyCustomException, long>().Input);
            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.Positive<MyCustomException, decimal>().Input);
            Assert.Equal(data.FloatInputWithValueMinus1, Guard.Protect(data.FloatInputWithValueMinus1).Against.Positive<MyCustomException, float>().Input);
            Assert.Equal(data.DoubleInputWithValueMinus1, Guard.Protect(data.DoubleInputWithValueMinus1).Against.Positive<MyCustomException, double>().Input);
            Assert.Equal(data.EnumInputWithValueMinusOne, Guard.Protect(data.EnumInputWithValueMinusOne).Against.Positive<MyCustomException, MyTestEnum>().Input);
        }

        [Fact]
        public void PreservesInputGivenZeroValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue0, Guard.Protect(data.ShortInputWithValue0).Against.Positive<MyCustomException, short>().Input);
            Assert.Equal(data.IntInputWithValue0, Guard.Protect(data.IntInputWithValue0).Against.Positive<MyCustomException, int>().Input);
            Assert.Equal(data.LongInputWithValue0, Guard.Protect(data.LongInputWithValue0).Against.Positive<MyCustomException, long>().Input);
            Assert.Equal(data.DecimalInputWithValue0, Guard.Protect(data.DecimalInputWithValue0).Against.Positive<MyCustomException, decimal>().Input);
            Assert.Equal(data.FloatInputWithValue0, Guard.Protect(data.FloatInputWithValue0).Against.Positive<MyCustomException, float>().Input);
            Assert.Equal(data.DoubleInputWithValue0, Guard.Protect(data.DoubleInputWithValue0).Against.Positive<MyCustomException, double>().Input);
            Assert.Equal(data.EnumInputWithValueZero, Guard.Protect(data.EnumInputWithValueZero).Against.Positive<MyCustomException, MyTestEnum>().Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.Positive<MyCustomException, short>().InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValueMinus1), Guard.Protect(data.IntInputWithValueMinus1, nameof(data.IntInputWithValueMinus1)).Against.Positive<MyCustomException, int>().InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.Positive<MyCustomException, long>().InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.Positive<MyCustomException, decimal>().InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValueMinus1), Guard.Protect(data.FloatInputWithValueMinus1, nameof(data.FloatInputWithValueMinus1)).Against.Positive<MyCustomException, float>().InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValueMinus1), Guard.Protect(data.DoubleInputWithValueMinus1, nameof(data.DoubleInputWithValueMinus1)).Against.Positive<MyCustomException, double>().InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueMinusOne), Guard.Protect(data.EnumInputWithValueMinusOne, nameof(data.EnumInputWithValueMinusOne)).Against.Positive<MyCustomException, MyTestEnum>().InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenZeroValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue0), Guard.Protect(data.ShortInputWithValue0, nameof(data.ShortInputWithValue0)).Against.Positive<MyCustomException, short>().InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue0), Guard.Protect(data.IntInputWithValue0, nameof(data.IntInputWithValue0)).Against.Positive<MyCustomException, int>().InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue0), Guard.Protect(data.LongInputWithValue0, nameof(data.LongInputWithValue0)).Against.Positive<MyCustomException, long>().InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue0), Guard.Protect(data.DecimalInputWithValue0, nameof(data.DecimalInputWithValue0)).Against.Positive<MyCustomException, decimal>().InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue0), Guard.Protect(data.FloatInputWithValue0, nameof(data.FloatInputWithValue0)).Against.Positive<MyCustomException, float>().InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue0), Guard.Protect(data.DoubleInputWithValue0, nameof(data.DoubleInputWithValue0)).Against.Positive<MyCustomException, double>().InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueZero), Guard.Protect(data.EnumInputWithValueZero, nameof(data.EnumInputWithValueZero)).Against.Positive<MyCustomException, MyTestEnum>().InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenPositiveValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue1).Against.Positive<MyCustomException, short>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue1).Against.Positive<MyCustomException, int>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.Positive<MyCustomException, long>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue1).Against.Positive<MyCustomException, decimal>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.Positive<MyCustomException, float>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue1).Against.Positive<MyCustomException, double>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.Positive<MyCustomException, MyTestEnum>());
        }

        #endregion

        #region custom exception type as TException with constructor args

        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValueMinus1).Against.Positive<MyCustomException, short>("ags1")
                .Protect(data.IntInputWithValueMinus1).Against.Positive<MyCustomException, int>("ags1")
                .Protect(data.LongInputWithValueMinus1).Against.Positive<MyCustomException, long>("ags1")
                .Protect(data.DecimalInputWithValueMinus1).Against.Positive<MyCustomException, decimal>("ags1")
                .Protect(data.FloatInputWithValueMinus1).Against.Positive<MyCustomException, float>("ags1")
                .Protect(data.DoubleInputWithValueMinus1).Against.Positive<MyCustomException, double>("ags1")
                .Protect(data.EnumInputWithValueMinusOne).Against.Positive<MyCustomException, MyTestEnum>("ags1");
        }

        [Fact]
        public void DoesNothingGivenZeroValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue0).Against.Positive<MyCustomException, short>("ags1")
                .Protect(data.IntInputWithValue0).Against.Positive<MyCustomException, int>("ags1")
                .Protect(data.LongInputWithValue0).Against.Positive<MyCustomException, long>("ags1")
                .Protect(data.DecimalInputWithValue0).Against.Positive<MyCustomException, decimal>("ags1")
                .Protect(data.FloatInputWithValue0).Against.Positive<MyCustomException, float>("ags1")
                .Protect(data.DoubleInputWithValue0).Against.Positive<MyCustomException, double>("ags1")
                .Protect(data.EnumInputWithValueZero).Against.Positive<MyCustomException, MyTestEnum>("ags1");
        }

        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.Positive<MyCustomException, short>("ags1").Input);
            Assert.Equal(data.IntInputWithValueMinus1, Guard.Protect(data.IntInputWithValueMinus1).Against.Positive<MyCustomException, int>("ags1").Input);
            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.Positive<MyCustomException, long>("ags1").Input);
            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.Positive<MyCustomException, decimal>("ags1").Input);
            Assert.Equal(data.FloatInputWithValueMinus1, Guard.Protect(data.FloatInputWithValueMinus1).Against.Positive<MyCustomException, float>("ags1").Input);
            Assert.Equal(data.DoubleInputWithValueMinus1, Guard.Protect(data.DoubleInputWithValueMinus1).Against.Positive<MyCustomException, double>("ags1").Input);
            Assert.Equal(data.EnumInputWithValueMinusOne, Guard.Protect(data.EnumInputWithValueMinusOne).Against.Positive<MyCustomException, MyTestEnum>("ags1").Input);
        }

        [Fact]
        public void PreservesInputGivenZeroValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue0, Guard.Protect(data.ShortInputWithValue0).Against.Positive<MyCustomException, short>("ags1").Input);
            Assert.Equal(data.IntInputWithValue0, Guard.Protect(data.IntInputWithValue0).Against.Positive<MyCustomException, int>("ags1").Input);
            Assert.Equal(data.LongInputWithValue0, Guard.Protect(data.LongInputWithValue0).Against.Positive<MyCustomException, long>("ags1").Input);
            Assert.Equal(data.DecimalInputWithValue0, Guard.Protect(data.DecimalInputWithValue0).Against.Positive<MyCustomException, decimal>("ags1").Input);
            Assert.Equal(data.FloatInputWithValue0, Guard.Protect(data.FloatInputWithValue0).Against.Positive<MyCustomException, float>("ags1").Input);
            Assert.Equal(data.DoubleInputWithValue0, Guard.Protect(data.DoubleInputWithValue0).Against.Positive<MyCustomException, double>("ags1").Input);
            Assert.Equal(data.EnumInputWithValueZero, Guard.Protect(data.EnumInputWithValueZero).Against.Positive<MyCustomException, MyTestEnum>("ags1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.Positive<MyCustomException, short>("ags1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValueMinus1), Guard.Protect(data.IntInputWithValueMinus1, nameof(data.IntInputWithValueMinus1)).Against.Positive<MyCustomException, int>("ags1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.Positive<MyCustomException, long>("ags1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.Positive<MyCustomException, decimal>("ags1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValueMinus1), Guard.Protect(data.FloatInputWithValueMinus1, nameof(data.FloatInputWithValueMinus1)).Against.Positive<MyCustomException, float>("ags1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValueMinus1), Guard.Protect(data.DoubleInputWithValueMinus1, nameof(data.DoubleInputWithValueMinus1)).Against.Positive<MyCustomException, double>("ags1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueMinusOne), Guard.Protect(data.EnumInputWithValueMinusOne, nameof(data.EnumInputWithValueMinusOne)).Against.Positive<MyCustomException, MyTestEnum>("ags1").InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenZeroValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue0), Guard.Protect(data.ShortInputWithValue0, nameof(data.ShortInputWithValue0)).Against.Positive<MyCustomException, short>("ags1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue0), Guard.Protect(data.IntInputWithValue0, nameof(data.IntInputWithValue0)).Against.Positive<MyCustomException, int>("ags1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue0), Guard.Protect(data.LongInputWithValue0, nameof(data.LongInputWithValue0)).Against.Positive<MyCustomException, long>("ags1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue0), Guard.Protect(data.DecimalInputWithValue0, nameof(data.DecimalInputWithValue0)).Against.Positive<MyCustomException, decimal>("ags1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue0), Guard.Protect(data.FloatInputWithValue0, nameof(data.FloatInputWithValue0)).Against.Positive<MyCustomException, float>("ags1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue0), Guard.Protect(data.DoubleInputWithValue0, nameof(data.DoubleInputWithValue0)).Against.Positive<MyCustomException, double>("ags1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueZero), Guard.Protect(data.EnumInputWithValueZero, nameof(data.EnumInputWithValueZero)).Against.Positive<MyCustomException, MyTestEnum>("ags1").InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenPositiveValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue1).Against.Positive<MyCustomException, short>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue1).Against.Positive<MyCustomException, int>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.Positive<MyCustomException, long>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue1).Against.Positive<MyCustomException, decimal>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.Positive<MyCustomException, float>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue1).Against.Positive<MyCustomException, double>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.Positive<MyCustomException, MyTestEnum>("ags1"));
        }

        #endregion

        #region custom exception type as parameter

        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValueMinus1).Against.Positive<short>(typeof(MyCustomException))
                .Protect(data.IntInputWithValueMinus1).Against.Positive<int>(typeof(MyCustomException))
                .Protect(data.LongInputWithValueMinus1).Against.Positive<long>(typeof(MyCustomException))
                .Protect(data.DecimalInputWithValueMinus1).Against.Positive<decimal>(typeof(MyCustomException))
                .Protect(data.FloatInputWithValueMinus1).Against.Positive<float>(typeof(MyCustomException))
                .Protect(data.DoubleInputWithValueMinus1).Against.Positive<double>(typeof(MyCustomException))
                .Protect(data.EnumInputWithValueMinusOne).Against.Positive<MyTestEnum>(typeof(MyCustomException));
        }

        [Fact]
        public void DoesNothingGivenZeroValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue0).Against.Positive<short>(typeof(MyCustomException))
                .Protect(data.IntInputWithValue0).Against.Positive<int>(typeof(MyCustomException))
                .Protect(data.LongInputWithValue0).Against.Positive<long>(typeof(MyCustomException))
                .Protect(data.DecimalInputWithValue0).Against.Positive<decimal>(typeof(MyCustomException))
                .Protect(data.FloatInputWithValue0).Against.Positive<float>(typeof(MyCustomException))
                .Protect(data.DoubleInputWithValue0).Against.Positive<double>(typeof(MyCustomException))
                .Protect(data.EnumInputWithValueZero).Against.Positive<MyTestEnum>(typeof(MyCustomException));
        }

        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.Positive<short>(typeof(MyCustomException)).Input);
            Assert.Equal(data.IntInputWithValueMinus1, Guard.Protect(data.IntInputWithValueMinus1).Against.Positive<int>(typeof(MyCustomException)).Input);
            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.Positive<long>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.Positive<decimal>(typeof(MyCustomException)).Input);
            Assert.Equal(data.FloatInputWithValueMinus1, Guard.Protect(data.FloatInputWithValueMinus1).Against.Positive<float>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DoubleInputWithValueMinus1, Guard.Protect(data.DoubleInputWithValueMinus1).Against.Positive<double>(typeof(MyCustomException)).Input);
            Assert.Equal(data.EnumInputWithValueMinusOne, Guard.Protect(data.EnumInputWithValueMinusOne).Against.Positive<MyTestEnum>(typeof(MyCustomException)).Input);
        }

        [Fact]
        public void PreservesInputGivenZeroValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue0, Guard.Protect(data.ShortInputWithValue0).Against.Positive<short>(typeof(MyCustomException)).Input);
            Assert.Equal(data.IntInputWithValue0, Guard.Protect(data.IntInputWithValue0).Against.Positive<int>(typeof(MyCustomException)).Input);
            Assert.Equal(data.LongInputWithValue0, Guard.Protect(data.LongInputWithValue0).Against.Positive<long>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DecimalInputWithValue0, Guard.Protect(data.DecimalInputWithValue0).Against.Positive<decimal>(typeof(MyCustomException)).Input);
            Assert.Equal(data.FloatInputWithValue0, Guard.Protect(data.FloatInputWithValue0).Against.Positive<float>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DoubleInputWithValue0, Guard.Protect(data.DoubleInputWithValue0).Against.Positive<double>(typeof(MyCustomException)).Input);
            Assert.Equal(data.EnumInputWithValueZero, Guard.Protect(data.EnumInputWithValueZero).Against.Positive<MyTestEnum>(typeof(MyCustomException)).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.Positive<short>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValueMinus1), Guard.Protect(data.IntInputWithValueMinus1, nameof(data.IntInputWithValueMinus1)).Against.Positive<int>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.Positive<long>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.Positive<decimal>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValueMinus1), Guard.Protect(data.FloatInputWithValueMinus1, nameof(data.FloatInputWithValueMinus1)).Against.Positive<float>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValueMinus1), Guard.Protect(data.DoubleInputWithValueMinus1, nameof(data.DoubleInputWithValueMinus1)).Against.Positive<double>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueMinusOne), Guard.Protect(data.EnumInputWithValueMinusOne, nameof(data.EnumInputWithValueMinusOne)).Against.Positive<MyTestEnum>(typeof(MyCustomException)).InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenZeroValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue0), Guard.Protect(data.ShortInputWithValue0, nameof(data.ShortInputWithValue0)).Against.Positive<short>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue0), Guard.Protect(data.IntInputWithValue0, nameof(data.IntInputWithValue0)).Against.Positive<int>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue0), Guard.Protect(data.LongInputWithValue0, nameof(data.LongInputWithValue0)).Against.Positive<long>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue0), Guard.Protect(data.DecimalInputWithValue0, nameof(data.DecimalInputWithValue0)).Against.Positive<decimal>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue0), Guard.Protect(data.FloatInputWithValue0, nameof(data.FloatInputWithValue0)).Against.Positive<float>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue0), Guard.Protect(data.DoubleInputWithValue0, nameof(data.DoubleInputWithValue0)).Against.Positive<double>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueZero), Guard.Protect(data.EnumInputWithValueZero, nameof(data.EnumInputWithValueZero)).Against.Positive<MyTestEnum>(typeof(MyCustomException)).InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenPositiveValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue1).Against.Positive<short>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue1).Against.Positive<int>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.Positive<long>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue1).Against.Positive<decimal>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.Positive<float>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue1).Against.Positive<double>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.Positive<MyTestEnum>(typeof(MyCustomException)));
        }

        #endregion

        #region custom exception type as parameter with constructor args

        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValueMinus1).Against.Positive<short>(typeof(MyCustomException), "args1")
                .Protect(data.IntInputWithValueMinus1).Against.Positive<int>(typeof(MyCustomException), "args1")
                .Protect(data.LongInputWithValueMinus1).Against.Positive<long>(typeof(MyCustomException), "args1")
                .Protect(data.DecimalInputWithValueMinus1).Against.Positive<decimal>(typeof(MyCustomException), "args1")
                .Protect(data.FloatInputWithValueMinus1).Against.Positive<float>(typeof(MyCustomException), "args1")
                .Protect(data.DoubleInputWithValueMinus1).Against.Positive<double>(typeof(MyCustomException), "args1")
                .Protect(data.EnumInputWithValueMinusOne).Against.Positive<MyTestEnum>(typeof(MyCustomException), "args1");
        }

        [Fact]
        public void DoesNothingGivenZeroValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue0).Against.Positive<short>(typeof(MyCustomException), "args1")
                .Protect(data.IntInputWithValue0).Against.Positive<int>(typeof(MyCustomException), "args1")
                .Protect(data.LongInputWithValue0).Against.Positive<long>(typeof(MyCustomException), "args1")
                .Protect(data.DecimalInputWithValue0).Against.Positive<decimal>(typeof(MyCustomException), "args1")
                .Protect(data.FloatInputWithValue0).Against.Positive<float>(typeof(MyCustomException), "args1")
                .Protect(data.DoubleInputWithValue0).Against.Positive<double>(typeof(MyCustomException), "args1")
                .Protect(data.EnumInputWithValueZero).Against.Positive<MyTestEnum>(typeof(MyCustomException), "args1");
        }

        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.Positive<short>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.IntInputWithValueMinus1, Guard.Protect(data.IntInputWithValueMinus1).Against.Positive<int>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.Positive<long>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.Positive<decimal>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.FloatInputWithValueMinus1, Guard.Protect(data.FloatInputWithValueMinus1).Against.Positive<float>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DoubleInputWithValueMinus1, Guard.Protect(data.DoubleInputWithValueMinus1).Against.Positive<double>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.EnumInputWithValueMinusOne, Guard.Protect(data.EnumInputWithValueMinusOne).Against.Positive<MyTestEnum>(typeof(MyCustomException), "args1").Input);
        }

        [Fact]
        public void PreservesInputGivenZeroValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue0, Guard.Protect(data.ShortInputWithValue0).Against.Positive<short>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.IntInputWithValue0, Guard.Protect(data.IntInputWithValue0).Against.Positive<int>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.LongInputWithValue0, Guard.Protect(data.LongInputWithValue0).Against.Positive<long>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DecimalInputWithValue0, Guard.Protect(data.DecimalInputWithValue0).Against.Positive<decimal>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.FloatInputWithValue0, Guard.Protect(data.FloatInputWithValue0).Against.Positive<float>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DoubleInputWithValue0, Guard.Protect(data.DoubleInputWithValue0).Against.Positive<double>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.EnumInputWithValueZero, Guard.Protect(data.EnumInputWithValueZero).Against.Positive<MyTestEnum>(typeof(MyCustomException), "args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.Positive<short>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValueMinus1), Guard.Protect(data.IntInputWithValueMinus1, nameof(data.IntInputWithValueMinus1)).Against.Positive<int>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.Positive<long>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.Positive<decimal>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValueMinus1), Guard.Protect(data.FloatInputWithValueMinus1, nameof(data.FloatInputWithValueMinus1)).Against.Positive<float>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValueMinus1), Guard.Protect(data.DoubleInputWithValueMinus1, nameof(data.DoubleInputWithValueMinus1)).Against.Positive<double>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueMinusOne), Guard.Protect(data.EnumInputWithValueMinusOne, nameof(data.EnumInputWithValueMinusOne)).Against.Positive<MyTestEnum>(typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenZeroValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue0), Guard.Protect(data.ShortInputWithValue0, nameof(data.ShortInputWithValue0)).Against.Positive<short>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue0), Guard.Protect(data.IntInputWithValue0, nameof(data.IntInputWithValue0)).Against.Positive<int>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue0), Guard.Protect(data.LongInputWithValue0, nameof(data.LongInputWithValue0)).Against.Positive<long>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue0), Guard.Protect(data.DecimalInputWithValue0, nameof(data.DecimalInputWithValue0)).Against.Positive<decimal>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue0), Guard.Protect(data.FloatInputWithValue0, nameof(data.FloatInputWithValue0)).Against.Positive<float>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue0), Guard.Protect(data.DoubleInputWithValue0, nameof(data.DoubleInputWithValue0)).Against.Positive<double>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueZero), Guard.Protect(data.EnumInputWithValueZero, nameof(data.EnumInputWithValueZero)).Against.Positive<MyTestEnum>(typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenPositiveValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue1).Against.Positive<short>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue1).Against.Positive<int>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.Positive<long>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue1).Against.Positive<decimal>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.Positive<float>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue1).Against.Positive<double>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.Positive<MyTestEnum>(typeof(MyCustomException), "args1"));
        }

        #endregion
    }
}
