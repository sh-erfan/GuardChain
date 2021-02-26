using System;
using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using Xunit;

namespace GuardChain.Tests.GuardAgainstLessThanOrEqualTests
{
    public class AgainstLessThanOrEqualTestsForFloat
    {

        #region no custom exception

        [Fact]
        public void DoesNothingGivenValueGreaterThanLimit()
        {
            var data = new TestData();

            Guard.Protect(data.FloatInputWithValue1).Against.LessThanOrEqual(0);


        }

        [Fact]
        public void PreservesInputGivenValueGreaterThanLimit()
        {
            var data = new TestData();

            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.LessThanOrEqual(0).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueGreaterThanLimit()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.LessThanOrEqual(0).InputParameterName);
        }

        [Fact]
        public void ThrowsArgumentExceptionGivenValueEqualToLimit()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.FloatInputWithValue1).Against.LessThanOrEqual(1));
        }

        [Fact]
        public void ThrowsArgumentExceptionGivenValueLessThanLimit()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.FloatInputWithValue1).Against.LessThanOrEqual(2));
        }

        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenValueGreaterThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.FloatInputWithValue1).Against.LessThanOrEqual<MyCustomException>(0);

        }

        [Fact]
        public void PreservesInputGivenValueGreaterThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.LessThanOrEqual<MyCustomException>(0).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueGreaterThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.LessThanOrEqual<MyCustomException>(0).InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueEqualToLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.LessThanOrEqual<MyCustomException>(1));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueLessThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.LessThanOrEqual<MyCustomException>(2));
        }

        #endregion

        #region custom exception type as TException with constructor args

        [Fact]
        public void DoesNothingGivenValueGreaterThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Guard.Protect(data.FloatInputWithValue1).Against.LessThanOrEqual<MyCustomException>(0, "args1");
        }

        [Fact]
        public void PreservesInputGivenValueGreaterThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.LessThanOrEqual<MyCustomException>(0, "args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueGreaterThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.LessThanOrEqual<MyCustomException>(0, "args1").InputParameterName);
        }


        [Fact]
        public void ThrowsCustomExceptionGivenValueEqualToLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.LessThanOrEqual<MyCustomException>(1, "args1"));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueLessThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.LessThanOrEqual<MyCustomException>(2, "args1"));
        }

        #endregion

        #region custom exception type as parameter

        [Fact]
        public void DoesNothingGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.FloatInputWithValue1).Against.LessThanOrEqual(0, typeof(MyCustomException));
        }

        [Fact]
        public void PreservesInputGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.LessThanOrEqual(0, typeof(MyCustomException)).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.LessThanOrEqual(0, typeof(MyCustomException)).InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueEqualToLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.LessThanOrEqual(1, typeof(MyCustomException)));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueLessThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.LessThanOrEqual(2, typeof(MyCustomException)));
        }

        #endregion

        #region custom exception type as parameter with constructor args

        [Fact]
        public void DoesNothingGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Guard.Protect(data.FloatInputWithValue1).Against.LessThanOrEqual(0, typeof(MyCustomException), "args1");
        }

        [Fact]
        public void PreservesInputGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.LessThanOrEqual(0, typeof(MyCustomException), "args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.LessThanOrEqual(0, typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueEqualToLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.LessThanOrEqual(1, typeof(MyCustomException), "args1"));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueLessThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.LessThanOrEqual(2, typeof(MyCustomException), "args1"));
        }

        #endregion

    }
}
