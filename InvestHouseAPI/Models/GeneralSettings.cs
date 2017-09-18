using System;
using System.Collections.Generic;

namespace InvestHouseAPI.Models
{
    public partial class GeneralSettings
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Phones { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }
        public string BackgroundImage { get; set; }
    }
}
