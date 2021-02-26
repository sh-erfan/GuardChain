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
    public class AgainstGreaterThanTestsForFloat
    {
        #region no custom exception

        [Fact]
        public void DoesNothingGivenValueLessThanLimit()
        {
            var data = new TestData();

            Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan(2);

        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimit()
        {
            var data = new TestData();

            Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan(1);
        }

        [Fact]
        public void PreservesInputGivenValueLessThanLimit()
        {
            var data = new TestData();

            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan(2).Input);
        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimit()
        {
            var data = new TestData();

            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan(1).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueLessThanLimit()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.GreaterThan(2).InputParameterName);

        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimit()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.GreaterThan(1).InputParameterName);

        }

        [Fact]
        public void ThrowsArgumentExceptionGivenValueGreaterThanLimit()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan(0));

        }

        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenValueLessThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<MyCustomException>(2);
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<MyCustomException>(1);

        }

        [Fact]
        public void PreservesInputGivenValueLessThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<MyCustomException>(2).Input);
        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<MyCustomException>(1).Input);

        }

        [Fact]
        public void PreservesInputParameterNameGivenValueLessThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.GreaterThan<MyCustomException>(2).InputParameterName);

        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.GreaterThan<MyCustomException>(1).InputParameterName);

        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueGreaterThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<MyCustomException>(0));
        }


        #endregion

        #region custom exception type as TException with constructor args


        [Fact]
        public void DoesNothingGivenValueLessThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<MyCustomException>(2, "args1");

        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<MyCustomException>(1, "args1");

        }

        [Fact]
        public void PreservesInputGivenValueLessThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<MyCustomException>(2, "args1").Input);

        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<MyCustomException>(1, "args1").Input);

        }

        [Fact]
        public void PreservesInputParameterNameGivenValueLessThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.GreaterThan<MyCustomException>(2, "args1").InputParameterName);

        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.GreaterThan<MyCustomException>(1, "args1").InputParameterName);

        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueGreaterThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan<MyCustomException>(0, "args1"));

        }

        #endregion

        #region custom exception type as parameter
        [Fact]
        public void DoesNothingGivenValueLessThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan(2, typeof(MyCustomException));
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan(1, typeof(MyCustomException));
        }

        [Fact]
        public void PreservesInputGivenValueLessThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan(2, typeof(MyCustomException)).Input);

        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan(1, typeof(MyCustomException)).Input);

        }

        [Fact]
        public void PreservesInputParameterNameGivenValueLessThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.GreaterThan(2, typeof(MyCustomException)).InputParameterName);

        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.GreaterThan(1, typeof(MyCustomException)).InputParameterName);

        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan(0, typeof(MyCustomException)));
        }


        #endregion

        #region custom exception type as parameter with constructor args


        [Fact]
        public void DoesNothingGivenValueLessThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan(2, typeof(MyCustomException), "args1");
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan(1, typeof(MyCustomException), "args1");
        }

        [Fact]
        public void PreservesInputGivenValueLessThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan(2, typeof(MyCustomException), "args1").Input);

        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan(1, typeof(MyCustomException), "args1").Input);

        }

        [Fact]
        public void PreservesInputParameterNameGivenValueLessThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.GreaterThan(2, typeof(MyCustomException), "args1").InputParameterName);

        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.GreaterThan(1, typeof(MyCustomException), "args1").InputParameterName);

        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue1).Against.GreaterThan(0, typeof(MyCustomException), "args1"));

        }


        #endregion

    }
}
