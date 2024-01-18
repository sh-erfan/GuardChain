using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using Xunit;

namespace GuardChain.Tests.GuardAgainstZeroTests
{
    public class AgainstZeroTestsForDecimal
    {
        #region no custom exception

        [Fact]
        public void DoesNothingGivenPositiveValue()
        {
            var data = new TestData();

            Guard.Protect(data.DecimalInputWithValue1).Against.Zero();

        }


        [Fact]
        public void PreservesInputGivenPositiveValue()
        {
            var data = new TestData();

            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Zero().Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenPositiveValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Zero().InputParameterName);
           
        }

        [Fact]
        public void DoesNothingGivenNegativeValue()
        {
            var data = new TestData();

            Guard.Protect(data.DecimalInputWithValueMinus1).Against.Zero();
        }


        [Fact]
        public void PreservesInputGivenNegativeValue()
        {
            var data = new TestData();

            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.Zero().Input);
           
        }


        [Fact]
        public void PreservesInputParameterNameGivenNegativeValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.Zero().InputParameterName);
          
        }



        [Fact]
        public void ThrowsArgumentExceptionGivenZeroValue()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.Zero());
           
        }

        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenPositiveValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.DecimalInputWithValue1).Against.Zero<MyCustomException>();

        }


        [Fact]
        public void PreservesInputGivenPositiveValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Zero<MyCustomException>().Input);
            
        }


        [Fact]
        public void PreservesInputParameterNameGivenPositiveValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Zero<MyCustomException>().InputParameterName);
          
        }


        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.DecimalInputWithValueMinus1).Against.Zero<MyCustomException>();

        }


        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.Zero<MyCustomException>().Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.Zero<MyCustomException>().InputParameterName);
           
        }


        [Fact]
        public void ThrowsCustomExceptionGivenZeroValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.Zero<MyCustomException>());
           
        }

        #endregion

        #region custom exception type as TException with constructor args

        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.DecimalInputWithValueMinus1).Against.Zero<MyCustomException>("ags1");

        }


        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.Zero<MyCustomException>("ags1").Input);
           
        }


        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.Zero<MyCustomException>("ags1").InputParameterName);
           
        }



        [Fact]
        public void ThrowsCustomExceptionGivenZeroValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.Zero<MyCustomException>("ags1"));
           
        }

        #endregion

        #region custom exception type as parameter

        [Fact]
        public void DoesNothingGivenPositiveValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.DecimalInputWithValue1).Against.Zero(typeof(MyCustomException));

        }


        [Fact]
        public void PreservesInputGivenPositiveValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Zero(typeof(MyCustomException)).Input);
           
        }


        [Fact]
        public void PreservesInputParameterNameGivenPositiveValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Zero(typeof(MyCustomException)).InputParameterName);
            
        }

        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.DecimalInputWithValueMinus1).Against.Zero(typeof(MyCustomException));

        }


        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.Zero(typeof(MyCustomException)).Input);
           
        }


        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.Zero(typeof(MyCustomException)).InputParameterName);
           
        }

        
        [Fact]
        public void ThrowsCustomExceptionGivenZeroValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.Zero(typeof(MyCustomException)));
           
        }

        #endregion

        #region custom exception type as parameter with constructor args

        [Fact]
        public void DoesNothingGivenPositiveValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.DecimalInputWithValue1).Against.Zero(typeof(MyCustomException), "args1");

        }


        [Fact]
        public void PreservesInputGivenPositiveValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.DecimalInputWithValue1,
                Guard.Protect(data.DecimalInputWithValue1).Against.Zero(typeof(MyCustomException), "args1").Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenPositiveValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Zero(typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void DoesNothingGivenNegativeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.DecimalInputWithValueMinus1).Against.Zero(typeof(MyCustomException), "args1");

        }


        [Fact]
        public void PreservesInputGivenNegativeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.DecimalInputWithValueMinus1, Guard.Protect(data.DecimalInputWithValueMinus1).Against.Zero(typeof(MyCustomException), "args1").Input);
          
        }


        [Fact]
        public void PreservesInputParameterNameGivenNegativeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DecimalInputWithValueMinus1), Guard.Protect(data.DecimalInputWithValueMinus1, nameof(data.DecimalInputWithValueMinus1)).Against.Zero(typeof(MyCustomException), "args1").InputParameterName);
           
        }


        [Fact]
        public void ThrowsCustomExceptionGivenZeroValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.Zero(typeof(MyCustomException), "args1"));
        }

        #endregion
    }
}
