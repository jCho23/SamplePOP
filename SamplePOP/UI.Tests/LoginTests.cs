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
        public void CreateNewUserAndLogin()
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
        public void ExistingUserLogin()
        {
            
        }


        [Test]
        public void LocalRepl()
        {
            App.Repl();
        }



    }
}