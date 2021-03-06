﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NewsReader.BusinessLayer;
using NewsReader.Models;

namespace NewsReader.Controllers
{
    public class NewsController : ApiController
    {
        private readonly News_BL news;

        public NewsController()
        {
            news = new News_BL();
        }

        //get 3 random news
        public IEnumerable<News> GetAllNews()
        {
            return news.GetImportantNews();
        }

        //filter news by date and title
        public IEnumerable<News> PostFilteredNews(FilterNewsVM model)
        {
            return news.GetFilteredNews(model);
        }

        //get 5 last news
        public IEnumerable<News> GetLastNews()
        {
            return news.GetLastNews();
        }
    }
}
