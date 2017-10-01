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
        public string IntroLeadIn { get; set; }
        public string IntroLeadInColor { get; set; }
        public string IntroLeadInFont { get; set; }
        public string IntroHeading { get; set; }
        public string IntroHeadingColor { get; set; }
        public string IntroHeadingFont { get; set; }
        public string IntroButtonText { get; set; }
        public string IntroButtonColor { get; set; }
        public string IntroButtonFontColor { get; set; }
        public string IntroButtonBgColor { get; set; }
        public string IntroButtonTextFont { get; set; }
    }
}
