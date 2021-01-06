using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using Xunit;

namespace GuardChain.Tests.GuardAgainstLessThanTests
{
    public class GuardAgainstLessThanTestsForTInput
    {
        [Fact]
        public void DoesNothingGivenValueGreaterThanLimit()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInput).Against.LessThan<short>(0)
                .Protect(data.IntInput).Against.LessThan<int>(0)
                .Protect(data.LongInput).Against.LessThan<long>(0)
                .Protect(data.DecimalInput).Against.LessThan<decimal>(0)
                .Protect(data.FloatInput).Against.LessThan<float>(0)
                .Protect(data.DoubleInput).Against.LessThan<double>(0)
                .Protect(data.EnumInputTwo).Against.LessThan<MyTestEnum>(MyTestEnum.One);
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimit()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInput).Against.LessThan<short>(1)
                .Protect(data.IntInput).Against.LessThan<int>(1)
                .Protect(data.LongInput).Against.LessThan<long>(1)
                .Protect(data.DecimalInput).Against.LessThan<decimal>(1)
                .Protect(data.FloatInput).Against.LessThan<float>(1)
                .Protect(data.DoubleInput).Against.LessThan<double>(1)
                .Protect(data.EnumInputTwo).Against.LessThan<MyTestEnum>(MyTestEnum.Two);
        }

        [Fact]
        public void ThrowsArgumentExceptionGivenValueLessThanLimit()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.ShortInput).Against.LessThan<short>(2));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.IntInput).Against.LessThan<int>(2));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.LongInput).Against.LessThan<long>(2));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DecimalInput).Against.LessThan<decimal>(2));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.FloatInput).Against.LessThan<float>(2));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DoubleInput).Against.LessThan<double>(2));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.EnumInputTwo).Against.LessThan<MyTestEnum>(MyTestEnum.Three));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueLessThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.LessThan<MyCustomException, short>(2));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.LessThan<MyCustomException, int>(2));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.LessThan<MyCustomException, long>(2));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.LessThan<MyCustomException, decimal>(2));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.LessThan<MyCustomException, float>(2));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.LessThan<MyCustomException, double>(2));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.LessThan<MyCustomException, MyTestEnum>(MyTestEnum.Three));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueLessThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.LessThan<MyCustomException, short>(2, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.LessThan<MyCustomException, int>(2, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.LessThan<MyCustomException, long>(2, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.LessThan<MyCustomException, decimal>(2, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.LessThan<MyCustomException, float>(2, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.LessThan<MyCustomException, double>(2, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.LessThan<MyCustomException, MyTestEnum>(MyTestEnum.Three, "arg1"));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueLessThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.LessThan<short>(2, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.LessThan<int>(2, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.LessThan<long>(2, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.LessThan<decimal>(2, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.LessThan<float>(2, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.LessThan<double>(2, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.LessThan<MyTestEnum>(MyTestEnum.Three, typeof(MyCustomException)));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueLessThanLimitWithCustomExceptionTypeTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.LessThan<short>(2, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.LessThan<int>(2, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.LessThan<long>(2, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.LessThan<decimal>(2, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.LessThan<float>(2, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.LessThan<double>(2, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.LessThan<MyTestEnum>(MyTestEnum.Three, typeof(MyCustomException), "arg1"));
        }


        [Fact]
        public void ReturnsExpectedInputGivenValueGreaterThanLimit()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInput, Guard.Protect(data.ShortInput).Against.LessThan<short>(0).Input);
            Assert.Equal(data.IntInput, Guard.Protect(data.IntInput).Against.LessThan<int>(0).Input);
            Assert.Equal(data.LongInput, Guard.Protect(data.LongInput).Against.LessThan<long>(0).Input);
            Assert.Equal(data.DecimalInput, Guard.Protect(data.DecimalInput).Against.LessThan<decimal>(0).Input);
            Assert.Equal(data.FloatInput, Guard.Protect(data.FloatInput).Against.LessThan<float>(0).Input);
            Assert.Equal(data.DoubleInput, Guard.Protect(data.DoubleInput).Against.LessThan<double>(0).Input);
            Assert.Equal(data.EnumInputTwo, Guard.Protect(data.EnumInputTwo).Against.LessThan<MyTestEnum>(MyTestEnum.One).Input);
        }

        [Fact]
        public void ReturnsExpectedInputGivenValueEqualToLimit()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInput, Guard.Protect(data.ShortInput).Against.LessThan<short>(1).Input);
            Assert.Equal(data.IntInput, Guard.Protect(data.IntInput).Against.LessThan<int>(1).Input);
            Assert.Equal(data.LongInput, Guard.Protect(data.LongInput).Against.LessThan<long>(1).Input);
            Assert.Equal(data.DecimalInput, Guard.Protect(data.DecimalInput).Against.LessThan<decimal>(1).Input);
            Assert.Equal(data.FloatInput, Guard.Protect(data.FloatInput).Against.LessThan<float>(1).Input);
            Assert.Equal(data.DoubleInput, Guard.Protect(data.DoubleInput).Against.LessThan<double>(1).Input);
            Assert.Equal(data.EnumInputTwo, Guard.Protect(data.EnumInputTwo).Against.LessThan<MyTestEnum>(MyTestEnum.Two).Input);
        }
    }
}
