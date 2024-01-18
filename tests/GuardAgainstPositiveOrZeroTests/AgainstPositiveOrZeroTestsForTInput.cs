using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using Xunit;

namespace GuardChain.Tests.GuardAgainstPositiveOrZeroTests
{
    public class AgainstPositiveOrZeroTestsForTInput
    {
        #region no custom exception

        [Fact]
        public void DoesNothingGivenNegativeValue()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValueMinus1).Against.PositiveOrZero<short>()
                .Protect(data.IntInputWithValueMinus1).Against.PositiveOrZero<int>()
                .Protect(data.LongInputWithValueMinus1).Against.PositiveOrZero<long>()
                .Protect(data.DecimalInputWithValueMinus1).Against.PositiveOrZero<decimal>()
                .Protect(data.FloatInputWithValueMinus1).Against.PositiveOrZero<float>()
                .Protect(data.DoubleInputWithValueMinus1).Against.PositiveOrZero<double>()
                .Protect(data.EnumInputWithValueMinusOne).Against.PositiveOrZero<MyTestEnum>();
        }


        [Fact]
        public void PreservesInputGivenNegativeValue()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.PositiveOrZero<short>().Input);
            Assert.Equal(data.IntInputWithValueMinus1, Guard.Protect(data.IntInputWithValueMinus1).Against.PositiveOrZero<int>().Input);
            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.PositiveOrZero<long>().Input);
            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.PositiveOrZero<decimal>().Input);
            Assert.Equal(data.FloatInputWithValueMinus1, Guard.Protect(data.FloatInputWithValueMinus1).Against.PositiveOrZero<float>().Input);
            Assert.Equal(data.DoubleInputWithValueMinus1, Guard.Protect(data.DoubleInputWithValueMinus1).Against.PositiveOrZero<double>().Input);
            Assert.Equal(data.EnumInputWithValueMinusOne, Guard.Protect(data.EnumInputWithValueMinusOne).Against.PositiveOrZero<MyTestEnum>().Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNegativeValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.PositiveOrZero<short>().InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValueMinus1), Guard.Protect(data.IntInputWithValueMinus1, nameof(data.IntInputWithValueMinus1)).Against.PositiveOrZero<int>().InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.PositiveOrZero<long>().InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.PositiveOrZero<decimal>().InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValueMinus1), Guard.Protect(data.FloatInputWithValueMinus1, nameof(data.FloatInputWithValueMinus1)).Against.PositiveOrZero<float>().InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValueMinus1), Guard.Protect(data.DoubleInputWithValueMinus1, nameof(data.DoubleInputWithValueMinus1)).Against.PositiveOrZero<double>().InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueMinusOne), Guard.Protect(data.EnumInputWithValueMinusOne, nameof(data.EnumInputWithValueMinusOne)).Against.PositiveOrZero<MyTestEnum>().InputParameterName);
        }


        [Fact]
        public void ThrowsArgumentExceptionGivenPositiveValue()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.ShortInputWithValue1).Against.PositiveOrZero<short>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.IntInputWithValue1).Against.PositiveOrZero<int>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.LongInputWithValue1).Against.PositiveOrZero<long>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DecimalInputWithValue1).Against.PositiveOrZero<decimal>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.FloatInputWithValue1).Against.PositiveOrZero<float>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DoubleInputWithValue1).Against.PositiveOrZero<double>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.PositiveOrZero<MyTestEnum>());
        }


        [Fact]
        public void ThrowsArgumentExceptionGivenZeroValue()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.ShortInputWithValue0).Against.PositiveOrZero<short>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.IntInputWithValue0).Against.PositiveOrZero<int>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.LongInputWithValue0).Against.PositiveOrZero<long>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.PositiveOrZero<decimal>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.FloatInputWithValue0).Against.PositiveOrZero<float>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DoubleInputWithValue0).Against.PositiveOrZero<double>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.EnumInputWithValueZero).Against.PositiveOrZero<MyTestEnum>());
        }

        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, short>()
                .Protect(data.IntInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, int>()
                .Protect(data.LongInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, long>()
                .Protect(data.DecimalInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, decimal>()
                .Protect(data.FloatInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, float>()
                .Protect(data.DoubleInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, double>()
                .Protect(data.EnumInputWithValueMinusOne).Against.PositiveOrZero<MyCustomException, MyTestEnum>();
        }


        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, short>().Input);
            Assert.Equal(data.IntInputWithValueMinus1, Guard.Protect(data.IntInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, int>().Input);
            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, long>().Input);
            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, decimal>().Input);
            Assert.Equal(data.FloatInputWithValueMinus1, Guard.Protect(data.FloatInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, float>().Input);
            Assert.Equal(data.DoubleInputWithValueMinus1, Guard.Protect(data.DoubleInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, double>().Input);
            Assert.Equal(data.EnumInputWithValueMinusOne, Guard.Protect(data.EnumInputWithValueMinusOne).Against.PositiveOrZero<MyCustomException, MyTestEnum>().Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.PositiveOrZero<MyCustomException, short>().InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValueMinus1), Guard.Protect(data.IntInputWithValueMinus1, nameof(data.IntInputWithValueMinus1)).Against.PositiveOrZero<MyCustomException, int>().InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.PositiveOrZero<MyCustomException, long>().InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.PositiveOrZero<MyCustomException, decimal>().InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValueMinus1), Guard.Protect(data.FloatInputWithValueMinus1, nameof(data.FloatInputWithValueMinus1)).Against.PositiveOrZero<MyCustomException, float>().InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValueMinus1), Guard.Protect(data.DoubleInputWithValueMinus1, nameof(data.DoubleInputWithValueMinus1)).Against.PositiveOrZero<MyCustomException, double>().InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueMinusOne), Guard.Protect(data.EnumInputWithValueMinusOne, nameof(data.EnumInputWithValueMinusOne)).Against.PositiveOrZero<MyCustomException, MyTestEnum>().InputParameterName);
        }


        [Fact]
        public void ThrowsCustomExceptionGivenPositiveValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue1).Against.PositiveOrZero<MyCustomException, short>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue1).Against.PositiveOrZero<MyCustomException, int>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.PositiveOrZero<MyCustomException, long>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue1).Against.PositiveOrZero<MyCustomException, decimal>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.PositiveOrZero<MyCustomException, float>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue1).Against.PositiveOrZero<MyCustomException, double>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.PositiveOrZero<MyCustomException, MyTestEnum>());
        }

        [Fact]
        public void ThrowsCustomExceptionGivenZeroValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue0).Against.PositiveOrZero<MyCustomException, short>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue0).Against.PositiveOrZero<MyCustomException, int>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue0).Against.PositiveOrZero<MyCustomException, long>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.PositiveOrZero<MyCustomException, decimal>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue0).Against.PositiveOrZero<MyCustomException, float>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue0).Against.PositiveOrZero<MyCustomException, double>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueZero).Against.PositiveOrZero<MyCustomException, MyTestEnum>());
        }

        #endregion

        #region custom exception type as TException with constructor args

        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, short>("ags1")
                .Protect(data.IntInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, int>("ags1")
                .Protect(data.LongInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, long>("ags1")
                .Protect(data.DecimalInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, decimal>("ags1")
                .Protect(data.FloatInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, float>("ags1")
                .Protect(data.DoubleInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, double>("ags1")
                .Protect(data.EnumInputWithValueMinusOne).Against.PositiveOrZero<MyCustomException, MyTestEnum>("ags1");
        }


        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, short>("ags1").Input);
            Assert.Equal(data.IntInputWithValueMinus1, Guard.Protect(data.IntInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, int>("ags1").Input);
            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, long>("ags1").Input);
            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, decimal>("ags1").Input);
            Assert.Equal(data.FloatInputWithValueMinus1, Guard.Protect(data.FloatInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, float>("ags1").Input);
            Assert.Equal(data.DoubleInputWithValueMinus1, Guard.Protect(data.DoubleInputWithValueMinus1).Against.PositiveOrZero<MyCustomException, double>("ags1").Input);
            Assert.Equal(data.EnumInputWithValueMinusOne, Guard.Protect(data.EnumInputWithValueMinusOne).Against.PositiveOrZero<MyCustomException, MyTestEnum>("ags1").Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.PositiveOrZero<MyCustomException, short>("ags1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValueMinus1), Guard.Protect(data.IntInputWithValueMinus1, nameof(data.IntInputWithValueMinus1)).Against.PositiveOrZero<MyCustomException, int>("ags1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.PositiveOrZero<MyCustomException, long>("ags1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.PositiveOrZero<MyCustomException, decimal>("ags1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValueMinus1), Guard.Protect(data.FloatInputWithValueMinus1, nameof(data.FloatInputWithValueMinus1)).Against.PositiveOrZero<MyCustomException, float>("ags1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValueMinus1), Guard.Protect(data.DoubleInputWithValueMinus1, nameof(data.DoubleInputWithValueMinus1)).Against.PositiveOrZero<MyCustomException, double>("ags1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueMinusOne), Guard.Protect(data.EnumInputWithValueMinusOne, nameof(data.EnumInputWithValueMinusOne)).Against.PositiveOrZero<MyCustomException, MyTestEnum>("ags1").InputParameterName);
        }


        [Fact]
        public void ThrowsCustomExceptionGivenPositiveValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue1).Against.PositiveOrZero<MyCustomException, short>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue1).Against.PositiveOrZero<MyCustomException, int>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.PositiveOrZero<MyCustomException, long>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue1).Against.PositiveOrZero<MyCustomException, decimal>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.PositiveOrZero<MyCustomException, float>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue1).Against.PositiveOrZero<MyCustomException, double>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.PositiveOrZero<MyCustomException, MyTestEnum>("ags1"));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenZeroValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue0).Against.PositiveOrZero<MyCustomException, short>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue0).Against.PositiveOrZero<MyCustomException, int>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue0).Against.PositiveOrZero<MyCustomException, long>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.PositiveOrZero<MyCustomException, decimal>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue0).Against.PositiveOrZero<MyCustomException, float>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue0).Against.PositiveOrZero<MyCustomException, double>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueZero).Against.PositiveOrZero<MyCustomException, MyTestEnum>("ags1"));
        }

        #endregion

        #region custom exception type as parameter

        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValueMinus1).Against.PositiveOrZero<short>(typeof(MyCustomException))
                .Protect(data.IntInputWithValueMinus1).Against.PositiveOrZero<int>(typeof(MyCustomException))
                .Protect(data.LongInputWithValueMinus1).Against.PositiveOrZero<long>(typeof(MyCustomException))
                .Protect(data.DecimalInputWithValueMinus1).Against.PositiveOrZero<decimal>(typeof(MyCustomException))
                .Protect(data.FloatInputWithValueMinus1).Against.PositiveOrZero<float>(typeof(MyCustomException))
                .Protect(data.DoubleInputWithValueMinus1).Against.PositiveOrZero<double>(typeof(MyCustomException))
                .Protect(data.EnumInputWithValueMinusOne).Against.PositiveOrZero<MyTestEnum>(typeof(MyCustomException));
        }


        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.PositiveOrZero<short>(typeof(MyCustomException)).Input);
            Assert.Equal(data.IntInputWithValueMinus1, Guard.Protect(data.IntInputWithValueMinus1).Against.PositiveOrZero<int>(typeof(MyCustomException)).Input);
            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.PositiveOrZero<long>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.PositiveOrZero<decimal>(typeof(MyCustomException)).Input);
            Assert.Equal(data.FloatInputWithValueMinus1, Guard.Protect(data.FloatInputWithValueMinus1).Against.PositiveOrZero<float>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DoubleInputWithValueMinus1, Guard.Protect(data.DoubleInputWithValueMinus1).Against.PositiveOrZero<double>(typeof(MyCustomException)).Input);
            Assert.Equal(data.EnumInputWithValueMinusOne, Guard.Protect(data.EnumInputWithValueMinusOne).Against.PositiveOrZero<MyTestEnum>(typeof(MyCustomException)).Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.PositiveOrZero<short>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValueMinus1), Guard.Protect(data.IntInputWithValueMinus1, nameof(data.IntInputWithValueMinus1)).Against.PositiveOrZero<int>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.PositiveOrZero<long>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.PositiveOrZero<decimal>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValueMinus1), Guard.Protect(data.FloatInputWithValueMinus1, nameof(data.FloatInputWithValueMinus1)).Against.PositiveOrZero<float>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValueMinus1), Guard.Protect(data.DoubleInputWithValueMinus1, nameof(data.DoubleInputWithValueMinus1)).Against.PositiveOrZero<double>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueMinusOne), Guard.Protect(data.EnumInputWithValueMinusOne, nameof(data.EnumInputWithValueMinusOne)).Against.PositiveOrZero<MyTestEnum>(typeof(MyCustomException)).InputParameterName);
        }


        [Fact]
        public void ThrowsCustomExceptionGivenPositiveValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue1).Against.PositiveOrZero<short>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue1).Against.PositiveOrZero<int>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.PositiveOrZero<long>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue1).Against.PositiveOrZero<decimal>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.PositiveOrZero<float>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue1).Against.PositiveOrZero<double>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.PositiveOrZero<MyTestEnum>(typeof(MyCustomException)));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenZeroValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue0).Against.PositiveOrZero<short>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue0).Against.PositiveOrZero<int>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue0).Against.PositiveOrZero<long>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.PositiveOrZero<decimal>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue0).Against.PositiveOrZero<float>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue0).Against.PositiveOrZero<double>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueZero).Against.PositiveOrZero<MyTestEnum>(typeof(MyCustomException)));
        }

        #endregion

        #region custom exception type as parameter with constructor args

        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValueMinus1).Against.PositiveOrZero<short>(typeof(MyCustomException), "args1")
                .Protect(data.IntInputWithValueMinus1).Against.PositiveOrZero<int>(typeof(MyCustomException), "args1")
                .Protect(data.LongInputWithValueMinus1).Against.PositiveOrZero<long>(typeof(MyCustomException), "args1")
                .Protect(data.DecimalInputWithValueMinus1).Against.PositiveOrZero<decimal>(typeof(MyCustomException), "args1")
                .Protect(data.FloatInputWithValueMinus1).Against.PositiveOrZero<float>(typeof(MyCustomException), "args1")
                .Protect(data.DoubleInputWithValueMinus1).Against.PositiveOrZero<double>(typeof(MyCustomException), "args1")
                .Protect(data.EnumInputWithValueMinusOne).Against.PositiveOrZero<MyTestEnum>(typeof(MyCustomException), "args1");
        }


        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.PositiveOrZero<short>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.IntInputWithValueMinus1, Guard.Protect(data.IntInputWithValueMinus1).Against.PositiveOrZero<int>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.PositiveOrZero<long>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.PositiveOrZero<decimal>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.FloatInputWithValueMinus1, Guard.Protect(data.FloatInputWithValueMinus1).Against.PositiveOrZero<float>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DoubleInputWithValueMinus1, Guard.Protect(data.DoubleInputWithValueMinus1).Against.PositiveOrZero<double>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.EnumInputWithValueMinusOne, Guard.Protect(data.EnumInputWithValueMinusOne).Against.PositiveOrZero<MyTestEnum>(typeof(MyCustomException), "args1").Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.PositiveOrZero<short>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValueMinus1), Guard.Protect(data.IntInputWithValueMinus1, nameof(data.IntInputWithValueMinus1)).Against.PositiveOrZero<int>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.PositiveOrZero<long>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.PositiveOrZero<decimal>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValueMinus1), Guard.Protect(data.FloatInputWithValueMinus1, nameof(data.FloatInputWithValueMinus1)).Against.PositiveOrZero<float>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValueMinus1), Guard.Protect(data.DoubleInputWithValueMinus1, nameof(data.DoubleInputWithValueMinus1)).Against.PositiveOrZero<double>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueMinusOne), Guard.Protect(data.EnumInputWithValueMinusOne, nameof(data.EnumInputWithValueMinusOne)).Against.PositiveOrZero<MyTestEnum>(typeof(MyCustomException), "args1").InputParameterName);
        }


        [Fact]
        public void ThrowsCustomExceptionGivenPositiveValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue1).Against.PositiveOrZero<short>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue1).Against.PositiveOrZero<int>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.PositiveOrZero<long>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue1).Against.PositiveOrZero<decimal>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.PositiveOrZero<float>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue1).Against.PositiveOrZero<double>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.PositiveOrZero<MyTestEnum>(typeof(MyCustomException), "args1"));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenZeroValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue0).Against.PositiveOrZero<short>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue0).Against.PositiveOrZero<int>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue0).Against.PositiveOrZero<long>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.PositiveOrZero<decimal>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue0).Against.PositiveOrZero<float>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue0).Against.PositiveOrZero<double>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueZero).Against.PositiveOrZero<MyTestEnum>(typeof(MyCustomException), "args1"));
        }

        #endregion
    }
}
