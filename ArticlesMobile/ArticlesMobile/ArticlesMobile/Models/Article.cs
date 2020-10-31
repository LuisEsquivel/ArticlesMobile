using System;
using System.Collections.Generic;
using System.Text;

namespace ArticlesMobile.Models
{
    public class Article
    {

        public int _Id { get; set; }

        public DateTime date { get; set; }

        public string title { get; set; }

        public string content { get; set; }

        public string image { get; set; }

    }
}
