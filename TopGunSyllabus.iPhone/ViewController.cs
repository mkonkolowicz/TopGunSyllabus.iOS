using System;
using TopGunSyllabus.Core.Model;
using TopGunSyllabus.Core.Service;
using UIKit;

namespace TopGunSyllabus.iPhone
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
            PhaseDataService phaseDataService = new PhaseDataService();
            SelectedPhase = phaseDataService.ReturnPhaseById(0);
        }

        public Phase SelectedPhase
        { get; set; }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            DataBindUI();
            // Perform any additional setup after loading the view, typically from a nib.
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