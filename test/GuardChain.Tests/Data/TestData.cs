using System;
using System.Collections.Generic;
using System.Text;

namespace GuardChain.Tests.Data
{
    public class TestData
    {
        public string StringInputWithDefaultValue { get; } = default(string);
        public string StringInputWithNormalValue { get; } = "normal string";
        public string StringInputWithWhiteSpacesValue { get; } = "   ";
        public string StringInputWithZeroLength { get; } = "";
        public string StringInputWithEmptyValue { get; } = string.Empty;
        public string StringInputWithNullValue { get; } = null;
        public short ShortInputWithDefaultValue { get; } = default(short);
        public short ShortInputWithValue1 { get; } = 1;
        public short ShortInputWithValue0 { get; } = 0;
        public short ShortInputWithValueMinus1 { get; } = -1;
        public short ShortInputWithValue100 { get; } = 100;
        public int IntInputWithDefaultValue { get; } = default(int);
        public int IntInputWithValue1 { get; } = 1;
        public int IntInputWithValue0 { get; } = 0;
        public int IntInputWithValueMinus1 { get; } = -1;
        public int IntInputWithValue100 { get; } = 100;
        public long LongInputWithDefaultValue { get; } = default(long);
        public long LongInputWithValue1 { get; } = 1;
        public long LongInputWithValue0 { get; } = 0;
        public long LongInputWithValueMinus1 { get; } = -1;
        public long LongInputWithValue100 { get; } = 100;
        public decimal DecimalInputWithDefaultValue { get; } = default(decimal);
        public decimal DecimalInputWithValue1 { get; } = (decimal)1.0;
        public decimal DecimalInputWithValue0 { get; } = (decimal)0.0;
        public decimal DecimalInputWithValueMinus1 { get; } = (decimal)-1.0;
        public decimal DecimalInputWithValue100 { get; } = (decimal)100.0;
        public float FloatInputWithDefaultValue { get; } = default(float);
        public float FloatInputWithValue1 { get; } = (float)1.0;
        public float FloatInputWithValue0 { get; } = (float)0.0;
        public float FloatInputWithValueMinus1 { get; } = (float)-1.0;
        public float FloatInputWithValue100 { get; } = (float)100.0;
        public double DoubleInputWithDefaultValue { get; } = default(double);
        public double DoubleInputWithValue1 { get; } = 1.0;
        public double DoubleInputWithValue0 { get; } = 0.0;
        public double DoubleInputWithValueMinus1 { get; } = -1.0;
        public double DoubleInputWithValue100 { get; } = 100.0;
        public DateTime DateTimeInputWithDefaultValue { get; } = default(DateTime);
        public DateTime DateTimeInputWithValueYesterday { get; } = DateTime.Now.AddDays(-1);
        public DateTime DateTimeInputWithValueNow { get; } = DateTime.Now;
        public DateTime DateTimeInputWithValueTomorrow { get; } = DateTime.Now.AddDays(1);
        public DateTime DateTimeInputWithValueOneHundredDaysAhead { get; } = DateTime.Now.AddDays(100);
        public DateTime SqlDateTimeInputWithMinValue { get; } = new DateTime(552877920000000000);
        public DateTime SqlDateTimeInputWithMaxValue { get; } = new DateTime(3155378975999970000);
        //public DateTime SqlDateTimeInputWithValueBeforeMin { get; } = (new DateTime(552877920000000000)).AddDays(-1);
        //public DateTime SqlDateTimeInputWithValueAfterMax { get; } = (new DateTime(3155378975999970000)).AddDays(1);
        public MyTestEnum EnumInputWithDefaultValue { get; } = default(MyTestEnum);
        public MyTestEnum EnumInputWithValueMinusOne { get; } = MyTestEnum.MinusOne;
        public MyTestEnum EnumInputWithValueZero { get; } = MyTestEnum.Zero;
        public MyTestEnum EnumInputWithValueTwo { get; } = MyTestEnum.Two;
        public MyTestEnum EnumInputWithValueOneHundred { get; } = MyTestEnum.OneHundred;
        public Guid GuidInputWithDefaultValue { get; } = default(Guid);
        public Guid GuidInputWithNormalValue { get; } = Guid.NewGuid();
        public Guid GuidInputWithEmptyValue { get; } = Guid.Empty;
        public object ObjectInputWithDefaultValue { get; } = default(object);
        public object ObjectInput { get; } = new object();
        public object ObjectInputWithValueNull { get; } = null;
        public MyTestPerson PersonInputWithAge10 { get; } = new MyTestPerson { Age = 10 };
        public MyTestPerson PersonInputWithAge20 { get; } = new MyTestPerson { Age = 20 };
        public MyTestPerson PersonInputWithAge30 { get; } = new MyTestPerson { Age = 30 };
        public List<object> ListOfObjectsInputWithDefaultValue { get; } = default(List<object>);
        public List<object> ListOfObjectsInputWithTwoItems { get; } = new List<object> { new object(), new object() };
        public List<object> ListOfObjectsInputWithNoItems { get; } = new List<object>();
        public List<object> ListOfObjectsInputWithNullValue { get; } = null;
    }
}
