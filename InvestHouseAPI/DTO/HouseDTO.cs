using InvestHouseAPI.Dto;
using InvestHouseAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestHouseAPI.DTO
{
    public class HouseDTO : RelationSubject
    {

        public int? SiteId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Number { get; set; }
        public string MarkerNumber { get; set; }
        public string TotalPrice { get; set; }
        public string HousePrice { get; set; }
        public string HouseSqaure { get; set; }
        public string AreaPrice { get; set; }
        public string AreaSquare { get; set; }
        public int? Status { get; set; }

        public HouseDTO()
        {

        }

        public HouseDTO(Houses house)
        {
            Id = house.Id;
            SiteId = house.SiteId;
            Name = house.Name;
            Description = house.Description;
            Number = house.Number;
            MarkerNumber = house.MarkerNumber;
            TotalPrice = house.TotalPrice;
            HousePrice = house.HousePrice;
            HouseSqaure = house.HouseSqaure;
            AreaPrice = house.AreaPrice;
            AreaSquare = house.AreaSquare;
            Status = house.Status;

        }
    }
}
