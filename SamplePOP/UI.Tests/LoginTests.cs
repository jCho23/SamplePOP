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
			//Arrange
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
            
        }

        [Test]
        public void ExistingUserLoginAndroid()
        {
            
        }



        [Test]
        public void LocalRepl()
        {
            App.Repl();
        }



    }
}