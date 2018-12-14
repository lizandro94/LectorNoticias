﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using NewsReader.Models;

namespace NewsReader.BusinessLayer
{
    public class News_BL
    {
        private readonly NewsModel db;

        public News_BL()
        {
            db = new NewsModel();
        }

        public IEnumerable<News> GetImportantNews()
        {
            var news = db.News.ToList();
            int Count = news.Count();
            var rng = new Random();
            var values = Enumerable.Range(0, Count).OrderBy(x => rng.Next()).ToArray();

            var ImportantNews = news.Where((element, index) => values.Take(3).Contains(index));
            return ImportantNews;
        }

        public IEnumerable<News> GetFilteredNews(FilterNewsVM filter)
        {
            var ImportantNews = db.News.Where(elem => 
                                    elem.Title == filter.Title 
                                    && elem.PublicationDate > filter.StartDate
                                    && elem.PublicationDate < filter.EndDate);
            return ImportantNews;
        }
    }

    public class FilterNewsVM
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
    }
}