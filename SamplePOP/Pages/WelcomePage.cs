using System;
using System.Linq;

using Xamarin.UITest;
using Xamarin.UITest.Queries;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace SamplePOP
{
    public class WelcomePage : BasePage
    {
        readonly Query getStartedBtn;

        public WelcomePage(IApp app, Platform platform) : base(app, platform)
        {
            if (OnAndroid)
            {
                
            }

            if (OniOS)
            {
               getStartedBtn = x => x.Marked("Get Started"); 
            }
           
		}

        public void TapGetStartedButton(string text)
        {
            App.ClearText();
            App.Tap(getStartedBtn);
            App.Screenshot("Tapped the 'Get Started' Button");
        }
    }
}
