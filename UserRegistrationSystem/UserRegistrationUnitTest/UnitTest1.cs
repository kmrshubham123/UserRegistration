using NUnit.Framework;
using UserRegistrationSystem;

namespace UserRegistrationUnitTest
{
    public class Tests
    {
        [Test]
        //TC1:-Test to Validate the user Entry for First Name
        public void GivenUserFistName_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            UserRegistration user = new UserRegistration();
            string firstName = "Kumar";
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        //TC2:-Test to Validate the user Entry for Last Name
        public void GivenUserLastName_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            UserRegistration user = new UserRegistration();
            string lastName = "Shubham";
            //Act
            bool result = user.ValidateLastName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        //TC3:-Test to Validate the user Entry for Email
        public void GivenUserEmail_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            UserRegistration user = new UserRegistration();
            string email = "kmrshubham123@gmail.com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        //TC4:-Test to Validate the user Entry for Mobile
        public void GivenUserMobile_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            UserRegistration user = new UserRegistration();
            string mobilenumber = "97 9899100665";
            //Act
            bool result = user.ValidateMobileNumber(mobilenumber);
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        //TC4:-Test to Validate the user Entry for Password
        public void GivenUserPassword_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            UserRegistration user = new UserRegistration();
            string password = "Happy@5698";
            //Act
            bool result = user.ValidatePasswordFourth(password);
            //Assert
            Assert.IsTrue(result);
        }
    }
}