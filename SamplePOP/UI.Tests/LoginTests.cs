using System;
using Xamarin.UITest;
using NUnit.Framework;

namespace SamplePOP
{
    [Category("LoginTests")]
    public class LoginTests : BaseTest
    {
        const string _usernameEmail = "junecho@gmail.com";
        const string _password = "Xamarinrocks";

        public LoginTests(Platform platform)
            : base(platform)
        {
        }

        [Test]
        public void CreateNewUserAndLoginiOS()
        {

            //Using Arrange, Act, Assert is a great way to keep your tests in order

            //Arrange
            #region
            var usernameEmail = _usernameEmail;
            var password = "Xamarintest";
            var expectedEmailPageTitle = "Email Page";

            //Act
            WelcomePage.TapGetStartedButton();
            EmailPage.EnterNewEmail(usernameEmail);
            LoginPage.CreateNewUser(usernameEmail, password);
            LocationPage.TapContinueLocation();
            NotificationPage.TapOnAllowNotifications();
            UpgradePage.TapNotRightNowButton();

            //Assert
            var actualEmailPageTitle = EmailPage.GetTitle();
            Assert.AreEqual(expectedEmailPageTitle, actualEmailPageTitle);
            #endregion
        }

        [Test]
        public void CreateNewUserAndLoginAndroid()
        {
            //Arrange 
            var usernameEmail = _usernameEmail;
            var password = "Xamarintest";

            //Act
            LoginPage.CreateNewUser(_usernameEmail, password);

            //Assert
        }


        [Test]
        public void ExistingUserLoginiOS()
        {
            //Arrange
            var ExistingEmail = _usernameEmail;


            //Act
            WelcomePage.TapGetStartedButton();
            EmailPage.EnterExistingEmail(ExistingEmail);
           


			//Assert
		}

        [Test]
        public void ExistingUserLoginAndroid()
        {
			//Arrange
			var usernameEmail = _usernameEmail;
			var password = "XamarinRocks";

            //Act
            LoginPage.EnterExsistingUser(_usernameEmail, password);

            //Assert
        }

        [Test]
        public void LocalRepl()
        {
            App.Repl();
        }
    }
}