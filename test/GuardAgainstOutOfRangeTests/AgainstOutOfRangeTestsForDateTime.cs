using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuardChain.Tests.GuardAgainstOutOfRangeTests
{
    public class AgainstOutOfRangeTestsForDateTime
    {
        #region no custom exception

        [Fact]
        public void DoesNothingGivenInRangeValue()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow);

        }


        [Fact]
        public void PreservesInputGiveInfRangeValue()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNonOutOfRangeValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenLowerBoundValue()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueYesterday).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow);

        }


        [Fact]
        public void PreservesInputGivenLowerBoundValue()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenLowerBoundValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenUpperBoundValue()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow);

        }


        [Fact]
        public void PreservesInputGivenUpperBoundValue()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenUpperBoundValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).InputParameterName);

        }


        [Fact]
        public void ThrowsArgumentOutOfRangeExceptionGivenOutOfRangeValue()
        {
            var data = new TestData();

            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Protect(data.DateTimeInputWithValueOneHundredDaysAhead).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow));

        }

        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenInRangeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfRange<MyCustomException>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow);

        }


        [Fact]
        public void PreservesInputGiveInfRangeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfRange<MyCustomException>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenNonOutOfRangeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.OutOfRange<MyCustomException>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenLowerBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueYesterday).Against.OutOfRange<MyCustomException>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow);

        }


        [Fact]
        public void PreservesInputGivenLowerBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.OutOfRange<MyCustomException>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenLowerBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.OutOfRange<MyCustomException>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenUpperBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.OutOfRange<MyCustomException>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow);

        }


        [Fact]
        public void PreservesInputGivenUpperBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.OutOfRange<MyCustomException>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenUpperBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.OutOfRange<MyCustomException>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow).InputParameterName);

        }


        [Fact]
        public void ThrowsArgumentOutOfRangeExceptionGivenOutOfRangeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueOneHundredDaysAhead).Against.OutOfRange<MyCustomException>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow));

        }

        #endregion

        #region custom exception type as TException with constructor args

        [Fact]
        public void DoesNothingGivenInRangeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfRange<MyCustomException>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, "ags1");

        }


        [Fact]
        public void PreservesInputGiveInfRangeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfRange<MyCustomException>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, "ags1").Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenNonOutOfRangeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.OutOfRange<MyCustomException>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, "ags1").InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenLowerBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueYesterday).Against.OutOfRange<MyCustomException>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, "ags1");

        }


        [Fact]
        public void PreservesInputGivenLowerBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.OutOfRange<MyCustomException>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, "ags1").Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenLowerBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.OutOfRange<MyCustomException>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, "ags1").InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenUpperBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.OutOfRange<MyCustomException>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, "ags1");

        }


        [Fact]
        public void PreservesInputGivenUpperBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.OutOfRange<MyCustomException>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, "ags1").Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenUpperBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.OutOfRange<MyCustomException>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, "ags1").InputParameterName);

        }


        [Fact]
        public void ThrowsArgumentOutOfRangeExceptionGivenOutOfRangeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueOneHundredDaysAhead).Against.OutOfRange<MyCustomException>(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, "ags1"));

        }

        #endregion

        #region custom exception type as parameter

        [Fact]
        public void DoesNothingGivenInRangeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException));

        }


        [Fact]
        public void PreservesInputGiveInfRangeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException)).Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenNonOutOfRangeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException)).InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenLowerBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueYesterday).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException));

        }


        [Fact]
        public void PreservesInputGivenLowerBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException)).Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenLowerBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException)).InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenUpperBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException));

        }


        [Fact]
        public void PreservesInputGivenUpperBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException)).Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenUpperBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException)).InputParameterName);

        }


        [Fact]
        public void ThrowsCustomExceptionGivenOutOfRangeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueOneHundredDaysAhead).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException)));

        }


        #endregion

        #region custom exception type as parameter with constructor args

        [Fact]
        public void DoesNothingGivenInRangeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException), "args1");

        }


        [Fact]
        public void PreservesInputGiveInfRangeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueNow, Guard.Protect(data.DateTimeInputWithValueNow).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException), "args1").Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenNonOutOfRangeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueNow), Guard.Protect(data.DateTimeInputWithValueNow, nameof(data.DateTimeInputWithValueNow)).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException), "args1").InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenLowerBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueYesterday).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException), "args1");

        }


        [Fact]
        public void PreservesInputGivenLowerBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException), "args1").Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenLowerBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException), "args1").InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenUpperBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException), "args1");

        }


        [Fact]
        public void PreservesInputGivenUpperBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException), "args1").Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenUpperBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException), "args1").InputParameterName);

        }


        [Fact]
        public void ThrowsCustomExceptionGivenOutOfRangeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueOneHundredDaysAhead).Against.OutOfRange(data.DateTimeInputWithValueYesterday, data.DateTimeInputWithValueTomorrow, typeof(MyCustomException), "args1"));

        }

        #endregion
    }
}
