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

    }
    }
}
