using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationWithExceptionAndReflaction
{
    public class InvalidException : Exception //Inherit Parent class of exception
    {
        public enum ExceptionType //Creating a enum with 3 variable
        {
            NULL_INPUT, EMPTY_INPUT, INVALID_INPUT
        }
        public ExceptionType type; // Creating enum name type variable
        public InvalidException(ExceptionType type, string message) : base(message) // Creating a constructor with parent class
        {
            this.type = type;// Assigning value
        }
    }
}