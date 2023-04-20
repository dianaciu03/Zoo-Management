using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Result<T>
    {
        public readonly T _value;
        public readonly Exception? _exception;
        public readonly string _message;

        private Result(T value)
        {
            _value = value;
            _exception = null;
            _message = null!;
        }

        private Result(Exception? exception)
        {
            _value = default!;
            _exception = exception;
            _message = null!;
        }

        private Result(string message)
        {
            _value = default!;
            _exception = null;
            _message = message;
        }

        public bool Success => _exception == null && _message == null;

        public static Result<T> Ok(T value)
        {
            return new Result<T>(value);
        }

        public static Result<T> Fail(Exception exception)
        {
            return new Result<T>(exception);
        }

        public static Result<T> Fail(string exception)
        {
            return new Result<T>(exception);
        }
    }
}
