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
    public class AgainstGreaterThanTestsForDateTime
    {
        #region no custom exception

        [Fact]
        public void DoesNothingGivenValueLessThanLimit()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueYesterday).Against.GreaterThan(data.DateTimeInputWithValueNow);
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimit()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueNow).Against.GreaterThan(data.DateTimeInputWithValueNow);
        }

        [Fact]
        public void PreservesInputGivenValueLessThanLimit()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.GreaterThan(data.DateTimeInputWithValueNow).Input);
        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimit()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.GreaterThan(data.DateTimeInputWithValueNow).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueLessThanLimit()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.GreaterThan(data.DateTimeInputWithValueNow).InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimit()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.GreaterThan(data.DateTimeInputWithValueNow).InputParameterName);
        }

        [Fact]
        public void ThrowsArgumentExceptionGivenValueGreaterThanLimit()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.GreaterThan(data.DateTimeInputWithValueNow));
        }

        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenValueLessThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueYesterday).Against.GreaterThan<MyCustomException>(data.DateTimeInputWithValueNow);
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueNow).Against.GreaterThan<MyCustomException>(data.DateTimeInputWithValueNow);
        }

        [Fact]
        public void PreservesInputGivenValueLessThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.GreaterThan<MyCustomException>(data.DateTimeInputWithValueNow).Input);
        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.GreaterThan<MyCustomException>(data.DateTimeInputWithValueNow).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueLessThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.GreaterThan<MyCustomException>(data.DateTimeInputWithValueNow).InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.GreaterThan<MyCustomException>(data.DateTimeInputWithValueNow).InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueGreaterThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.GreaterThan<MyCustomException>(data.DateTimeInputWithValueNow));
        }


        #endregion

        #region custom exception type as TException with constructor args


        [Fact]
        public void DoesNothingGivenValueLessThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueYesterday).Against.GreaterThan<MyCustomException>(data.DateTimeInputWithValueNow, "args1");
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueNow).Against.GreaterThan<MyCustomException>(data.DateTimeInputWithValueNow, "args1");
        }

        [Fact]
        public void PreservesInputGivenValueLessThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.GreaterThan<MyCustomException>(data.DateTimeInputWithValueNow, "args1").Input);
        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.GreaterThan<MyCustomException>(data.DateTimeInputWithValueNow, "args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueLessThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.GreaterThan<MyCustomException>(data.DateTimeInputWithValueNow, "args1").InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.GreaterThan<MyCustomException>(data.DateTimeInputWithValueNow, "args1").InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueGreaterThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.GreaterThan<MyCustomException>(data.DateTimeInputWithValueNow, "args1"));
        }

        #endregion

        #region custom exception type as parameter
        [Fact]
        public void DoesNothingGivenValueLessThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueYesterday).Against.GreaterThan(data.DateTimeInputWithValueNow, typeof(MyCustomException));
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueNow).Against.GreaterThan(data.DateTimeInputWithValueNow, typeof(MyCustomException));
        }

        [Fact]
        public void PreservesInputGivenValueLessThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.GreaterThan(data.DateTimeInputWithValueNow, typeof(MyCustomException)).Input);
        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.GreaterThan(data.DateTimeInputWithValueNow, typeof(MyCustomException)).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueLessThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.GreaterThan(data.DateTimeInputWithValueNow, typeof(MyCustomException)).InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.GreaterThan(data.DateTimeInputWithValueNow, typeof(MyCustomException)).InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.GreaterThan(data.DateTimeInputWithValueNow, typeof(MyCustomException)));
        }


        #endregion

        #region custom exception type as parameter with constructor args


        [Fact]
        public void DoesNothingGivenValueLessThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueYesterday).Against.GreaterThan(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1");
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueNow).Against.GreaterThan(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1");
        }

        [Fact]
        public void PreservesInputGivenValueLessThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.GreaterThan(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1").Input);
        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.GreaterThan(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueLessThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.GreaterThan(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.GreaterThan(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.GreaterThan(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1"));
        }


        #endregion









    }
}
