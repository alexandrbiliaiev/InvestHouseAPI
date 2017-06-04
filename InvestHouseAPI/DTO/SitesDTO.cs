using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvestHouseAPI.Models;
using InvestHouseAPI.Dto;

namespace InvestHouseAPI.DTO
{
    public class SitesDTO : RelationSubject
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }

        public SitesDTO()
        {
        }

        public SitesDTO(Sites site)
        {
            Id = site.Id;
            Title = site.Title;
            Url = site.Url;
            Description = site.Description;
        }

    }
}
