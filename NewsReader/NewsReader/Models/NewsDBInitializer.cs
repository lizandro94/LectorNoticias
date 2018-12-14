using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NewsReader.Models
{
    public class NewsDBInitializer : DropCreateDatabaseAlways<NewsModel>
    {
        protected override void Seed(NewsModel context)
        {
            IList<News> News = new List<News>();

            News.Add(new News()
            {
                PublicationDate = new DateTime(2018, 7, 5),
                Title = "Are scooters safe?",
                Content = "<p>AUSTIN, Texas – Narrow, motorized scooters whisking riders around " +
                "cities like Austin and Los Angeles are meant to alleviate traffic congestion, " +
                "encourage public transit and offer a cheap transportation alternative.</p>",
                Image = "https://www.gannett-cdn.com/-mm-/41f3aff081bb0539451f84a2519091e9cf1d256c/c=16-0-563-410/local/-/media/2018/11/08/USATODAY/usatsports/ford-acquires-spin-110818-1_large.jpg?width=534&height=401&fit=crop"
            });

            News.Add(new News()
            {
                PublicationDate = new DateTime(2018, 8, 10),
                Title = "Fatal collision involving billionaire's yacht under investigation",
                Content = "GREAT FALLS, Mont. – The U.S. Coast Guard is investigating a fatal" +
                " collision that occurred in late October between a 332-foot yacht owned by Montana" +
                " billionaire Dennis Washington and a 65-foot fishing boat that resulted in the death" +
                " of a man and an injury to another.",
                Image = "https://www.gannett-cdn.com/presto/2018/12/13/PGRF/c00fcc53-3374-48df-a42a-d09942449896-1000w_q95.jpg?width=534&height=401&fit=bounds&auto=webp"
            });

            News.Add(new News()
            {
                PublicationDate = DateTime.Now,
                Title = "First News",
                Content = "",
                Image = ""
            });

            News.Add(new News()
            {
                PublicationDate = DateTime.Now,
                Title = "First News",
                Content = "",
                Image = ""
            });

            News.Add(new News()
            {
                PublicationDate = DateTime.Now,
                Title = "First News",
                Content = "",
                Image = ""
            });

            News.Add(new News()
            {
                PublicationDate = DateTime.Now,
                Title = "First News",
                Content = "",
                Image = ""
            });

            News.Add(new News()
            {
                PublicationDate = DateTime.Now,
                Title = "First News",
                Content = "",
                Image = ""
            });

            News.Add(new News()
            {
                PublicationDate = DateTime.Now,
                Title = "First News",
                Content = "",
                Image = ""
            });

            News.Add(new News()
            {
                PublicationDate = DateTime.Now,
                Title = "First News",
                Content = "",
                Image = ""
            });

            News.Add(new News()
            {
                PublicationDate = DateTime.Now,
                Title = "First News",
                Content = "",
                Image = ""
            });

            context.News.AddRange(News);

            base.Seed(context);
        }
    }
}