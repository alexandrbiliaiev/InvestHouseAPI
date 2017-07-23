using System;
using System.Collections.Generic;

namespace InvestHouseAPI.Models
{
    public partial class Investments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameUa { get; set; }
        public string Description { get; set; }
        public string DescriptionUa { get; set; }
        public bool? Done { get; set; }
        public string Logo { get; set; }
    }
}
