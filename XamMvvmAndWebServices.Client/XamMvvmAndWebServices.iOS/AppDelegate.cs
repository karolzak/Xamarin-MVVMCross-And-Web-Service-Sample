﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using MvvmCross.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;

namespace XamMvvmAndWebServices.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxApplicationDelegate
    {
        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Window = new UIWindow(UIScreen.MainScreen.Bounds);

#if ENABLE_TEST_CLOUD
Xamarin.Calabash.Start();
#endif

            var setup = new Setup(this, Window);
            setup.Initialize();

            var startup = Mvx.Resolve<IMvxAppStart>();
            startup.Start();

            Window.MakeKeyAndVisible();

            return true;
        }
    }
}
