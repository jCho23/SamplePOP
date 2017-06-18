using System;
using System.Linq;

using Xamarin.UITest;
using Xamarin.UITest.Queries;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace SamplePOP
{
    public class NotificationPage : BasePage
    {
		readonly Query Allow;
		readonly Query DontAllow;

        public NotificationPage(IApp app, Platform platform) : base(app, platform)
        {
        }
    }
}
