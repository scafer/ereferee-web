﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Teams
{
    public class Team
    {
        public int? TeamId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
    }
}
