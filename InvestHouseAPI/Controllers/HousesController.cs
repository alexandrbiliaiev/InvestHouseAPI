using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InvestHouseAPI.Models;
using InvestHouseAPI.DTO;

namespace InvestHouseAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Houses")]
    public class HousesController : Controller
    {

        public DB_A29536_investHouseContext context = new DB_A29536_investHouseContext();

        [HttpGet]
        [Route("get/{siteId}/{id}")]
        public HouseDTO GetHouse([FromRoute]int id)
        {
            HouseDTO house = context.Houses.Where(h => h.Id == id).ToList().Select(h => new HouseDTO(h)).FirstOrDefault();
            return house;
        }

        [HttpGet]
        [Route("get/{siteId}")]
        public List<HouseDTO> GetHouses ([FromHeader]int siteId)
        {
            List<HouseDTO> houses = context.Houses.Where(h => h.SiteId == siteId).ToList().Select(h => new HouseDTO(h)).ToList();
            return houses;
        }

       

        [HttpPost]
        [Route("save")]
        public HouseDTO SaveHouse([FromBody] HouseDTO h)
        {
            Houses house;
            if (h.Id != 0)
            {
                house = context.Houses.FirstOrDefault(c => c.Id == h.Id);
            }
            else
            {
                house = new Houses();
                context.Houses.Add(house);
            }

            if (house == null)
            {
                return null;
            }


            house.SiteId = h.SiteId;
            house.Name = h.Name;
            house.Description = h.Description;
            house.Number = h.Number;
            house.MarkerNumber = h.MarkerNumber;
            house.TotalPrice = h.TotalPrice;
            house.HousePrice = h.HousePrice;
            house.HouseSqaure = h.HouseSqaure;
            house.AreaPrice = h.AreaPrice;
            house.AreaSquare = h.AreaSquare;
            house.Status = h.Status;

            context.SaveChanges();
            h.Id = house.Id;

            return h;
        }

        [HttpGet]
        [Route("remove/{id}")]
        public bool RemoveHouse([FromRoute] int id)
        {
            try
            {
                var house = context.Houses.Where(i => i.Id == id).FirstOrDefault();
                context.Houses.Remove(house);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }





    }
}