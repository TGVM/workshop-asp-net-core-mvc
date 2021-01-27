using System;

namespace SalesWebApplicationMVC.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message) { 
        
        }
    }
}
