using System;
using Xamarin.UITest;
using NUnit.Framework;

namespace SamplePOP.UI.Tests
{
    [Category("LoginTests")]
    public class LoginTests : BaseTest
    {
        const string _username = "ab.low22@gmail.com";
        const string _password = "Xamarinrocks";

        public LoginTests(Platform platform)
            : base(platform)
        {
        }

        [Test]
        public void CreateNewUserAndLogin()
        {
			//Arrange
			var username = _username;
			var password = "test";

            //Act

            //Assert
		}
    }
}