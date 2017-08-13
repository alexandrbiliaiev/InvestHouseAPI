using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InvestHouseAPI.Models;
using InvestHouseAPI.DTO;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace InvestHouseAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/investments")]
    public class InvestmentsController : Controller
    {

        private readonly IHostingEnvironment _env;

        public InvestmentsController(IHostingEnvironment env)
        {
            _env = env;
        }



        public DB_A29536_investHouseContext context = new DB_A29536_investHouseContext();

        [HttpGet]
        [Route("get")]
        public List<InvestmentDTO> GetInvestments()
        {
            List<InvestmentDTO> investments = context.Investments.ToList().Select(i => new InvestmentDTO(i)).ToList();
            return investments;
        }

        [HttpGet]
        [Route("get/{id}")]
        public InvestmentDTO GetInvestment([FromRoute]int id)
        {
            InvestmentDTO investment = context.Investments.Where(i => i.Id == id).ToList().Select(i => new InvestmentDTO(i)).FirstOrDefault();
            return investment;
        }

        [HttpPost]
        [Route("save")]
        public InvestmentDTO SaveInvestment([FromBody] InvestmentDTO inv)
        {
            Investments investment;
            if (inv.Id != 0)
            {
                investment = context.Investments.FirstOrDefault(c => c.Id == inv.Id);
            }
            else
            {
                investment = new Investments();
                context.Investments.Add(investment);
            }

            if (investment == null)
            {
                return null;
            }

            investment.Name = inv.Name;
            investment.NameUa = inv.NameUa;
            investment.Description = inv.Description;
            investment.DescriptionUa = inv.DescriptionUa;
            investment.Done = inv.Done;
            investment.Logo = inv.Logo;
            investment.Link = inv.Link;


            context.SaveChanges();
            inv.Id = investment.Id;
            return inv;
        }

        [HttpGet]
        [Route("remove/{id}")]
        public bool RemoveInvestment([FromRoute] int id)
        {
            try
            {
                var investment = context.Investments.Where(i => i.Id == id).FirstOrDefault();
                context.Investments.Remove(investment);
                context.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
           
        }

        [HttpPost]
        [Route("addLogo")]
        public FileResp UploadFiles(IFormFile file)
        {
            try
            {
                if (file == null)
                {
                    FileResp aa = new FileResp();

                    return aa ;
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
                .Trim('"');

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