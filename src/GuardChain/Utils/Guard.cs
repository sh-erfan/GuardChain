using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using GuardChain.Exceptions;
using GuardChain.Models;

namespace GuardChain.Utils
{
    public static class Guard
    {
        
        public static IInitialGuardClause<TInput> Protect<TInput>(TInput input)
        {
            return new InitialGuardClause<TInput>(input);
        }

        public static IInitialGuardClause<TInput> Protect<TInput>(TInput input, string inputParameterName)
        {
            return new InitialGuardClause<TInput>(input, inputParameterName);
        }


        public static void ThrowCustomException(Type customExceptionType, params object[] customExceptionArgs)
        {
            Exception exception;
            try
            {
                exception = (Exception)Activator.CreateInstance(customExceptionType, customExceptionArgs);
            }
            catch (InvalidCastException)
            {
                throw new CustomExceptionTypeIsNotAnException(customExceptionType.Name);
            }
            catch (MissingMethodException)
            {
                throw new NoConstructorMatchingWithSpecifiedArgs(customExceptionType.Name);
            }
            catch (Exception ex)
            {
                throw new GuardDefaultException(ex);
            }

            if (exception != null)
            {
                throw exception;
            }

            // This line is just to ensure that and exception will be thrown.
            // Execution will never be reached here/
            throw new GuardDefaultException($"Unable to create instance of {customExceptionType.Name} for unknown reason");
        }
    }
}
