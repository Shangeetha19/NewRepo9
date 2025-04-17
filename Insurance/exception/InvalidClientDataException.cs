using System;

namespace Insurance.exception
{
    // Thrown when client data is incomplete or invalid
    public class InvalidClientDataException : Exception
    {
        public InvalidClientDataException() { }

        public InvalidClientDataException(string message) : base(message) { }

        public InvalidClientDataException(string message, Exception inner) : base(message, inner) { }
    }
}


