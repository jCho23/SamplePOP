﻿﻿using System;
using System.Linq;

using Xamarin.UITest;
using Xamarin.UITest.Queries;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace SamplePOP
{
    public class UpgradePage : BasePage
    {
        readonly Query NotRightNowButton;
        readonly Query UpgradeMonthButton;
        readonly Query UpgradeYearButton;

        public UpgradePage(IApp app, Platform platform) : base(app, platform)
        {
			if (OnAndroid)
			{
				//notSureButton = x => x.Marked("Not Sure");
				//continueButton = x => x.Marked("Continue");
			}

			if (OniOS)
			{
				notRightNowButton = x => x.Marked("Not Sure");
				continueButton = x => x.Marked("Continue");
				
			}
        }
    }
}
