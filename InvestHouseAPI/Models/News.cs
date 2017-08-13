using System;
using System.Collections.Generic;

namespace InvestHouseAPI.Models
{
    public partial class News
    {
        public int Id { get; set; }
        public int? SiteId { get; set; }
        public string Title { get; set; }
        public string TitleUa { get; set; }
        public string Text { get; set; }
        public string TextUa { get; set; }
        public string Image { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
