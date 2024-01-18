using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using Xunit;

namespace GuardChain.Tests.GuardAgainstPositiveTests
{
    public class AgainstPositiveTestsForLong
    {
        #region no custom exception

        [Fact]
        public void DoesNothingGivenNegativeValue()
        {
            var data = new TestData();

            Guard.Protect(data.LongInputWithValueMinus1).Against.Positive();
        }

        [Fact]
        public void DoesNothingGivenZeroValue()
        {
            var data = new TestData();

            Guard.Protect(data.LongInputWithValue0).Against.Positive();
        }

        [Fact]
        public void PreservesInputGivenNegativeValue()
        {
            var data = new TestData();

            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.Positive().Input);
        }

        [Fact]
        public void PreservesInputGivenZeroValue()
        {
            var data = new TestData();

            Assert.Equal(data.LongInputWithValue0, Guard.Protect(data.LongInputWithValue0).Against.Positive().Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNegativeValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.Positive().InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenZeroValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.LongInputWithValue0), Guard.Protect(data.LongInputWithValue0, nameof(data.LongInputWithValue0)).Against.Positive().InputParameterName);
        }

        [Fact]
        public void ThrowsArgumentExceptionGivenPositiveValue()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.LongInputWithValue1).Against.Positive());
        }


        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.LongInputWithValueMinus1).Against.Positive<MyCustomException>();
        }

        [Fact]
        public void DoesNothingGivenZeroValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.LongInputWithValue0).Against.Positive<MyCustomException>();
        }

        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.Positive<MyCustomException>().Input);
        }

        [Fact]
        public void PreservesInputGivenZeroValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.LongInputWithValue0, Guard.Protect(data.LongInputWithValue0).Against.Positive<MyCustomException>().Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.Positive<MyCustomException>().InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenZeroValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.LongInputWithValue0), Guard.Protect(data.LongInputWithValue0, nameof(data.LongInputWithValue0)).Against.Positive<MyCustomException>().InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenPositiveValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.Positive<MyCustomException>());
        }

        #endregion

        #region custom exception type as TException with constructor args

        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.LongInputWithValueMinus1).Against.Positive<MyCustomException>("ags1");
        }

        [Fact]
        public void DoesNothingGivenZeroValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.LongInputWithValue0).Against.Positive<MyCustomException>("ags1");
        }

        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.Positive<MyCustomException>("ags1").Input);
        }

        [Fact]
        public void PreservesInputGivenZeroValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.LongInputWithValue0, Guard.Protect(data.LongInputWithValue0).Against.Positive<MyCustomException>("ags1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.Positive<MyCustomException>("ags1").InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenZeroValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.LongInputWithValue0), Guard.Protect(data.LongInputWithValue0, nameof(data.LongInputWithValue0)).Against.Positive<MyCustomException>("ags1").InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenPositiveValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.Positive<MyCustomException>("ags1"));
        }

        #endregion

        #region custom exception type as parameter

        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.LongInputWithValueMinus1).Against.Positive(typeof(MyCustomException));
        }

        [Fact]
        public void DoesNothingGivenZeroValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.LongInputWithValue0).Against.Positive(typeof(MyCustomException));
        }

        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.Positive(typeof(MyCustomException)).Input);
        }

        [Fact]
        public void PreservesInputGivenZeroValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.LongInputWithValue0, Guard.Protect(data.LongInputWithValue0).Against.Positive(typeof(MyCustomException)).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.Positive(typeof(MyCustomException)).InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenZeroValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.LongInputWithValue0), Guard.Protect(data.LongInputWithValue0, nameof(data.LongInputWithValue0)).Against.Positive(typeof(MyCustomException)).InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenPositiveValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.Positive(typeof(MyCustomException)));
        }

        #endregion

        #region custom exception type as parameter with constructor args

        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.LongInputWithValueMinus1).Against.Positive(typeof(MyCustomException), "args1");
        }

        [Fact]
        public void DoesNothingGivenZeroValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.LongInputWithValue0).Against.Positive(typeof(MyCustomException), "args1");
        }

        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.Positive(typeof(MyCustomException), "args1").Input);
        }

        [Fact]
        public void PreservesInputGivenZeroValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.LongInputWithValue0, Guard.Protect(data.LongInputWithValue0).Against.Positive(typeof(MyCustomException), "args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.Positive(typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenZeroValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.LongInputWithValue0), Guard.Protect(data.LongInputWithValue0, nameof(data.LongInputWithValue0)).Against.Positive(typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenPositiveValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.Positive(typeof(MyCustomException), "args1"));
        }

        #endregion
    }
}
