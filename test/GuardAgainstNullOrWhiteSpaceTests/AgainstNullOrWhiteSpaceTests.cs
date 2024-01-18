using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using Xunit;

namespace GuardChain.Tests.GuardAgainstNullOrWhiteSpaceTests
{
    public class AgainstNullOrWhiteSpaceTests
    {
        #region no custom exception

        [Fact]
        public void DoesNothingGivenNormalString()
        {
            var data = new TestData();

            Guard.Protect(data.StringInputWithNormalValue).Against.NullOrWhiteSpace();
        }


        [Fact]
        public void PreservesInputGivenNormalString()
        {
            var data = new TestData();

            Assert.Equal(data.StringInputWithNormalValue, Guard.Protect(data.StringInputWithNormalValue).Against.NullOrWhiteSpace().Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNormalString()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.StringInputWithNormalValue), Guard.Protect(data.StringInputWithNormalValue, nameof(data.StringInputWithNormalValue)).Against.NullOrWhiteSpace().InputParameterName);
        }

        [Fact]
        public void ThrowsArgumentExceptionGivenZeroLengthString()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.StringInputWithZeroLength).Against.NullOrWhiteSpace());
        }

        [Fact]
        public void ThrowsArgumentExceptionGivenEmptyString()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.StringInputWithEmptyValue).Against.NullOrWhiteSpace());
        }

        [Fact]
        public void ThrowsArgumentNullExceptionGivenNullString()
        {
            var data = new TestData();

            Assert.Throws<ArgumentNullException>(() => Guard.Protect(data.StringInputWithNullValue).Against.NullOrWhiteSpace());
        }

        [Fact]
        public void ThrowsArgumentExceptionGivenWhiteSpaceString()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.StringInputWithWhiteSpacesValue).Against.NullOrWhiteSpace());
        }


        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenNormalStringWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.StringInputWithNormalValue).Against.NullOrWhiteSpace<MyCustomException>();
        }


        [Fact]
        public void PreservesInputGivenNormalStringWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.StringInputWithNormalValue, Guard.Protect(data.StringInputWithNormalValue).Against.NullOrWhiteSpace<MyCustomException>().Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNormalStringWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.StringInputWithNormalValue), Guard.Protect(data.StringInputWithNormalValue, nameof(data.StringInputWithNormalValue)).Against.NullOrWhiteSpace<MyCustomException>().InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenZeroLengthStringWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.StringInputWithZeroLength).Against.NullOrWhiteSpace<MyCustomException>());
        }

        [Fact]
        public void ThrowsCustomExceptionGivenEmptyStringWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.StringInputWithEmptyValue).Against.NullOrWhiteSpace<MyCustomException>());
        }

        [Fact]
        public void ThrowCustomExceptionGivenNullStringWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.StringInputWithNullValue).Against.NullOrWhiteSpace<MyCustomException>());
        }

        [Fact]
        public void ThrowCustomExceptionGivenWhiteSpaceStringWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.StringInputWithWhiteSpacesValue).Against.NullOrWhiteSpace<MyCustomException>());
        }

        #endregion

        #region custom exception type as TException with constructor args

        [Fact]
        public void DoesNothingGivenNormalStringWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Guard.Protect(data.StringInputWithNormalValue).Against.NullOrWhiteSpace<MyCustomException>("args1");
        }


        [Fact]
        public void PreservesInputGivenNormalStringWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.StringInputWithNormalValue, Guard.Protect(data.StringInputWithNormalValue).Against.NullOrWhiteSpace<MyCustomException>("args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNormalStringWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.StringInputWithNormalValue), Guard.Protect(data.StringInputWithNormalValue, nameof(data.StringInputWithNormalValue)).Against.NullOrWhiteSpace<MyCustomException>("args1").InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenZeroLengthStringWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.StringInputWithZeroLength).Against.NullOrWhiteSpace<MyCustomException>("args1"));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenEmptyStringWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.StringInputWithEmptyValue).Against.NullOrWhiteSpace<MyCustomException>("args1"));
        }

        [Fact]
        public void ThrowCustomExceptionGivenNullStringWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.StringInputWithNullValue).Against.NullOrWhiteSpace<MyCustomException>("args1"));
        }


        [Fact]
        public void ThrowCustomExceptionGiveWhiteSpaceStringWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.StringInputWithWhiteSpacesValue).Against.NullOrWhiteSpace<MyCustomException>("args1"));
        }

        #endregion

        #region custom exception type as parameter

        [Fact]
        public void DoesNothingGivenNormalStringWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.StringInputWithNormalValue).Against.NullOrWhiteSpace(typeof(MyCustomException));
        }


        [Fact]
        public void PreservesInputGivenNormalStringWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.StringInputWithNormalValue, Guard.Protect(data.StringInputWithNormalValue).Against.NullOrWhiteSpace(typeof(MyCustomException)).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNormalStringWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.StringInputWithNormalValue), Guard.Protect(data.StringInputWithNormalValue, nameof(data.StringInputWithNormalValue)).Against.NullOrWhiteSpace(typeof(MyCustomException)).InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenZeroLengthStringWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.StringInputWithZeroLength).Against.NullOrWhiteSpace(typeof(MyCustomException)));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenEmptyStringWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.StringInputWithEmptyValue).Against.NullOrWhiteSpace(typeof(MyCustomException)));
        }

        [Fact]
        public void ThrowCustomExceptionGivenNullStringWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.StringInputWithNullValue).Against.NullOrWhiteSpace(typeof(MyCustomException)));
        }

        [Fact]
        public void ThrowCustomExceptionGivenWhiteSpaceStringWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.StringInputWithWhiteSpacesValue).Against.NullOrWhiteSpace(typeof(MyCustomException)));
        }



        #endregion

        #region custom exception type as parameter with constructor args


        [Fact]
        public void DoesNothingGivenNormalStringWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Guard.Protect(data.StringInputWithNormalValue).Against.NullOrWhiteSpace(typeof(MyCustomException), "args1");
        }


        [Fact]
        public void PreservesInputGivenNormalStringWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.StringInputWithNormalValue, Guard.Protect(data.StringInputWithNormalValue).Against.NullOrWhiteSpace(typeof(MyCustomException), "args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNormalStringWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.StringInputWithNormalValue), Guard.Protect(data.StringInputWithNormalValue, nameof(data.StringInputWithNormalValue)).Against.NullOrWhiteSpace(typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenZeroLengthStringWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.StringInputWithZeroLength).Against.NullOrWhiteSpace(typeof(MyCustomException), "args1"));
        }

        [Fact]
        public void ThrowsCustomExceptionGivenEmptyStringWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.StringInputWithEmptyValue).Against.NullOrWhiteSpace(typeof(MyCustomException), "args1"));
        }

        [Fact]
        public void ThrowCustomExceptionGivenNullStringWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.StringInputWithNullValue).Against.NullOrWhiteSpace(typeof(MyCustomException), "args1"));
        }

        [Fact]
        public void ThrowCustomExceptionGivenWhiteSpaceStringWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.StringInputWithWhiteSpacesValue).Against.NullOrWhiteSpace(typeof(MyCustomException), "args1"));
        }

        #endregion
    }
}
