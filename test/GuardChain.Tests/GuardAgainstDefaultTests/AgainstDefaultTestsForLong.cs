using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuardChain.Tests.GuardAgainstDefaultTests
{
    public class AgainstDefaultTestsForLong
    {
        #region no custom exception

        [Fact]
        public void DoesNothingGivenNonDefaultValue()
        {
            var data = new TestData();

            Guard.Protect(data.LongInputWithValue1).Against.Default();
        }

        [Fact]
        public void PreservesInputGivenNonDefaultValue()
        {
            var data = new TestData();

            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Default().Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNonDefaultValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Default().InputParameterName);
        }

        [Fact]
        public void ThrowsArgumentExceptionGivenDefaultValue()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.LongInputWithDefaultValue).Against.Default());
        }

        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenNonDefaultValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.LongInputWithValue1).Against.Default<MyCustomException>();
        }

        [Fact]
        public void PreservesInputGivenNonDefaultValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Default<MyCustomException>().Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNonDefaultValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Default<MyCustomException>().InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenDefaultValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithDefaultValue).Against.Default<MyCustomException>());
        }

        #endregion

        #region custom exception type as TException with constructor args

        [Fact]
        public void DoesNothingGivenNonDefaultValueWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Guard.Protect(data.LongInputWithValue1).Against.Default<MyCustomException>("args1");
        }

        [Fact]
        public void PreservesInputGivenNonDefaultValueWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Default<MyCustomException>("args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNonDefaultValueWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Default<MyCustomException>("args1").InputParameterName);
        }


        [Fact]
        public void ThrowsCustomExceptionGivenDefaultValueWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithDefaultValue).Against.Default<MyCustomException>("args1"));
        }


        #endregion

        #region custom exception type as parameter

        [Fact]
        public void DoesNothingGivenNonDefaultValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.LongInputWithValue1).Against.Default(typeof(MyCustomException));
        }

        [Fact]
        public void PreservesInputGivenNonDefaultValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Default(typeof(MyCustomException)).Input);
          
        }

        [Fact]
        public void PreservesInputParameterNameGivenNonDefaultValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Default(typeof(MyCustomException)).InputParameterName);
           
        }

        [Fact]
        public void ThrowsCustomExceptionGivenDefaultValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithDefaultValue).Against.Default(typeof(MyCustomException)));
           
        }


        #endregion

        #region custom exception type as parameter with constructor args

        [Fact]
        public void DoesNothingGivenNonDefaultValueWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Guard.Protect(data.LongInputWithValue1).Against.Default(typeof(MyCustomException), "args1");
        }

        [Fact]
        public void PreservesInputGivenNonDefaultValueWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Default(typeof(MyCustomException), "args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNonDefaultValueWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Default(typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueEqualToLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithDefaultValue).Against.Default(typeof(MyCustomException), "args1"));
        }

        #endregion
    }
}
