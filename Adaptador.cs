using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalariosApp
{
    internal class Adaptador : BaseAdapter
    {

        Activity context;
        List<Empleado> empleadoList;    

        public Adaptador(Activity context, List<Empleado> lista)
        {
            this.context = context;
            this.empleadoList = new List<Empleado>();  
        }

        public override int Count => empleadoList.Count;


        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = empleadoList[position];
            
            View view = convertView;

            if (view == null)
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2, null);

            return view;
        }

    }

    internal class AdaptadorViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        //public TextView Title { get; set; }
    }
}