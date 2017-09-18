using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using InvestHouseAPI.Models;
using InvestHouseAPI.DTO;
using Microsoft.Net.Http.Headers;
using System.IO;

namespace InvestHouseAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/news")]
    public class NewsController : Controller
    {
        private readonly IHostingEnvironment _env;

        public NewsController(IHostingEnvironment env)
        {
            _env = env;
        }

        public DB_A29536_investHouseContext context = new DB_A29536_investHouseContext();


        [HttpGet]
        [Route("get/{siteId}")]
        public List<NewsDTO> GetNews([FromRoute]int siteId)
        {
            List<NewsDTO> news = context.News.Where(i => i.SiteId == siteId).ToList().Select(n => new NewsDTO(n)).ToList();
            return news;
        }

        [HttpGet]
        [Route("get/{siteId}/{articleId}")]
        public NewsDTO GetArticle([FromRoute]int siteId, int articleId)
        {
            NewsDTO article = context.News.Where(i => i.SiteId == siteId && i.Id == articleId).ToList().Select(n => new NewsDTO(n)).FirstOrDefault();
            return article;
        }

        [HttpPost]
        [Route("save")]
        public NewsDTO SaveArticle([FromBody] NewsDTO art)
        {
            News article;
            if (art.Id != 0)
            {
                article = context.News.FirstOrDefault(c => c.Id == art.Id);
                article.CreationDate = DateTime.Now;
            }
            else
            {
                article = new News();
                context.News.Add(article);
            }

            if (article == null)
            {
                return null;
            }

            article.SiteId = art.SiteId;
            article.Title = art.Title;
            article.TitleUa = art.TitleUa;
            article.Text = art.Text;
            article.TextUa = art.TextUa;
            article.Image = art.Image;


            context.SaveChanges();
            art.Id = article.Id;
            return art;
        }

        [HttpGet]
        [Route("remove/{id}")]
        public bool removeArticle([FromRoute] int id)
        {
            try
            {
                var article = context.News.Where(i => i.Id == id).FirstOrDefault();
                context.News.Remove(article);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        [HttpPost]
        [Route("addImage")]
        public FileResp UploadFiles(IFormFile file)
        {
            try
            {
                if (file == null)
                {
                    FileResp aa = new FileResp();

                    return aa;
                }

                string fileName = SaveFile(file);

                FileResp ff = new FileResp();

                ff.Name = fileName;

                return ff;

            }
            catch (Exception ex)
            {
                FileResp aa = new FileResp();

                return aa;
            }
        }

        private string SaveFile(IFormFile file)
        {
            string filename = ContentDispositionHeaderValue
       .Parse(file.ContentDisposition)
       .FileName
       .TrimEnd()
       .TrimStart()
       .ToString();

            filename = $"\\files\\{Guid.NewGuid()}\\{filename}".Replace("\\", "/");

            string filePath = _env.WebRootPath + filename;
            string path = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            using (FileStream fs = System.IO.File.Create(filePath))
            {
                file.CopyTo(fs);
                fs.Flush();
            }

            return filename;
        }


    }
}