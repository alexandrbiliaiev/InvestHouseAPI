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
    [Route("api/Content")]
    public class ContentController : Controller
    {

        public DB_A29536_investHouseContext context = new DB_A29536_investHouseContext();

        [HttpGet]
        [Route("get/{siteId}")]
        public ContentDTO GetAboutUS([FromRoute]int siteId)
        {
            ContentDTO about = context.Content.Where(i => i.SiteId == siteId && i.Type == 1).ToList().Select(n => new ContentDTO(n)).FirstOrDefault();
            return about;
        }

        [HttpPost]
        [Route("save")]
        public ContentDTO SaveArticle([FromBody] ContentDTO art)
        {
            Content article;
            if (art.Id != 0)
            {
                article = context.Content.FirstOrDefault(c => c.Id == art.Id);
            }
            else
            {
                article = new Content();
                context.Content.Add(article);
            }

            if (article == null)
            {
                return null;
            }

            article.SiteId = art.SiteId;
            article.Title = art.Title;
            article.Body = art.Body;
            article.Type = art.Type;


            context.SaveChanges();
            art.Id = article.Id;
            return art;
        }
    }
}