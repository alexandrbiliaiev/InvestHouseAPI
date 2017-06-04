using System;
using System.Collections.Generic;

namespace InvestHouseAPI.Models
{
    public partial class Sites
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
    }
}
