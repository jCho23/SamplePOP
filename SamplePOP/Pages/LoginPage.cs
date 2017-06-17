using System;
using System.Linq;

using Xamarin.UITest;
using Xamarin.UITest.Queries;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace SamplePOP
{
    public class LoginPage : BasePage
    {
		readonly Query emailField;
        readonly Query passwordField;
		readonly Query nextButton;
		readonly Query backButton;

        public LoginPage(IApp app, Platform platform) : base(app, platform)
        {
            if (OnAndroid)
            {
				emailField = x => x.Marked("login_username");
				passwordField = x => x.Marked("login_password");
				nextButton = x => x.Marked("button_label");
				//backButton = x => x.Marked();
			}

            if (OniOS)
            {
				emailField = x => x.Marked("Email Address");
				passwordField = x => x.Marked("Password");
                nextButton = x => x.Marked("Next");
				backButton = x => x.Marked("Back");
            }
        }

        public void CreateNewUser (string username, string password)
        {
            
        }



	}
}
