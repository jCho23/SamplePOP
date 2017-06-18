﻿using System;
using Xamarin.UITest;
using NUnit.Framework;

namespace SamplePOP
{
    [Category("LoginTests")]
    public class LoginTests : BaseTest
    {
        const string _usernameEmail = "ab.low22@gmail.com";
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
			var password = "test";

            //Act
            WelcomePage.TapGetStartedButton();
            EmailPage.EnterNewEmail(usernameEmail);
            LoginPage.CreateNewUser(password);

            //Assert
		}

        [Test]
        public void Repl()
        {
            App.Repl();
        }



    }
}