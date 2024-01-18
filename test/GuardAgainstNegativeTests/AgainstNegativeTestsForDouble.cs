using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using Xunit;

namespace GuardChain.Tests.GuardAgainstNegativeTests
{
    public class AgainstNegativeTestsForDouble
    {
        #region no custom exception

        [Fact]
        public void DoesNothingGivenPositiveValue()
        {
            var data = new TestData();

            Guard.Protect(data.DoubleInputWithValue1).Against.Negative();

        }

        [Fact]
        public void DoesNothingGivenZeroValue()
        {
            var data = new TestData();

            Guard.Protect(data.DoubleInputWithValue0).Against.Negative();
        }

        [Fact]
        public void PreservesInputGivenPositiveValue()
        {
            var data = new TestData();

            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Negative().Input);
        }

        [Fact]
        public void PreservesInputGivenZeroValue()
        {
            var data = new TestData();

            Assert.Equal(data.DoubleInputWithValue0, Guard.Protect(data.DoubleInputWithValue0).Against.Negative().Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenPositiveValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Negative().InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenZeroValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DoubleInputWithValue0), Guard.Protect(data.DoubleInputWithValue0, nameof(data.DoubleInputWithValue0)).Against.Negative().InputParameterName);
        }

        [Fact]
        public void ThrowsArgumentExceptionGivenNegativeValue()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DoubleInputWithValueMinus1).Against.Negative());
        }


        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenPositiveValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.DoubleInputWithValue1).Against.Negative<MyCustomException>();
        }

        [Fact]
        public void DoesNothingGivenZeroValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.DoubleInputWithValue0).Against.Negative<MyCustomException>();
        }

        [Fact]
        public void PreservesInputGivenPositiveValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Negative<MyCustomException>().Input);
        }

        [Fact]
        public void PreservesInputGivenZeroValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.DoubleInputWithValue0, Guard.Protect(data.DoubleInputWithValue0).Against.Negative<MyCustomException>().Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenPositiveValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Negative<MyCustomException>().InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenZeroValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DoubleInputWithValue0), Guard.Protect(data.DoubleInputWithValue0, nameof(data.DoubleInputWithValue0)).Against.Negative<MyCustomException>().InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenNegativeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValueMinus1).Against.Negative<MyCustomException>());
        }

        #endregion

        #region custom exception type as TException with constructor args

        [Fact]
        public void DoesNothingGivenPositiveValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.DoubleInputWithValue1).Against.Negative<MyCustomException>("ags1");
        }

        [Fact]
        public void DoesNothingGivenZeroValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.DoubleInputWithValue0).Against.Negative<MyCustomException>("ags1");
        }

        [Fact]
        public void PreservesInputGivenPositiveValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Negative<MyCustomException>("ags1").Input);
        }

        [Fact]
        public void PreservesInputGivenZeroValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.DoubleInputWithValue0, Guard.Protect(data.DoubleInputWithValue0).Against.Negative<MyCustomException>("ags1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenPositiveValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Negative<MyCustomException>("ags1").InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenZeroValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DoubleInputWithValue0), Guard.Protect(data.DoubleInputWithValue0, nameof(data.DoubleInputWithValue0)).Against.Negative<MyCustomException>("ags1").InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenNegativeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValueMinus1).Against.Negative<MyCustomException>("ags1"));
        }

        #endregion

        #region custom exception type as parameter

        [Fact]
        public void DoesNothingGivenPositiveValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.DoubleInputWithValue1).Against.Negative(typeof(MyCustomException));
        }

        [Fact]
        public void DoesNothingGivenZeroValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.DoubleInputWithValue0).Against.Negative(typeof(MyCustomException));
        }

        [Fact]
        public void PreservesInputGivenPositiveValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Negative(typeof(MyCustomException)).Input);
        }

        [Fact]
        public void PreservesInputGivenZeroValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.DoubleInputWithValue0, Guard.Protect(data.DoubleInputWithValue0).Against.Negative(typeof(MyCustomException)).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenPositiveValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Negative(typeof(MyCustomException)).InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenZeroValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DoubleInputWithValue0), Guard.Protect(data.DoubleInputWithValue0, nameof(data.DoubleInputWithValue0)).Against.Negative(typeof(MyCustomException)).InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenNegativeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValueMinus1).Against.Negative(typeof(MyCustomException)));
        }

        #endregion

        #region custom exception type as parameter with constructor args

        [Fact]
        public void DoesNothingGivenPositiveValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.DoubleInputWithValue1).Against.Negative(typeof(MyCustomException), "args1");
        }

        [Fact]
        public void DoesNothingGivenZeroValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.DoubleInputWithValue0).Against.Negative(typeof(MyCustomException), "args1");
        }

        [Fact]
        public void PreservesInputGivenPositiveValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Negative(typeof(MyCustomException), "args1").Input);
        }

        [Fact]
        public void PreservesInputGivenZeroValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.DoubleInputWithValue0, Guard.Protect(data.DoubleInputWithValue0).Against.Negative(typeof(MyCustomException), "args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenPositiveValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Negative(typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenZeroValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DoubleInputWithValue0), Guard.Protect(data.DoubleInputWithValue0, nameof(data.DoubleInputWithValue0)).Against.Negative(typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenNegativeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValueMinus1).Against.Negative(typeof(MyCustomException), "args1"));
        }

        #endregion
    }
}
