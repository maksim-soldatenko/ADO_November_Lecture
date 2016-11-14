﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Domain
{
    public class Book: Entity
    {
        public string BookName { get; set; }

        public string Annotation { get; set; }

        public Author Author { get; set; }

        private ICollection<Publisher> Publishers { get; set; }
    }
}
