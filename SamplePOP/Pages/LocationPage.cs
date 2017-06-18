using System;
using System.Linq;

using Xamarin.UITest;
using Xamarin.UITest.Queries;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace SamplePOP
{
    public class LocationPage : BasePage
    {
        readonly Query notSureButton;
        readonly Query continueButton;

        public LocationPage(IApp app, Platform platform) : base(app, platform)
        {
			if (OnAndroid)
			{

			}

			if (OniOS)
			{
                notSureButton = x => x.Marked("Not Sure");
                continueButton = x => x.Marked("Continue");
			}

        }

        public void TapOnContinueLocation()
        {
            App.Tap(continueButton);
            App.Screenshot("Tapped on 'Continue Location' Button");
        }

		public void TapOnNotSureLocation()
		{
            App.Tap(notSureButton);
			App.Screenshot("Tapped on 'Continue Location' Button");
		}

    }
}
