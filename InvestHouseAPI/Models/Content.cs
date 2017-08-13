using System;
using System.Collections.Generic;

namespace InvestHouseAPI.Models
{
    public partial class Content
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public DateTime? CreationDate { get; set; }
        public string MenuName { get; set; }
        public int? OrderNumber { get; set; }
        public string Title { get; set; }
        public int? Type { get; set; }
    }
}
