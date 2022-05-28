using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationWithExceptionAndReflaction;

namespace MsTestUserRegistration
{
    [TestClass]
    public class UserTest
    {
        Validation validation;
        [TestInitialize]
        public void SetUp()
        {
            // common Arrange
            validation = new Validation();
        }
        [TestMethod]
        //Checking for multiple first name
        [DataRow("Praful", "Input is valid")]
        [DataRow("pr", "Input is not valid")]
        [DataRow("praful", "Input is not valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null, "Input should not be null")]
        public void GivenFirstNameValidation(string firstName, string expected) // Testing for Firstname Validation
        {
            try
            {
                //Act
                string actual = validation.FirstNameValidation(firstName);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        //Checking for multiple last names
        [DataRow("Rakhade", "Input is valid")]
        [DataRow("ra", "Input is not valid")]
        [DataRow("rakhade", "Input is not valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null, "Input should not be null")]
        public void GivenLastNameValidation(string lastName, string expected) // Testing for Lastname Validation
        {
            try
            {
                //Act
                string actual = validation.FirstNameValidation(lastName);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        //Checking for multiple email samples
        [DataRow("abc123@.com", "Input is not valid")]
        [DataRow("abc@abc@gmail.com", "Input is not valid")]
        [DataRow("abc+100@gmail.com", "Input is valid")]
        [DataRow("abc@1.com", "Input is valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null, "Input should not be null")]
        public void GivenEmailValidation(string email, string expected) // Testing for Lastname Validation
        {
            try
            {
                //Act
                string actual = validation.EmailValidation(email);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        //Checking for multiple mobile numbers
        [DataRow("91 9652545874", "Input is valid")]
        [DataRow("919652545874", "Input is not valid")]
        [DataRow("9144 9652545874", "Input is not valid")]
        [DataRow("91 1652545874", "Input is not valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null, "Input should not be null")]
        public void GivenMobileNumberValidation(string mobileNumber, string expected) // Testing for mobile number Validation
        {
            try
            {
                //Act
                string actual = validation.MobileNumberValidation(mobileNumber);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        //Checking for multiple password samples
        [DataRow("dfghnjvbn", "Input is valid")]
        [DataRow("ADF@#$%JVGB", "Input is valid")]
        [DataRow("FVGdf", "Input is not valid")]
        [DataRow("8745fgvhA", "Input is valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null, "Input should not be null")]
        public void GivenPassrordRule1Validation(string password, string expected) // Testing for password rule 1 Validation
        {
            try
            {
                //Act
                string actual = validation.PasswordRule1Validation(password);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        //Checking for multiple password samples
        [DataRow("dfghnjvbn", "Input is valid")]
        [DataRow("ADF@#$%JVGB", "Input is valid")]
        [DataRow("FVGdf", "Input is not valid")]
        [DataRow("8745fgvhA", "Input is valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null, "Input should not be null")]
        public void GivenPassrordRule2Validation(string password, string expected) // Testing for password rule 1 Validation
        {
            try
            {
                //Act
                string actual = validation.PasswordRule1Validation(password);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        //Checking for multiple password samples
        [DataRow("dfgDnjvbn", "Input is not valid")]
        [DataRow("A5sdf@#df", "Input is valid")]
        [DataRow("F5G@f", "Input is not valid")]
        [DataRow("8465ADFG", "Input is valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null, "Input should not be null")]
        public void GivenPasswordRule3Validation(string password, string expected) // Testing for password rule 3 Validation
        {
            try
            {
                //Act
                string actual = validation.PasswordRule3Validation(password);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        //Checking for multiple password samples
        [DataRow("dfgDnjvbn", "Input is not valid")]
        [DataRow("A5sdf@df", "Input is valid")]
        [DataRow("F5G@f", "Input is not valid")]
        [DataRow("85ADcv*gj5", "Input is valid")]
        [DataRow("*&&dfgADDd845", "Input is not valid")]
        [DataRow("885@dfvvvb", "Input is not valid")]
        [DataRow("AAaa#8ghbb", "Input is valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null, "Input should not be null")]
        public void GivenPasswordRule4Validation(string password, string expected) // Testing for password rule 4 along with all Validation
        {
            try
            {
                //Act
                string actual = validation.PasswordRule4Validation(password);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        //Checking for multiple email samples that are valid
        [DataRow("abc@gmail.com", "Input is valid")]
        [DataRow("abc-100@yahoo.com", "Input is valid")]
        [DataRow("abc.100@yahoo.com", "Input is valid")]
        [DataRow("abc@1.com", "Input is valid")]
        [DataRow("abc111@yahoo.com.au", "Input is valid")]
        [DataRow("abc-100@yahoo.com.au", "Input is valid")]
        [DataRow("abc@gmail.com.com", "Input is valid")]
        [DataRow("abc+100@yahoo.com", "Input is valid")]
        //Checking for multiple email samples that are Invalid
        [DataRow("abc", "Input is not valid")]
        [DataRow("abc@.com.my", "Input is not valid")]
        [DataRow("abc123@gmail.a", "Input is not valid")]
        [DataRow("abc123@.com", "Input is not valid")]
        [DataRow("abc@.com.com", "Input is not valid")]
        [DataRow(".abc@abc.com", "Input is not valid")]
        [DataRow("abc()*@gmail.com", "Input is not valid")]
        [DataRow("abc@%*.com", "Input is not valid")]
        [DataRow("abc..2002@gmail.com", "Input is not valid")]
        [DataRow("abc.@gmail.com", "Input is not valid")]
        [DataRow("abc@abc@gmail.com", "Input is not valid")]
        [DataRow("abc@gmail.com.1a", "Input is not valid")]
        [DataRow("abc@gmail.com.aa.au", "Input is not valid")]
        public void GivenEmailSamplesValidation(string email, string expected) // Testing for email samples Validation
        {
            try
            {
                //Act
                string actual = validation.EmailValidation(email);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
