using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using Newtonsoft.Json.Serialization;
using Xunit;

namespace GuardChain.Tests.GuardAgainstGreaterThanTests
{
    public class AgainstGreaterThanTestsForTInput
    {
        [Fact]
        public void DoesNothingGivenValueLessThanLimit()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInput).Against.GreaterThan<short>(2)
                .Protect(data.IntInput).Against.GreaterThan<int>(2)
                .Protect(data.LongInput).Against.GreaterThan<long>(2)
                .Protect(data.DecimalInput).Against.GreaterThan<decimal>(2)
                .Protect(data.FloatInput).Against.GreaterThan<float>(2)
                .Protect(data.DoubleInput).Against.GreaterThan<double>(2)
                .Protect(data.EnumInputTwo).Against.GreaterThan<MyTestEnum>(MyTestEnum.Three);
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimit()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInput).Against.GreaterThan<short>(1)
                .Protect(data.IntInput).Against.GreaterThan<int>(1)
                .Protect(data.LongInput).Against.GreaterThan<long>(1)
                .Protect(data.DecimalInput).Against.GreaterThan<decimal>(1)
                .Protect(data.FloatInput).Against.GreaterThan<float>(1)
                .Protect(data.DoubleInput).Against.GreaterThan<double>(1)
                .Protect(data.EnumInputTwo).Against.GreaterThan<MyTestEnum>(MyTestEnum.Two);
        }

        [Fact]
        public void ThrowsArgumentExceptionGivenValueGreaterThanLimit()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.ShortInput).Against.GreaterThan<short>(0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.IntInput).Against.GreaterThan<int>(0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.LongInput).Against.GreaterThan<long>(0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DecimalInput).Against.GreaterThan<decimal>(0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.FloatInput).Against.GreaterThan<float>(0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DoubleInput).Against.GreaterThan<double>(0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.EnumInputTwo).Against.GreaterThan<MyTestEnum>(MyTestEnum.One));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.GreaterThan<MyCustomException, short>(0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.GreaterThan<MyCustomException, int>(0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.GreaterThan<MyCustomException, long>(0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.GreaterThan<MyCustomException, decimal>(0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.GreaterThan<MyCustomException, float>(0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.GreaterThan<MyCustomException, double>(0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.GreaterThan<MyCustomException, MyTestEnum>(MyTestEnum.One));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.GreaterThan<MyCustomException, short>(0, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.GreaterThan<MyCustomException, int>(0, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.GreaterThan<MyCustomException, long>(0, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.GreaterThan<MyCustomException, decimal>(0, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.GreaterThan<MyCustomException, float>(0, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.GreaterThan<MyCustomException, double>(0, "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.GreaterThan<MyCustomException, MyTestEnum>(MyTestEnum.One, "arg1"));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueGreaterThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.GreaterThan<short>(0, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.GreaterThan<int>(0, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.GreaterThan<long>(0, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.GreaterThan<decimal>(0, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.GreaterThan<float>(0, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.GreaterThan<double>(0, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.GreaterThan<MyTestEnum>(MyTestEnum.One, typeof(MyCustomException)));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueGreaterThanLimitWithCustomExceptionTypeTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInput).Against.GreaterThan<short>(0, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInput).Against.GreaterThan<int>(0, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInput).Against.GreaterThan<long>(0, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInput).Against.GreaterThan<decimal>(0, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInput).Against.GreaterThan<float>(0, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInput).Against.GreaterThan<double>(0, typeof(MyCustomException), "arg1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputTwo).Against.GreaterThan<MyTestEnum>(MyTestEnum.One, typeof(MyCustomException), "arg1"));
        }


        [Fact]
        public void ReturnsExpectedInputGivenValueLessThanLimit()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInput, Guard.Protect(data.ShortInput).Against.GreaterThan<short>(2).Input);
            Assert.Equal(data.IntInput, Guard.Protect(data.IntInput).Against.GreaterThan<int>(2).Input);
            Assert.Equal(data.LongInput, Guard.Protect(data.LongInput).Against.GreaterThan<long>(2).Input);
            Assert.Equal(data.DecimalInput, Guard.Protect(data.DecimalInput).Against.GreaterThan<decimal>(2).Input);
            Assert.Equal(data.FloatInput, Guard.Protect(data.FloatInput).Against.GreaterThan<float>(2).Input);
            Assert.Equal(data.DoubleInput, Guard.Protect(data.DoubleInput).Against.GreaterThan<double>(2).Input);
            Assert.Equal(data.EnumInputTwo, Guard.Protect(data.EnumInputTwo).Against.GreaterThan<MyTestEnum>(MyTestEnum.Three).Input);
        }

        [Fact]
        public void ReturnsExpectedInputGivenValueEqualToLimit()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInput, Guard.Protect(data.ShortInput).Against.GreaterThan<short>(1).Input);
            Assert.Equal(data.IntInput, Guard.Protect(data.IntInput).Against.GreaterThan<int>(1).Input);
            Assert.Equal(data.LongInput, Guard.Protect(data.LongInput).Against.GreaterThan<long>(1).Input);
            Assert.Equal(data.DecimalInput, Guard.Protect(data.DecimalInput).Against.GreaterThan<decimal>(1).Input);
            Assert.Equal(data.FloatInput, Guard.Protect(data.FloatInput).Against.GreaterThan<float>(1).Input);
            Assert.Equal(data.DoubleInput, Guard.Protect(data.DoubleInput).Against.GreaterThan<double>(1).Input);
            Assert.Equal(data.EnumInputTwo, Guard.Protect(data.EnumInputTwo).Against.GreaterThan<MyTestEnum>(MyTestEnum.Two).Input);
        }


    }
}
