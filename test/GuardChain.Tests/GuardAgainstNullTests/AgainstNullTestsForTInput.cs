using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using Xunit;

namespace GuardChain.Tests.GuardAgainstNullTests
{
    public class AgainstNullTestsForTInput
    {
        [Fact]
        public void DoesNothingGivenNonNullValue()
        {
            var data = new TestData();

            Guard
                .Protect(data.StringInputWithNormalValue).Against.Null<string>()
                .Protect(data.StringInputWithZeroLength).Against.Null<string>()
                .Protect(data.StringInputWithEmptyValue).Against.Null<string>()
                .Protect(data.ShortInputWithValue1).Against.Null<short>()
                .Protect(data.IntInputWithValue1).Against.Null<int>()
                .Protect(data.LongInputWithValue1).Against.Null<long>()
                .Protect(data.DecimalInputWithValue1).Against.Null<decimal>()
                .Protect(data.FloatInputWithValue1).Against.Null<float>()
                .Protect(data.DoubleInputWithValue1).Against.Null<double>()
                .Protect(data.DateTimeInputWithValueNow).Against.Null<DateTime>()
                .Protect(data.EnumInputWithValueTwo).Against.Null<MyTestEnum>()
                .Protect(data.GuidInputWithEmptyValue).Against.Null<Guid>()
                .Protect(data.ObjectInput).Against.Null<object>()
                .Protect(data.ListOfObjectsInputWithNoItems).Against.Null<List<object>>();
        }

        [Fact]
        public void ThrowsArgumentNullExceptionGivenNullValue()
        {
            var data = new TestData();

            Assert.Throws<ArgumentNullException>(() => Guard.Protect(data.ObjectInputWithValueNull).Against.Null<object>());
        }

        [Fact]
        public void ThrowsCustomExceptionGivenNullValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ObjectInputWithValueNull).Against.Null<MyCustomException, object>());
        }

        [Fact]
        public void ThrowsCustomExceptionGivenNullValueWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ObjectInputWithValueNull).Against.Null<MyCustomException, object>( "arg1"));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenNullValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ObjectInputWithValueNull).Against.Null<object>(typeof(MyCustomException)));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenNullValueWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ObjectInputWithValueNull).Against.Null<object>(typeof(MyCustomException), "arg1"));
        }

        [Fact]
        public void ReturnsExpectedInputGivenNonNullValue()
        {
            var data = new TestData();

            Assert.Equal(data.StringInputWithNormalValue, Guard.Protect(data.StringInputWithNormalValue).Against.Null<string>().Input);
            Assert.Equal(data.StringInputWithZeroLength, Guard.Protect(data.StringInputWithZeroLength).Against.Null<string>().Input);
            Assert.Equal(data.StringInputWithEmptyValue, Guard.Protect(data.StringInputWithEmptyValue).Against.Null<string>().Input);
            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Null<short>().Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Null<int>().Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Null<long>().Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Null<decimal>().Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Null<float>().Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Null<double>().Input);
            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.Null<DateTime>().Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Null<MyTestEnum>().Input);
            Assert.Equal(data.GuidInputWithEmptyValue, Guard.Protect(data.GuidInputWithEmptyValue).Against.Null<Guid>().Input);
            Assert.Equal(data.ObjectInput, Guard.Protect(data.ObjectInput).Against.Null<object>().Input);
            Assert.Equal(data.ListOfObjectsInputWithNoItems, Guard.Protect(data.ListOfObjectsInputWithNoItems).Against.Null<List<Object>>().Input);
        }

        [Fact]
        public void ReturnsExpectedInputGivenNonNullValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.StringInputWithNormalValue, Guard.Protect(data.StringInputWithNormalValue).Against.Null<MyCustomException, string>().Input);
            Assert.Equal(data.StringInputWithZeroLength, Guard.Protect(data.StringInputWithZeroLength).Against.Null<MyCustomException, string>().Input);
            Assert.Equal(data.StringInputWithEmptyValue, Guard.Protect(data.StringInputWithEmptyValue).Against.Null<MyCustomException, string>().Input);
            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Null<MyCustomException, short>().Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Null<MyCustomException, int>().Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Null<MyCustomException, long>().Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Null<MyCustomException, decimal>().Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Null<MyCustomException, float>().Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Null<MyCustomException, double>().Input);
            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.Null<MyCustomException, DateTime>().Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Null<MyCustomException, MyTestEnum>().Input);
            Assert.Equal(data.GuidInputWithEmptyValue, Guard.Protect(data.GuidInputWithEmptyValue).Against.Null<MyCustomException, Guid>().Input);
            Assert.Equal(data.ObjectInput, Guard.Protect(data.ObjectInput).Against.Null<MyCustomException, object>().Input);
            Assert.Equal(data.ListOfObjectsInputWithNoItems, Guard.Protect(data.ListOfObjectsInputWithNoItems).Against.Null<MyCustomException, List<object>>().Input);
        }

        [Fact]
        public void ReturnsExpectedInputGivenNonNullValueWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.StringInputWithNormalValue, Guard.Protect(data.StringInputWithNormalValue).Against.Null<MyCustomException, string>("arg1").Input);
            Assert.Equal(data.StringInputWithZeroLength, Guard.Protect(data.StringInputWithZeroLength).Against.Null<MyCustomException, string>("arg1").Input);
            Assert.Equal(data.StringInputWithEmptyValue, Guard.Protect(data.StringInputWithEmptyValue).Against.Null<MyCustomException, string>("arg1").Input);
            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Null<MyCustomException, short>("arg1").Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Null<MyCustomException, int>("arg1").Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Null<MyCustomException, long>("arg1").Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Null<MyCustomException, decimal>("arg1").Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Null<MyCustomException, float>("arg1").Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Null<MyCustomException, double>("arg1").Input);
            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.Null<MyCustomException, DateTime>("arg1").Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Null<MyCustomException, MyTestEnum>("arg1").Input);
            Assert.Equal(data.GuidInputWithEmptyValue, Guard.Protect(data.GuidInputWithEmptyValue).Against.Null<MyCustomException, Guid>("arg1").Input);
            Assert.Equal(data.ObjectInput, Guard.Protect(data.ObjectInput).Against.Null<MyCustomException, object>("arg1").Input);
            Assert.Equal(data.ListOfObjectsInputWithNoItems, Guard.Protect(data.ListOfObjectsInputWithNoItems).Against.Null<MyCustomException, List<object>>().Input);
        }

        [Fact]
        public void ReturnsExpectedInputGivenNonNullValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.StringInputWithNormalValue, Guard.Protect(data.StringInputWithNormalValue).Against.Null<string>(typeof(MyCustomException)).Input);
            Assert.Equal(data.StringInputWithZeroLength, Guard.Protect(data.StringInputWithZeroLength).Against.Null<string>(typeof(MyCustomException)).Input);
            Assert.Equal(data.StringInputWithEmptyValue, Guard.Protect(data.StringInputWithEmptyValue).Against.Null<string>(typeof(MyCustomException)).Input);
            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Null<short>(typeof(MyCustomException)).Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Null<int>(typeof(MyCustomException)).Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Null<long>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Null<decimal>(typeof(MyCustomException)).Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Null<float>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Null<double>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.Null<DateTime>(typeof(MyCustomException)).Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Null<MyTestEnum>(typeof(MyCustomException)).Input);
            Assert.Equal(data.GuidInputWithEmptyValue, Guard.Protect(data.GuidInputWithEmptyValue).Against.Null<Guid>(typeof(MyCustomException)).Input);
            Assert.Equal(data.ObjectInput, Guard.Protect(data.ObjectInput).Against.Null<object>(typeof(MyCustomException)).Input);
            Assert.Equal(data.ListOfObjectsInputWithNoItems, Guard.Protect(data.ListOfObjectsInputWithNoItems).Against.Null<List<object>>(typeof(MyCustomException)).Input);
        }

        [Fact]
        public void ReturnsExpectedInputGivenNonNullValueWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.StringInputWithNormalValue, Guard.Protect(data.StringInputWithNormalValue).Against.Null<string>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.StringInputWithZeroLength, Guard.Protect(data.StringInputWithZeroLength).Against.Null<string>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.StringInputWithEmptyValue, Guard.Protect(data.StringInputWithEmptyValue).Against.Null<string>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Null<short>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Null<int>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Null<long>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Null<decimal>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Null<float>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Null<double>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.Null<DateTime>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Null<MyTestEnum>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.GuidInputWithEmptyValue, Guard.Protect(data.GuidInputWithEmptyValue).Against.Null<Guid>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.ObjectInput, Guard.Protect(data.ObjectInput).Against.Null<object>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.ListOfObjectsInputWithNoItems, Guard.Protect(data.ListOfObjectsInputWithNoItems).Against.Null<List<object>>(typeof(MyCustomException), "arg1").Input);
        }

    }
}
