using System;
using System.Linq;

using Xamarin.UITest;
using Xamarin.UITest.Queries;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace SamplePOP
{
    public class EmailPage : BasePage
    {
        readonly Query emailField;
        readonly Query nextButton;

        public EmailPage(IApp app, Platform platform) : base(app, platform)
        {
            if (OnAndroid)
            {
                emailField = x => x.Marked("login_username");
                nextButton = x => x.Marked("button_label");

            }

            if (OniOS)
            {
                emailField = x => x.Marked("Email Address");
                nextButton = x => x.Marked("Next");
            }

        }


    }
}
