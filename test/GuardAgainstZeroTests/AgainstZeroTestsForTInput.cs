using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using Xunit;

namespace GuardChain.Tests.GuardAgainstZeroTests
{
    public class AgainstZeroTestsForTInput
    {
        #region no custom exception

        [Fact]
        public void DoesNothingGivenPositiveValue()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.Zero<short>()
                .Protect(data.IntInputWithValue1).Against.Zero<int>()
                .Protect(data.LongInputWithValue1).Against.Zero<long>()
                .Protect(data.DecimalInputWithValue1).Against.Zero<decimal>()
                .Protect(data.FloatInputWithValue1).Against.Zero<float>()
                .Protect(data.DoubleInputWithValue1).Against.Zero<double>()
                .Protect(data.EnumInputWithValueTwo).Against.Zero<MyTestEnum>();
        }


        [Fact]
        public void PreservesInputGivenPositiveValue()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Zero<short>().Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Zero<int>().Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Zero<long>().Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Zero<decimal>().Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Zero<float>().Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Zero<double>().Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Zero<MyTestEnum>().Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenPositiveValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.Zero<short>().InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.Zero<int>().InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Zero<long>().InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Zero<decimal>().InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.Zero<float>().InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Zero<double>().InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.Zero<MyTestEnum>().InputParameterName);
        }

        [Fact]
        public void DoesNothingGivenNegativeValue()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValueMinus1).Against.Zero<short>()
                .Protect(data.IntInputWithValueMinus1).Against.Zero<int>()
                .Protect(data.LongInputWithValueMinus1).Against.Zero<long>()
                .Protect(data.DecimalInputWithValueMinus1).Against.Zero<decimal>()
                .Protect(data.FloatInputWithValueMinus1).Against.Zero<float>()
                .Protect(data.DoubleInputWithValueMinus1).Against.Zero<double>()
                .Protect(data.EnumInputWithValueMinusOne).Against.Zero<MyTestEnum>();
        }


        [Fact]
        public void PreservesInputGivenNegativeValue()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.Zero<short>().Input);
            Assert.Equal(data.IntInputWithValueMinus1, Guard.Protect(data.IntInputWithValueMinus1).Against.Zero<int>().Input);
            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.Zero<long>().Input);
            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.Zero<decimal>().Input);
            Assert.Equal(data.FloatInputWithValueMinus1, Guard.Protect(data.FloatInputWithValueMinus1).Against.Zero<float>().Input);
            Assert.Equal(data.DoubleInputWithValueMinus1, Guard.Protect(data.DoubleInputWithValueMinus1).Against.Zero<double>().Input);
            Assert.Equal(data.EnumInputWithValueMinusOne, Guard.Protect(data.EnumInputWithValueMinusOne).Against.Zero<MyTestEnum>().Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNegativeValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.Zero<short>().InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValueMinus1), Guard.Protect(data.IntInputWithValueMinus1, nameof(data.IntInputWithValueMinus1)).Against.Zero<int>().InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.Zero<long>().InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.Zero<decimal>().InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValueMinus1), Guard.Protect(data.FloatInputWithValueMinus1, nameof(data.FloatInputWithValueMinus1)).Against.Zero<float>().InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValueMinus1), Guard.Protect(data.DoubleInputWithValueMinus1, nameof(data.DoubleInputWithValueMinus1)).Against.Zero<double>().InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueMinusOne), Guard.Protect(data.EnumInputWithValueMinusOne, nameof(data.EnumInputWithValueMinusOne)).Against.Zero<MyTestEnum>().InputParameterName);
        }



        [Fact]
        public void ThrowsArgumentExceptionGivenZeroValue()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.ShortInputWithValue0).Against.Zero<short>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.IntInputWithValue0).Against.Zero<int>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.LongInputWithValue0).Against.Zero<long>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.Zero<decimal>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.FloatInputWithValue0).Against.Zero<float>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DoubleInputWithValue0).Against.Zero<double>());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.EnumInputWithValueZero).Against.Zero<MyTestEnum>());
        }

        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenPositiveValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.Zero<MyCustomException, short>()
                .Protect(data.IntInputWithValue1).Against.Zero<MyCustomException, int>()
                .Protect(data.LongInputWithValue1).Against.Zero<MyCustomException, long>()
                .Protect(data.DecimalInputWithValue1).Against.Zero<MyCustomException, decimal>()
                .Protect(data.FloatInputWithValue1).Against.Zero<MyCustomException, float>()
                .Protect(data.DoubleInputWithValue1).Against.Zero<MyCustomException, double>()
                .Protect(data.EnumInputWithValueTwo).Against.Zero<MyCustomException, MyTestEnum>();
        }


        [Fact]
        public void PreservesInputGivenPositiveValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Zero<MyCustomException, short>().Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Zero<MyCustomException, int>().Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Zero<MyCustomException, long>().Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Zero<MyCustomException, decimal>().Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Zero<MyCustomException, float>().Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Zero<MyCustomException, double>().Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Zero<MyCustomException, MyTestEnum>().Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenPositiveValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.Zero<MyCustomException, short>().InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.Zero<MyCustomException, int>().InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Zero<MyCustomException, long>().InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Zero<MyCustomException, decimal>().InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.Zero<MyCustomException, float>().InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Zero<MyCustomException, double>().InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.Zero<MyCustomException, MyTestEnum>().InputParameterName);
        }


        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValueMinus1).Against.Zero<MyCustomException, short>()
                .Protect(data.IntInputWithValueMinus1).Against.Zero<MyCustomException, int>()
                .Protect(data.LongInputWithValueMinus1).Against.Zero<MyCustomException, long>()
                .Protect(data.DecimalInputWithValueMinus1).Against.Zero<MyCustomException, decimal>()
                .Protect(data.FloatInputWithValueMinus1).Against.Zero<MyCustomException, float>()
                .Protect(data.DoubleInputWithValueMinus1).Against.Zero<MyCustomException, double>()
                .Protect(data.EnumInputWithValueMinusOne).Against.Zero<MyCustomException, MyTestEnum>();
        }


        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.Zero<MyCustomException, short>().Input);
            Assert.Equal(data.IntInputWithValueMinus1, Guard.Protect(data.IntInputWithValueMinus1).Against.Zero<MyCustomException, int>().Input);
            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.Zero<MyCustomException, long>().Input);
            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.Zero<MyCustomException, decimal>().Input);
            Assert.Equal(data.FloatInputWithValueMinus1, Guard.Protect(data.FloatInputWithValueMinus1).Against.Zero<MyCustomException, float>().Input);
            Assert.Equal(data.DoubleInputWithValueMinus1, Guard.Protect(data.DoubleInputWithValueMinus1).Against.Zero<MyCustomException, double>().Input);
            Assert.Equal(data.EnumInputWithValueMinusOne, Guard.Protect(data.EnumInputWithValueMinusOne).Against.Zero<MyCustomException, MyTestEnum>().Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.Zero<MyCustomException, short>().InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValueMinus1), Guard.Protect(data.IntInputWithValueMinus1, nameof(data.IntInputWithValueMinus1)).Against.Zero<MyCustomException, int>().InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.Zero<MyCustomException, long>().InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.Zero<MyCustomException, decimal>().InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValueMinus1), Guard.Protect(data.FloatInputWithValueMinus1, nameof(data.FloatInputWithValueMinus1)).Against.Zero<MyCustomException, float>().InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValueMinus1), Guard.Protect(data.DoubleInputWithValueMinus1, nameof(data.DoubleInputWithValueMinus1)).Against.Zero<MyCustomException, double>().InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueMinusOne), Guard.Protect(data.EnumInputWithValueMinusOne, nameof(data.EnumInputWithValueMinusOne)).Against.Zero<MyCustomException, MyTestEnum>().InputParameterName);
        }


        [Fact]
        public void ThrowsCustomExceptionGivenZeroValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue0).Against.Zero<MyCustomException, short>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue0).Against.Zero<MyCustomException, int>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue0).Against.Zero<MyCustomException, long>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.Zero<MyCustomException, decimal>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue0).Against.Zero<MyCustomException, float>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue0).Against.Zero<MyCustomException, double>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueZero).Against.Zero<MyCustomException, MyTestEnum>());
        }

        #endregion

        #region custom exception type as TException with constructor args

        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValueMinus1).Against.Zero<MyCustomException, short>("ags1")
                .Protect(data.IntInputWithValueMinus1).Against.Zero<MyCustomException, int>("ags1")
                .Protect(data.LongInputWithValueMinus1).Against.Zero<MyCustomException, long>("ags1")
                .Protect(data.DecimalInputWithValueMinus1).Against.Zero<MyCustomException, decimal>("ags1")
                .Protect(data.FloatInputWithValueMinus1).Against.Zero<MyCustomException, float>("ags1")
                .Protect(data.DoubleInputWithValueMinus1).Against.Zero<MyCustomException, double>("ags1")
                .Protect(data.EnumInputWithValueMinusOne).Against.Zero<MyCustomException, MyTestEnum>("ags1");
        }


        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.Zero<MyCustomException, short>("ags1").Input);
            Assert.Equal(data.IntInputWithValueMinus1, Guard.Protect(data.IntInputWithValueMinus1).Against.Zero<MyCustomException, int>("ags1").Input);
            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.Zero<MyCustomException, long>("ags1").Input);
            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.Zero<MyCustomException, decimal>("ags1").Input);
            Assert.Equal(data.FloatInputWithValueMinus1, Guard.Protect(data.FloatInputWithValueMinus1).Against.Zero<MyCustomException, float>("ags1").Input);
            Assert.Equal(data.DoubleInputWithValueMinus1, Guard.Protect(data.DoubleInputWithValueMinus1).Against.Zero<MyCustomException, double>("ags1").Input);
            Assert.Equal(data.EnumInputWithValueMinusOne, Guard.Protect(data.EnumInputWithValueMinusOne).Against.Zero<MyCustomException, MyTestEnum>("ags1").Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.Zero<MyCustomException, short>("ags1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValueMinus1), Guard.Protect(data.IntInputWithValueMinus1, nameof(data.IntInputWithValueMinus1)).Against.Zero<MyCustomException, int>("ags1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.Zero<MyCustomException, long>("ags1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.Zero<MyCustomException, decimal>("ags1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValueMinus1), Guard.Protect(data.FloatInputWithValueMinus1, nameof(data.FloatInputWithValueMinus1)).Against.Zero<MyCustomException, float>("ags1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValueMinus1), Guard.Protect(data.DoubleInputWithValueMinus1, nameof(data.DoubleInputWithValueMinus1)).Against.Zero<MyCustomException, double>("ags1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueMinusOne), Guard.Protect(data.EnumInputWithValueMinusOne, nameof(data.EnumInputWithValueMinusOne)).Against.Zero<MyCustomException, MyTestEnum>("ags1").InputParameterName);
        }



        [Fact]
        public void ThrowsCustomExceptionGivenZeroValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue0).Against.Zero<MyCustomException, short>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue0).Against.Zero<MyCustomException, int>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue0).Against.Zero<MyCustomException, long>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.Zero<MyCustomException, decimal>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue0).Against.Zero<MyCustomException, float>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue0).Against.Zero<MyCustomException, double>("ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueZero).Against.Zero<MyCustomException, MyTestEnum>("ags1"));
        }

        #endregion

        #region custom exception type as parameter

        [Fact]
        public void DoesNothingGivenPositiveValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.Zero<short>(typeof(MyCustomException))
                .Protect(data.IntInputWithValue1).Against.Zero<int>(typeof(MyCustomException))
                .Protect(data.LongInputWithValue1).Against.Zero<long>(typeof(MyCustomException))
                .Protect(data.DecimalInputWithValue1).Against.Zero<decimal>(typeof(MyCustomException))
                .Protect(data.FloatInputWithValue1).Against.Zero<float>(typeof(MyCustomException))
                .Protect(data.DoubleInputWithValue1).Against.Zero<double>(typeof(MyCustomException))
                .Protect(data.EnumInputWithValueTwo).Against.Zero<MyTestEnum>(typeof(MyCustomException));
        }


        [Fact]
        public void PreservesInputGivenPositiveValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Zero<short>(typeof(MyCustomException)).Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Zero<int>(typeof(MyCustomException)).Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Zero<long>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Zero<decimal>(typeof(MyCustomException)).Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Zero<float>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Zero<double>(typeof(MyCustomException)).Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Zero<MyTestEnum>(typeof(MyCustomException)).Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenPositiveValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.Zero<short>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.Zero<int>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Zero<long>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Zero<decimal>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.Zero<float>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Zero<double>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.Zero<MyTestEnum>(typeof(MyCustomException)).InputParameterName);
        }

        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValueMinus1).Against.Zero<short>(typeof(MyCustomException))
                .Protect(data.IntInputWithValueMinus1).Against.Zero<int>(typeof(MyCustomException))
                .Protect(data.LongInputWithValueMinus1).Against.Zero<long>(typeof(MyCustomException))
                .Protect(data.DecimalInputWithValueMinus1).Against.Zero<decimal>(typeof(MyCustomException))
                .Protect(data.FloatInputWithValueMinus1).Against.Zero<float>(typeof(MyCustomException))
                .Protect(data.DoubleInputWithValueMinus1).Against.Zero<double>(typeof(MyCustomException))
                .Protect(data.EnumInputWithValueMinusOne).Against.Zero<MyTestEnum>(typeof(MyCustomException));
        }


        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.Zero<short>(typeof(MyCustomException)).Input);
            Assert.Equal(data.IntInputWithValueMinus1, Guard.Protect(data.IntInputWithValueMinus1).Against.Zero<int>(typeof(MyCustomException)).Input);
            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.Zero<long>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.Zero<decimal>(typeof(MyCustomException)).Input);
            Assert.Equal(data.FloatInputWithValueMinus1, Guard.Protect(data.FloatInputWithValueMinus1).Against.Zero<float>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DoubleInputWithValueMinus1, Guard.Protect(data.DoubleInputWithValueMinus1).Against.Zero<double>(typeof(MyCustomException)).Input);
            Assert.Equal(data.EnumInputWithValueMinusOne, Guard.Protect(data.EnumInputWithValueMinusOne).Against.Zero<MyTestEnum>(typeof(MyCustomException)).Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.Zero<short>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValueMinus1), Guard.Protect(data.IntInputWithValueMinus1, nameof(data.IntInputWithValueMinus1)).Against.Zero<int>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.Zero<long>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.Zero<decimal>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValueMinus1), Guard.Protect(data.FloatInputWithValueMinus1, nameof(data.FloatInputWithValueMinus1)).Against.Zero<float>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValueMinus1), Guard.Protect(data.DoubleInputWithValueMinus1, nameof(data.DoubleInputWithValueMinus1)).Against.Zero<double>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueMinusOne), Guard.Protect(data.EnumInputWithValueMinusOne, nameof(data.EnumInputWithValueMinusOne)).Against.Zero<MyTestEnum>(typeof(MyCustomException)).InputParameterName);
        }

        
        [Fact]
        public void ThrowsCustomExceptionGivenZeroValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue0).Against.Zero<short>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue0).Against.Zero<int>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue0).Against.Zero<long>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.Zero<decimal>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue0).Against.Zero<float>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue0).Against.Zero<double>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueZero).Against.Zero<MyTestEnum>(typeof(MyCustomException)));
        }

        #endregion

        #region custom exception type as parameter with constructor args

        [Fact]
        public void DoesNothingGivenPositiveValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.Zero<short>(typeof(MyCustomException), "args1")
                .Protect(data.IntInputWithValue1).Against.Zero<int>(typeof(MyCustomException), "args1")
                .Protect(data.LongInputWithValue1).Against.Zero<long>(typeof(MyCustomException), "args1")
                .Protect(data.DecimalInputWithValue1).Against.Zero<decimal>(typeof(MyCustomException), "args1")
                .Protect(data.FloatInputWithValue1).Against.Zero<float>(typeof(MyCustomException), "args1")
                .Protect(data.DoubleInputWithValue1).Against.Zero<double>(typeof(MyCustomException), "args1")
                .Protect(data.EnumInputWithValueTwo).Against.Zero<MyTestEnum>(typeof(MyCustomException), "args1");
        }


        [Fact]
        public void PreservesInputGivenPositiveValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Zero<short>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Zero<int>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Zero<long>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Zero<decimal>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Zero<float>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Zero<double>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Zero<MyTestEnum>(typeof(MyCustomException), "args1").Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenPositiveValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.Zero<short>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.Zero<int>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Zero<long>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Zero<decimal>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.Zero<float>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Zero<double>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.Zero<MyTestEnum>(typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValueMinus1).Against.Zero<short>(typeof(MyCustomException), "args1")
                .Protect(data.IntInputWithValueMinus1).Against.Zero<int>(typeof(MyCustomException), "args1")
                .Protect(data.LongInputWithValueMinus1).Against.Zero<long>(typeof(MyCustomException), "args1")
                .Protect(data.DecimalInputWithValueMinus1).Against.Zero<decimal>(typeof(MyCustomException), "args1")
                .Protect(data.FloatInputWithValueMinus1).Against.Zero<float>(typeof(MyCustomException), "args1")
                .Protect(data.DoubleInputWithValueMinus1).Against.Zero<double>(typeof(MyCustomException), "args1")
                .Protect(data.EnumInputWithValueMinusOne).Against.Zero<MyTestEnum>(typeof(MyCustomException), "args1");
        }


        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.Zero<short>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.IntInputWithValueMinus1, Guard.Protect(data.IntInputWithValueMinus1).Against.Zero<int>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.Zero<long>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.Zero<decimal>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.FloatInputWithValueMinus1, Guard.Protect(data.FloatInputWithValueMinus1).Against.Zero<float>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DoubleInputWithValueMinus1, Guard.Protect(data.DoubleInputWithValueMinus1).Against.Zero<double>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.EnumInputWithValueMinusOne, Guard.Protect(data.EnumInputWithValueMinusOne).Against.Zero<MyTestEnum>(typeof(MyCustomException), "args1").Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.Zero<short>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValueMinus1), Guard.Protect(data.IntInputWithValueMinus1, nameof(data.IntInputWithValueMinus1)).Against.Zero<int>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.Zero<long>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.Zero<decimal>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValueMinus1), Guard.Protect(data.FloatInputWithValueMinus1, nameof(data.FloatInputWithValueMinus1)).Against.Zero<float>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValueMinus1), Guard.Protect(data.DoubleInputWithValueMinus1, nameof(data.DoubleInputWithValueMinus1)).Against.Zero<double>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueMinusOne), Guard.Protect(data.EnumInputWithValueMinusOne, nameof(data.EnumInputWithValueMinusOne)).Against.Zero<MyTestEnum>(typeof(MyCustomException), "args1").InputParameterName);
        }


        [Fact]
        public void ThrowsCustomExceptionGivenZeroValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue0).Against.Zero<short>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue0).Against.Zero<int>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue0).Against.Zero<long>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.Zero<decimal>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue0).Against.Zero<float>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue0).Against.Zero<double>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueZero).Against.Zero<MyTestEnum>(typeof(MyCustomException), "args1"));
        }

        #endregion
    }
}
