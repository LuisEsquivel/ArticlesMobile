using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace ArticlesMobile.Helpers
{
    public  class Generals
    {

        public string Url(string[] urlparams)
        {
            string url = "";

            foreach(string p in urlparams)
            {
                url += Application.Current.Resources[p].ToString(); 
            }

            return url;
        }

        public string Key(string key)
        {
            return Application.Current.Resources[key].ToString();
        }

        public string UrlImage(string[] p)
        {
            return Application.Current.Resources[ p[0].ToString() ] + p[1].ToString() + ".jpg?" + Guid.NewGuid().ToString();
        }

    }
}
