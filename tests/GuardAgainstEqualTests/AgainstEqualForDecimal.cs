using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuardChain.Tests.GuardAgainstEqualTests
{
    public class AgainstEqualForDecimal
    {
        #region no custom exception

        [Fact]
        public void DoesNothingGivenNonEqualValue()
        {
            var data = new TestData();

            Guard.Protect(data.DecimalInputWithValue1).Against.Equal(data.DecimalInputWithValue0);

        }


        [Fact]
        public void PreservesInputGivenNonEqualValue()
        {
            var data = new TestData();

            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Equal(data.DecimalInputWithValue0).Input);
          
        }


        [Fact]
        public void PreservesInputParameterNameGivenNonEqualValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Equal(data.DecimalInputWithValue0).InputParameterName);
           
        }


        [Fact]
        public void ThrowsArgumentExceptionGivenEqualValue()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.Equal(data.DecimalInputWithValue0));
           
        }

        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenNonEqualValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.DecimalInputWithValue1).Against.Equal<MyCustomException>(data.DecimalInputWithValue0);               

        }


        [Fact]
        public void PreservesInputGivenNonEqualValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Equal<MyCustomException>(data.DecimalInputWithValue0).Input);
           
        }


        [Fact]
        public void PreservesInputParameterNameGivenNonEqualValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Equal<MyCustomException>(data.DecimalInputWithValue0).InputParameterName);
           
        }


        [Fact]
        public void ThrowsArgumentExceptionGivenEqualValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.Equal<MyCustomException>(data.DecimalInputWithValue0));
            
        }

        #endregion

        #region custom exception type as TException with constructor args

        [Fact]
        public void DoesNothingGivenNonEqualValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.DecimalInputWithValue1).Against.Equal<MyCustomException>(data.DecimalInputWithValue0, "ags1");

        }


        [Fact]
        public void PreservesInputGivenNonEqualValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Equal<MyCustomException>(data.DecimalInputWithValue0, "ags1").Input);
           
        }


        [Fact]
        public void PreservesInputParameterNameGivenNonEqualValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Equal<MyCustomException>(data.DecimalInputWithValue0, "ags1").InputParameterName);
            
        }


        [Fact]
        public void ThrowsArgumentExceptionGivenEqualValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.Equal<MyCustomException>(data.DecimalInputWithValue0, "ags1"));
           
        }

        #endregion

        #region custom exception type as parameter

        [Fact]
        public void DoesNothingGivenNonEqualValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.DecimalInputWithValue1).Against.Equal(data.DecimalInputWithValue0, typeof(MyCustomException));

        }


        [Fact]
        public void PreservesInputGivenNonEqualValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Equal(data.DecimalInputWithValue0, typeof(MyCustomException)).Input);
            
        }


        [Fact]
        public void PreservesInputParameterNameGivenNonEqualValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Equal(data.DecimalInputWithValue0, typeof(MyCustomException)).InputParameterName);
           
        }


        [Fact]
        public void ThrowsArgumentExceptionGivenEqualValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.Equal(data.DecimalInputWithValue0, typeof(MyCustomException)));
           
        }

        #endregion

        #region custom exception type as parameter with constructor args

        [Fact]
        public void DoesNothingGivenNonEqualValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.DecimalInputWithValue1).Against.Equal(data.DecimalInputWithValue0, typeof(MyCustomException), "args1");
               

        }


        [Fact]
        public void PreservesInputGivenNonEqualValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Equal(data.DecimalInputWithValue0, typeof(MyCustomException), "args1").Input);
          
        }


        [Fact]
        public void PreservesInputParameterNameGivenNonEqualValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Equal(data.DecimalInputWithValue0, typeof(MyCustomException), "args1").InputParameterName);
            
        }


        [Fact]
        public void ThrowsArgumentExceptionGivenEqualValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.Equal(data.DecimalInputWithValue0, typeof(MyCustomException), "args1"));
           
        }

        #endregion

    }
}
