using System;
namespace SalesWebApplicationMVC.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base(message) { 
        }

    }
}
