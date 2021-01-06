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
                .Protect(data.StringInput).Against.Null<string>()
                .Protect(data.ZeroLengthStringInput).Against.Null<string>()
                .Protect(data.EmptyStringInput).Against.Null<string>()
                .Protect(data.ShortInput).Against.Null<short>()
                .Protect(data.IntInput).Against.Null<int>()
                .Protect(data.LongInput).Against.Null<long>()
                .Protect(data.DecimalInput).Against.Null<decimal>()
                .Protect(data.FloatInput).Against.Null<float>()
                .Protect(data.DoubleInput).Against.Null<double>()
                .Protect(data.DateTimeInput).Against.Null<DateTime>()
                .Protect(data.EnumInputTwo).Against.Null<MyTestEnum>()
                .Protect(data.GuidInput).Against.Null<Guid>()
                .Protect(data.ObjectInput).Against.Null<object>()
                .Protect(data.ListInput).Against.Null<List<object>>();
        }

        [Fact]
        public void ThrowsArgumentNullExceptionGivenNullValue()
        {
            var data = new TestData();

            Assert.Throws<ArgumentNullException>(() => Guard.Protect(data.NullObjectInput).Against.Null<object>());
        }

        [Fact]
        public void ThrowsCustomExceptionGivenNullValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.NullObjectInput).Against.Null<MyCustomException, object>());
        }

        [Fact]
        public void ThrowsCustomExceptionGivenNullValueWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.NullObjectInput).Against.Null<MyCustomException, object>( "arg1"));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenNullValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.NullObjectInput).Against.Null<object>(typeof(MyCustomException)));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenNullValueWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.NullObjectInput).Against.Null<object>(typeof(MyCustomException), "arg1"));
        }

        [Fact]
        public void ReturnsExpectedInputGivenNonNullValue()
        {
            var data = new TestData();

            Assert.Equal(data.StringInput, Guard.Protect(data.StringInput).Against.Null<string>().Input);
            Assert.Equal(data.ZeroLengthStringInput, Guard.Protect(data.ZeroLengthStringInput).Against.Null<string>().Input);
            Assert.Equal(data.EmptyStringInput, Guard.Protect(data.EmptyStringInput).Against.Null<string>().Input);
            Assert.Equal(data.ShortInput, Guard.Protect(data.ShortInput).Against.Null<short>().Input);
            Assert.Equal(data.IntInput, Guard.Protect(data.IntInput).Against.Null<int>().Input);
            Assert.Equal(data.LongInput, Guard.Protect(data.LongInput).Against.Null<long>().Input);
            Assert.Equal(data.DecimalInput, Guard.Protect(data.DecimalInput).Against.Null<decimal>().Input);
            Assert.Equal(data.FloatInput, Guard.Protect(data.FloatInput).Against.Null<float>().Input);
            Assert.Equal(data.DoubleInput, Guard.Protect(data.DoubleInput).Against.Null<double>().Input);
            Assert.Equal(data.DateTimeInput, Guard.Protect(data.DateTimeInput).Against.Null<DateTime>().Input);
            Assert.Equal(data.EnumInputTwo, Guard.Protect(data.EnumInputTwo).Against.Null<MyTestEnum>().Input);
            Assert.Equal(data.GuidInput, Guard.Protect(data.GuidInput).Against.Null<Guid>().Input);
            Assert.Equal(data.ObjectInput, Guard.Protect(data.ObjectInput).Against.Null<object>().Input);
            Assert.Equal(data.ListInput, Guard.Protect(data.ListInput).Against.Null<List<Object>>().Input);
        }

        [Fact]
        public void ReturnsExpectedInputGivenNonNullValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.StringInput, Guard.Protect(data.StringInput).Against.Null<MyCustomException, string>().Input);
            Assert.Equal(data.ZeroLengthStringInput, Guard.Protect(data.ZeroLengthStringInput).Against.Null<MyCustomException, string>().Input);
            Assert.Equal(data.EmptyStringInput, Guard.Protect(data.EmptyStringInput).Against.Null<MyCustomException, string>().Input);
            Assert.Equal(data.ShortInput, Guard.Protect(data.ShortInput).Against.Null<MyCustomException, short>().Input);
            Assert.Equal(data.IntInput, Guard.Protect(data.IntInput).Against.Null<MyCustomException, int>().Input);
            Assert.Equal(data.LongInput, Guard.Protect(data.LongInput).Against.Null<MyCustomException, long>().Input);
            Assert.Equal(data.DecimalInput, Guard.Protect(data.DecimalInput).Against.Null<MyCustomException, decimal>().Input);
            Assert.Equal(data.FloatInput, Guard.Protect(data.FloatInput).Against.Null<MyCustomException, float>().Input);
            Assert.Equal(data.DoubleInput, Guard.Protect(data.DoubleInput).Against.Null<MyCustomException, double>().Input);
            Assert.Equal(data.DateTimeInput, Guard.Protect(data.DateTimeInput).Against.Null<MyCustomException, DateTime>().Input);
            Assert.Equal(data.EnumInputTwo, Guard.Protect(data.EnumInputTwo).Against.Null<MyCustomException, MyTestEnum>().Input);
            Assert.Equal(data.GuidInput, Guard.Protect(data.GuidInput).Against.Null<MyCustomException, Guid>().Input);
            Assert.Equal(data.ObjectInput, Guard.Protect(data.ObjectInput).Against.Null<MyCustomException, object>().Input);
            Assert.Equal(data.ListInput, Guard.Protect(data.ListInput).Against.Null<MyCustomException, List<object>>().Input);
        }

        [Fact]
        public void ReturnsExpectedInputGivenNonNullValueWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.StringInput, Guard.Protect(data.StringInput).Against.Null<MyCustomException, string>("arg1").Input);
            Assert.Equal(data.ZeroLengthStringInput, Guard.Protect(data.ZeroLengthStringInput).Against.Null<MyCustomException, string>("arg1").Input);
            Assert.Equal(data.EmptyStringInput, Guard.Protect(data.EmptyStringInput).Against.Null<MyCustomException, string>("arg1").Input);
            Assert.Equal(data.ShortInput, Guard.Protect(data.ShortInput).Against.Null<MyCustomException, short>("arg1").Input);
            Assert.Equal(data.IntInput, Guard.Protect(data.IntInput).Against.Null<MyCustomException, int>("arg1").Input);
            Assert.Equal(data.LongInput, Guard.Protect(data.LongInput).Against.Null<MyCustomException, long>("arg1").Input);
            Assert.Equal(data.DecimalInput, Guard.Protect(data.DecimalInput).Against.Null<MyCustomException, decimal>("arg1").Input);
            Assert.Equal(data.FloatInput, Guard.Protect(data.FloatInput).Against.Null<MyCustomException, float>("arg1").Input);
            Assert.Equal(data.DoubleInput, Guard.Protect(data.DoubleInput).Against.Null<MyCustomException, double>("arg1").Input);
            Assert.Equal(data.DateTimeInput, Guard.Protect(data.DateTimeInput).Against.Null<MyCustomException, DateTime>("arg1").Input);
            Assert.Equal(data.EnumInputTwo, Guard.Protect(data.EnumInputTwo).Against.Null<MyCustomException, MyTestEnum>("arg1").Input);
            Assert.Equal(data.GuidInput, Guard.Protect(data.GuidInput).Against.Null<MyCustomException, Guid>("arg1").Input);
            Assert.Equal(data.ObjectInput, Guard.Protect(data.ObjectInput).Against.Null<MyCustomException, object>("arg1").Input);
            Assert.Equal(data.ListInput, Guard.Protect(data.ListInput).Against.Null<MyCustomException, List<object>>().Input);
        }

        [Fact]
        public void ReturnsExpectedInputGivenNonNullValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.StringInput, Guard.Protect(data.StringInput).Against.Null<string>(typeof(MyCustomException)).Input);
            Assert.Equal(data.ZeroLengthStringInput, Guard.Protect(data.ZeroLengthStringInput).Against.Null<string>(typeof(MyCustomException)).Input);
            Assert.Equal(data.EmptyStringInput, Guard.Protect(data.EmptyStringInput).Against.Null<string>(typeof(MyCustomException)).Input);
            Assert.Equal(data.ShortInput, Guard.Protect(data.ShortInput).Against.Null<short>(typeof(MyCustomException)).Input);
            Assert.Equal(data.IntInput, Guard.Protect(data.IntInput).Against.Null<int>(typeof(MyCustomException)).Input);
            Assert.Equal(data.LongInput, Guard.Protect(data.LongInput).Against.Null<long>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DecimalInput, Guard.Protect(data.DecimalInput).Against.Null<decimal>(typeof(MyCustomException)).Input);
            Assert.Equal(data.FloatInput, Guard.Protect(data.FloatInput).Against.Null<float>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DoubleInput, Guard.Protect(data.DoubleInput).Against.Null<double>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DateTimeInput, Guard.Protect(data.DateTimeInput).Against.Null<DateTime>(typeof(MyCustomException)).Input);
            Assert.Equal(data.EnumInputTwo, Guard.Protect(data.EnumInputTwo).Against.Null<MyTestEnum>(typeof(MyCustomException)).Input);
            Assert.Equal(data.GuidInput, Guard.Protect(data.GuidInput).Against.Null<Guid>(typeof(MyCustomException)).Input);
            Assert.Equal(data.ObjectInput, Guard.Protect(data.ObjectInput).Against.Null<object>(typeof(MyCustomException)).Input);
            Assert.Equal(data.ListInput, Guard.Protect(data.ListInput).Against.Null<List<object>>(typeof(MyCustomException)).Input);
        }

        [Fact]
        public void ReturnsExpectedInputGivenNonNullValueWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.StringInput, Guard.Protect(data.StringInput).Against.Null<string>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.ZeroLengthStringInput, Guard.Protect(data.ZeroLengthStringInput).Against.Null<string>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.EmptyStringInput, Guard.Protect(data.EmptyStringInput).Against.Null<string>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.ShortInput, Guard.Protect(data.ShortInput).Against.Null<short>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.IntInput, Guard.Protect(data.IntInput).Against.Null<int>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.LongInput, Guard.Protect(data.LongInput).Against.Null<long>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.DecimalInput, Guard.Protect(data.DecimalInput).Against.Null<decimal>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.FloatInput, Guard.Protect(data.FloatInput).Against.Null<float>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.DoubleInput, Guard.Protect(data.DoubleInput).Against.Null<double>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.DateTimeInput, Guard.Protect(data.DateTimeInput).Against.Null<DateTime>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.EnumInputTwo, Guard.Protect(data.EnumInputTwo).Against.Null<MyTestEnum>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.GuidInput, Guard.Protect(data.GuidInput).Against.Null<Guid>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.ObjectInput, Guard.Protect(data.ObjectInput).Against.Null<object>(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.ListInput, Guard.Protect(data.ListInput).Against.Null<List<object>>(typeof(MyCustomException), "arg1").Input);
        }

    }
}
