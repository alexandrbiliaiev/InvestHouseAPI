using InvestHouseAPI.Dto;
using InvestHouseAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestHouseAPI.DTO
{
    public class GeneralSettingsDTO : RelationSubject
    {
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

        public GeneralSettingsDTO()
        {

        }

        public GeneralSettingsDTO(GeneralSettings settings)
        {
            Address = settings.Address;
            Phones = settings.Phones;
            Fax = settings.Fax;
            Email = settings.Email;
            Skype = settings.Skype;
            BackgroundImage = settings.BackgroundImage;
            IntroLeadIn = settings.IntroLeadIn;
            IntroLeadInColor = settings.IntroLeadInColor;
            IntroLeadInFont = settings.IntroLeadInFont;
            IntroHeading = settings.IntroHeading;
            IntroHeadingColor = settings.IntroHeadingColor;
            IntroHeadingFont = settings.IntroHeadingFont;
            IntroButtonText = settings.IntroButtonText;
            IntroButtonColor = settings.IntroButtonColor;
            IntroButtonFontColor = settings.IntroButtonFontColor;
            IntroButtonBgColor = settings.IntroButtonBgColor;
            IntroButtonTextFont = settings.IntroButtonTextFont;

    }
    }
}
