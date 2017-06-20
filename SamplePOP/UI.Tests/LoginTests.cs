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

            //Act
            WelcomePage.TapGetStartedButton();
            EmailPage.EnterNewEmail(usernameEmail);
            LoginPage.CreateNewUser(password);
            LocationPage.TapOnContinueLocation();
            NotificationPage.TapOnAllowNotifications();

            //Assert
		}

        [Test]
        public void Repl()
        {
            App.Repl();
        }



    }
}