using ArticlesMobile.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticlesMobile.Models

{
    public class Article
    {

        Generals generals;

        public Article()
        {
            generals = new Generals();  
        }

        public string _Id { get; set; }

        public DateTime date { get; set; }

        public string title { get; set; }

        public string content { get; set; }

        public string image { get; set; }

        public string urlimage {
            get
            {
                string[] p = { "UrlImage", this._Id.ToString() };
                return this.generals.UrlImage( p );
            }
            set
            {
                urlimage = value;
            }
        }

    }
}
