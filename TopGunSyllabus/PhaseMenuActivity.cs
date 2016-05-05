using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;
using TopGunSyllabus.Android.Adapters;
using TopGunSyllabus.Core.Model;
using TopGunSyllabus.Core.Service;

namespace TopGunSyllabus.Android
{
    [Activity(Label = "Top Gun Syllabus",MainLauncher = true)]
    public class PhaseMenuActivity : Activity
    {
        private ListView phaseListView;
        private List<Phase> allPhases;
        private PhaseDataService phaseDataService; 

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PhasesMenuView);
            phaseListView = FindViewById<ListView>(Resource.Id.PhasesListView);
            phaseDataService = new PhaseDataService();
            allPhases = phaseDataService.GetAllPhases();
            phaseListView.Adapter = new PhaseListAdapter(this,allPhases);
            phaseListView.ItemClick += OnListItemClick;
        }

        void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var listView = sender as ListView;
            var clickedRow = e.Position;
                                         
            switch (clickedRow)
            {
                case 0:
                    StartActivity(typeof(Phase0));
                    break;
                case 1:
                    StartActivity(typeof(Phase1));
                    break;
                case 2:
                    StartActivity(typeof(Phase2));
                    break;
                case 3:
                    StartActivity(typeof(Phase3));
                    break;
                case 4:
                    StartActivity(typeof(Phase4));
                    break;
                default:
                    StartActivity(typeof(PhaseMenuActivity));
                    break;
            }
        }
    }
}