﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace Page.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

			LoadApplication(new App(path));

			return base.FinishedLaunching(app, options);
		}
	}
}
