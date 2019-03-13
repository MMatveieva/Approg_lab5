﻿using System;
using System.Collections.Generic;
using System.Linq;
using CodeFirstDataAccess;
using CodeFirstModel;
using CodeFirstWebApp.Models;
using System.Web.Mvc;
using System.Data.Entity;

namespace CodeFirstWebApp.Models
{
    public class BookModel
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Edition { get; set; }
        public string Publishing { get; set; }
    }
}