using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using Xunit;

namespace GuardChain.Tests.GuardAgainstLessThanOrEqualTests
{
    public class GuardAgainstLessThanOrEqualTestsForTInput
    {
        [Fact]
        public void DoesNothingGivenValueGreaterThanLimit()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInput).Against.LessThanOrEqual<short>(0)
                .Protect(data.IntInput).Against.LessThanOrEqual<int>(0)
                .Protect(data.LongInput).Against.LessThanOrEqual<long>(0)
                .Protect(data.DecimalInput).Against.LessThanOrEqual<decimal>(0)
                .Protect(data.FloatInput).Against.LessThanOrEqual<float>(0)
                .Protect(data.DoubleInput).Against.LessThanOrEqual<double>(0)
                .Protect(data.EnumInputTwo).Against.LessThanOrEqual<MyTestEnum>(MyTestEnum.One);
        }

        [Fact]
        public void ThrowsArgumentExceptionGivenValueEqualToLimit()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.ShortInput).Against.LessThanOrEqual<short>(1));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.IntInput).Against.LessThanOrEqual<int>(1));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.LongInput).Against.LessThanOrEqual<long>(1));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DecimalInput).Against.LessThanOrEqual<decimal>(1));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.FloatInput).Against.LessThanOrEqual<float>(1));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DoubleInput).Against.LessThanOrEqual<double>(1));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.EnumInputTwo).Against.LessThanOrEqual<MyTestEnum>(MyTestEnum.Two));
        }

        [Fact]
        public void ThrowsArgumentExceptionGivenValueLessThanLimit()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.ShortInput).Against.LessThanOrEqual<short>(2));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.IntInput).Against.LessThanOrEqual<int>(2));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.LongInput).Against.LessThanOrEqual<long>(2));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DecimalInput).Against.LessThanOrEqual<decimal>(2));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.FloatInput).Against.LessThanOrEqual<float>(2));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DoubleInput).Against.LessThanOrEqual<double>(2));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.EnumInputTwo).Against.LessThanOrEqual<MyTestEnum>(MyTestEnum.Three));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueLessThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.LessThanOrEqual<MyCustomException, short>(2));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.LessThanOrEqual<MyCustomException, int>(2));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.LessThanOrEqual<MyCustomException, long>(2));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.LessThanOrEqual<MyCustomException, decimal>(2));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.LessThanOrEqual<MyCustomException, float>(2));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.LessThanOrEqual<MyCustomException, double>(2));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.LessThanOrEqual<MyCustomException, MyTestEnum>(MyTestEnum.Three));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueLessThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.LessThanOrEqual<MyCustomException, short>(2, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.LessThanOrEqual<MyCustomException, int>(2, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.LessThanOrEqual<MyCustomException, long>(2, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.LessThanOrEqual<MyCustomException, decimal>(2, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.LessThanOrEqual<MyCustomException, float>(2, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.LessThanOrEqual<MyCustomException, double>(2, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.LessThanOrEqual<MyCustomException, MyTestEnum>(MyTestEnum.Three, "arg1"));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueLessThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.LessThanOrEqual<short>(2, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.LessThanOrEqual<int>(2, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.LessThanOrEqual<long>(2, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.LessThanOrEqual<decimal>(2, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.LessThanOrEqual<float>(2, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.LessThanOrEqual<double>(2, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.LessThanOrEqual<MyTestEnum>(MyTestEnum.Three, typeof(MyCustomException)));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueLessThanLimitWithCustomExceptionTypeTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.LessThanOrEqual<short>(2, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.LessThanOrEqual<int>(2, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.LessThanOrEqual<long>(2, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.LessThanOrEqual<decimal>(2, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.LessThanOrEqual<float>(2, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.LessThanOrEqual<double>(2, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.LessThanOrEqual<MyTestEnum>(MyTestEnum.Three, typeof(MyCustomException), "arg1"));
        }


        [Fact]
        public void ThrowsCustomExceptionGivenValueEqualToLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.LessThanOrEqual<MyCustomException, short>(1));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.LessThanOrEqual<MyCustomException, int>(1));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.LessThanOrEqual<MyCustomException, long>(1));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.LessThanOrEqual<MyCustomException, decimal>(1));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.LessThanOrEqual<MyCustomException, float>(1));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.LessThanOrEqual<MyCustomException, double>(1));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.LessThanOrEqual<MyCustomException, MyTestEnum>(MyTestEnum.Two));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueEqualToLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.LessThanOrEqual<MyCustomException, short>(1, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.LessThanOrEqual<MyCustomException, int>(1, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.LessThanOrEqual<MyCustomException, long>(1, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.LessThanOrEqual<MyCustomException, decimal>(1, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.LessThanOrEqual<MyCustomException, float>(1, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.LessThanOrEqual<MyCustomException, double>(1, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.LessThanOrEqual<MyCustomException, MyTestEnum>(MyTestEnum.Two, "arg1"));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueEqualToLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.LessThanOrEqual<short>(1, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.LessThanOrEqual<int>(1, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.LessThanOrEqual<long>(1, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.LessThanOrEqual<decimal>(1, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.LessThanOrEqual<float>(1, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.LessThanOrEqual<double>(1, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.LessThanOrEqual<MyTestEnum>(MyTestEnum.Two, typeof(MyCustomException)));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueEqualToLimitWithCustomExceptionTypeTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.LessThanOrEqual<short>(1, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.LessThanOrEqual<int>(1, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.LessThanOrEqual<long>(1, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.LessThanOrEqual<decimal>(1, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.LessThanOrEqual<float>(1, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.LessThanOrEqual<double>(1, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.LessThanOrEqual<MyTestEnum>(MyTestEnum.Two, typeof(MyCustomException), "arg1"));
        }


        [Fact]
        public void ReturnsExpectedInputGivenValueGreaterThanLimit()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInput, Guard.Protect(data.ShortInput).Against.LessThanOrEqual<short>(0).Input);
            Assert.Equal(data.IntInput, Guard.Protect(data.IntInput).Against.LessThanOrEqual<int>(0).Input);
            Assert.Equal(data.LongInput, Guard.Protect(data.LongInput).Against.LessThanOrEqual<long>(0).Input);
            Assert.Equal(data.DecimalInput, Guard.Protect(data.DecimalInput).Against.LessThanOrEqual<decimal>(0).Input);
            Assert.Equal(data.FloatInput, Guard.Protect(data.FloatInput).Against.LessThanOrEqual<float>(0).Input);
            Assert.Equal(data.DoubleInput, Guard.Protect(data.DoubleInput).Against.LessThanOrEqual<double>(0).Input);
            Assert.Equal(data.EnumInputTwo, Guard.Protect(data.EnumInputTwo).Against.LessThanOrEqual<MyTestEnum>(MyTestEnum.One).Input);
        }

    }
}
