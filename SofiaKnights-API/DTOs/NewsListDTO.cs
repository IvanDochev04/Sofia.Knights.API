﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.DTOs
{
    public class NewsListDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string Date { get; set; }

        public string PictureUrl { get; set; }
    }
}
