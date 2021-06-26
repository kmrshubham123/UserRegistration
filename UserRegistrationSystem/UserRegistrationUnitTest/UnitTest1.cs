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
        //TC5:-Test to Validate the user Entry for All Sample Email
        [Test]
        public void GivenAllSampleEmail_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            UserRegistration user = new UserRegistration();
            string email = "abc@yahoo.com, abc-100@yahoo.com, abc.100@yahoo.com, abc111@abc.com, abc-100@yabc.net, abc.100@abc.com.au, abc@1.com,abc@gmail.com.com,abc+100@ygmail.com";
            //Act
            bool result = user.ValidateAllEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
    }
}