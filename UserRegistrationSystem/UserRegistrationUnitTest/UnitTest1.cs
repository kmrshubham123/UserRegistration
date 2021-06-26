using NUnit.Framework;
using UserRegistrationSystem;

namespace UserRegistrationUnitTest
{
    public class Tests
    {
        [Test]
        //TC1:-Test to Validate the user Entry for First Name
        //Test Case for Pass(Happy) Entry
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
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsTrue(result);
        }
        //TC5:-Test to Validate the user Entry for All Sample Email
        //Refactor:-Exception
        [Test]
        public void GivenAllSampleEmail_WhenValidate_ShouldReturnTrue()
        {
            try
            {
                //Arrange
                UserRegistration user = new UserRegistration();
                string email = "abc@yahoo.com, abc-100@yahoo.com, abc.100@yahoo.com, abc111@abc.com, abc-100@yabc.net, abc.100@abc.com.au, abc@1.com,abc@gmail.com.com,abc+100@ygmail.com";
                //Act
                bool result = user.ValidateAllEmail(email);
            }
            catch (InvalidUserDetailException e)
            {
                //Assert
                Assert.AreEqual("Invalid Sample Email.", e.Message);
            }
        }
        //UC12:-Test Cases Fail(Sad) The Entry
        [Test]
        public void GivenUserFistName_WhenValidate_Should_Throw_InvalidUserDetailException_Indicating_Invalid_FirstName()
        {
            try
            {
                //Arrange
                UserRegistration user = new UserRegistration();
                string firstName = "kumar";
                //Act
                bool result = user.ValidateFirstName(firstName);
            }
            catch (InvalidUserDetailException e)
            {
                //Assert
                Assert.AreEqual("Invalid first name.", e.Message);
            }
        }
        [Test]
        public void GivenUserLastName_WhenValidate_Should_Throw_InvalidUserDetailException_Indicating_Invalid_LastName()
        {
            try
            {
                //Arrange
                UserRegistration user = new UserRegistration();
                string lastName = "shubham";
                //Act
                bool result = user.ValidateLastName(lastName);
            }
            catch (InvalidUserDetailException e)
            {
                //Assert
                Assert.AreEqual("Invalid last name.", e.Message);
            }
        }
        [Test]
        public void GivenEmail_WhenValidate_Should_Throw_InvalidUserDetailException_Indicating_Invalid_Email()
        {
            try
            {
                //Arrange
                UserRegistration user = new UserRegistration();
                string email = "KUMARSHUBHAM123@Gmail.com";
                //Act
                bool result = user.ValidateEmail(email);
            }
            catch (InvalidUserDetailException e)
            {
                //Assert
                Assert.AreEqual("Invalid email id.", e.Message);
            }
        }
   
        [Test]
        public void GivenMobileNumber_WhenValidate_Should_Throw_InvalidUserDetailException_Indicating_Invalid_MobileNumber()
        {
            try
            {
                //Arrange
                UserRegistration user = new UserRegistration();
                string mobileNumber = "923659865987";
                //Act
                bool result = user.ValidateMobileNumber(mobileNumber);
            }
            catch (InvalidUserDetailException e)
            {
                //Assert
                Assert.AreEqual("Invalid mobile number.", e.Message);
            }
        }
        [Test]
        public void GivenPassword_WhenValidate_Should_Throw_InvalidUserDetailException_Indicating_Invalid_Password()
        {
            try
            {
                //Arrange
                UserRegistration user = new UserRegistration();
                string password = "kumar@96969";
                //Act
                bool result = user.ValidatePassword(password);
            }
            catch (InvalidUserDetailException e)
            {
                //Assert
                Assert.AreEqual("Invalid password.", e.Message);
            }
        }
    }
}