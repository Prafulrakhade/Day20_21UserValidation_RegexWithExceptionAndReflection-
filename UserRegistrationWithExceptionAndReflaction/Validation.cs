using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationWithExceptionAndReflaction
{
    public class Validation
    {
        public string FirstNameValidation(string fName) // Creating a method for First name validation
        {
            try
            {
                string pattern = "^[A-Z][a-z]{2,}$"; // Regex for first name validation
                if (fName.Equals(string.Empty))
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input should not be empty");
                }                                     //If name entered by user is match with regex then it is valid otherwise not
                if (Regex.IsMatch(fName, pattern))
                {
                    Console.WriteLine($"\nYour first name \"{fName}\" is valid");
                    return "Input is valid";
                }
                else
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input is not valid");
                }

            }
            catch (NullReferenceException ex)
            {
                throw new InvalidException(InvalidException.ExceptionType.NULL_INPUT, "Input should not be null");
            }
            catch (InvalidException ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }
    }
}
