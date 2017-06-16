using System;
using System.Linq;

using Xamarin.UITest;
using Xamarin.UITest.Queries;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace SamplePOP
{
    public class WelcomePage : BasePage
    {
		readonly Query backButton;
		readonly Query locationAlertContinueBtn;
		readonly Query notificationsAllowBtn;

        public WelcomePage(IApp app, Platform platform) : base(app, platform)
        {
        }




		public void GetStartedButton(string text)
		{

		}
    }
}
