﻿using System;
using System.Linq;

using Xamarin.UITest;
using Xamarin.UITest.Queries;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace SamplePOP
{
    public class LocationPage : BasePage
    {



        public LocationPage(IApp app, Platform platform) : base(app, platform)
        {
        }
    }
}
