using System;

namespace Insurance.exception
{
    // Thrown when policy is not found
    public class PolicyNotFoundException : Exception
    {
        public PolicyNotFoundException(string message) : base(message) { }
    }
}
