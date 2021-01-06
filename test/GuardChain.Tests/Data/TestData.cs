using System;
using System.Collections.Generic;
using System.Text;

namespace GuardChain.Tests.Data
{
    public class TestData
    {
        public string StringInput { get; } = "normal string";
        public string ZeroLengthStringInput { get; } = "";
        public string EmptyStringInput { get; } = string.Empty;
        public short ShortInput { get; } = 1;
        public int IntInput { get; } = 1;
        public long LongInput { get; } = 1;
        public decimal DecimalInput { get; } = (decimal)1.0;
        public float FloatInput { get; } = (float)1.0;
        public double DoubleInput { get; } = 1.0;
        public DateTime DateTimeInput { get; } = DateTime.Now;
        public MyTestEnum EnumInputTwo { get; } = MyTestEnum.Two;
        public Guid GuidInput { get; } = Guid.Empty;
        public object ObjectInput { get; } = new object();
        public object NullObjectInput { get; } = null;
        public List<object> ListInput { get; } = new List<object>();
    }
}
