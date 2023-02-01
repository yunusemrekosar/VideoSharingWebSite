﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSite.Application.ViewModels
{
    public class RequestCategory
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public string? CategoryDescription { get; set; }
    }
}
