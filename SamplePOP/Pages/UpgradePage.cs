﻿﻿using System;
using System.Linq;

using Xamarin.UITest;
using Xamarin.UITest.Queries;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace SamplePOP
{
    public class UpgradePage : BasePage
    {
        readonly Query notRightNowButton;
        readonly Query upgradeMonthButton;
        readonly Query upgradeYearButton;

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
                upgradeMonthButton = x => x.Marked("XXXXXContinue");
                upgradeYearButton = x => x.Marked("XXXXXXContinue");
			}
        }

        public void TapNotRightNowButton()
        {
            
        }



    }
}
