using System;
using System.Linq.Expressions;

namespace NeaUtils.Extensions.ErrorHandling
{
    internal static class ErrorChecks
    {
        public static InvalidValueException ConditionalErrorCheck<T>(this T source, Expression<Func<T, bool>> exp, bool autothrow = false)
        {
            if (!exp.Compile()(source))
            {
                return null;
            }
            
            var ex = new InvalidValueException("The Value " + source + " violated the predicate Function: " + exp.Body);
            if (autothrow)
            {
                throw ex;
            }
            return ex;
        }
    }

    public class InvalidValueException : Exception
    {
        public InvalidValueException()
        {
        }

        public InvalidValueException(string message)
        : base(message)
        {
        }

        public InvalidValueException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
