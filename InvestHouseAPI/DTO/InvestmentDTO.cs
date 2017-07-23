using InvestHouseAPI.Dto;
using InvestHouseAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestHouseAPI.DTO
{
    public class InvestmentDTO : RelationSubject
    {
        public string Name { get; set; }
        public string NameUa { get; set; }
        public string Description { get; set; }
        public string DescriptionUa { get; set; }
        public bool? Done { get; set; }
        public string Logo { get; set; }

        public InvestmentDTO()
        {
        }

        public InvestmentDTO(Investments investment)
        {
            Id = investment.Id;
            Name = investment.Name;
            NameUa = investment.NameUa;
            Description = investment.Description;
            DescriptionUa = investment.DescriptionUa;
            Done = investment.Done;
            Logo = investment.Logo;
        }


    }
}
