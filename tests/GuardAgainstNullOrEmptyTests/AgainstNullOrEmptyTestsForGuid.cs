using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using Xunit;

namespace GuardChain.Tests.GuardAgainstNullOrEmptyTests
{
    public class AgainstNullOrEmptyTestsForGuid
    {
        #region no custom exception

        [Fact]
        public void DoesNothingGivenNormalGuid()
        {
            var data = new TestData();

            Guard.Protect(data.GuidInputWithNormalValue).Against.NullOrEmpty();
        }


        [Fact]
        public void PreservesInputGivenNormalGuid()
        {
            var data = new TestData();

            Assert.Equal(data.GuidInputWithNormalValue, Guard.Protect(data.GuidInputWithNormalValue).Against.NullOrEmpty().Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNormalGuid()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.GuidInputWithNormalValue), Guard.Protect(data.GuidInputWithNormalValue, nameof(data.GuidInputWithNormalValue)).Against.NullOrEmpty().InputParameterName);
        }


        [Fact]
        public void ThrowsArgumentExceptionGivenEmptyGuid()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.GuidInputWithEmptyValue).Against.NullOrEmpty());
        }



        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenNormalGuidWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.GuidInputWithNormalValue).Against.NullOrEmpty<MyCustomException>();
        }


        [Fact]
        public void PreservesInputGivenNormalGuidWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.GuidInputWithNormalValue, Guard.Protect(data.GuidInputWithNormalValue).Against.NullOrEmpty<MyCustomException>().Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNormalGuidWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.GuidInputWithNormalValue), Guard.Protect(data.GuidInputWithNormalValue, nameof(data.GuidInputWithNormalValue)).Against.NullOrEmpty<MyCustomException>().InputParameterName);
        }


        [Fact]
        public void ThrowsCustomExceptionGivenEmptyGuidWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.GuidInputWithEmptyValue).Against.NullOrEmpty<MyCustomException>());
        }

       

        #endregion

        #region custom exception type as TException with constructor args

        [Fact]
        public void DoesNothingGivenNormalGuidWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Guard.Protect(data.GuidInputWithNormalValue).Against.NullOrEmpty<MyCustomException>("args1");
        }


        [Fact]
        public void PreservesInputGivenNormalGuidWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.GuidInputWithNormalValue, Guard.Protect(data.GuidInputWithNormalValue).Against.NullOrEmpty<MyCustomException>("args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNormalGuidWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.GuidInputWithNormalValue), Guard.Protect(data.GuidInputWithNormalValue, nameof(data.GuidInputWithNormalValue)).Against.NullOrEmpty<MyCustomException>("args1").InputParameterName);
        }


        [Fact]
        public void ThrowsCustomExceptionGivenEmptyGuidWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.GuidInputWithEmptyValue).Against.NullOrEmpty<MyCustomException>("args1"));
        }



        #endregion

        #region custom exception type as parameter

        [Fact]
        public void DoesNothingGivenNormalGuidWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.GuidInputWithNormalValue).Against.NullOrEmpty(typeof(MyCustomException));
        }


        [Fact]
        public void PreservesInputGivenNormalGuidWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.GuidInputWithNormalValue, Guard.Protect(data.GuidInputWithNormalValue).Against.NullOrEmpty(typeof(MyCustomException)).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNormalGuidWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.GuidInputWithNormalValue), Guard.Protect(data.GuidInputWithNormalValue, nameof(data.GuidInputWithNormalValue)).Against.NullOrEmpty(typeof(MyCustomException)).InputParameterName);
        }


        [Fact]
        public void ThrowsCustomExceptionGivenEmptyGuidWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.GuidInputWithEmptyValue).Against.NullOrEmpty(typeof(MyCustomException)));
        }


       
        #endregion

        #region custom exception type as parameter with constructor args


        [Fact]
        public void DoesNothingGivenNormalGuidWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Guard.Protect(data.GuidInputWithNormalValue).Against.NullOrEmpty(typeof(MyCustomException), "args1");
        }


        [Fact]
        public void PreservesInputGivenNormalGuidWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.GuidInputWithNormalValue, Guard.Protect(data.GuidInputWithNormalValue).Against.NullOrEmpty(typeof(MyCustomException), "args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNormalGuidWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.GuidInputWithNormalValue), Guard.Protect(data.GuidInputWithNormalValue, nameof(data.GuidInputWithNormalValue)).Against.NullOrEmpty(typeof(MyCustomException), "args1").InputParameterName);
        }

       
        [Fact]
        public void ThrowsCustomExceptionGivenEmptyGuidWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.GuidInputWithEmptyValue).Against.NullOrEmpty(typeof(MyCustomException), "args1"));
        }

       
        #endregion
    }
}
