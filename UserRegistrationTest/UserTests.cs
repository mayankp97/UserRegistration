using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using UserRegistration;

namespace UserRegistrationTests
{
    [TestFixture]
    class UserTests
    {
        private User _user;
        [SetUp]
        public void SetUp()
        {
            _user = new User();
        }
        [Test]
        public void ValidateFirstName_IfValidName_ReturnsTrue()
        {
            //Arrange
            var firstName = "Mayank";

            //Act
            var result = _user.ValidateFirstName(firstName);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        [TestCase("mayank")]
        [TestCase("Ma")]
        public void ValidateFirstName_IfInvalidName_ReturnsFalse(string firstName)
        {


            //Assert
            Assert.That(() => _user.ValidateFirstName(firstName), Throws.Exception.InstanceOf<UserException>());
            Assert.That(() => _user.ValidateFirstName(firstName), Throws.Exception.Message.Contains("invalid first name").IgnoreCase);
        }

        [Test]
        public void ValidateLastName_IfValidName_ReturnsTrue()
        {
            //Arrange
            var lastName = "Purohit";

            //Act
            var result = _user.ValidateLastName(lastName);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        [TestCase("purohit")]
        [TestCase("Pu")]
        public void ValidateLastName_IfInvalidName_ReturnsFalse(string lastName)
        {

            //Assert
            Assert.That(() => _user.ValidateLastName(lastName), Throws.Exception.InstanceOf<UserException>());
            Assert.That(() => _user.ValidateLastName(lastName), Throws.Exception.Message.Contains("invalid last name").IgnoreCase);
        }

        [Test]
        [TestCase("abc@bl.co")]
        [TestCase("abc.xyz@bl.co.in")]
        public void ValidateEmail_IfValidEmail_ReturnsTrue(string email)
        {
            //Act
            var result = _user.ValidateEmail(email);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        [TestCase("abc@bl")]
        [TestCase("abc@.co")]
        [TestCase("@bl.co")]
        public void ValidateEmail_IfInvalidEmail_ReturnsFalse(string email)
        {
            //Assert
            Assert.That(() => _user.ValidateEmail(email), Throws.Exception.InstanceOf<UserException>());
            Assert.That(() => _user.ValidateEmail(email), Throws.Exception.Message.Contains("invalid email").IgnoreCase);
        }

        [Test]
        [TestCase("91 9919819801")]
        public void ValidateMobileNumber_IfValidMobileNumber_ReturnsTrue(string mobileNumber)
        {
            //Act
            var result = _user.ValidateMobileNumber(mobileNumber);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        [TestCase("9919819801")]
        [TestCase("919919819801")]
        [TestCase("91 0919819801")]
        public void ValidateMobileNumber_IfInvalidMobileNumber_ReturnsFalse(string mobileNumber)
        {
            //Assert
            Assert.That(() => _user.ValidateMobileNumber(mobileNumber), Throws.Exception.InstanceOf<UserException>());
            Assert.That(() => _user.ValidateMobileNumber(mobileNumber), Throws.Exception.Message.Contains("invalid mobile number").IgnoreCase);
        }

        [Test]
        [TestCase("Starwars@123")]
        public void ValidatePasswrord_IfValidPassword_ReturnsTrue(string password)
        {
            //Act
            var result = _user.ValidatePassword(password);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        [TestCase("Star@12")]
        [TestCase("starwars@123")]
        [TestCase("Starwars@")]
        [TestCase("Starwars@@123")]

        public void ValidatePAssword_IfInvalidPassword_ReturnsFalse(string password)
        {
            //Assert
            Assert.That(() => _user.ValidatePassword(password), Throws.Exception.InstanceOf<UserException>());
            Assert.That(() => _user.ValidatePassword(password), Throws.Exception.Message.Contains("invalid password").IgnoreCase);
        }
    }
}
