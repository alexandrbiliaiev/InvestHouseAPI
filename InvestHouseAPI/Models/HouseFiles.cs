using System;
using System.Collections.Generic;

namespace InvestHouseAPI.Models
{
    public partial class HouseFiles
    {
        public int Id { get; set; }
        public int? SiteId { get; set; }
        public int? HouseId { get; set; }
        public string Link { get; set; }
        public bool? Preview { get; set; }
    }
}
