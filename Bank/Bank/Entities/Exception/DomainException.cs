using System;

namespace Bank.Entities.Exception
{
    internal class DomainException : ApplicationException 
    {
        public DomainException(string message) : base(message)
        { }
    }
}
