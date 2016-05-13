using Foundation;
using System;
using System.CodeDom.Compiler;
using TopGunSyllabus.Core.Model;
using TopGunSyllabus.Core.Service;
using TopGunSyllabus.iPhone.DataSources;
using UIKit;

namespace TopGunSyllabus.iPhone
{
	partial class PhaseTableViewController : UITableViewController
	{
        PhaseDataService dataService = new PhaseDataService();

        public PhaseTableViewController (IntPtr handle) : base (handle)
		{
		}

	    public override void ViewDidLoad()
	    {
	        var phases = dataService.GetAllPhases();
            var dataSource = new PhaseDataSource(phases,this);

            TableView.Source = dataSource;
	        this.NavigationItem.Title = "Top Gun Phases";
	    }

	    public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
	    {
	        base.PrepareForSegue(segue, sender);

	        if(segue.Identifier == "PhaseDetailSegue")
	        {
	            var phaseDetailViewController = segue.DestinationViewController as PhaseDetailViewController;
	            if(phaseDetailViewController != null)
	            {
	                var source = TableView.Source as PhaseDataSource;
	                var rowPath = TableView.IndexPathForSelectedRow;
	                var item = source.GetItem(rowPath.Row);
                    phaseDetailViewController.SelectedPhase = item;
	            }
	        }
	    }
        
    }
}
