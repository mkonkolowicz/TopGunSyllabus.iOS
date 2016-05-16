using System;
using System.Collections.Generic;
using System.Text;
using Foundation;
using TopGunSyllabus.Core.Model;
using UIKit;

namespace TopGunSyllabus.iPhone.DataSources
{
    public class PhaseDataSource : UITableViewSource
    {
        private List<Phase> phases;
        protected Phase[] phaseNames;
        NSString cellIdentifier = new NSString("PhaseCell");
        private UITableViewController callingController;

        public PhaseDataSource (List<Phase> phases, UITableViewController callingController )
        {
            this.phases = phases;
            phaseNames = this.phases.ToArray();
            this.callingController = callingController;
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier) as UITableViewCell;

            if(cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
            }

            var phase = phases[indexPath.Row];
            cell.TextLabel.Text = phase.Name;
            
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return phases.Count;
        }

        public Phase GetItem(int id)
        {
            return phases[id];
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            tableView.DeselectRow(indexPath, true);
            callingController.PerformSegue("PhaseDetailSegue",this);
        }

    }
}
