using AspNetZaj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;
using System.Xml.Linq;

namespace AspNetZaj.Controllers
{
    public class DisplayRssController : Controller
    {
        // GET: DisplayRss
        public ActionResult Index(int page = 1, int pageSize = 4)
        {
            XElement rss = XElement.Load("https://news.google.com/news/rss/?ned=pl_pl&gl=PL&hl=pl");

            var q = rss.Descendants("item").Select(n =>
                    new RssItem
                    {
                        Title = n.Element("title").Value,
                        Description = n.Element("description").Value,
                        PubDate = DateTime.Parse(n.Element("pubDate").Value),
                        Category = n.Element("category").Value,
                        Url = n.Element("link").Value,
                    });
            var rssItems = q.ToList()
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            ViewBag.PageSize = (q.ToList().Count() / pageSize);
            ViewBag.Page = (int)page;

            return View("Columns", rssItems);
        }

        [HttpPost]
        public int SetPage(int page)
        {
            return ViewBag.Page = page;
        }
    }

}