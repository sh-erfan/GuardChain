using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuardChain.Tests.GuardAgainstEqualTests
{
    public class AgainstEqualForTInput
    {
        #region no custom exception

        [Fact]
        public void DoesNothingGivenNonEqualValue()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.Equal<short>(data.ShortInputWithValue0)
                .Protect(data.IntInputWithValue1).Against.Equal<int>(data.IntInputWithValue0)
                .Protect(data.LongInputWithValue1).Against.Equal<long>(data.LongInputWithValue0)
                .Protect(data.DecimalInputWithValue1).Against.Equal<decimal>(data.DecimalInputWithValue0)
                .Protect(data.FloatInputWithValue1).Against.Equal<float>(data.FloatInputWithValue0)
                .Protect(data.DoubleInputWithValue1).Against.Equal<double>(data.DoubleInputWithValue0)
                .Protect(data.EnumInputWithValueTwo).Against.Equal<MyTestEnum>(data.EnumInputWithValueZero)
                .Protect(data.DateTimeInputWithValueTomorrow).Against.Equal<DateTime>(data.DateTimeInputWithValueYesterday)
                .Protect(data.PersonInputWithAge10).Against.Equal<MyTestPerson>(data.PersonInputWithAge20);

        }


        [Fact]
        public void PreservesInputGivenNonEqualValue()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Equal<short>(data.ShortInputWithValue0).Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Equal<int>(data.IntInputWithValue0).Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Equal<long>(data.LongInputWithValue0).Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Equal<decimal>(data.DecimalInputWithValue0).Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Equal<float>(data.FloatInputWithValue0).Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Equal<double>(data.DoubleInputWithValue0).Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Equal<MyTestEnum>(data.EnumInputWithValueZero).Input);
            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.Equal<DateTime>(data.DateTimeInputWithValueYesterday).Input);
            Assert.Equal(data.PersonInputWithAge10, Guard.Protect(data.PersonInputWithAge10).Against.Equal<MyTestPerson>(data.PersonInputWithAge20).Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNonEqualValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.Equal<short>(data.ShortInputWithValue0).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.Equal<int>(data.IntInputWithValue0).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Equal<long>(data.LongInputWithValue0).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Equal<decimal>(data.DecimalInputWithValue0).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.Equal<float>(data.FloatInputWithValue0).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Equal<double>(data.DoubleInputWithValue0).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.Equal<MyTestEnum>(data.EnumInputWithValueZero).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.Equal<DateTime>(data.DateTimeInputWithValueYesterday).InputParameterName);
            Assert.Equal(nameof(data.PersonInputWithAge10), Guard.Protect(data.PersonInputWithAge10, nameof(data.PersonInputWithAge10)).Against.Equal<MyTestPerson>(data.PersonInputWithAge20).InputParameterName);
        }


        [Fact]
        public void ThrowsArgumentExceptionGivenEqualValue()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.ShortInputWithValue0).Against.Equal<short>(data.ShortInputWithValue0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.IntInputWithValue0).Against.Equal<int>(data.IntInputWithValue0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.LongInputWithValue0).Against.Equal<long>(data.LongInputWithValue0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.Equal<decimal>(data.DecimalInputWithValue0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.FloatInputWithValue0).Against.Equal<float>(data.FloatInputWithValue0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DoubleInputWithValue0).Against.Equal<double>(data.DoubleInputWithValue0));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.Equal<MyTestEnum>(data.EnumInputWithValueTwo));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.Equal<DateTime>(data.DateTimeInputWithValueTomorrow));
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.PersonInputWithAge10).Against.Equal<MyTestPerson>(data.PersonInputWithAge10));
        }

        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenNonEqualValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.Equal<MyCustomException, short>(data.ShortInputWithValue0)
                .Protect(data.IntInputWithValue1).Against.Equal<MyCustomException, int>(data.IntInputWithValue0)
                .Protect(data.LongInputWithValue1).Against.Equal<MyCustomException, long>(data.LongInputWithValue0)
                .Protect(data.DecimalInputWithValue1).Against.Equal<MyCustomException, decimal>(data.DecimalInputWithValue0)
                .Protect(data.FloatInputWithValue1).Against.Equal<MyCustomException, float>(data.FloatInputWithValue0)
                .Protect(data.DoubleInputWithValue1).Against.Equal<MyCustomException, double>(data.DoubleInputWithValue0)
                .Protect(data.EnumInputWithValueTwo).Against.Equal<MyCustomException, MyTestEnum>(data.EnumInputWithValueZero)
                .Protect(data.DateTimeInputWithValueTomorrow).Against.Equal<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday)
                .Protect(data.PersonInputWithAge10).Against.Equal<MyCustomException, MyTestPerson>(data.PersonInputWithAge20);

        }


        [Fact]
        public void PreservesInputGivenNonEqualValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Equal<MyCustomException, short>(data.ShortInputWithValue0).Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Equal<MyCustomException, int>(data.IntInputWithValue0).Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Equal<MyCustomException, long>(data.LongInputWithValue0).Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Equal<MyCustomException, decimal>(data.DecimalInputWithValue0).Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Equal<MyCustomException, float>(data.FloatInputWithValue0).Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Equal<MyCustomException, double>(data.DoubleInputWithValue0).Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Equal<MyCustomException, MyTestEnum>(data.EnumInputWithValueZero).Input);
            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.Equal<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday).Input);
            Assert.Equal(data.PersonInputWithAge10, Guard.Protect(data.PersonInputWithAge10).Against.Equal<MyCustomException, MyTestPerson>(data.PersonInputWithAge20).Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNonEqualValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.Equal<MyCustomException, short>(data.ShortInputWithValue0).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.Equal<MyCustomException, int>(data.IntInputWithValue0).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Equal<MyCustomException, long>(data.LongInputWithValue0).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Equal<MyCustomException, decimal>(data.DecimalInputWithValue0).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.Equal<MyCustomException, float>(data.FloatInputWithValue0).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Equal<MyCustomException, double>(data.DoubleInputWithValue0).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.Equal<MyCustomException, MyTestEnum>(data.EnumInputWithValueZero).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.Equal<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday).InputParameterName);
            Assert.Equal(nameof(data.PersonInputWithAge10), Guard.Protect(data.PersonInputWithAge10, nameof(data.PersonInputWithAge10)).Against.Equal<MyCustomException, MyTestPerson>(data.PersonInputWithAge20).InputParameterName);
        }


        [Fact]
        public void ThrowsArgumentExceptionGivenEqualValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue0).Against.Equal<MyCustomException, short>(data.ShortInputWithValue0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue0).Against.Equal<MyCustomException, int>(data.IntInputWithValue0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue0).Against.Equal<MyCustomException, long>(data.LongInputWithValue0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.Equal<MyCustomException, decimal>(data.DecimalInputWithValue0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue0).Against.Equal<MyCustomException, float>(data.FloatInputWithValue0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue0).Against.Equal<MyCustomException, double>(data.DoubleInputWithValue0));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.Equal<MyCustomException, MyTestEnum>(data.EnumInputWithValueTwo));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.Equal<MyCustomException, DateTime>(data.DateTimeInputWithValueTomorrow));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.PersonInputWithAge10).Against.Equal<MyCustomException, MyTestPerson>(data.PersonInputWithAge10));
        }

        #endregion

        #region custom exception type as TException with constructor args

        [Fact]
        public void DoesNothingGivenNonEqualValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.Equal<MyCustomException, short>(data.ShortInputWithValue0, "ags1")
                .Protect(data.IntInputWithValue1).Against.Equal<MyCustomException, int>(data.IntInputWithValue0, "ags1")
                .Protect(data.LongInputWithValue1).Against.Equal<MyCustomException, long>(data.LongInputWithValue0, "ags1")
                .Protect(data.DecimalInputWithValue1).Against.Equal<MyCustomException, decimal>(data.DecimalInputWithValue0, "ags1")
                .Protect(data.FloatInputWithValue1).Against.Equal<MyCustomException, float>(data.FloatInputWithValue0, "ags1")
                .Protect(data.DoubleInputWithValue1).Against.Equal<MyCustomException, double>(data.DoubleInputWithValue0, "ags1")
                .Protect(data.EnumInputWithValueTwo).Against.Equal<MyCustomException, MyTestEnum>(data.EnumInputWithValueZero, "ags1")
                .Protect(data.DateTimeInputWithValueTomorrow).Against.Equal<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday, "ags1")
                .Protect(data.PersonInputWithAge10).Against.Equal<MyCustomException, MyTestPerson>(data.PersonInputWithAge20, "ags1");

        }


        [Fact]
        public void PreservesInputGivenNonEqualValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Equal<MyCustomException, short>(data.ShortInputWithValue0, "ags1").Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Equal<MyCustomException, int>(data.IntInputWithValue0, "ags1").Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Equal<MyCustomException, long>(data.LongInputWithValue0, "ags1").Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Equal<MyCustomException, decimal>(data.DecimalInputWithValue0, "ags1").Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Equal<MyCustomException, float>(data.FloatInputWithValue0, "ags1").Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Equal<MyCustomException, double>(data.DoubleInputWithValue0, "ags1").Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Equal<MyCustomException, MyTestEnum>(data.EnumInputWithValueZero, "ags1").Input);
            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.Equal<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday, "ags1").Input);
            Assert.Equal(data.PersonInputWithAge10, Guard.Protect(data.PersonInputWithAge10).Against.Equal<MyCustomException, MyTestPerson>(data.PersonInputWithAge20, "ags1").Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNonEqualValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.Equal<MyCustomException, short>(data.ShortInputWithValue0, "ags1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.Equal<MyCustomException, int>(data.IntInputWithValue0, "ags1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Equal<MyCustomException, long>(data.LongInputWithValue0, "ags1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Equal<MyCustomException, decimal>(data.DecimalInputWithValue0, "ags1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.Equal<MyCustomException, float>(data.FloatInputWithValue0, "ags1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Equal<MyCustomException, double>(data.DoubleInputWithValue0, "ags1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.Equal<MyCustomException, MyTestEnum>(data.EnumInputWithValueZero, "ags1").InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.Equal<MyCustomException, DateTime>(data.DateTimeInputWithValueYesterday, "ags1").InputParameterName);
            Assert.Equal(nameof(data.PersonInputWithAge10), Guard.Protect(data.PersonInputWithAge10, nameof(data.PersonInputWithAge10)).Against.Equal<MyCustomException, MyTestPerson>(data.PersonInputWithAge20, "ags1").InputParameterName);
        }


        [Fact]
        public void ThrowsArgumentExceptionGivenEqualValueWithCustomExceptionTypeAsTExceptionHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue0).Against.Equal<MyCustomException, short>(data.ShortInputWithValue0, "ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue0).Against.Equal<MyCustomException, int>(data.IntInputWithValue0, "ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue0).Against.Equal<MyCustomException, long>(data.LongInputWithValue0, "ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.Equal<MyCustomException, decimal>(data.DecimalInputWithValue0, "ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue0).Against.Equal<MyCustomException, float>(data.FloatInputWithValue0, "ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue0).Against.Equal<MyCustomException, double>(data.DoubleInputWithValue0, "ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.Equal<MyCustomException, MyTestEnum>(data.EnumInputWithValueTwo, "ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.Equal<MyCustomException, DateTime>(data.DateTimeInputWithValueTomorrow, "ags1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.PersonInputWithAge10).Against.Equal<MyCustomException, MyTestPerson>(data.PersonInputWithAge10, "ags1"));
        }

        #endregion

        #region custom exception type as parameter

        [Fact]
        public void DoesNothingGivenNonEqualValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.Equal<short>(data.ShortInputWithValue0, typeof(MyCustomException))
                .Protect(data.IntInputWithValue1).Against.Equal<int>(data.IntInputWithValue0, typeof(MyCustomException))
                .Protect(data.LongInputWithValue1).Against.Equal<long>(data.LongInputWithValue0, typeof(MyCustomException))
                .Protect(data.DecimalInputWithValue1).Against.Equal<decimal>(data.DecimalInputWithValue0, typeof(MyCustomException))
                .Protect(data.FloatInputWithValue1).Against.Equal<float>(data.FloatInputWithValue0, typeof(MyCustomException))
                .Protect(data.DoubleInputWithValue1).Against.Equal<double>(data.DoubleInputWithValue0, typeof(MyCustomException))
                .Protect(data.EnumInputWithValueTwo).Against.Equal<MyTestEnum>(data.EnumInputWithValueZero, typeof(MyCustomException))
                .Protect(data.DateTimeInputWithValueTomorrow).Against.Equal<DateTime>(data.DateTimeInputWithValueYesterday, typeof(MyCustomException))
                .Protect(data.PersonInputWithAge10).Against.Equal<MyTestPerson>(data.PersonInputWithAge20, typeof(MyCustomException));

        }


        [Fact]
        public void PreservesInputGivenNonEqualValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Equal<short>(data.ShortInputWithValue0, typeof(MyCustomException)).Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Equal<int>(data.IntInputWithValue0, typeof(MyCustomException)).Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Equal<long>(data.LongInputWithValue0, typeof(MyCustomException)).Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Equal<decimal>(data.DecimalInputWithValue0, typeof(MyCustomException)).Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Equal<float>(data.FloatInputWithValue0, typeof(MyCustomException)).Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Equal<double>(data.DoubleInputWithValue0, typeof(MyCustomException)).Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Equal<MyTestEnum>(data.EnumInputWithValueZero, typeof(MyCustomException)).Input);
            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.Equal<DateTime>(data.DateTimeInputWithValueYesterday, typeof(MyCustomException)).Input);
            Assert.Equal(data.PersonInputWithAge10, Guard.Protect(data.PersonInputWithAge10).Against.Equal<MyTestPerson>(data.PersonInputWithAge20, typeof(MyCustomException)).Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNonEqualValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.Equal<short>(data.ShortInputWithValue0, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.Equal<int>(data.IntInputWithValue0, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Equal<long>(data.LongInputWithValue0, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Equal<decimal>(data.DecimalInputWithValue0, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.Equal<float>(data.FloatInputWithValue0, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Equal<double>(data.DoubleInputWithValue0, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.Equal<MyTestEnum>(data.EnumInputWithValueZero, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.Equal<DateTime>(data.DateTimeInputWithValueYesterday, typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.PersonInputWithAge10), Guard.Protect(data.PersonInputWithAge10, nameof(data.PersonInputWithAge10)).Against.Equal<MyTestPerson>(data.PersonInputWithAge20, typeof(MyCustomException)).InputParameterName);
        }


        [Fact]
        public void ThrowsArgumentExceptionGivenEqualValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue0).Against.Equal<short>(data.ShortInputWithValue0, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue0).Against.Equal<int>(data.IntInputWithValue0, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue0).Against.Equal<long>(data.LongInputWithValue0, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.Equal<decimal>(data.DecimalInputWithValue0, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue0).Against.Equal<float>(data.FloatInputWithValue0, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue0).Against.Equal<double>(data.DoubleInputWithValue0, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.Equal<MyTestEnum>(data.EnumInputWithValueTwo, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.Equal<DateTime>(data.DateTimeInputWithValueTomorrow, typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.PersonInputWithAge10).Against.Equal<MyTestPerson>(data.PersonInputWithAge10, typeof(MyCustomException)));
        }

        #endregion

        #region custom exception type as parameter with constructor args

        [Fact]
        public void DoesNothingGivenNonEqualValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.Equal<short>(data.ShortInputWithValue0, typeof(MyCustomException), "args1")
                .Protect(data.IntInputWithValue1).Against.Equal<int>(data.IntInputWithValue0, typeof(MyCustomException), "args1")
                .Protect(data.LongInputWithValue1).Against.Equal<long>(data.LongInputWithValue0, typeof(MyCustomException), "args1")
                .Protect(data.DecimalInputWithValue1).Against.Equal<decimal>(data.DecimalInputWithValue0, typeof(MyCustomException), "args1")
                .Protect(data.FloatInputWithValue1).Against.Equal<float>(data.FloatInputWithValue0, typeof(MyCustomException), "args1")
                .Protect(data.DoubleInputWithValue1).Against.Equal<double>(data.DoubleInputWithValue0, typeof(MyCustomException), "args1")
                .Protect(data.EnumInputWithValueTwo).Against.Equal<MyTestEnum>(data.EnumInputWithValueZero, typeof(MyCustomException), "args1")
                .Protect(data.DateTimeInputWithValueTomorrow).Against.Equal<DateTime>(data.DateTimeInputWithValueYesterday, typeof(MyCustomException), "args1")
                .Protect(data.PersonInputWithAge10).Against.Equal<MyTestPerson>(data.PersonInputWithAge20, typeof(MyCustomException), "args1");

        }


        [Fact]
        public void PreservesInputGivenNonEqualValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Equal<short>(data.ShortInputWithValue0, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Equal<int>(data.IntInputWithValue0, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Equal<long>(data.LongInputWithValue0, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Equal<decimal>(data.DecimalInputWithValue0, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Equal<float>(data.FloatInputWithValue0, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Equal<double>(data.DoubleInputWithValue0, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Equal<MyTestEnum>(data.EnumInputWithValueZero, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DateTimeInputWithValueTomorrow, Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.Equal<DateTime>(data.DateTimeInputWithValueYesterday, typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.PersonInputWithAge10, Guard.Protect(data.PersonInputWithAge10).Against.Equal<MyTestPerson>(data.PersonInputWithAge20, typeof(MyCustomException), "args1").Input);
        }


        [Fact]
        public void PreservesInputParameterNameGivenNonEqualValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.Equal<short>(data.ShortInputWithValue0, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.Equal<int>(data.IntInputWithValue0, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Equal<long>(data.LongInputWithValue0, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Equal<decimal>(data.DecimalInputWithValue0, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.Equal<float>(data.FloatInputWithValue0, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Equal<double>(data.DoubleInputWithValue0, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.Equal<MyTestEnum>(data.EnumInputWithValueZero, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueTomorrow), Guard.Protect(data.DateTimeInputWithValueTomorrow, nameof(data.DateTimeInputWithValueTomorrow)).Against.Equal<DateTime>(data.DateTimeInputWithValueYesterday, typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.PersonInputWithAge10), Guard.Protect(data.PersonInputWithAge10, nameof(data.PersonInputWithAge10)).Against.Equal<MyTestPerson>(data.PersonInputWithAge20, typeof(MyCustomException), "args1").InputParameterName);
        }


        [Fact]
        public void ThrowsArgumentExceptionGivenEqualValueWithCustomExceptionTypeAsParameterHavingConstructorArgs()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithValue0).Against.Equal<short>(data.ShortInputWithValue0, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithValue0).Against.Equal<int>(data.IntInputWithValue0, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithValue0).Against.Equal<long>(data.LongInputWithValue0, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithValue0).Against.Equal<decimal>(data.DecimalInputWithValue0, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithValue0).Against.Equal<float>(data.FloatInputWithValue0, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithValue0).Against.Equal<double>(data.DoubleInputWithValue0, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithValueTwo).Against.Equal<MyTestEnum>(data.EnumInputWithValueTwo, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithValueTomorrow).Against.Equal<DateTime>(data.DateTimeInputWithValueTomorrow, typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.PersonInputWithAge10).Against.Equal<MyTestPerson>(data.PersonInputWithAge10, typeof(MyCustomException), "args1"));
        }

        #endregion

    }
}
