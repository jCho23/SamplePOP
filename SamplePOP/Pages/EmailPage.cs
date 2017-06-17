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
        }
    }
}
