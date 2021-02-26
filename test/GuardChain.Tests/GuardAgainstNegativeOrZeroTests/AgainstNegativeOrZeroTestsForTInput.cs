using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using Xunit;

namespace GuardChain.Tests.GuardAgainstNegativeOrZeroTests
{
    public class AgainstNegativeOrZeroTestsForTInput
    {
        #region no custom exception

        [Fact]
        public void DoesNothingGivenPositiveValue()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.NegativeOrZero<short>()
                .Protect(data.IntInputWithValue1).Against.NegativeOrZero<int>()
                .Protect(data.LongInputWithValue1).Against.NegativeOrZero<long>()
                .Protect(data.DecimalInputWithValue1).Against.NegativeOrZero<decimal>()
                .Protect(data.FloatInputWithValue1).Against.NegativeOrZero<float>()
                .Protect(data.DoubleInputWithValue1).Against.NegativeOrZero<double>()
                .Protect(data.EnumInputWithValueTwo).Against.NegativeOrZero<MyTestEnum>();
        }


        [Fact]
        public void PreservesInputGivenPositiveValue()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.NegativeOrZero<short>().Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.NegativeOrZero<int>().Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.NegativeOrZero<long>().Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.NegativeOrZero<decimal>().Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.NegativeOrZero<float>().Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.NegativeOrZero<double>().Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.NegativeOrZero<MyTestEnum>().Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenPositiveValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.NegativeOrZero<short>().InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.NegativeOrZero<int>().InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.NegativeOrZero<long>().InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.NegativeOrZero<decimal>().InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.NegativeOrZero<float>().InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.NegativeOrZero<double>().InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.NegativeOrZero<MyTestEnum>().InputParameterName);
        }


        [Fact]
        public void ThrowsArgumentExceptionGivenNegativeValue()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.ShortInputWithValueMinus1).Against.NegativeOrZero<short>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.IntInputWithValueMinus1).Against.NegativeOrZero<int>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.LongInputWithValueMinus1).Against.NegativeOrZero<long>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DecimalInputWithValueMinus1).Against.NegativeOrZero<decimal>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.FloatInputWithValueMinus1).Against.NegativeOrZero<float>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DoubleInputWithValueMinus1).Against.NegativeOrZero<double>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.EnumInputWithValueMinusOne).Against.NegativeOrZero<MyTestEnum>());
        }


        [Fact]
        public void ThrowsArgumentExceptionGivenZeroValue()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.ShortInputWithValue0).Against.NegativeOrZero<short>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.IntInputWithValue0).Against.NegativeOrZero<int>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.LongInputWithValue0).Against.NegativeOrZero<long>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.NegativeOrZero<decimal>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.FloatInputWithValue0).Against.NegativeOrZero<float>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DoubleInputWithValue0).Against.NegativeOrZero<double>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.EnumInputWithValueZero).Against.NegativeOrZero<MyTestEnum>());
        }

        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenPositiveValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.NegativeOrZero<MyCustomException, short>()
                .Protect(data.IntInputWithValue1).Against.NegativeOrZero<MyCustomException, int>()
                .Protect(data.LongInputWithValue1).Against.NegativeOrZero<MyCustomException, long>()
                .Protect(data.DecimalInputWithValue1).Against.NegativeOrZero<MyCustomException, decimal>()
                .Protect(data.FloatInputWithValue1).Against.NegativeOrZero<MyCustomException, float>()
                .Protect(data.DoubleInputWithValue1).Against.NegativeOrZero<MyCustomException, double>()
                .Protect(data.EnumInputWithValueTwo).Against.NegativeOrZero<MyCustomException, MyTestEnum>();
        }


        [Fact]
        public void PreservesInputGivenPositiveValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.NegativeOrZero<MyCustomException, short>().Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.NegativeOrZero<MyCustomException, int>().Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.NegativeOrZero<MyCustomException, long>().Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.NegativeOrZero<MyCustomException, decimal>().Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.NegativeOrZero<MyCustomException, float>().Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.NegativeOrZero<MyCustomException, double>().Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.NegativeOrZero<MyCustomException, MyTestEnum>().Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenPositiveValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.NegativeOrZero<MyCustomException, short>().InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.NegativeOrZero<MyCustomException, int>().InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.NegativeOrZero<MyCustomException, long>().InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.NegativeOrZero<MyCustomException, decimal>().InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.NegativeOrZero<MyCustomException, float>().InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.NegativeOrZero<MyCustomException, double>().InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.NegativeOrZero<MyCustomException, MyTestEnum>().InputParameterName);
        }


        [Fact]
        public void ThrowsCustomExceptionGivenNegativeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValueMinus1).Against.NegativeOrZero<MyCustomException, short>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValueMinus1).Against.NegativeOrZero<MyCustomException, int>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValueMinus1).Against.NegativeOrZero<MyCustomException, long>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValueMinus1).Against.NegativeOrZero<MyCustomException, decimal>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValueMinus1).Against.NegativeOrZero<MyCustomException, float>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValueMinus1).Against.NegativeOrZero<MyCustomException, double>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueMinusOne).Against.NegativeOrZero<MyCustomException, MyTestEnum>());
        }

        [Fact]
        public void ThrowsCustomExceptionGivenZeroValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue0).Against.NegativeOrZero<MyCustomException, short>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue0).Against.NegativeOrZero<MyCustomException, int>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue0).Against.NegativeOrZero<MyCustomException, long>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.NegativeOrZero<MyCustomException, decimal>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue0).Against.NegativeOrZero<MyCustomException, float>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue0).Against.NegativeOrZero<MyCustomException, double>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueZero).Against.NegativeOrZero<MyCustomException, MyTestEnum>());
        }

        #endregion

        #region custom exception type as TException with constructor args

        [Fact]
        public void DoesNothingGivenPositiveValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.NegativeOrZero<MyCustomException, short>("ags1")
                .Protect(data.IntInputWithValue1).Against.NegativeOrZero<MyCustomException, int>("ags1")
                .Protect(data.LongInputWithValue1).Against.NegativeOrZero<MyCustomException, long>("ags1")
                .Protect(data.DecimalInputWithValue1).Against.NegativeOrZero<MyCustomException, decimal>("ags1")
                .Protect(data.FloatInputWithValue1).Against.NegativeOrZero<MyCustomException, float>("ags1")
                .Protect(data.DoubleInputWithValue1).Against.NegativeOrZero<MyCustomException, double>("ags1")
                .Protect(data.EnumInputWithValueTwo).Against.NegativeOrZero<MyCustomException, MyTestEnum>("ags1");
        }
      

        [Fact]
        public void PreservesInputGivenPositiveValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.NegativeOrZero<MyCustomException, short>("ags1").Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.NegativeOrZero<MyCustomException, int>("ags1").Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.NegativeOrZero<MyCustomException, long>("ags1").Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.NegativeOrZero<MyCustomException, decimal>("ags1").Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.NegativeOrZero<MyCustomException, float>("ags1").Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.NegativeOrZero<MyCustomException, double>("ags1").Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.NegativeOrZero<MyCustomException, MyTestEnum>("ags1").Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenPositiveValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.NegativeOrZero<MyCustomException, short>("ags1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.NegativeOrZero<MyCustomException, int>("ags1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.NegativeOrZero<MyCustomException, long>("ags1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.NegativeOrZero<MyCustomException, decimal>("ags1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.NegativeOrZero<MyCustomException, float>("ags1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.NegativeOrZero<MyCustomException, double>("ags1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.NegativeOrZero<MyCustomException, MyTestEnum>("ags1").InputParameterName);
        }


        [Fact]
        public void ThrowsCustomExceptionGivenNegativeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValueMinus1).Against.NegativeOrZero<MyCustomException, short>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValueMinus1).Against.NegativeOrZero<MyCustomException, int>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValueMinus1).Against.NegativeOrZero<MyCustomException, long>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValueMinus1).Against.NegativeOrZero<MyCustomException, decimal>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValueMinus1).Against.NegativeOrZero<MyCustomException, float>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValueMinus1).Against.NegativeOrZero<MyCustomException, double>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueMinusOne).Against.NegativeOrZero<MyCustomException, MyTestEnum>("ags1"));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenZeroValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue0).Against.NegativeOrZero<MyCustomException, short>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue0).Against.NegativeOrZero<MyCustomException, int>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue0).Against.NegativeOrZero<MyCustomException, long>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.NegativeOrZero<MyCustomException, decimal>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue0).Against.NegativeOrZero<MyCustomException, float>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue0).Against.NegativeOrZero<MyCustomException, double>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueZero).Against.NegativeOrZero<MyCustomException, MyTestEnum>("ags1"));
        }

        #endregion

        #region custom exception type as parameter

        [Fact]
        public void DoesNothingGivenPositiveValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.NegativeOrZero<short>(typeof(MyCustomException))
                .Protect(data.IntInputWithValue1).Against.NegativeOrZero<int>(typeof(MyCustomException))
                .Protect(data.LongInputWithValue1).Against.NegativeOrZero<long>(typeof(MyCustomException))
                .Protect(data.DecimalInputWithValue1).Against.NegativeOrZero<decimal>(typeof(MyCustomException))
                .Protect(data.FloatInputWithValue1).Against.NegativeOrZero<float>(typeof(MyCustomException))
                .Protect(data.DoubleInputWithValue1).Against.NegativeOrZero<double>(typeof(MyCustomException))
                .Protect(data.EnumInputWithValueTwo).Against.NegativeOrZero<MyTestEnum>(typeof(MyCustomException));
        }


        [Fact]
        public void PreservesInputGivenPositiveValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.NegativeOrZero<short>(typeof(MyCustomException)).Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.NegativeOrZero<int>(typeof(MyCustomException)).Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.NegativeOrZero<long>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.NegativeOrZero<decimal>(typeof(MyCustomException)).Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.NegativeOrZero<float>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.NegativeOrZero<double>(typeof(MyCustomException)).Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.NegativeOrZero<MyTestEnum>(typeof(MyCustomException)).Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenPositiveValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.NegativeOrZero<short>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.NegativeOrZero<int>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.NegativeOrZero<long>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.NegativeOrZero<decimal>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.NegativeOrZero<float>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.NegativeOrZero<double>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.NegativeOrZero<MyTestEnum>(typeof(MyCustomException)).InputParameterName);
        }


        [Fact]
        public void ThrowsCustomExceptionGivenNegativeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValueMinus1).Against.NegativeOrZero<short>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValueMinus1).Against.NegativeOrZero<int>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValueMinus1).Against.NegativeOrZero<long>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValueMinus1).Against.NegativeOrZero<decimal>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValueMinus1).Against.NegativeOrZero<float>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValueMinus1).Against.NegativeOrZero<double>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueMinusOne).Against.NegativeOrZero<MyTestEnum>(typeof(MyCustomException)));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenZeroValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue0).Against.NegativeOrZero<short>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue0).Against.NegativeOrZero<int>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue0).Against.NegativeOrZero<long>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.NegativeOrZero<decimal>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue0).Against.NegativeOrZero<float>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue0).Against.NegativeOrZero<double>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueZero).Against.NegativeOrZero<MyTestEnum>(typeof(MyCustomException)));
        }

        #endregion

        #region custom exception type as parameter with constructor args

        [Fact]
        public void DoesNothingGivenPositiveValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.NegativeOrZero<short>(typeof(MyCustomException), "args1")
                .Protect(data.IntInputWithValue1).Against.NegativeOrZero<int>(typeof(MyCustomException), "args1")
                .Protect(data.LongInputWithValue1).Against.NegativeOrZero<long>(typeof(MyCustomException), "args1")
                .Protect(data.DecimalInputWithValue1).Against.NegativeOrZero<decimal>(typeof(MyCustomException), "args1")
                .Protect(data.FloatInputWithValue1).Against.NegativeOrZero<float>(typeof(MyCustomException), "args1")
                .Protect(data.DoubleInputWithValue1).Against.NegativeOrZero<double>(typeof(MyCustomException), "args1")
                .Protect(data.EnumInputWithValueTwo).Against.NegativeOrZero<MyTestEnum>(typeof(MyCustomException), "args1");
        }


        [Fact]
        public void PreservesInputGivenPositiveValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.NegativeOrZero<short>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.NegativeOrZero<int>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.NegativeOrZero<long>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.NegativeOrZero<decimal>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.NegativeOrZero<float>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.NegativeOrZero<double>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.NegativeOrZero<MyTestEnum>(typeof(MyCustomException), "args1").Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenPositiveValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.NegativeOrZero<short>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.NegativeOrZero<int>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.NegativeOrZero<long>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.NegativeOrZero<decimal>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.NegativeOrZero<float>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.NegativeOrZero<double>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.NegativeOrZero<MyTestEnum>(typeof(MyCustomException), "args1").InputParameterName);
        }


        [Fact]
        public void ThrowsCustomExceptionGivenNegativeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValueMinus1).Against.NegativeOrZero<short>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValueMinus1).Against.NegativeOrZero<int>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValueMinus1).Against.NegativeOrZero<long>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValueMinus1).Against.NegativeOrZero<decimal>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValueMinus1).Against.NegativeOrZero<float>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValueMinus1).Against.NegativeOrZero<double>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueMinusOne).Against.NegativeOrZero<MyTestEnum>(typeof(MyCustomException), "args1"));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenZeroValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue0).Against.NegativeOrZero<short>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue0).Against.NegativeOrZero<int>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue0).Against.NegativeOrZero<long>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.NegativeOrZero<decimal>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue0).Against.NegativeOrZero<float>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue0).Against.NegativeOrZero<double>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueZero).Against.NegativeOrZero<MyTestEnum>(typeof(MyCustomException), "args1"));
        }

        #endregion
    }
}
