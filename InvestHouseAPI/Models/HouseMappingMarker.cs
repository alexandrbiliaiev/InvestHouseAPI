using System;
using System.Collections.Generic;

namespace InvestHouseAPI.Models
{
    public partial class HouseMappingMarker
    {
        public int Id { get; set; }
        public int? MapId { get; set; }
        public int? HouseId { get; set; }
        public string ImageLink { get; set; }
        public int? XMarker { get; set; }
        public int? YMarker { get; set; }
    }
}
