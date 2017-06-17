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
        readonly Query dialogEmailConfirmationYesButton;
        readonly Query progressIndicator;

        public LoginPage(IApp app, Platform platform) : base(app, platform)
        {
            if (OnAndroid)
            {
				emailField = x => x.Marked("login_username");
				passwordField = x => x.Marked("login_password");
				nextButton = x => x.Marked("button_label");
				//backButton = x => x.Marked();
                dialogEmailConfirmationYesButton = x => x.Marked("button1");
                progressIndicator = x => x.Marked("progress");
			}

            if (OniOS)
            {
				emailField = x => x.Marked("Email Address");
				passwordField = x => x.Marked("Password");
                nextButton = x => x.Marked("Next");
				backButton = x => x.Marked("Back");
                dialogEmailConfirmationYesButton = x => x.Marked("Yes");
            }
        }

        public void CreateNewUser (string username, string password)
        {
            if (OnAndroid)
            {
                App.ClearText();
				App.EnterText(passwordField, password);
				App.DismissKeyboard();
				App.Screenshot("We have 'Entered' our New User Password");

				App.Tap(nextButton);
				App.Screenshot("Then we 'Tapped' the 'Next' Button");

				App.WaitForElement(dialogEmailConfirmationYesButton);
				App.Screenshot("Email Confirmaiton popup should appear");

				App.Tap(dialogEmailConfirmationYesButton);
				App.Screenshot("Next we 'Tapped' on the 'Yes' Button");
            }

            if (OniOS)
            {
                App.ClearText();
				App.EnterText(passwordField, password);
				App.DismissKeyboard();
				App.Screenshot("We have 'Entered' our New User Password");

				App.Tap(nextButton);
                App.Screenshot("Then we 'Tapped' the 'Next' Button");

				App.WaitForElement(dialogEmailConfirmationYesButton);
				App.Screenshot("Email Confirmaiton popup should appear");

				App.Tap(dialogEmailConfirmationYesButton);
                App.Screenshot("Next we 'Tapped' on the 'Yes' Button");
            }
        }

        public void EnterExsistingUser(string username, string password)
        {
            App.ClearText();
            App.EnterText(passwordField, password);
            App.Screenshot("We 'Entered' our password");

            App.DismissKeyboard();
            App.Screenshot("Dismissed Keyboard");

            App.Tap(nextButton);
            App.Screenshot("Then we 'Tapped' on the 'Next' Button");
            App.WaitForNoElement(progressIndicator);
        }
	}
}
