using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using Xunit;

namespace GuardChain.Tests.GuardAgainstNegativeTests
{
    public class AgainstNegativeTestsForTInput
    {

        #region no custom exception

        [Fact]
        public void DoesNothingGivenPositiveValue()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.Negative<short>()
                .Protect(data.IntInputWithValue1).Against.Negative<int>()
                .Protect(data.LongInputWithValue1).Against.Negative<long>()
                .Protect(data.DecimalInputWithValue1).Against.Negative<decimal>()
                .Protect(data.FloatInputWithValue1).Against.Negative<float>()
                .Protect(data.DoubleInputWithValue1).Against.Negative<double>()
                .Protect(data.EnumInputWithValueTwo).Against.Negative<MyTestEnum>();
        }

        [Fact]
        public void DoesNothingGivenZeroValue()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue0).Against.Negative<short>()
                .Protect(data.IntInputWithValue0).Against.Negative<int>()
                .Protect(data.LongInputWithValue0).Against.Negative<long>()
                .Protect(data.DecimalInputWithValue0).Against.Negative<decimal>()
                .Protect(data.FloatInputWithValue0).Against.Negative<float>()
                .Protect(data.DoubleInputWithValue0).Against.Negative<double>()
                .Protect(data.EnumInputWithValueZero).Against.Negative<MyTestEnum>();
        }

        [Fact]
        public void PreservesInputGivenPositiveValue()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Negative<short>().Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Negative<int>().Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Negative<long>().Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Negative<decimal>().Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Negative<float>().Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Negative<double>().Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Negative<MyTestEnum>().Input);
        }

        [Fact]
        public void PreservesInputGivenZeroValue()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue0, Guard.Protect(data.ShortInputWithValue0).Against.Negative<short>().Input);
            Assert.Equal(data.IntInputWithValue0, Guard.Protect(data.IntInputWithValue0).Against.Negative<int>().Input);
            Assert.Equal(data.LongInputWithValue0, Guard.Protect(data.LongInputWithValue0).Against.Negative<long>().Input);
            Assert.Equal(data.DecimalInputWithValue0, Guard.Protect(data.DecimalInputWithValue0).Against.Negative<decimal>().Input);
            Assert.Equal(data.FloatInputWithValue0, Guard.Protect(data.FloatInputWithValue0).Against.Negative<float>().Input);
            Assert.Equal(data.DoubleInputWithValue0, Guard.Protect(data.DoubleInputWithValue0).Against.Negative<double>().Input);
            Assert.Equal(data.EnumInputWithValueZero, Guard.Protect(data.EnumInputWithValueZero).Against.Negative<MyTestEnum>().Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenPositiveValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.Negative<short>().InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.Negative<int>().InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Negative<long>().InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Negative<decimal>().InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.Negative<float>().InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Negative<double>().InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.Negative<MyTestEnum>().InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenZeroValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue0), Guard.Protect(data.ShortInputWithValue0, nameof(data.ShortInputWithValue0)).Against.Negative<short>().InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue0), Guard.Protect(data.IntInputWithValue0, nameof(data.IntInputWithValue0)).Against.Negative<int>().InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue0), Guard.Protect(data.LongInputWithValue0, nameof(data.LongInputWithValue0)).Against.Negative<long>().InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue0), Guard.Protect(data.DecimalInputWithValue0, nameof(data.DecimalInputWithValue0)).Against.Negative<decimal>().InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue0), Guard.Protect(data.FloatInputWithValue0, nameof(data.FloatInputWithValue0)).Against.Negative<float>().InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue0), Guard.Protect(data.DoubleInputWithValue0, nameof(data.DoubleInputWithValue0)).Against.Negative<double>().InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueZero), Guard.Protect(data.EnumInputWithValueZero, nameof(data.EnumInputWithValueZero)).Against.Negative<MyTestEnum>().InputParameterName);
        }

        [Fact]
        public void ThrowsArgumentExceptionGivenNegativeValue()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.ShortInputWithValueMinus1).Against.Negative<short>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.IntInputWithValueMinus1).Against.Negative<int>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.LongInputWithValueMinus1).Against.Negative<long>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DecimalInputWithValueMinus1).Against.Negative<decimal>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.FloatInputWithValueMinus1).Against.Negative<float>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DoubleInputWithValueMinus1).Against.Negative<double>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.EnumInputWithValueMinusOne).Against.Negative<MyTestEnum>());
        }


        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenPositiveValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.Negative<MyCustomException, short>()
                .Protect(data.IntInputWithValue1).Against.Negative<MyCustomException, int>()
                .Protect(data.LongInputWithValue1).Against.Negative<MyCustomException, long>()
                .Protect(data.DecimalInputWithValue1).Against.Negative<MyCustomException, decimal>()
                .Protect(data.FloatInputWithValue1).Against.Negative<MyCustomException, float>()
                .Protect(data.DoubleInputWithValue1).Against.Negative<MyCustomException, double>()
                .Protect(data.EnumInputWithValueTwo).Against.Negative<MyCustomException, MyTestEnum>();
        }

        [Fact]
        public void DoesNothingGivenZeroValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue0).Against.Negative<MyCustomException, short>()
                .Protect(data.IntInputWithValue0).Against.Negative<MyCustomException, int>()
                .Protect(data.LongInputWithValue0).Against.Negative<MyCustomException, long>()
                .Protect(data.DecimalInputWithValue0).Against.Negative<MyCustomException, decimal>()
                .Protect(data.FloatInputWithValue0).Against.Negative<MyCustomException, float>()
                .Protect(data.DoubleInputWithValue0).Against.Negative<MyCustomException, double>()
                .Protect(data.EnumInputWithValueZero).Against.Negative<MyCustomException, MyTestEnum>();
        }

        [Fact]
        public void PreservesInputGivenPositiveValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Negative<MyCustomException, short>().Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Negative<MyCustomException, int>().Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Negative<MyCustomException, long>().Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Negative<MyCustomException, decimal>().Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Negative<MyCustomException, float>().Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Negative<MyCustomException, double>().Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Negative<MyCustomException, MyTestEnum>().Input);
        }

        [Fact]
        public void PreservesInputGivenZeroValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue0, Guard.Protect(data.ShortInputWithValue0).Against.Negative<MyCustomException, short>().Input);
            Assert.Equal(data.IntInputWithValue0, Guard.Protect(data.IntInputWithValue0).Against.Negative<MyCustomException, int>().Input);
            Assert.Equal(data.LongInputWithValue0, Guard.Protect(data.LongInputWithValue0).Against.Negative<MyCustomException, long>().Input);
            Assert.Equal(data.DecimalInputWithValue0, Guard.Protect(data.DecimalInputWithValue0).Against.Negative<MyCustomException, decimal>().Input);
            Assert.Equal(data.FloatInputWithValue0, Guard.Protect(data.FloatInputWithValue0).Against.Negative<MyCustomException, float>().Input);
            Assert.Equal(data.DoubleInputWithValue0, Guard.Protect(data.DoubleInputWithValue0).Against.Negative<MyCustomException, double>().Input);
            Assert.Equal(data.EnumInputWithValueZero, Guard.Protect(data.EnumInputWithValueZero).Against.Negative<MyCustomException, MyTestEnum>().Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenPositiveValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.Negative<MyCustomException, short>().InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.Negative<MyCustomException, int>().InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Negative<MyCustomException, long>().InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Negative<MyCustomException, decimal>().InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.Negative<MyCustomException, float>().InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Negative<MyCustomException, double>().InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.Negative<MyCustomException, MyTestEnum>().InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenZeroValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue0), Guard.Protect(data.ShortInputWithValue0, nameof(data.ShortInputWithValue0)).Against.Negative<MyCustomException, short>().InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue0), Guard.Protect(data.IntInputWithValue0, nameof(data.IntInputWithValue0)).Against.Negative<MyCustomException, int>().InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue0), Guard.Protect(data.LongInputWithValue0, nameof(data.LongInputWithValue0)).Against.Negative<MyCustomException, long>().InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue0), Guard.Protect(data.DecimalInputWithValue0, nameof(data.DecimalInputWithValue0)).Against.Negative<MyCustomException, decimal>().InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue0), Guard.Protect(data.FloatInputWithValue0, nameof(data.FloatInputWithValue0)).Against.Negative<MyCustomException, float>().InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue0), Guard.Protect(data.DoubleInputWithValue0, nameof(data.DoubleInputWithValue0)).Against.Negative<MyCustomException, double>().InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueZero), Guard.Protect(data.EnumInputWithValueZero, nameof(data.EnumInputWithValueZero)).Against.Negative<MyCustomException, MyTestEnum>().InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenNegativeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValueMinus1).Against.Negative<MyCustomException, short>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValueMinus1).Against.Negative<MyCustomException, int>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValueMinus1).Against.Negative<MyCustomException, long>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValueMinus1).Against.Negative<MyCustomException, decimal>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValueMinus1).Against.Negative<MyCustomException, float>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValueMinus1).Against.Negative<MyCustomException, double>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueMinusOne).Against.Negative<MyCustomException, MyTestEnum>());
        }

        #endregion

        #region custom exception type as TException with constructor args

        [Fact]
        public void DoesNothingGivenPositiveValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.Negative<MyCustomException, short>("ags1")
                .Protect(data.IntInputWithValue1).Against.Negative<MyCustomException, int>("ags1")
                .Protect(data.LongInputWithValue1).Against.Negative<MyCustomException, long>("ags1")
                .Protect(data.DecimalInputWithValue1).Against.Negative<MyCustomException, decimal>("ags1")
                .Protect(data.FloatInputWithValue1).Against.Negative<MyCustomException, float>("ags1")
                .Protect(data.DoubleInputWithValue1).Against.Negative<MyCustomException, double>("ags1")
                .Protect(data.EnumInputWithValueTwo).Against.Negative<MyCustomException, MyTestEnum>("ags1");
        }

        [Fact]
        public void DoesNothingGivenZeroValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue0).Against.Negative<MyCustomException, short>("ags1")
                .Protect(data.IntInputWithValue0).Against.Negative<MyCustomException, int>("ags1")
                .Protect(data.LongInputWithValue0).Against.Negative<MyCustomException, long>("ags1")
                .Protect(data.DecimalInputWithValue0).Against.Negative<MyCustomException, decimal>("ags1")
                .Protect(data.FloatInputWithValue0).Against.Negative<MyCustomException, float>("ags1")
                .Protect(data.DoubleInputWithValue0).Against.Negative<MyCustomException, double>("ags1")
                .Protect(data.EnumInputWithValueZero).Against.Negative<MyCustomException, MyTestEnum>("ags1");
        }

        [Fact]
        public void PreservesInputGivenPositiveValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Negative<MyCustomException, short>("ags1").Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Negative<MyCustomException, int>("ags1").Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Negative<MyCustomException, long>("ags1").Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Negative<MyCustomException, decimal>("ags1").Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Negative<MyCustomException, float>("ags1").Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Negative<MyCustomException, double>("ags1").Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Negative<MyCustomException, MyTestEnum>("ags1").Input);
        }

        [Fact]
        public void PreservesInputGivenZeroValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue0, Guard.Protect(data.ShortInputWithValue0).Against.Negative<MyCustomException, short>("ags1").Input);
            Assert.Equal(data.IntInputWithValue0, Guard.Protect(data.IntInputWithValue0).Against.Negative<MyCustomException, int>("ags1").Input);
            Assert.Equal(data.LongInputWithValue0, Guard.Protect(data.LongInputWithValue0).Against.Negative<MyCustomException, long>("ags1").Input);
            Assert.Equal(data.DecimalInputWithValue0, Guard.Protect(data.DecimalInputWithValue0).Against.Negative<MyCustomException, decimal>("ags1").Input);
            Assert.Equal(data.FloatInputWithValue0, Guard.Protect(data.FloatInputWithValue0).Against.Negative<MyCustomException, float>("ags1").Input);
            Assert.Equal(data.DoubleInputWithValue0, Guard.Protect(data.DoubleInputWithValue0).Against.Negative<MyCustomException, double>("ags1").Input);
            Assert.Equal(data.EnumInputWithValueZero, Guard.Protect(data.EnumInputWithValueZero).Against.Negative<MyCustomException, MyTestEnum>("ags1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenPositiveValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.Negative<MyCustomException, short>("ags1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.Negative<MyCustomException, int>("ags1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Negative<MyCustomException, long>("ags1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Negative<MyCustomException, decimal>("ags1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.Negative<MyCustomException, float>("ags1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Negative<MyCustomException, double>("ags1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.Negative<MyCustomException, MyTestEnum>("ags1").InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenZeroValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue0), Guard.Protect(data.ShortInputWithValue0, nameof(data.ShortInputWithValue0)).Against.Negative<MyCustomException, short>("ags1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue0), Guard.Protect(data.IntInputWithValue0, nameof(data.IntInputWithValue0)).Against.Negative<MyCustomException, int>("ags1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue0), Guard.Protect(data.LongInputWithValue0, nameof(data.LongInputWithValue0)).Against.Negative<MyCustomException, long>("ags1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue0), Guard.Protect(data.DecimalInputWithValue0, nameof(data.DecimalInputWithValue0)).Against.Negative<MyCustomException, decimal>("ags1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue0), Guard.Protect(data.FloatInputWithValue0, nameof(data.FloatInputWithValue0)).Against.Negative<MyCustomException, float>("ags1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue0), Guard.Protect(data.DoubleInputWithValue0, nameof(data.DoubleInputWithValue0)).Against.Negative<MyCustomException, double>("ags1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueZero), Guard.Protect(data.EnumInputWithValueZero, nameof(data.EnumInputWithValueZero)).Against.Negative<MyCustomException, MyTestEnum>("ags1").InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenNegativeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValueMinus1).Against.Negative<MyCustomException, short>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValueMinus1).Against.Negative<MyCustomException, int>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValueMinus1).Against.Negative<MyCustomException, long>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValueMinus1).Against.Negative<MyCustomException, decimal>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValueMinus1).Against.Negative<MyCustomException, float>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValueMinus1).Against.Negative<MyCustomException, double>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueMinusOne).Against.Negative<MyCustomException, MyTestEnum>("ags1"));
        }

        #endregion

        #region custom exception type as parameter

        [Fact]
        public void DoesNothingGivenPositiveValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.Negative<short>(typeof(MyCustomException))
                .Protect(data.IntInputWithValue1).Against.Negative<int>(typeof(MyCustomException))
                .Protect(data.LongInputWithValue1).Against.Negative<long>(typeof(MyCustomException))
                .Protect(data.DecimalInputWithValue1).Against.Negative<decimal>(typeof(MyCustomException))
                .Protect(data.FloatInputWithValue1).Against.Negative<float>(typeof(MyCustomException))
                .Protect(data.DoubleInputWithValue1).Against.Negative<double>(typeof(MyCustomException))
                .Protect(data.EnumInputWithValueTwo).Against.Negative<MyTestEnum>(typeof(MyCustomException));
        }

        [Fact]
        public void DoesNothingGivenZeroValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue0).Against.Negative<short>(typeof(MyCustomException))
                .Protect(data.IntInputWithValue0).Against.Negative<int>(typeof(MyCustomException))
                .Protect(data.LongInputWithValue0).Against.Negative<long>(typeof(MyCustomException))
                .Protect(data.DecimalInputWithValue0).Against.Negative<decimal>(typeof(MyCustomException))
                .Protect(data.FloatInputWithValue0).Against.Negative<float>(typeof(MyCustomException))
                .Protect(data.DoubleInputWithValue0).Against.Negative<double>(typeof(MyCustomException))
                .Protect(data.EnumInputWithValueZero).Against.Negative<MyTestEnum>(typeof(MyCustomException));
        }

        [Fact]
        public void PreservesInputGivenPositiveValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Negative<short>(typeof(MyCustomException)).Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Negative<int>(typeof(MyCustomException)).Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Negative<long>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Negative<decimal>(typeof(MyCustomException)).Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Negative<float>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Negative<double>(typeof(MyCustomException)).Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Negative<MyTestEnum>(typeof(MyCustomException)).Input);
        }

        [Fact]
        public void PreservesInputGivenZeroValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue0, Guard.Protect(data.ShortInputWithValue0).Against.Negative<short>(typeof(MyCustomException)).Input);
            Assert.Equal(data.IntInputWithValue0, Guard.Protect(data.IntInputWithValue0).Against.Negative<int>(typeof(MyCustomException)).Input);
            Assert.Equal(data.LongInputWithValue0, Guard.Protect(data.LongInputWithValue0).Against.Negative<long>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DecimalInputWithValue0, Guard.Protect(data.DecimalInputWithValue0).Against.Negative<decimal>(typeof(MyCustomException)).Input);
            Assert.Equal(data.FloatInputWithValue0, Guard.Protect(data.FloatInputWithValue0).Against.Negative<float>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DoubleInputWithValue0, Guard.Protect(data.DoubleInputWithValue0).Against.Negative<double>(typeof(MyCustomException)).Input);
            Assert.Equal(data.EnumInputWithValueZero, Guard.Protect(data.EnumInputWithValueZero).Against.Negative<MyTestEnum>(typeof(MyCustomException)).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenPositiveValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.Negative<short>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.Negative<int>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Negative<long>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Negative<decimal>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.Negative<float>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Negative<double>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.Negative<MyTestEnum>(typeof(MyCustomException)).InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenZeroValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue0), Guard.Protect(data.ShortInputWithValue0, nameof(data.ShortInputWithValue0)).Against.Negative<short>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue0), Guard.Protect(data.IntInputWithValue0, nameof(data.IntInputWithValue0)).Against.Negative<int>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue0), Guard.Protect(data.LongInputWithValue0, nameof(data.LongInputWithValue0)).Against.Negative<long>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue0), Guard.Protect(data.DecimalInputWithValue0, nameof(data.DecimalInputWithValue0)).Against.Negative<decimal>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue0), Guard.Protect(data.FloatInputWithValue0, nameof(data.FloatInputWithValue0)).Against.Negative<float>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue0), Guard.Protect(data.DoubleInputWithValue0, nameof(data.DoubleInputWithValue0)).Against.Negative<double>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueZero), Guard.Protect(data.EnumInputWithValueZero, nameof(data.EnumInputWithValueZero)).Against.Negative<MyTestEnum>(typeof(MyCustomException)).InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenNegativeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValueMinus1).Against.Negative<short>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValueMinus1).Against.Negative<int>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValueMinus1).Against.Negative<long>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValueMinus1).Against.Negative<decimal>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValueMinus1).Against.Negative<float>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValueMinus1).Against.Negative<double>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueMinusOne).Against.Negative<MyTestEnum>(typeof(MyCustomException)));
        }

        #endregion

        #region custom exception type as parameter with constructor args

        [Fact]
        public void DoesNothingGivenPositiveValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.Negative<short>(typeof(MyCustomException),"args1")
                .Protect(data.IntInputWithValue1).Against.Negative<int>(typeof(MyCustomException), "args1")
                .Protect(data.LongInputWithValue1).Against.Negative<long>(typeof(MyCustomException), "args1")
                .Protect(data.DecimalInputWithValue1).Against.Negative<decimal>(typeof(MyCustomException), "args1")
                .Protect(data.FloatInputWithValue1).Against.Negative<float>(typeof(MyCustomException), "args1")
                .Protect(data.DoubleInputWithValue1).Against.Negative<double>(typeof(MyCustomException), "args1")
                .Protect(data.EnumInputWithValueTwo).Against.Negative<MyTestEnum>(typeof(MyCustomException), "args1");
        }

        [Fact]
        public void DoesNothingGivenZeroValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue0).Against.Negative<short>(typeof(MyCustomException), "args1")
                .Protect(data.IntInputWithValue0).Against.Negative<int>(typeof(MyCustomException), "args1")
                .Protect(data.LongInputWithValue0).Against.Negative<long>(typeof(MyCustomException), "args1")
                .Protect(data.DecimalInputWithValue0).Against.Negative<decimal>(typeof(MyCustomException), "args1")
                .Protect(data.FloatInputWithValue0).Against.Negative<float>(typeof(MyCustomException), "args1")
                .Protect(data.DoubleInputWithValue0).Against.Negative<double>(typeof(MyCustomException), "args1")
                .Protect(data.EnumInputWithValueZero).Against.Negative<MyTestEnum>(typeof(MyCustomException), "args1");
        }

        [Fact]
        public void PreservesInputGivenPositiveValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Negative<short>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Negative<int>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Negative<long>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Negative<decimal>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Negative<float>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Negative<double>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Negative<MyTestEnum>(typeof(MyCustomException), "args1").Input);
        }

        [Fact]
        public void PreservesInputGivenZeroValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue0, Guard.Protect(data.ShortInputWithValue0).Against.Negative<short>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.IntInputWithValue0, Guard.Protect(data.IntInputWithValue0).Against.Negative<int>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.LongInputWithValue0, Guard.Protect(data.LongInputWithValue0).Against.Negative<long>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DecimalInputWithValue0, Guard.Protect(data.DecimalInputWithValue0).Against.Negative<decimal>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.FloatInputWithValue0, Guard.Protect(data.FloatInputWithValue0).Against.Negative<float>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DoubleInputWithValue0, Guard.Protect(data.DoubleInputWithValue0).Against.Negative<double>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.EnumInputWithValueZero, Guard.Protect(data.EnumInputWithValueZero).Against.Negative<MyTestEnum>(typeof(MyCustomException), "args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenPositiveValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.Negative<short>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.Negative<int>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Negative<long>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Negative<decimal>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.Negative<float>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Negative<double>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.Negative<MyTestEnum>(typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenZeroValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue0), Guard.Protect(data.ShortInputWithValue0, nameof(data.ShortInputWithValue0)).Against.Negative<short>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue0), Guard.Protect(data.IntInputWithValue0, nameof(data.IntInputWithValue0)).Against.Negative<int>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue0), Guard.Protect(data.LongInputWithValue0, nameof(data.LongInputWithValue0)).Against.Negative<long>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue0), Guard.Protect(data.DecimalInputWithValue0, nameof(data.DecimalInputWithValue0)).Against.Negative<decimal>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue0), Guard.Protect(data.FloatInputWithValue0, nameof(data.FloatInputWithValue0)).Against.Negative<float>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue0), Guard.Protect(data.DoubleInputWithValue0, nameof(data.DoubleInputWithValue0)).Against.Negative<double>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueZero), Guard.Protect(data.EnumInputWithValueZero, nameof(data.EnumInputWithValueZero)).Against.Negative<MyTestEnum>(typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenNegativeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValueMinus1).Against.Negative<short>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValueMinus1).Against.Negative<int>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValueMinus1).Against.Negative<long>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValueMinus1).Against.Negative<decimal>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValueMinus1).Against.Negative<float>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValueMinus1).Against.Negative<double>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueMinusOne).Against.Negative<MyTestEnum>(typeof(MyCustomException), "args1"));
        }

        #endregion

    }
}
