using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using Xunit;

namespace GuardChain.Tests.GuardAgainstGreaterThanOrEqualTests
{
    public class AgainstGreaterThanOrEqualTestsForTInput
    {
        [Fact]
        public void DoesNothingGivenValueLessThanLimit()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInput).Against.GreaterThanOrEqual<short>(2)
                .Protect(data.IntInput).Against.GreaterThanOrEqual<int>(2)
                .Protect(data.LongInput).Against.GreaterThanOrEqual<long>(2)
                .Protect(data.DecimalInput).Against.GreaterThanOrEqual<decimal>(2)
                .Protect(data.FloatInput).Against.GreaterThanOrEqual<float>(2)
                .Protect(data.DoubleInput).Against.GreaterThanOrEqual<double>(2)
                .Protect(data.EnumInputTwo).Against.GreaterThanOrEqual<MyTestEnum>(MyTestEnum.Three);
        }

        [Fact]
        public void ThrowsArgumentExceptionGivenValueEqualToLimit()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.ShortInput).Against.GreaterThanOrEqual<short>(1));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.IntInput).Against.GreaterThanOrEqual<int>(1));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.LongInput).Against.GreaterThanOrEqual<long>(1));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DecimalInput).Against.GreaterThanOrEqual<decimal>(1));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.FloatInput).Against.GreaterThanOrEqual<float>(1));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DoubleInput).Against.GreaterThanOrEqual<double>(1));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.EnumInputTwo).Against.GreaterThanOrEqual<MyTestEnum>(MyTestEnum.Two));
        }

        [Fact]
        public void ThrowsArgumentExceptionGivenValueGreaterThanLimit()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.ShortInput).Against.GreaterThanOrEqual<short>(0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.IntInput).Against.GreaterThanOrEqual<int>(0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.LongInput).Against.GreaterThanOrEqual<long>(0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DecimalInput).Against.GreaterThanOrEqual<decimal>(0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.FloatInput).Against.GreaterThanOrEqual<float>(0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DoubleInput).Against.GreaterThanOrEqual<double>(0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.EnumInputTwo).Against.GreaterThanOrEqual<MyTestEnum>(MyTestEnum.One));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.GreaterThanOrEqual<MyCustomException, short>(0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.GreaterThanOrEqual<MyCustomException, int>(0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.GreaterThanOrEqual<MyCustomException, long>(0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.GreaterThanOrEqual<MyCustomException, decimal>(0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.GreaterThanOrEqual<MyCustomException, float>(0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.GreaterThanOrEqual<MyCustomException, double>(0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.GreaterThanOrEqual<MyCustomException, MyTestEnum>(MyTestEnum.One));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.GreaterThanOrEqual<MyCustomException, short>(0, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.GreaterThanOrEqual<MyCustomException, int>(0, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.GreaterThanOrEqual<MyCustomException, long>(0, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.GreaterThanOrEqual<MyCustomException, decimal>(0, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.GreaterThanOrEqual<MyCustomException, float>(0, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.GreaterThanOrEqual<MyCustomException, double>(0, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.GreaterThanOrEqual<MyCustomException, MyTestEnum>(MyTestEnum.One, "arg1"));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueGreaterThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.GreaterThanOrEqual<short>(0, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.GreaterThanOrEqual<int>(0, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.GreaterThanOrEqual<long>(0, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.GreaterThanOrEqual<decimal>(0, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.GreaterThanOrEqual<float>(0, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.GreaterThanOrEqual<double>(0, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.GreaterThanOrEqual<MyTestEnum>(MyTestEnum.One, typeof(MyCustomException)));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueGreaterThanLimitWithCustomExceptionTypeTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.GreaterThanOrEqual<short>(0, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.GreaterThanOrEqual<int>(0, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.GreaterThanOrEqual<long>(0, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.GreaterThanOrEqual<decimal>(0, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.GreaterThanOrEqual<float>(0, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.GreaterThanOrEqual<double>(0, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.GreaterThanOrEqual<MyTestEnum>(MyTestEnum.One, typeof(MyCustomException), "arg1"));
        }


        [Fact]
        public void ThrowsCustomExceptionGivenValueEqualToLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.GreaterThanOrEqual<MyCustomException, short>(1));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.GreaterThanOrEqual<MyCustomException, int>(1));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.GreaterThanOrEqual<MyCustomException, long>(1));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.GreaterThanOrEqual<MyCustomException, decimal>(1));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.GreaterThanOrEqual<MyCustomException, float>(1));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.GreaterThanOrEqual<MyCustomException, double>(1));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.GreaterThanOrEqual<MyCustomException, MyTestEnum>(MyTestEnum.Two));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueEqualToLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.GreaterThanOrEqual<MyCustomException, short>(1, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.GreaterThanOrEqual<MyCustomException, int>(1, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.GreaterThanOrEqual<MyCustomException, long>(1, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.GreaterThanOrEqual<MyCustomException, decimal>(1, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.GreaterThanOrEqual<MyCustomException, float>(1, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.GreaterThanOrEqual<MyCustomException, double>(1, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.GreaterThanOrEqual<MyCustomException, MyTestEnum>(MyTestEnum.Two, "arg1"));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueEqualToLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.GreaterThanOrEqual<short>(1, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.GreaterThanOrEqual<int>(1, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.GreaterThanOrEqual<long>(1, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.GreaterThanOrEqual<decimal>(1, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.GreaterThanOrEqual<float>(1, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.GreaterThanOrEqual<double>(1, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.GreaterThanOrEqual<MyTestEnum>(MyTestEnum.Two, typeof(MyCustomException)));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueEqualToLimitWithCustomExceptionTypeTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.GreaterThanOrEqual<short>(1, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.GreaterThanOrEqual<int>(1, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.GreaterThanOrEqual<long>(1, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.GreaterThanOrEqual<decimal>(1, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.GreaterThanOrEqual<float>(1, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.GreaterThanOrEqual<double>(1, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.GreaterThanOrEqual<MyTestEnum>(MyTestEnum.Two, typeof(MyCustomException), "arg1"));
        }


        [Fact]
        public void ReturnsExpectedInputGivenValueLessThanLimit()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInput, Guard.Protect(data.ShortInput).Against.GreaterThanOrEqual<short>(2).Input);
            Assert.Equal(data.IntInput, Guard.Protect(data.IntInput).Against.GreaterThanOrEqual<int>(2).Input);
            Assert.Equal(data.LongInput, Guard.Protect(data.LongInput).Against.GreaterThanOrEqual<long>(2).Input);
            Assert.Equal(data.DecimalInput, Guard.Protect(data.DecimalInput).Against.GreaterThanOrEqual<decimal>(2).Input);
            Assert.Equal(data.FloatInput, Guard.Protect(data.FloatInput).Against.GreaterThanOrEqual<float>(2).Input);
            Assert.Equal(data.DoubleInput, Guard.Protect(data.DoubleInput).Against.GreaterThanOrEqual<double>(2).Input);
            Assert.Equal(data.EnumInputTwo, Guard.Protect(data.EnumInputTwo).Against.GreaterThanOrEqual<MyTestEnum>(MyTestEnum.Three).Input);
        }



        #region Data

        class TestData
        {
            public short ShortInput { get; } = 1;
            public int IntInput { get; } = 1;
            public long LongInput { get; } = 1;
            public decimal DecimalInput { get; } = (decimal)1.0;
            public float FloatInput { get; } = (float)1.0;
            public double DoubleInput { get; } = 1.0;
            public DateTime DateTimeInput { get; } = DateTime.Now;
            public MyTestEnum EnumInputTwo { get; } = MyTestEnum.Two;
            public Guid GuidInput { get; } = Guid.Empty;
            public object ObjectInput { get; } = new object();
            public object NullObjectInput { get; } = null;
            public List<object> ListInput { get; } = new List<object>();
        }




        #endregion
    }
}
