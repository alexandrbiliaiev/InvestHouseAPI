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
        [Route("api/admin/content/get")]
        public ContentDTO getContent([FromBody] ContentRequestDTO contentRequest)
        {
            using (context)
            {
                ContentDTO content = context.Content.Where(i => i.SiteId == contentRequest.Id && i.Type == contentRequest.ContentType).ToList().Select(c => new ContentDTO(c)).FirstOrDefault();

                return content;
            }
        }

        [HttpPost]
        [Route("/api/admin/content/save")]
        public ContentDTO SaveContent([FromBody] ContentDTO content)
        {
            using (context)
            {
                Content cont;
                if (content.Id != 0)
                {
                    cont = context.Content.FirstOrDefault(c => c.Id == content.Id);
                }
                else
                {
                    cont = new Content();
                    context.Content.Add(cont);
                    cont.CreationDate = DateTime.Now;
                }

                if (cont == null)
                {
                    return null;
                }

                cont.MenuName = content.MenuName;
                cont.MenuNameUa = content.MenuNameUA;
                cont.Title = content.Title;
                cont.TitleUa = content.TitleUA;
                cont.OrderNumber = content.OrderNumber;
                cont.SiteId = content.SiteId;
                cont.Type = 0;
                cont.Body = content.Body;
                cont.BodyUa = content.BodyUA;
                

                context.SaveChanges();
                content.Id = cont.Id;
                return content;
            }
        }




    }
}