using NUnit.Framework;

using Xamarin.UITest;
using SamplePOP;

namespace SamplePOP
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]

	public abstract class BaseTest
	{
		protected IApp App;
		protected Platform Platform;

        protected WelcomePage WelcomePage;
        protected EmailPage EmailPage;
        protected LoginPage LoginPage;


		protected BaseTest(Platform platform) => Platform = platform;

		[SetUp]
		virtual public void BeforeEachTest()
		{
			App = AppInitializer.StartApp(Platform);
			App.Screenshot("App Initialized");

            WelcomePage = new WelcomePage(App, Platform);
            EmailPage = new EmailPage(App, Platform);
            LoginPage = new LoginPage(App, Platform);
		}
	}
}

