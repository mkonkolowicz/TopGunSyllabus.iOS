using System;
using TopGunSyllabus.Core.Model;
using TopGunSyllabus.Core.Service;
using UIKit;

namespace TopGunSyllabus.iPhone
{
    public partial class PhaseDetailViewController : UIViewController
    {
        public PhaseDetailViewController(IntPtr handle) : base(handle)
        {
            //PhaseDataService phaseDataService = new PhaseDataService();
            //SelectedPhase = phaseDataService.ReturnPhaseById(1);
        }

        public Phase SelectedPhase
        { get; set; }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            DataBindUI();
        }

        private void DataBindUI()
        {
            PhaseSummary.Text = SelectedPhase.Summary;
            PhaseDetails.Text = SelectedPhase.LearningObjectives;
            var banner = new UIImageView {Image = UIImage.FromFile("Images\topgun_teamfortress.png")};
            Banner = banner;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}