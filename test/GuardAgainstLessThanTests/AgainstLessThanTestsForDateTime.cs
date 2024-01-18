using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using Xunit;

namespace GuardChain.Tests.GuardAgainstLessThanTests
{
    public class AgainstLessThanTestsForDateTime
    {
        #region no custom exception

        [Fact]
        public void DoesNothingGivenValueGreaterThanLimit()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.LessThan(data.DateTimeInputWithValueNow);
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimit()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueNow).Against.LessThan(data.DateTimeInputWithValueNow);
        }

        [Fact]
        public void PreservesInputGivenValueGreaterThanLimit()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.LessThan(data.DateTimeInputWithValueNow).Input);
        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimit()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.LessThan(data.DateTimeInputWithValueNow).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueGreaterThanLimit()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.LessThan(data.DateTimeInputWithValueNow).InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimit()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.LessThan(data.DateTimeInputWithValueNow).InputParameterName);
        }

        [Fact]
        public void ThrowsArgumentExceptionGivenValueLessThanLimit()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DateTimeInputWithValueYesterday).Against.LessThan(data.DateTimeInputWithValueNow));
        }

        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenValueGreaterThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.LessThan<MyCustomException>(data.DateTimeInputWithValueNow);
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueNow).Against.LessThan<MyCustomException>(data.DateTimeInputWithValueNow);
        }

        [Fact]
        public void PreservesInputGivenValueGreaterThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.LessThan<MyCustomException>(data.DateTimeInputWithValueNow).Input);
        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.LessThan<MyCustomException>(data.DateTimeInputWithValueNow).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueGreaterThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.LessThan<MyCustomException>(data.DateTimeInputWithValueNow).InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.LessThan<MyCustomException>(data.DateTimeInputWithValueNow).InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueLessThanLimitWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueYesterday).Against.LessThan<MyCustomException>(data.DateTimeInputWithValueNow));
        }

        #endregion

        #region custom exception type as TException with constructor args

        [Fact]
        public void DoesNothingGivenValueGreaterThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.LessThan<MyCustomException>(data.DateTimeInputWithValueNow, "args1");
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueNow).Against.LessThan<MyCustomException>(data.DateTimeInputWithValueNow, "args1");
        }

        [Fact]
        public void PreservesInputGivenValueGreaterThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.LessThan<MyCustomException>(data.DateTimeInputWithValueNow, "args1").Input);
        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.LessThan<MyCustomException>(data.DateTimeInputWithValueNow, "args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueGreaterThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.LessThan<MyCustomException>(data.DateTimeInputWithValueNow, "args1").InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.LessThan<MyCustomException>(data.DateTimeInputWithValueNow, "args1").InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueLessThanLimitWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueYesterday).Against.LessThan<MyCustomException>(data.DateTimeInputWithValueNow, "args1"));
        }

        #endregion

        #region custom exception type as parameter

        [Fact]
        public void DoesNothingGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.LessThan(data.DateTimeInputWithValueNow, typeof(MyCustomException));
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueNow).Against.LessThan(data.DateTimeInputWithValueNow, typeof(MyCustomException));
        }

        [Fact]
        public void PreservesInputGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.LessThan(data.DateTimeInputWithValueNow, typeof(MyCustomException)).Input);
        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

           Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.LessThan(data.DateTimeInputWithValueNow, typeof(MyCustomException)).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.LessThan(data.DateTimeInputWithValueNow, typeof(MyCustomException)).InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.LessThan(data.DateTimeInputWithValueNow, typeof(MyCustomException)).InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueLessThanLimitWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueYesterday).Against.LessThan(data.DateTimeInputWithValueNow, typeof(MyCustomException)));
        }

        #endregion

        #region custom exception type as parameter with constructor args

        [Fact]
        public void DoesNothingGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.LessThan(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1");
        }

        [Fact]
        public void DoesNothingGivenValueEqualToLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueNow).Against.LessThan(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1");
        }

        [Fact]
        public void PreservesInputGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.LessThan(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1").Input);
        }

        [Fact]
        public void PreservesInputGivenValueEqualToLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.LessThan(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueGreaterThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.LessThan(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void PreservesInputParameterNameGivenValueEqualToLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.LessThan(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueLessThanLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueYesterday).Against.LessThan(data.DateTimeInputWithValueNow, typeof(MyCustomException), "args1"));
        }


        #endregion

    }
}
