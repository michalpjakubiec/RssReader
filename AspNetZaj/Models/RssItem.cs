using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetZaj.Models
{
    public class RssItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PubDate { get; set; }
        public string Category { get; set; }
        public string Url { get; set; }
    }
}