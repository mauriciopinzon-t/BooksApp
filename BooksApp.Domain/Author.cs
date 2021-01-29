﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BooksApp.Domain
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Publisher 
    {
        public int Id {get; set;}
        public string PublisherName { get; set;}
    }
}
