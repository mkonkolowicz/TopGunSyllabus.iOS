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
		UIImageView Banner { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView PhaseDetails { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView PhaseSummary { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel TopGunSyllabusLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (Banner != null) {
				Banner.Dispose ();
				Banner = null;
			}
			if (PhaseDetails != null) {
				PhaseDetails.Dispose ();
				PhaseDetails = null;
			}
			if (PhaseSummary != null) {
				PhaseSummary.Dispose ();
				PhaseSummary = null;
			}
			if (TopGunSyllabusLabel != null) {
				TopGunSyllabusLabel.Dispose ();
				TopGunSyllabusLabel = null;
			}
		}
	}
}
