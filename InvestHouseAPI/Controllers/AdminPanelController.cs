using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InvestHouseAPI.Models;
using InvestHouseAPI.DTO;
using Microsoft.AspNetCore.Cors;

namespace InvestHouseAPI.Controllers
{

    public class AdminPanelController : Controller
    {

        public DB_A26102_investHouseContext context = new DB_A26102_investHouseContext();

        [HttpPost]
        [Route("api/admin/site/get")]
        public IEnumerable<SitesDTO> getSites([FromBody] SitesDTO site)
        {
            using (context)
            {
                List<SitesDTO> sites = context.Sites.Where(s => s.Id == site.Id).ToList().Select(s => new SitesDTO(s)).ToList();

                return sites;
            }
        }


        [HttpPost]
        [Route("/api/admin/sites/save")]
        public SitesDTO SaveSite([FromBody] SitesDTO site)
        {
            using (context)
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
            using (context)
            {
                Sites siteToRemove = context.Sites.Where(s => s.Id == site.Id).FirstOrDefault();

                context.Remove(siteToRemove);

                context.SaveChanges();

                return true;
            }
        }


        [HttpPost]
        [Route("api/admin/content/get")]
        public IEnumerable<ContentDTO> getContent([FromBody] SitesDTO site)
        {
            using (context)
            {
                List<ContentDTO> contentList = context.Content.Where(i => i.SiteId == site.Id).ToList().Select(c => new ContentDTO(c)).ToList();

                return contentList;
            }
        }



    }
}