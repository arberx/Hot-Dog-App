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

namespace RaysHotDogs.Adapters
{
    public class HotDogListAdapter:BaseAdapter<HotDog>
    {
        List<HotDog> items;
        Activity context;

        //constructor
        public HotDogListAdapter(Activity context, List<HotDog>items):base()
        {
            this.context = context;
            this.items = items;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        //indexor
    }
}