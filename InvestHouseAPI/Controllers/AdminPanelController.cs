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
    public class AdminPanelController : Controller
    {
        [HttpGet]
        [Route("api/admin/sites/get")]
        public IEnumerable<SitesDTO> getSites()
        {
            using (investHouseContext context = new investHouseContext())
            {
                List<SitesDTO> sites = context.Sites.ToList().Select(s => new SitesDTO(s)).ToList();

                return sites;
            }
        }


        [HttpPost]
        [Route("/api/admin/sites/save")]
        public SitesDTO SaveSite([FromBody] SitesDTO site)
        {
            using (investHouseContext context = new investHouseContext())
            {
                Sites st;
                if (site.Id != 0)
                {
                    st = context.Sites.FirstOrDefault(c => c.Id == site.Id);
                }
                else
                {
                    st = new Sites();
                    context.Sites.Add(st);
                }

                if (st == null)
                {
                    return null;
                }

                st.Url = site.Url;
                st.Title = site.Title;
                st.Description = site.Description;

                context.SaveChanges();
                site.Id = st.Id;
                return site;
            }
        }

        [HttpPost]
        [Route("/api/admin/sites/delete")]
        public bool deleteSite([FromBody] SitesDTO site)
        {
            using (investHouseContext context = new investHouseContext())
            {
                Sites siteToRemove = context.Sites.Where(s => s.Id == site.Id).FirstOrDefault();

                context.Remove(siteToRemove);

                context.SaveChanges();

                return true;
            }
        }



    }
}