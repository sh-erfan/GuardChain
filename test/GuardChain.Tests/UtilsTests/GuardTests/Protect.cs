using System;
using System.Collections;
using System.Collections.Generic;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using Xunit;

namespace GuardChain.Tests.UtilsTests.GuardTests
{
    public class Protect
    {

        [Theory]
        [ClassData(typeof(TestData))]
        public void ShouldReturnCorrectTypeGivenInputOfSpecificType(object input, string inputParameterName, Type inputType, string inputTypeFullName)
        {
            Assert.Equal(inputTypeFullName, Guard.Protect(input).Against.Input.GetType().FullName);
        }

        [Theory]
        [ClassData(typeof(TestData))]
        public void ShouldReturnBackTheInputValue(object input, string inputParameterName, Type inputType, string inputTypeFullName)
        {
            Assert.Equal(input, Guard.Protect(input).Against.Input);
        }

        [Theory]
        [ClassData(typeof(TestData))]
        public void ShouldReturnBackTheInputParameterName(object input, string inputParameterName, Type inputType, string inputTypeFullName)
        {
            Assert.Equal(inputParameterName, Guard.Protect(input, inputParameterName).Against.InputParameterName);
        }

        [Theory]
        [ClassData(typeof(TestData))]
        public void ShouldReturnDefaultInputParameterNameWhenNotSpecified(object input, string inputParameterName, Type inputType, string inputTypeFullName)
        {
            var defaultInputParameterName = "GuardInput";

            Assert.Equal(defaultInputParameterName, Guard.Protect(input).Against.InputParameterName);
        }

        #region Data

        public class TestData : IEnumerable<object[]>
        {
            Foo fooInput = new Foo();
            IEnumerable<Foo> fooInputs = new List<Foo>{ new Foo()};
            object objectInput = new object();
            string stringInput = "input";
            DateTime dateTimeInput = DateTime.Now;
            short shortInput = 1;
            int intInput = 1;
            long longInput = 1L;
            float floatInput = 1.5f;
            decimal decimalInput = 1.5M;
            double doubleInput = 1.5;

            public IEnumerator<object[]> GetEnumerator()
            {

                yield return new object[] { fooInput, nameof(fooInput), fooInput.GetType(), fooInput.GetType().FullName };
                yield return new object[] { fooInputs, nameof(fooInputs), fooInputs.GetType(), fooInputs.GetType().FullName };
                yield return new object[] { objectInput, nameof(objectInput), objectInput.GetType(), objectInput.GetType().FullName };
                yield return new object[] { stringInput, nameof(stringInput), stringInput.GetType(), stringInput.GetType().FullName };
                yield return new object[] { dateTimeInput, nameof(dateTimeInput), dateTimeInput.GetType(), dateTimeInput.GetType().FullName };
                yield return new object[] { shortInput, nameof(shortInput), shortInput.GetType(), shortInput.GetType().FullName };
                yield return new object[] { intInput, nameof(intInput), intInput.GetType(), intInput.GetType().FullName };
                yield return new object[] { longInput, nameof(longInput), longInput.GetType(), longInput.GetType().FullName };
                yield return new object[] { floatInput, nameof(floatInput), floatInput.GetType(), floatInput.GetType().FullName };
                yield return new object[] { decimalInput, nameof(decimalInput), decimalInput.GetType(), decimalInput.GetType().FullName };
                yield return new object[] { doubleInput, nameof(doubleInput), doubleInput.GetType(), doubleInput.GetType().FullName };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        class Foo
        {
            public string StringField { get; set; }
        }

        #endregion
    }
}
