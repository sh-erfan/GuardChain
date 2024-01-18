using System;
using GuardChain.Exceptions;
using GuardChain.Utils;
using Xunit;

namespace GuardChain.Tests.UtilsTests.GuardTests
{
    public class ThrowException
    {
        [Fact]
        public void ShouldThrowTheCustomGivenMatchingConstructorArguments()
        {
            Assert.Throws<CustomExceptionWithDefaultConstructor>(() => Guard.ThrowCustomException(typeof(CustomExceptionWithDefaultConstructor)));
            Assert.Throws<CustomExceptionWithoutDefaultConstructor>(() => Guard.ThrowCustomException(typeof(CustomExceptionWithoutDefaultConstructor), 100));
            Assert.Throws<CustomExceptionWithoutDefaultConstructor>(() => Guard.ThrowCustomException(typeof(CustomExceptionWithoutDefaultConstructor), "message"));
            Assert.Throws<CustomExceptionWithMultipleConstructors>(() => Guard.ThrowCustomException(typeof(CustomExceptionWithMultipleConstructors)));
            Assert.Throws<CustomExceptionWithMultipleConstructors>(() => Guard.ThrowCustomException(typeof(CustomExceptionWithMultipleConstructors), "message"));
            Assert.Throws<CustomExceptionWithMultipleConstructors>(() => Guard.ThrowCustomException(typeof(CustomExceptionWithMultipleConstructors), 100, "message"));

            Assert.Throws<CustomExceptionWithDefaultConstructor>(() => Guard.ThrowCustomException<CustomExceptionWithDefaultConstructor>());
            Assert.Throws<CustomExceptionWithoutDefaultConstructor>(() => Guard.ThrowCustomException<CustomExceptionWithoutDefaultConstructor>(100));
            Assert.Throws<CustomExceptionWithoutDefaultConstructor>(() => Guard.ThrowCustomException<CustomExceptionWithoutDefaultConstructor>("message"));
            Assert.Throws<CustomExceptionWithMultipleConstructors>(() => Guard.ThrowCustomException<CustomExceptionWithMultipleConstructors>());
            Assert.Throws<CustomExceptionWithMultipleConstructors>(() => Guard.ThrowCustomException<CustomExceptionWithMultipleConstructors>("message"));
            Assert.Throws<CustomExceptionWithMultipleConstructors>(() => Guard.ThrowCustomException<CustomExceptionWithMultipleConstructors>(100, "message"));
        }


        [Fact]
        public void ShouldThrowNoConstructorMatchingWithSpecifiedArgsExceptionGivenInconsistentConstructorParameters()
        {
            Assert.Throws<NoConstructorMatchingWithSpecifiedArgs>(() => Guard.ThrowCustomException(typeof(CustomExceptionWithDefaultConstructor), "My constructor does not accept parameters"));
            Assert.Throws<NoConstructorMatchingWithSpecifiedArgs>(() => Guard.ThrowCustomException(typeof(CustomExceptionWithoutDefaultConstructor)));
            Assert.Throws<NoConstructorMatchingWithSpecifiedArgs>(() => Guard.ThrowCustomException(typeof(CustomExceptionWithoutDefaultConstructor), 100, "message"));
            Assert.Throws<NoConstructorMatchingWithSpecifiedArgs>(() => Guard.ThrowCustomException(typeof(CustomExceptionWithoutDefaultConstructor), DateTime.Now));
            Assert.Throws<NoConstructorMatchingWithSpecifiedArgs>(() => Guard.ThrowCustomException(typeof(CustomExceptionWithMultipleConstructors), "message", 100));
            Assert.Throws<NoConstructorMatchingWithSpecifiedArgs>(() => Guard.ThrowCustomException(typeof(CustomExceptionWithMultipleConstructors), "message1", "message2"));

            Assert.Throws<NoConstructorMatchingWithSpecifiedArgs>(() => Guard.ThrowCustomException<CustomExceptionWithDefaultConstructor>("My constructor does not accept parameters"));
            Assert.Throws<NoConstructorMatchingWithSpecifiedArgs>(() => Guard.ThrowCustomException<CustomExceptionWithoutDefaultConstructor>());
            Assert.Throws<NoConstructorMatchingWithSpecifiedArgs>(() => Guard.ThrowCustomException<CustomExceptionWithoutDefaultConstructor>(100, "message"));
            Assert.Throws<NoConstructorMatchingWithSpecifiedArgs>(() => Guard.ThrowCustomException<CustomExceptionWithoutDefaultConstructor>(DateTime.Now));
            Assert.Throws<NoConstructorMatchingWithSpecifiedArgs>(() => Guard.ThrowCustomException<CustomExceptionWithMultipleConstructors>("message", 100));
            Assert.Throws<NoConstructorMatchingWithSpecifiedArgs>(() => Guard.ThrowCustomException<CustomExceptionWithMultipleConstructors>("message1", "message2"));
        }

        #region Data

        class CustomExceptionWithDefaultConstructor : Exception
        {

        }

        class CustomExceptionWithoutDefaultConstructor : Exception
        {
            public CustomExceptionWithoutDefaultConstructor(int x) { }
            public CustomExceptionWithoutDefaultConstructor(string str) { }
        }

        class CustomExceptionWithMultipleConstructors : Exception
        {
            public CustomExceptionWithMultipleConstructors() { }
            public CustomExceptionWithMultipleConstructors(int x) { }
            public CustomExceptionWithMultipleConstructors(string str) { }
            public CustomExceptionWithMultipleConstructors(int x, string str) { }
        }




        #endregion
    }
}
