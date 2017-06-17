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
                
            }

            if (OniOS)
            {
				emailField = x => x.Marked("Email Address");
				passwordField = x => x.Marked("Password");
                nextButton = x => x.Marked("Next");

            }

        }
    }
}
