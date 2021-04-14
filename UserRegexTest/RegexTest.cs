using NUnit.Framework;
using UserRegistration;

namespace UserRegexTest
{
    public class RegexTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void GivenFirstName_WhenValidate_ShouldReturnTrue()
        {
            UserValidation user = new UserValidation();
            bool valid = user.ValidateFirstName("Janhavi");
            Assert.IsTrue(valid);
        }

        [Test]
        public void GivenWrongFirstName_WhenValidate_ShouldReturnFalse()
        {
            UserValidation user = new UserValidation();
            bool valid = user.ValidateFirstName("ian");
            Assert.IsFalse(valid);
        }
        [Test]
        public void GivenLastName_WhenValidate_ShouldReturnTrue()
        {
            UserValidation user = new UserValidation();
            bool valid = user.ValidateLastName("Parte");
            Assert.IsTrue(valid);
        }

        [Test]
        public void GivenWrongLastName_WhenValidate_ShouldReturnFalse()
        {
            UserValidation user = new UserValidation();
            bool valid = user.ValidateLastName("parte");
            Assert.IsFalse(valid);
        }  
        [Test]
        public void GivenMobileNumber_WhenValidate_ShouldReturbTrue()
        {
            UserValidation user = new UserValidation();
            bool valid = user.ValidateMobileNo("9757123369");
            Assert.IsTrue(valid);
        }
        [Test]
        public void GivenWrongMobileNumber_WhenValidate_ShouldReturnFalse()
        {
            UserValidation user = new UserValidation();
            bool valid = user.ValidateMobileNo("25631754");
            Assert.IsFalse(valid);
        }
        [Test]
        public void GivenEmailAddress_WhenValidate_ShouldReturnTrue()
        {
            UserValidation user = new UserValidation();
            bool valid = user.ValidateEmail("partejannvi@gmail.com");
            Assert.IsTrue(valid);
        }
        [Test]
        public void GivenWrongEmailAddress_WhenValidate_ShouldReturnFalse()
        {
            UserValidation user = new UserValidation();
            bool valid = user.ValidateEmail("janhavipartegmail.com");
            Assert.IsFalse(valid);
        }
        [Test]
        public void GivenPassword_WhenValidate_ShouldReturnTrue()
        {
            UserValidation user = new UserValidation();
            bool valid = user.ValidatePassword("abcdeS@1234");
            Assert.IsTrue(valid);
        }
    }
}