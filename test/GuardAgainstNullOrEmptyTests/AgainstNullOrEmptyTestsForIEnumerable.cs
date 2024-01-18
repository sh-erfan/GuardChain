using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using Xunit;

namespace GuardChain.Tests.GuardAgainstNullOrEmptyTests
{
    public class AgainstNullOrEmptyTestsForIEnumerable
    {

        #region no custom exception

        [Fact]
        public void DoesNothingGivenNonEmptyList()
        {
            var data = new TestData();

            Guard.Protect(data.ListOfObjectsInputWithTwoItems).Against.NullOrEmpty();
        }


        [Fact]
        public void PreservesInputGivenNonEmptyList()
        {
            var data = new TestData();

            Assert.Equal(data.ListOfObjectsInputWithTwoItems, Guard.Protect(data.ListOfObjectsInputWithTwoItems).Against.NullOrEmpty().Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNonEmptyList()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ListOfObjectsInputWithTwoItems), Guard.Protect(data.ListOfObjectsInputWithTwoItems, nameof(data.ListOfObjectsInputWithTwoItems)).Against.NullOrEmpty().InputParameterName);
        }


        [Fact]
        public void ThrowsArgumentExceptionGivenEmptyList()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.ListOfObjectsInputWithNoItems).Against.NullOrEmpty());
        }

        [Fact]
        public void ThrowsArgumentNullExceptionGivenNullList()
        {
            var data = new TestData();

            Assert.Throws<ArgumentNullException>(() => Guard.Protect(data.ListOfObjectsInputWithNullValue).Against.NullOrEmpty());
        }


        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenNonEmptyListWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.ListOfObjectsInputWithTwoItems).Against.NullOrEmpty<MyCustomException>();
        }


        [Fact]
        public void PreservesInputGivenNonEmptyListWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.ListOfObjectsInputWithTwoItems, Guard.Protect(data.ListOfObjectsInputWithTwoItems).Against.NullOrEmpty<MyCustomException>().Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNonEmptyListWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ListOfObjectsInputWithTwoItems), Guard.Protect(data.ListOfObjectsInputWithTwoItems, nameof(data.ListOfObjectsInputWithTwoItems)).Against.NullOrEmpty<MyCustomException>().InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenEmptyListWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ListOfObjectsInputWithNoItems).Against.NullOrEmpty<MyCustomException>());
        }

        [Fact]
        public void ThrowCustomExceptionGivenNullListWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ListOfObjectsInputWithNullValue).Against.NullOrEmpty<MyCustomException>());
        }

        #endregion

        #region custom exception type as TException with constructor args

        [Fact]
        public void DoesNothingGivenNonEmptyListWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Guard.Protect(data.ListOfObjectsInputWithTwoItems).Against.NullOrEmpty<MyCustomException>("args1");
        }


        [Fact]
        public void PreservesInputGivenNonEmptyListWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.ListOfObjectsInputWithTwoItems, Guard.Protect(data.ListOfObjectsInputWithTwoItems).Against.NullOrEmpty<MyCustomException>("args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNonEmptyListWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ListOfObjectsInputWithTwoItems), Guard.Protect(data.ListOfObjectsInputWithTwoItems, nameof(data.ListOfObjectsInputWithTwoItems)).Against.NullOrEmpty<MyCustomException>("args1").InputParameterName);
        }


        [Fact]
        public void ThrowsCustomExceptionGivenEmptyListWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ListOfObjectsInputWithNoItems).Against.NullOrEmpty<MyCustomException>("args1"));
        }

        [Fact]
        public void ThrowCustomExceptionGivenNullListWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ListOfObjectsInputWithNullValue).Against.NullOrEmpty<MyCustomException>("args1"));
        }


        #endregion

        #region custom exception type as parameter

        [Fact]
        public void DoesNothingGivenNonEmptyListWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.ListOfObjectsInputWithTwoItems).Against.NullOrEmpty(typeof(MyCustomException));
        }


        [Fact]
        public void PreservesInputGivenNonEmptyListWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.ListOfObjectsInputWithTwoItems, Guard.Protect(data.ListOfObjectsInputWithTwoItems).Against.NullOrEmpty(typeof(MyCustomException)).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNonEmptyListWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ListOfObjectsInputWithTwoItems), Guard.Protect(data.ListOfObjectsInputWithTwoItems, nameof(data.ListOfObjectsInputWithTwoItems)).Against.NullOrEmpty(typeof(MyCustomException)).InputParameterName);
        }


        [Fact]
        public void ThrowsCustomExceptionGivenEmptyListWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ListOfObjectsInputWithNoItems).Against.NullOrEmpty(typeof(MyCustomException)));
        }

        [Fact]
        public void ThrowCustomExceptionGivenNullListWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ListOfObjectsInputWithNullValue).Against.NullOrEmpty(typeof(MyCustomException)));
        }



        #endregion

        #region custom exception type as parameter with constructor args


        [Fact]
        public void DoesNothingGivenNonEmptyListWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Guard.Protect(data.ListOfObjectsInputWithTwoItems).Against.NullOrEmpty(typeof(MyCustomException), "args1");
        }


        [Fact]
        public void PreservesInputGivenNonEmptyListWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.ListOfObjectsInputWithTwoItems, Guard.Protect(data.ListOfObjectsInputWithTwoItems).Against.NullOrEmpty(typeof(MyCustomException), "args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNonEmptyListWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ListOfObjectsInputWithTwoItems), Guard.Protect(data.ListOfObjectsInputWithTwoItems, nameof(data.ListOfObjectsInputWithTwoItems)).Against.NullOrEmpty(typeof(MyCustomException), "args1").InputParameterName);
        }


        [Fact]
        public void ThrowsCustomExceptionGivenEmptyListWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ListOfObjectsInputWithNoItems).Against.NullOrEmpty(typeof(MyCustomException), "args1"));
        }

        [Fact]
        public void ThrowCustomExceptionGivenNullListWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ListOfObjectsInputWithNullValue).Against.NullOrEmpty(typeof(MyCustomException), "args1"));
        }

        #endregion

    }
}
