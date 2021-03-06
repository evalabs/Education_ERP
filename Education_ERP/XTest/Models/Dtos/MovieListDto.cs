﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XTest.Models.Dtos
{
    public class MovieListDto
    {
        public int PagesCount { get; set; }
        public int CurrentPage { get; set; }
        public List<Movie> Items { get; set; }
    }
}