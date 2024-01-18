using GuardChain.Extensions;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuardChain.Tests.GuardAgainstDefaultTests
{
    public class AgainstDefaultTestsForTInput
    {
        #region no custom exception

        [Fact]
        public void DoesNothingGivenNonDefaultValue()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.Default()
                .Protect(data.IntInputWithValue1).Against.Default()
                .Protect(data.LongInputWithValue1).Against.Default()
                .Protect(data.DecimalInputWithValue1).Against.Default()
                .Protect(data.FloatInputWithValue1).Against.Default()
                .Protect(data.DoubleInputWithValue1).Against.Default()
                .Protect(data.EnumInputWithValueTwo).Against.Default()            
                .Protect(data.DateTimeInputWithValueYesterday).Against.Default()
                .Protect(data.ObjectInput).Against.Default()
                .Protect(data.ListOfObjectsInputWithNoItems).Against.Default();

        }

        [Fact]
        public void PreservesInputGivenNonDefaultValue()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Default().Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Default().Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Default().Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Default().Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Default().Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Default().Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Default().Input);
            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.Default().Input);
            Assert.Equal(data.ObjectInput, Guard.Protect(data.ObjectInput).Against.Default().Input);
            Assert.Equal(data.ListOfObjectsInputWithNoItems, Guard.Protect(data.ListOfObjectsInputWithNoItems).Against.Default().Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNonDefaultValue()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.Default().InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.Default().InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Default().InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Default().InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.Default().InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Default().InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.Default().InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.Default().InputParameterName);
            Assert.Equal(nameof(data.ObjectInput), Guard.Protect(data.ObjectInput, nameof(data.ObjectInput)).Against.Default().InputParameterName);
            Assert.Equal(nameof(data.ListOfObjectsInputWithNoItems), Guard.Protect(data.ListOfObjectsInputWithNoItems, nameof(data.ListOfObjectsInputWithNoItems)).Against.Default().InputParameterName);
        }

        [Fact]
        public void ThrowsArgumentExceptionGivenDefaultValue()
        {
            var data = new TestData();

            Assert.Throws<ArgumentException>(() => Guard.Protect(data.ShortInputWithDefaultValue).Against.Default());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.IntInputWithDefaultValue).Against.Default());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.LongInputWithDefaultValue).Against.Default());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DecimalInputWithDefaultValue).Against.Default());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.FloatInputWithDefaultValue).Against.Default());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DoubleInputWithDefaultValue).Against.Default());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.EnumInputWithDefaultValue).Against.Default());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.DateTimeInputWithDefaultValue).Against.Default());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.ObjectInputWithDefaultValue).Against.Default());
            Assert.Throws<ArgumentException>(() => Guard.Protect(data.ListOfObjectsInputWithDefaultValue).Against.Default());
        }


        #endregion

        #region custom exception type as TException

        [Fact]
        public void DoesNothingGivenNonDefaultValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.Default<MyCustomException, short>()
                .Protect(data.IntInputWithValue1).Against.Default<MyCustomException, int>()
                .Protect(data.LongInputWithValue1).Against.Default<MyCustomException, long>()
                .Protect(data.DecimalInputWithValue1).Against.Default<MyCustomException, decimal>()
                .Protect(data.FloatInputWithValue1).Against.Default<MyCustomException, float>()
                .Protect(data.DoubleInputWithValue1).Against.Default<MyCustomException, double>()
                .Protect(data.EnumInputWithValueTwo).Against.Default<MyCustomException, MyTestEnum>()
                .Protect(data.DateTimeInputWithValueYesterday).Against.Default<MyCustomException, DateTime>()
                .Protect(data.ObjectInput).Against.Default<MyCustomException, object>()
                .Protect(data.ListOfObjectsInputWithNoItems).Against.Default<MyCustomException, List<object>>();
        }

        [Fact]
        public void PreservesInputGivenNonDefaultValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Default<MyCustomException, short>().Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Default<MyCustomException, int>().Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Default<MyCustomException, long>().Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Default<MyCustomException, decimal>().Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Default<MyCustomException, float>().Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Default<MyCustomException, double>().Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Default<MyCustomException, MyTestEnum>().Input);
            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.Default<MyCustomException, DateTime>().Input);
            Assert.Equal(data.ObjectInput, Guard.Protect(data.ObjectInput).Against.Default<MyCustomException, object>().Input);
            Assert.Equal(data.ListOfObjectsInputWithNoItems, Guard.Protect(data.ListOfObjectsInputWithNoItems).Against.Default<MyCustomException, object>().Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNonDefaultValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.Default<MyCustomException, short>().InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.Default<MyCustomException, int>().InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Default<MyCustomException, long>().InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Default<MyCustomException, decimal>().InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.Default<MyCustomException, float>().InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Default<MyCustomException, double>().InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.Default<MyCustomException, MyTestEnum>().InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.Default<MyCustomException, DateTime>().InputParameterName);
            Assert.Equal(nameof(data.ObjectInput), Guard.Protect(data.ObjectInput, nameof(data.ObjectInput)).Against.Default<MyCustomException, object>().InputParameterName);
            Assert.Equal(nameof(data.ListOfObjectsInputWithNoItems), Guard.Protect(data.ListOfObjectsInputWithNoItems, nameof(data.ListOfObjectsInputWithNoItems)).Against.Default<MyCustomException, List<object>>().InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenDefaultValueWithCustomExceptionTypeAsTException()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithDefaultValue).Against.Default<MyCustomException, short>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithDefaultValue).Against.Default<MyCustomException, int>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithDefaultValue).Against.Default<MyCustomException, long>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithDefaultValue).Against.Default<MyCustomException, decimal>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithDefaultValue).Against.Default<MyCustomException, float>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithDefaultValue).Against.Default<MyCustomException, double>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithDefaultValue).Against.Default<MyCustomException, MyTestEnum>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithDefaultValue).Against.Default<MyCustomException, DateTime>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ObjectInputWithDefaultValue).Against.Default<MyCustomException, object>());
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ListOfObjectsInputWithDefaultValue).Against.Default<MyCustomException, List<object>>());
        }

        #endregion

        #region custom exception type as TException with constructor args

        [Fact]
        public void DoesNothingGivenNonDefaultValueWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.Default<MyCustomException, short>("args1")
                .Protect(data.IntInputWithValue1).Against.Default<MyCustomException, int>("args1")
                .Protect(data.LongInputWithValue1).Against.Default<MyCustomException, long>("args1")
                .Protect(data.DecimalInputWithValue1).Against.Default<MyCustomException, decimal>("args1")
                .Protect(data.FloatInputWithValue1).Against.Default<MyCustomException, float>("args1")
                .Protect(data.DoubleInputWithValue1).Against.Default<MyCustomException, double>("args1")
                .Protect(data.EnumInputWithValueTwo).Against.Default<MyCustomException, MyTestEnum>("args1")
                .Protect(data.DateTimeInputWithValueYesterday).Against.Default<MyCustomException, DateTime>("args1")
                .Protect(data.ObjectInput).Against.Default<MyCustomException, object>("args1")
                .Protect(data.ListOfObjectsInputWithNoItems).Against.Default<MyCustomException, List<object>>("args1");
        }

        [Fact]
        public void PreservesInputGivenNonDefaultValueWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Default<MyCustomException, short>("args1").Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Default<MyCustomException, int>("args1").Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Default<MyCustomException, long>("args1").Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Default<MyCustomException, decimal>("args1").Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Default<MyCustomException, float>("args1").Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Default<MyCustomException, double>("args1").Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Default<MyCustomException, MyTestEnum>("args1").Input);
            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.Default<MyCustomException, DateTime>("args1").Input);
            Assert.Equal(data.ObjectInput, Guard.Protect(data.ObjectInput).Against.Default<MyCustomException, object>("args1").Input);
            Assert.Equal(data.ListOfObjectsInputWithNoItems, Guard.Protect(data.ListOfObjectsInputWithNoItems).Against.Default<MyCustomException, List<object>>("args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNonDefaultValueWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.Default<MyCustomException, short>("args1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.Default<MyCustomException, int>("args1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Default<MyCustomException, long>("args1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Default<MyCustomException, decimal>("args1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.Default<MyCustomException, float>("args1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Default<MyCustomException, double>("args1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.Default<MyCustomException, MyTestEnum>("args1").InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.Default<MyCustomException, DateTime>("args1").InputParameterName);
            Assert.Equal(nameof(data.ObjectInput), Guard.Protect(data.ObjectInput, nameof(data.ObjectInput)).Against.Default<MyCustomException, object>("args1").InputParameterName);
            Assert.Equal(nameof(data.ListOfObjectsInputWithNoItems), Guard.Protect(data.ListOfObjectsInputWithNoItems, nameof(data.ListOfObjectsInputWithNoItems)).Against.Default<MyCustomException, List<object>>("args1").InputParameterName);
        }


        [Fact]
        public void ThrowsCustomExceptionGivenDefaultValueWithCustomExceptionTypeAsTExceptionHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithDefaultValue).Against.Default<MyCustomException, short>( "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithDefaultValue).Against.Default<MyCustomException, int>("args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithDefaultValue).Against.Default<MyCustomException, long>("args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithDefaultValue).Against.Default<MyCustomException, decimal>("args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithDefaultValue).Against.Default<MyCustomException, float>("args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithDefaultValue).Against.Default<MyCustomException, double>("args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithDefaultValue).Against.Default<MyCustomException, MyTestEnum>("args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithDefaultValue).Against.Default<MyCustomException, DateTime>("args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ObjectInputWithDefaultValue).Against.Default<MyCustomException, object>("args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ListOfObjectsInputWithDefaultValue).Against.Default<MyCustomException, List<object>>("args1"));
        }


        #endregion

        #region custom exception type as parameter

        [Fact]
        public void DoesNothingGivenNonDefaultValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.Default<short>(typeof(MyCustomException))
                .Protect(data.IntInputWithValue1).Against.Default<int>(typeof(MyCustomException))
                .Protect(data.LongInputWithValue1).Against.Default<long>(typeof(MyCustomException))
                .Protect(data.DecimalInputWithValue1).Against.Default<decimal>(typeof(MyCustomException))
                .Protect(data.FloatInputWithValue1).Against.Default<float>(typeof(MyCustomException))
                .Protect(data.DoubleInputWithValue1).Against.Default<double>(typeof(MyCustomException))
                .Protect(data.EnumInputWithValueTwo).Against.Default<MyTestEnum>(typeof(MyCustomException))
                .Protect(data.DateTimeInputWithValueYesterday).Against.Default<DateTime>(typeof(MyCustomException))
                .Protect(data.ObjectInput).Against.Default<object>(typeof(MyCustomException))
                .Protect(data.ListOfObjectsInputWithNoItems).Against.Default<List<object>>(typeof(MyCustomException));
        }

        [Fact]
        public void PreservesInputGivenNonDefaultValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Default<short>(typeof(MyCustomException)).Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Default<int>(typeof(MyCustomException)).Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Default<long>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Default<decimal>(typeof(MyCustomException)).Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Default<float>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Default<double>(typeof(MyCustomException)).Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Default<MyTestEnum>(typeof(MyCustomException)).Input);
            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.Default<DateTime>(typeof(MyCustomException)).Input);
            Assert.Equal(data.ObjectInput, Guard.Protect(data.ObjectInput).Against.Default<object>(typeof(MyCustomException)).Input);
            Assert.Equal(data.ListOfObjectsInputWithNoItems, Guard.Protect(data.ListOfObjectsInputWithNoItems).Against.Default<List<object>>(typeof(MyCustomException)).Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNonDefaultValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.Default<short>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.Default<int>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Default<long>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Default<decimal>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.Default<float>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Default<double>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.Default<MyTestEnum>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.Default<DateTime>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.ObjectInput), Guard.Protect(data.ObjectInput, nameof(data.ObjectInput)).Against.Default<object>(typeof(MyCustomException)).InputParameterName);
            Assert.Equal(nameof(data.ListOfObjectsInputWithNoItems), Guard.Protect(data.ListOfObjectsInputWithNoItems, nameof(data.ListOfObjectsInputWithNoItems)).Against.Default<List<object>>(typeof(MyCustomException)).InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenDefaultValueWithCustomExceptionTypeAsParameter()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithDefaultValue).Against.Default<short>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithDefaultValue).Against.Default<int>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithDefaultValue).Against.Default<long>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithDefaultValue).Against.Default<decimal>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithDefaultValue).Against.Default<float>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithDefaultValue).Against.Default<double>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithDefaultValue).Against.Default<MyTestEnum>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithDefaultValue).Against.Default<DateTime>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ObjectInputWithDefaultValue).Against.Default<object>(typeof(MyCustomException)));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ListOfObjectsInputWithDefaultValue).Against.Default<List<object>>(typeof(MyCustomException)));
        }


        #endregion

        #region custom exception type as parameter with constructor args

        [Fact]
        public void DoesNothingGivenNonDefaultValueWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Guard
                .Protect(data.ShortInputWithValue1).Against.Default<short>(typeof(MyCustomException), "args1")
                .Protect(data.IntInputWithValue1).Against.Default<int>(typeof(MyCustomException), "args1")
                .Protect(data.LongInputWithValue1).Against.Default<long>(typeof(MyCustomException), "args1")
                .Protect(data.DecimalInputWithValue1).Against.Default<decimal>(typeof(MyCustomException), "args1")
                .Protect(data.FloatInputWithValue1).Against.Default<float>(typeof(MyCustomException), "args1")
                .Protect(data.DoubleInputWithValue1).Against.Default<double>(typeof(MyCustomException), "args1")
                .Protect(data.EnumInputWithValueTwo).Against.Default<MyTestEnum>(typeof(MyCustomException), "args1")
                .Protect(data.DateTimeInputWithValueYesterday).Against.Default<DateTime>(typeof(MyCustomException), "args1")
                .Protect(data.ObjectInput).Against.Default<object>(typeof(MyCustomException), "args1")
                .Protect(data.ListOfObjectsInputWithNoItems).Against.Default<List<object>>(typeof(MyCustomException), "args1");
        }

        [Fact]
        public void PreservesInputGivenNonDefaultValueWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(data.ShortInputWithValue1, Guard.Protect(data.ShortInputWithValue1).Against.Default<short>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.IntInputWithValue1, Guard.Protect(data.IntInputWithValue1).Against.Default<int>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.LongInputWithValue1, Guard.Protect(data.LongInputWithValue1).Against.Default<long>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DecimalInputWithValue1, Guard.Protect(data.DecimalInputWithValue1).Against.Default<decimal>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.FloatInputWithValue1, Guard.Protect(data.FloatInputWithValue1).Against.Default<float>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DoubleInputWithValue1, Guard.Protect(data.DoubleInputWithValue1).Against.Default<double>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.EnumInputWithValueTwo, Guard.Protect(data.EnumInputWithValueTwo).Against.Default<MyTestEnum>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.DateTimeInputWithValueYesterday, Guard.Protect(data.DateTimeInputWithValueYesterday).Against.Default<DateTime>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.ObjectInput, Guard.Protect(data.ObjectInput).Against.Default<object>(typeof(MyCustomException), "args1").Input);
            Assert.Equal(data.ListOfObjectsInputWithNoItems, Guard.Protect(data.ListOfObjectsInputWithNoItems).Against.Default<List<object>>(typeof(MyCustomException), "args1").Input);
        }

        [Fact]
        public void PreservesInputParameterNameGivenNonDefaultValueWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Equal(nameof(data.ShortInputWithValue1), Guard.Protect(data.ShortInputWithValue1, nameof(data.ShortInputWithValue1)).Against.Default<short>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.IntInputWithValue1), Guard.Protect(data.IntInputWithValue1, nameof(data.IntInputWithValue1)).Against.Default<int>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.LongInputWithValue1), Guard.Protect(data.LongInputWithValue1, nameof(data.LongInputWithValue1)).Against.Default<long>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DecimalInputWithValue1), Guard.Protect(data.DecimalInputWithValue1, nameof(data.DecimalInputWithValue1)).Against.Default<decimal>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.FloatInputWithValue1), Guard.Protect(data.FloatInputWithValue1, nameof(data.FloatInputWithValue1)).Against.Default<float>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DoubleInputWithValue1), Guard.Protect(data.DoubleInputWithValue1, nameof(data.DoubleInputWithValue1)).Against.Default<double>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.EnumInputWithValueTwo), Guard.Protect(data.EnumInputWithValueTwo, nameof(data.EnumInputWithValueTwo)).Against.Default<MyTestEnum>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.DateTimeInputWithValueYesterday), Guard.Protect(data.DateTimeInputWithValueYesterday, nameof(data.DateTimeInputWithValueYesterday)).Against.Default<DateTime>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.ObjectInput), Guard.Protect(data.ObjectInput, nameof(data.ObjectInput)).Against.Default<object>(typeof(MyCustomException), "args1").InputParameterName);
            Assert.Equal(nameof(data.ListOfObjectsInputWithNoItems), Guard.Protect(data.ListOfObjectsInputWithNoItems, nameof(data.ListOfObjectsInputWithNoItems)).Against.Default<List<object>>(typeof(MyCustomException), "args1").InputParameterName);
        }

        [Fact]
        public void ThrowsCustomExceptionGivenValueEqualToLimitWithCustomExceptionTypeAsParameterHavingConstructorArguments()
        {
            var data = new TestData();

            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ShortInputWithDefaultValue).Against.Default<short>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.IntInputWithDefaultValue).Against.Default<int>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.LongInputWithDefaultValue).Against.Default<long>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DecimalInputWithDefaultValue).Against.Default<decimal>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.FloatInputWithDefaultValue).Against.Default<float>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DoubleInputWithDefaultValue).Against.Default<double>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.EnumInputWithDefaultValue).Against.Default<MyTestEnum>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.DateTimeInputWithDefaultValue).Against.Default<DateTime>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ObjectInputWithDefaultValue).Against.Default<object>(typeof(MyCustomException), "args1"));
            Assert.Throws<MyCustomException>(() => Guard.Protect(data.ListOfObjectsInputWithDefaultValue).Against.Default<List<object>>(typeof(MyCustomException), "args1"));
        }

        #endregion
    }
}
