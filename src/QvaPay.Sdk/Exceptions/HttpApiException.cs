using System;

namespace QvaPay.Sdk.Exceptions
{
    public class HttpApiException<T> : Exception
    {
        public T Error { get; set; }
        public HttpApiException(string message, Exception innerException, T error)
            : base(message: message, innerException: innerException)
        {
            Error = error;
        }
    }
}
