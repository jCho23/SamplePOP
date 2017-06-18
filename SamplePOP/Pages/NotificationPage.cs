using System;
using System.Linq;

using Xamarin.UITest;
using Xamarin.UITest.Queries;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace SamplePOP
{
    public class NotificationPage : BasePage
    {
		readonly Query AllowButton;
		readonly Query DontAllowButton;
		readonly Query dialogNotificationConfirmationYesButton;
		readonly Query dialogNotificationConfirmationNoButton;

        public NotificationPage(IApp app, Platform platform) : base(app, platform)
        {
			if (OnAndroid)
			{
				//AllowButton = x => x.Marked("Allow");
				//DontAllowButton = x => x.Marked("Don't Allow");
				//dialogNotificationConfirmationYesButton = x => x.Marked("Allow");
				//dialogNotificationConfirmationNoButton = x => x.Marked("Don't Allow");
			}

			if (OniOS)
			{
                AllowButton = x => x.Marked("Allow");
                DontAllowButton = x => x.Marked("Don't Allow");
                dialogNotificationConfirmationYesButton = x => x.Marked("Allow");
                dialogNotificationConfirmationNoButton = x => x.Marked("Don't Allow");

			}
        }

        public void TapOnAllowNotifications()
        {
            App.Tap(AllowButton);
            App.Screenshot("'Tapped' on the 'Allow Notification' Button");
        }


		public void TapOnDontAllowNotifications()
		{
            App.Tap(DontAllowButton);
			App.Screenshot("'Tapped' on the 'Don't Allow Notification' Button");
		}

    }
}
