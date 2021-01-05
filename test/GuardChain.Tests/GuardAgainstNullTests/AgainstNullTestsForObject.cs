using GuardChain.Extensions;
using GuardChain.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuardChain.Tests.GuardAgainstNullTests
{
    public class AgainstNullTestsForObject
    {
        [Fact]
        public void DoesNothingGivenNonNullObject()
        {
            var data = new TestData();

            Guard.Protect(data.NonNullObject).Against.Null();
        }

        [Fact]
        public void ThrowsArgumentNullExceptionGivenNullObject()
        {
            var data = new TestData();

            Assert.Throws<ArgumentNullException>(() => Guard.Protect(data.NullObject).Against.Null());
        }

        [Fact]
        public void ThrowsCustomExceptionGivenNullObjectWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.NullObject).Against.Null<MyCustomException>());
        }

        [Fact]
        public void ThrowsCustomExceptionGivenNullObjectWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.NullObject).Against.Null<MyCustomException>("arg1"));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenNullObjectWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.NullObject).Against.Null(typeof(MyCustomException)));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenNullObjectWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.NullObject).Against.Null(typeof(MyCustomException), "arg1"));
        }

        [Fact]
        public void ReturnsExpectedInputGivenNonNullObject()
        {
            var data = new TestData();

            Assert.Equal(data.NonNullObject, Guard.Protect(data.NonNullObject).Against.Null().Input);
        }

        [Fact]
        public void ReturnsExpectedInputGivenNonNullObjectWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.NonNullObject, Guard.Protect(data.NonNullObject).Against.Null<MyCustomException>().Input);
        }

        [Fact]
        public void ReturnsExpectedInputGivenNonNullObjectWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.NonNullObject, Guard.Protect(data.NonNullObject).Against.Null<MyCustomException>("arg1").Input);
        }

        [Fact]
        public void ReturnsExpectedInputGivenNonNullObjectWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.NonNullObject, Guard.Protect(data.NonNullObject).Against.Null(typeof(MyCustomException)).Input);
        }

        [Fact]
        public void ReturnsExpectedInputGivenNonNullObjectWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.NonNullObject, Guard.Protect(data.NonNullObject).Against.Null(typeof(MyCustomException), "arg1").Input);
        }

        #region Data

        class TestData
        {
            public object NullObject { get; } = null;
            public object NonNullObject { get; } = new object();
        }

        class MyCustomException : Exception
        {
            public MyCustomException() : base()
            {

            }

            public MyCustomException(string message) : base(message)
            {

            }
        }

        #endregion
    }
}
