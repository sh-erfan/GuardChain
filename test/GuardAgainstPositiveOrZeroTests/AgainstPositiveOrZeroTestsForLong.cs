using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using Xunit;

namespace GuardChain.Tests.GuardAgainstPositiveOrZeroTests
{
    public class AgainstPositiveOrZeroTestsForLong
    {
        #region no custom exception

        [Fact]
        public void DoesNothingGivenNegativeValue()
        {
            var data = new TestData();

            Guard.Protect(data.LongInputWithValueMinus1).Against.PositiveOrZero();
        }


        [Fact]
        public void PreservesInputGivenNegativeValue()
        {
            var data = new TestData();

            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.PositiveOrZero().Input);
         
        }


        [Fact]
        public void PreservesInputParameterNameGivenNegativeValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.PositiveOrZero().InputParameterName);
            
        }


        [Fact]
        public void ThrowsArgumentExceptionGivenPositiveValue()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.LongInputWithValue1).Against.PositiveOrZero());
           
        }


        [Fact]
        public void ThrowsArgumentExceptionGivenZeroValue()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.LongInputWithValue0).Against.PositiveOrZero());
           
        }

        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.LongInputWithValueMinus1).Against.PositiveOrZero<MyCustomException>();

        }


        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.PositiveOrZero<MyCustomException>().Input);
           
        }


        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.PositiveOrZero<MyCustomException>().InputParameterName);
           
        }


        [Fact]
        public void ThrowsCustomExceptionGivenPositiveValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.PositiveOrZero<MyCustomException>());
           
        }

        [Fact]
        public void ThrowsCustomExceptionGivenZeroValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue0).Against.PositiveOrZero<MyCustomException>());
            
        }

        #endregion

        #region custom exception type as TException with constructor args

        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.LongInputWithValueMinus1).Against.PositiveOrZero<MyCustomException>("ags1");

        }


        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.PositiveOrZero<MyCustomException>("ags1").Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.PositiveOrZero<MyCustomException>("ags1").InputParameterName);
           
        }


        [Fact]
        public void ThrowsCustomExceptionGivenPositiveValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.PositiveOrZero<MyCustomException>("ags1"));
           
        }

        [Fact]
        public void ThrowsCustomExceptionGivenZeroValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue0).Against.PositiveOrZero<MyCustomException>("ags1"));
           
        }

        #endregion

        #region custom exception type as parameter

        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.LongInputWithValueMinus1).Against.PositiveOrZero(typeof(MyCustomException));

        }


        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.PositiveOrZero(typeof(MyCustomException)).Input);
           
        }


        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.PositiveOrZero(typeof(MyCustomException)).InputParameterName);
          
        }


        [Fact]
        public void ThrowsCustomExceptionGivenPositiveValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.PositiveOrZero(typeof(MyCustomException)));
           
        }

        [Fact]
        public void ThrowsCustomExceptionGivenZeroValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue0).Against.PositiveOrZero(typeof(MyCustomException)));
           
        }

        #endregion

        #region custom exception type as parameter with constructor args

        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.LongInputWithValueMinus1).Against.PositiveOrZero(typeof(MyCustomException), "args1");

        }


        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.LongInputWithValueMinus1, Guard.Protect(data.LongInputWithValueMinus1).Against.PositiveOrZero(typeof(MyCustomException), "args1").Input);
          
        }


        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.LongInputWithValueMinus1), Guard.Protect(data.LongInputWithValueMinus1, nameof(data.LongInputWithValueMinus1)).Against.PositiveOrZero(typeof(MyCustomException), "args1").InputParameterName);
            
        }


        [Fact]
        public void ThrowsCustomExceptionGivenPositiveValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue1).Against.PositiveOrZero(typeof(MyCustomException), "args1"));
            
        }

        [Fact]
        public void ThrowsCustomExceptionGivenZeroValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue0).Against.PositiveOrZero(typeof(MyCustomException), "args1"));
           
        }

        #endregion
    }
}
