using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using GuardChain.Models;
using GuardChain.Tests.Data;
using GuardChain.Utils;
using Xunit;

namespace GuardChain.Tests.UtilsTests.ChainTests
{
    public class Next
    {
        [Theory]
        [ClassData(typeof(TestData))]
        public void ShouldConvertGuardClauseToChainableGuardClause<TData>(IGuardClause<TData> guardClause)
        {
            Assert.Equal(typeof(ChainableGuardClause<TData>), Chain.Next(guardClause).GetType());
        }

        #region Data

        public class TestData : IEnumerable<object[]>
        {
            Foo fooInput = new Foo();
            IEnumerable<Foo> fooInputs = new List<Foo> { new Foo() };
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
                yield return new object[] { new GuardClause<Foo>(fooInput) };
                yield return new object[] { new GuardClause<IEnumerable<Foo>>(fooInputs) };
                yield return new object[] { new GuardClause<object>(objectInput) };
                yield return new object[] { new GuardClause<string>(stringInput) };
                yield return new object[] { new GuardClause<DateTime>(dateTimeInput) };
                yield return new object[] { new GuardClause<short>(shortInput) };
                yield return new object[] { new GuardClause<int>(intInput) };
                yield return new object[] { new GuardClause<long>(longInput) };
                yield return new object[] { new GuardClause<float>(floatInput) };
                yield return new object[] { new GuardClause<decimal>(decimalInput) };
                yield return new object[] { new GuardClause<double>(doubleInput) };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        #endregion
    }
}
