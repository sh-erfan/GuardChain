using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuardChain.Tests.GuardAgainstOutOfSqlDateRangeTests
{
    public class AgainstOutOfSqlDateRangeTestsForSqlDateTime
    {
        #region no custom exception

        [Fact]
        public void DoesNothingGivenInRangeValue()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfSqlDateRange();

        }


        [Fact]
        public void PreservesInputGiveInfRangeValue()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfSqlDateRange().Input);

        }
        

        [Fact]
        public void PreservesInputParameterNameGivenNonOutOfSqlDateRangeValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.OutOfSqlDateRange().InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenLowerBoundValue()
        {
            var data = new TestData();

            Guard.Protect(data.SqlDateTimeInputWithMinValue).Against.OutOfSqlDateRange();

        }


        [Fact]
        public void PreservesInputGivenLowerBoundValue()
        {
            var data = new TestData();

            Assert.Equal(data.SqlDateTimeInputWithMinValue, Guard.Protect(data.SqlDateTimeInputWithMinValue).Against.OutOfSqlDateRange().Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenLowerBoundValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.SqlDateTimeInputWithMinValue), Guard.Protect(data.SqlDateTimeInputWithMinValue, nameof(data.SqlDateTimeInputWithMinValue)).Against.OutOfSqlDateRange().InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenUpperBoundValue()
        {
            var data = new TestData();

            Guard.Protect(data.SqlDateTimeInputWithMaxValue).Against.OutOfSqlDateRange();

        }


        [Fact]
        public void PreservesInputGivenUpperBoundValue()
        {
            var data = new TestData();

            Assert.Equal(data.SqlDateTimeInputWithMaxValue, Guard.Protect(data.SqlDateTimeInputWithMaxValue).Against.OutOfSqlDateRange().Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenUpperBoundValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.SqlDateTimeInputWithMaxValue), Guard.Protect(data.SqlDateTimeInputWithMaxValue, nameof(data.SqlDateTimeInputWithMaxValue)).Against.OutOfSqlDateRange().InputParameterName);

        }


        [Fact]
        public void ThrowsArgumentOutOfRangeExceptionGivenOutOfSqlDateRangeValue()
        {
            var data = new TestData();

            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Protect(data.SqlDateTimeInputWithMinValue.AddDays(-1)).Against.OutOfSqlDateRange());
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Protect(data.SqlDateTimeInputWithMaxValue.AddDays(1)).Against.OutOfSqlDateRange());

        }

        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenInRangeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfSqlDateRange<MyCustomException>();

        }


        [Fact]
        public void PreservesInputGiveInfRangeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfSqlDateRange<MyCustomException>().Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenNonOutOfSqlDateRangeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.OutOfSqlDateRange<MyCustomException>().InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenLowerBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.SqlDateTimeInputWithMinValue).Against.OutOfSqlDateRange<MyCustomException>();

        }


        [Fact]
        public void PreservesInputGivenLowerBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.SqlDateTimeInputWithMinValue, Guard.Protect(data.SqlDateTimeInputWithMinValue).Against.OutOfSqlDateRange<MyCustomException>().Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenLowerBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.SqlDateTimeInputWithMinValue), Guard.Protect(data.SqlDateTimeInputWithMinValue, nameof(data.SqlDateTimeInputWithMinValue)).Against.OutOfSqlDateRange<MyCustomException>().InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenUpperBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.SqlDateTimeInputWithMaxValue).Against.OutOfSqlDateRange<MyCustomException>();

        }


        [Fact]
        public void PreservesInputGivenUpperBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.SqlDateTimeInputWithMaxValue, Guard.Protect(data.SqlDateTimeInputWithMaxValue).Against.OutOfSqlDateRange<MyCustomException>().Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenUpperBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.SqlDateTimeInputWithMaxValue), Guard.Protect(data.SqlDateTimeInputWithMaxValue, nameof(data.SqlDateTimeInputWithMaxValue)).Against.OutOfSqlDateRange<MyCustomException>().InputParameterName);

        }


        [Fact]
        public void ThrowsCustomExceptionGivenOutOfSqlDateRangeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.SqlDateTimeInputWithMinValue.AddDays(-1)).Against.OutOfSqlDateRange<MyCustomException>());

        }

        #endregion

        #region custom exception type as TException with constructor args

        [Fact]
        public void DoesNothingGivenInRangeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfSqlDateRange<MyCustomException>("args1");

        }


        [Fact]
        public void PreservesInputGiveInfRangeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfSqlDateRange<MyCustomException>("args1").Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenNonOutOfSqlDateRangeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.OutOfSqlDateRange<MyCustomException>("args1").InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenLowerBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.SqlDateTimeInputWithMinValue).Against.OutOfSqlDateRange<MyCustomException>("args1");

        }


        [Fact]
        public void PreservesInputGivenLowerBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.SqlDateTimeInputWithMinValue, Guard.Protect(data.SqlDateTimeInputWithMinValue).Against.OutOfSqlDateRange<MyCustomException>("args1").Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenLowerBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.SqlDateTimeInputWithMinValue), Guard.Protect(data.SqlDateTimeInputWithMinValue, nameof(data.SqlDateTimeInputWithMinValue)).Against.OutOfSqlDateRange<MyCustomException>("args1").InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenUpperBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.SqlDateTimeInputWithMaxValue).Against.OutOfSqlDateRange<MyCustomException>("args1");

        }


        [Fact]
        public void PreservesInputGivenUpperBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.SqlDateTimeInputWithMaxValue, Guard.Protect(data.SqlDateTimeInputWithMaxValue).Against.OutOfSqlDateRange<MyCustomException>("args1").Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenUpperBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.SqlDateTimeInputWithMaxValue), Guard.Protect(data.SqlDateTimeInputWithMaxValue, nameof(data.SqlDateTimeInputWithMaxValue)).Against.OutOfSqlDateRange<MyCustomException>("args1").InputParameterName);

        }


        [Fact]
        public void ThrowsCustomExceptionExceptionGivenOutOfSqlDateRangeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.SqlDateTimeInputWithMinValue.AddDays(-1)).Against.OutOfSqlDateRange<MyCustomException>("args1"));

        }

        #endregion

        #region custom exception type as parameter

        [Fact]
        public void DoesNothingGivenInRangeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfSqlDateRange(typeof(MyCustomException));

        }


        [Fact]
        public void PreservesInputGiveInfRangeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfSqlDateRange(typeof(MyCustomException)).Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenNonOutOfSqlDateRangeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.OutOfSqlDateRange(typeof(MyCustomException)).InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenLowerBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.SqlDateTimeInputWithMinValue).Against.OutOfSqlDateRange(typeof(MyCustomException));

        }


        [Fact]
        public void PreservesInputGivenLowerBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.SqlDateTimeInputWithMinValue, Guard.Protect(data.SqlDateTimeInputWithMinValue).Against.OutOfSqlDateRange(typeof(MyCustomException)).Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenLowerBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.SqlDateTimeInputWithMinValue), Guard.Protect(data.SqlDateTimeInputWithMinValue, nameof(data.SqlDateTimeInputWithMinValue)).Against.OutOfSqlDateRange(typeof(MyCustomException)).InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenUpperBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.SqlDateTimeInputWithMaxValue).Against.OutOfSqlDateRange(typeof(MyCustomException));

        }


        [Fact]
        public void PreservesInputGivenUpperBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.SqlDateTimeInputWithMaxValue, Guard.Protect(data.SqlDateTimeInputWithMaxValue).Against.OutOfSqlDateRange(typeof(MyCustomException)).Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenUpperBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.SqlDateTimeInputWithMaxValue), Guard.Protect(data.SqlDateTimeInputWithMaxValue, nameof(data.SqlDateTimeInputWithMaxValue)).Against.OutOfSqlDateRange(typeof(MyCustomException)).InputParameterName);

        }


        [Fact]
        public void ThrowsCustomExceptionGivenOutOfSqlDateRangeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.SqlDateTimeInputWithMinValue.AddDays(-1)).Against.OutOfSqlDateRange(typeof(MyCustomException)));

        }


        #endregion

        #region custom exception type as parameter with constructor args

        [Fact]
        public void DoesNothingGivenInRangeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfSqlDateRange(typeof(MyCustomException), "args1");

        }


        [Fact]
        public void PreservesInputGiveInfRangeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfSqlDateRange(typeof(MyCustomException), "args1").Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenNonOutOfSqlDateRangeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.OutOfSqlDateRange(typeof(MyCustomException), "args1").InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenLowerBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.SqlDateTimeInputWithMinValue).Against.OutOfSqlDateRange(typeof(MyCustomException), "args1");

        }


        [Fact]
        public void PreservesInputGivenLowerBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.SqlDateTimeInputWithMinValue, Guard.Protect(data.SqlDateTimeInputWithMinValue).Against.OutOfSqlDateRange(typeof(MyCustomException), "args1").Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenLowerBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.SqlDateTimeInputWithMinValue), Guard.Protect(data.SqlDateTimeInputWithMinValue, nameof(data.SqlDateTimeInputWithMinValue)).Against.OutOfSqlDateRange(typeof(MyCustomException), "args1").InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenUpperBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.SqlDateTimeInputWithMaxValue).Against.OutOfSqlDateRange(typeof(MyCustomException), "args1");

        }


        [Fact]
        public void PreservesInputGivenUpperBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.SqlDateTimeInputWithMaxValue, Guard.Protect(data.SqlDateTimeInputWithMaxValue).Against.OutOfSqlDateRange(typeof(MyCustomException), "args1").Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenUpperBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.SqlDateTimeInputWithMaxValue), Guard.Protect(data.SqlDateTimeInputWithMaxValue, nameof(data.SqlDateTimeInputWithMaxValue)).Against.OutOfSqlDateRange(typeof(MyCustomException), "args1").InputParameterName);

        }


        [Fact]
        public void ThrowsCustomExceptionGivenOutOfSqlDateRangeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.SqlDateTimeInputWithMinValue.AddDays(-1)).Against.OutOfSqlDateRange(typeof(MyCustomException), "args1"));

        }

        #endregion
    }
}
