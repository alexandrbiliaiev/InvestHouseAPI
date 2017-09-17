using System;
using System.Collections.Generic;

namespace InvestHouseAPI.Models
{
    public partial class Houses
    {
        public int Id { get; set; }
        public int? SiteId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Number { get; set; }
        public string MarkerNumber { get; set; }
        public string TotalPrice { get; set; }
        public string HousePrice { get; set; }
        public string HouseSqaure { get; set; }
        public string AreaPrice { get; set; }
        public string AreaSquare { get; set; }
        public int? Status { get; set; }
    }
}
