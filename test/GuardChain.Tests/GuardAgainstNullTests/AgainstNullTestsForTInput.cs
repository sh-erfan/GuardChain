using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Extensions;
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
                .Protect(data.StringInput).Against.Null()
                .Protect(data.ZeroLengthStringInput).Against.Null()
                .Protect(data.EmptyStringInput).Against.Null()
                .Protect(data.ShortInput).Against.Null()
                .Protect(data.IntInput).Against.Null()
                .Protect(data.LongInput).Against.Null()
                .Protect(data.DecimalInput).Against.Null()
                .Protect(data.FloatInput).Against.Null()
                .Protect(data.DoubleInput).Against.Null()
                .Protect(data.DateTimeInput).Against.Null()
                .Protect(data.EnumInput).Against.Null()
                .Protect(data.GuidInput).Against.Null()
                .Protect(data.ObjectInput).Against.Null()
                .Protect(data.ListInput).Against.Null();
        }

        [Fact]
        public void ThrowsArgumentNullExceptionGivenNullValue()
        {
            var data = new TestData();

            Assert.Throws<ArgumentNullException>(() => Guard.Protect(data.NullObjectInput).Against.Null());
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

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.NullObjectInput).Against.Null(typeof(MyCustomException)));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenNullValueWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.NullObjectInput).Against.Null(typeof(MyCustomException), "arg1"));
        }

        [Fact]
        public void ReturnsExpectedInputGivenNonNullValue()
        {
            var data = new TestData();

            Assert.Equal(data.StringInput, Guard.Protect(data.StringInput).Against.Null().Input);
            Assert.Equal(data.ZeroLengthStringInput, Guard.Protect(data.ZeroLengthStringInput).Against.Null().Input);
            Assert.Equal(data.EmptyStringInput, Guard.Protect(data.EmptyStringInput).Against.Null().Input);
            Assert.Equal(data.ShortInput, Guard.Protect(data.ShortInput).Against.Null().Input);
            Assert.Equal(data.IntInput, Guard.Protect(data.IntInput).Against.Null().Input);
            Assert.Equal(data.LongInput, Guard.Protect(data.LongInput).Against.Null().Input);
            Assert.Equal(data.DecimalInput, Guard.Protect(data.DecimalInput).Against.Null().Input);
            Assert.Equal(data.FloatInput, Guard.Protect(data.FloatInput).Against.Null().Input);
            Assert.Equal(data.DoubleInput, Guard.Protect(data.DoubleInput).Against.Null().Input);
            Assert.Equal(data.DateTimeInput, Guard.Protect(data.DateTimeInput).Against.Null().Input);
            Assert.Equal(data.EnumInput, Guard.Protect(data.EnumInput).Against.Null().Input);
            Assert.Equal(data.GuidInput, Guard.Protect(data.GuidInput).Against.Null().Input);
            Assert.Equal(data.ObjectInput, Guard.Protect(data.ObjectInput).Against.Null().Input);
            Assert.Equal(data.ListInput, Guard.Protect(data.ListInput).Against.Null().Input);
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
            Assert.Equal(data.EnumInput, Guard.Protect(data.EnumInput).Against.Null<MyCustomException, MyEnum>().Input);
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
            Assert.Equal(data.EnumInput, Guard.Protect(data.EnumInput).Against.Null<MyCustomException, MyEnum>("arg1").Input);
            Assert.Equal(data.GuidInput, Guard.Protect(data.GuidInput).Against.Null<MyCustomException, Guid>("arg1").Input);
            Assert.Equal(data.ObjectInput, Guard.Protect(data.ObjectInput).Against.Null<MyCustomException, object>("arg1").Input);
            Assert.Equal(data.ListInput, Guard.Protect(data.ListInput).Against.Null<MyCustomException, List<object>>().Input);
        }

        [Fact]
        public void ReturnsExpectedInputGivenNonNullValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.StringInput, Guard.Protect(data.StringInput).Against.Null(typeof(MyCustomException)).Input);
            Assert.Equal(data.ZeroLengthStringInput, Guard.Protect(data.ZeroLengthStringInput).Against.Null(typeof(MyCustomException)).Input);
            Assert.Equal(data.EmptyStringInput, Guard.Protect(data.EmptyStringInput).Against.Null(typeof(MyCustomException)).Input);
            Assert.Equal(data.ShortInput, Guard.Protect(data.ShortInput).Against.Null(typeof(MyCustomException)).Input);
            Assert.Equal(data.IntInput, Guard.Protect(data.IntInput).Against.Null(typeof(MyCustomException)).Input);
            Assert.Equal(data.LongInput, Guard.Protect(data.LongInput).Against.Null(typeof(MyCustomException)).Input);
            Assert.Equal(data.DecimalInput, Guard.Protect(data.DecimalInput).Against.Null(typeof(MyCustomException)).Input);
            Assert.Equal(data.FloatInput, Guard.Protect(data.FloatInput).Against.Null(typeof(MyCustomException)).Input);
            Assert.Equal(data.DoubleInput, Guard.Protect(data.DoubleInput).Against.Null(typeof(MyCustomException)).Input);
            Assert.Equal(data.DateTimeInput, Guard.Protect(data.DateTimeInput).Against.Null(typeof(MyCustomException)).Input);
            Assert.Equal(data.EnumInput, Guard.Protect(data.EnumInput).Against.Null(typeof(MyCustomException)).Input);
            Assert.Equal(data.GuidInput, Guard.Protect(data.GuidInput).Against.Null(typeof(MyCustomException)).Input);
            Assert.Equal(data.ObjectInput, Guard.Protect(data.ObjectInput).Against.Null(typeof(MyCustomException)).Input);
            Assert.Equal(data.ListInput, Guard.Protect(data.ListInput).Against.Null(typeof(MyCustomException)).Input);
        }

        [Fact]
        public void ReturnsExpectedInputGivenNonNullValueWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.StringInput, Guard.Protect(data.StringInput).Against.Null(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.ZeroLengthStringInput, Guard.Protect(data.ZeroLengthStringInput).Against.Null(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.EmptyStringInput, Guard.Protect(data.EmptyStringInput).Against.Null(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.ShortInput, Guard.Protect(data.ShortInput).Against.Null(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.IntInput, Guard.Protect(data.IntInput).Against.Null(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.LongInput, Guard.Protect(data.LongInput).Against.Null(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.DecimalInput, Guard.Protect(data.DecimalInput).Against.Null(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.FloatInput, Guard.Protect(data.FloatInput).Against.Null(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.DoubleInput, Guard.Protect(data.DoubleInput).Against.Null(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.DateTimeInput, Guard.Protect(data.DateTimeInput).Against.Null(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.EnumInput, Guard.Protect(data.EnumInput).Against.Null(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.GuidInput, Guard.Protect(data.GuidInput).Against.Null(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.ObjectInput, Guard.Protect(data.ObjectInput).Against.Null(typeof(MyCustomException), "arg1").Input);
            Assert.Equal(data.ListInput, Guard.Protect(data.ListInput).Against.Null(typeof(MyCustomException), "arg1").Input);
        }


        #region Data


        class TestData
        {
            public string StringInput { get; } = "normal string";
            public string ZeroLengthStringInput { get; } = "";
            public string EmptyStringInput { get; } = string.Empty;
            public short ShortInput { get; } = 1;
            public int IntInput { get; } = 1;
            public long LongInput { get; } = 1;
            public decimal DecimalInput { get; } = (decimal)1.0;
            public float FloatInput { get; } = (float)1.0;
            public double DoubleInput { get; } = 1.0;
            public DateTime DateTimeInput { get; } = DateTime.Now;
            public MyEnum EnumInput { get; } = MyEnum.Foo;
            public Guid GuidInput { get; } = Guid.Empty;
            public object ObjectInput { get; } = new object();
            public object NullObjectInput { get; } = null;
            public List<object> ListInput { get; } = new List<object>();
        }

        enum MyEnum
        {
            Foo,
            Bar
        }

        class MyCustomException : Exception
        {
            public MyCustomException() : base()
            {
                
            }

            public MyCustomException(string NullObject) : base(NullObject)
            {
                
            }
        }

        #endregion
    }
}
