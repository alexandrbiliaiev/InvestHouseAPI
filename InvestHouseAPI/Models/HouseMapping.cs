using System;
using System.Collections.Generic;

namespace InvestHouseAPI.Models
{
    public partial class HouseMapping
    {
        public int Id { get; set; }
        public int? SiteId { get; set; }
        public bool? IsOneImage { get; set; }
        public string Link { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
