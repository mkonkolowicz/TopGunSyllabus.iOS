// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TopGunSyllabus.iPhone
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel TopGunBanner { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView TopGunBannerView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (TopGunBanner != null) {
				TopGunBanner.Dispose ();
				TopGunBanner = null;
			}
			if (TopGunBannerView != null) {
				TopGunBannerView.Dispose ();
				TopGunBannerView = null;
			}
		}
	}
}
