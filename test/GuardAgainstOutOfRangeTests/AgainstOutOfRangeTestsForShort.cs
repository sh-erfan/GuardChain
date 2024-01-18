using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuardChain.Tests.GuardAgainstOutOfRangeTests
{
    public class AgainstOutOfRangeTestsForShort
    {
        #region no custom exception

        [Fact]
        public void DoesNothingGivenInRangeValue()
        {
            var data = new TestData();

            Guard.Protect(data.ShortInputWithValue0).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1);

        }


        [Fact]
        public void PreservesInputGiveInfRangeValue()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue0, Guard.Protect(data.ShortInputWithValue0).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNonOutOfRangeValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue0), Guard.Protect(data.ShortInputWithValue0, nameof(data.ShortInputWithValue0)).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenLowerBoundValue()
        {
            var data = new TestData();

            Guard.Protect(data.ShortInputWithValueMinus1).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1);

        }


        [Fact]
        public void PreservesInputGivenLowerBoundValue()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenLowerBoundValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenUpperBoundValue()
        {
            var data = new TestData();

            Guard.Protect(data.ShortInputWithValue1).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1);

        }


        [Fact]
        public void PreservesInputGivenUpperBoundValue()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenUpperBoundValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).InputParameterName);

        }


        [Fact]
        public void ThrowsArgumentOutOfRangeExceptionGivenOutOfRangeValue()
        {
            var data = new TestData();

            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Protect(data.ShortInputWithValue100).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1));

        }

        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenInRangeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.ShortInputWithValue0).Against.OutOfRange<MyCustomException>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1);

        }


        [Fact]
        public void PreservesInputGiveInfRangeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue0, Guard.Protect(data.ShortInputWithValue0).Against.OutOfRange<MyCustomException>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenNonOutOfRangeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue0), Guard.Protect(data.ShortInputWithValue0, nameof(data.ShortInputWithValue0)).Against.OutOfRange<MyCustomException>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenLowerBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.ShortInputWithValueMinus1).Against.OutOfRange<MyCustomException>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1);

        }


        [Fact]
        public void PreservesInputGivenLowerBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.OutOfRange<MyCustomException>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenLowerBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.OutOfRange<MyCustomException>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenUpperBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard.Protect(data.ShortInputWithValue1).Against.OutOfRange<MyCustomException>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1);

        }


        [Fact]
        public void PreservesInputGivenUpperBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.OutOfRange<MyCustomException>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenUpperBoundValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.OutOfRange<MyCustomException>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1).InputParameterName);

        }


        [Fact]
        public void ThrowsArgumentOutOfRangeExceptionGivenOutOfRangeValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue100).Against.OutOfRange<MyCustomException>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1));

        }

        #endregion

        #region custom exception type as TException with constructor args

        [Fact]
        public void DoesNothingGivenInRangeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.ShortInputWithValue0).Against.OutOfRange<MyCustomException>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, "ags1");

        }


        [Fact]
        public void PreservesInputGiveInfRangeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue0, Guard.Protect(data.ShortInputWithValue0).Against.OutOfRange<MyCustomException>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, "ags1").Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenNonOutOfRangeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue0), Guard.Protect(data.ShortInputWithValue0, nameof(data.ShortInputWithValue0)).Against.OutOfRange<MyCustomException>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, "ags1").InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenLowerBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.ShortInputWithValueMinus1).Against.OutOfRange<MyCustomException>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, "ags1");

        }


        [Fact]
        public void PreservesInputGivenLowerBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.OutOfRange<MyCustomException>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, "ags1").Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenLowerBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.OutOfRange<MyCustomException>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, "ags1").InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenUpperBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.ShortInputWithValue1).Against.OutOfRange<MyCustomException>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, "ags1");

        }


        [Fact]
        public void PreservesInputGivenUpperBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.OutOfRange<MyCustomException>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, "ags1").Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenUpperBoundValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.OutOfRange<MyCustomException>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, "ags1").InputParameterName);

        }


        [Fact]
        public void ThrowsArgumentOutOfRangeExceptionGivenOutOfRangeValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue100).Against.OutOfRange<MyCustomException>(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, "ags1"));

        }

        #endregion

        #region custom exception type as parameter

        [Fact]
        public void DoesNothingGivenInRangeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.ShortInputWithValue0).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException));

        }


        [Fact]
        public void PreservesInputGiveInfRangeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue0, Guard.Protect(data.ShortInputWithValue0).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException)).Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenNonOutOfRangeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue0), Guard.Protect(data.ShortInputWithValue0, nameof(data.ShortInputWithValue0)).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException)).InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenLowerBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.ShortInputWithValueMinus1).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException));

        }


        [Fact]
        public void PreservesInputGivenLowerBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException)).Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenLowerBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException)).InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenUpperBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard.Protect(data.ShortInputWithValue1).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException));

        }


        [Fact]
        public void PreservesInputGivenUpperBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException)).Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenUpperBoundValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException)).InputParameterName);

        }


        [Fact]
        public void ThrowsCustomExceptionGivenOutOfRangeValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue100).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException)));

        }


        #endregion

        #region custom exception type as parameter with constructor args

        [Fact]
        public void DoesNothingGivenInRangeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.ShortInputWithValue0).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException), "args1");

        }


        [Fact]
        public void PreservesInputGiveInfRangeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue0, Guard.Protect(data.ShortInputWithValue0).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException), "args1").Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenNonOutOfRangeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue0), Guard.Protect(data.ShortInputWithValue0, nameof(data.ShortInputWithValue0)).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException), "args1").InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenLowerBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.ShortInputWithValueMinus1).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException), "args1");

        }


        [Fact]
        public void PreservesInputGivenLowerBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValueMinus1, Guard.Protect(data.ShortInputWithValueMinus1).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException), "args1").Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenLowerBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValueMinus1), Guard.Protect(data.ShortInputWithValueMinus1, nameof(data.ShortInputWithValueMinus1)).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException), "args1").InputParameterName);

        }

        [Fact]
        public void DoesNothingGivenUpperBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard.Protect(data.ShortInputWithValue1).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException), "args1");

        }


        [Fact]
        public void PreservesInputGivenUpperBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException), "args1").Input);

        }


        [Fact]
        public void PreservesInputParameterNameGivenUpperBoundValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException), "args1").InputParameterName);

        }


        [Fact]
        public void ThrowsCustomExceptionGivenOutOfRangeValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue100).Against.OutOfRange(data.ShortInputWithValueMinus1, data.ShortInputWithValue1, typeof(MyCustomException), "args1"));

        }

        #endregion
    }
}
