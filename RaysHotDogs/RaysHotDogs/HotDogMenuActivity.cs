using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using RaysHotDogs.Core.Model;
using RaysHotDogs.Core.Service;

namespace RaysHotDogs
{
    [Activity(Label = "HotDogMenuActivity", MainLauncher = true)]
    public class HotDogMenuActivity : Activity
    {
        //create the name of our list view
        private ListView hotDogListView;

        //list of Hotdogs, "all hotdogs"
        private List<HotDog> allHotDogs;

        //data service, to get all avaliable hotdogs
        private HotDogDataService hotDogDataService;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.HotDogMenuView);

            //set the list view
            hotDogListView = FindViewById<ListView>(Resource.Id.hotDogListView);

            //instatiate the hotdogdataservice
            hotDogDataService = new HotDogDataService();

            //get all htodogs
            allHotDogs = hotDogDataService.GetAllHotDogs();

        }
    }
}