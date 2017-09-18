using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InvestHouseAPI.Models;
using InvestHouseAPI.DTO;
using System.Net.Http.Headers;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace InvestHouseAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/GeneralSettings")]
    public class GeneralSettingsController : Controller
    {
        private readonly IHostingEnvironment _env;

        public GeneralSettingsController(IHostingEnvironment env)
        {
            _env = env;
        }

        public DB_A29536_investHouseContext context = new DB_A29536_investHouseContext();

        [HttpPost]
        [Route("get")]
        public GeneralSettingsDTO GetSettings ()
        {
            GeneralSettingsDTO settings = context.GeneralSettings.ToList().Select(s => new GeneralSettingsDTO(s)).FirstOrDefault();

            return settings;

        }

        [HttpPost]
        [Route("save")]
        public GeneralSettingsDTO SaveSettings ([FromBody] GeneralSettingsDTO settings)
        {
            GeneralSettings setting;
            if (settings.Id != 0)
            {
                setting = context.GeneralSettings.FirstOrDefault(s => s.Id == settings.Id);
            }
            else
            {
                setting = new GeneralSettings();
                context.GeneralSettings.Add(setting);
            }

            if (setting == null)
            {
                return null;
            }

            setting.Address = settings.Address;
            setting.BackgroundImage = settings.BackgroundImage;
            setting.Phones = settings.Phones;
            setting.Fax = settings.Fax;
            setting.Email = settings.Email;
            setting.Skype = settings.Skype;


            context.SaveChanges();
            settings.Id = setting.Id;

            return settings;
        }

        [HttpPost]
        [Route("addBackgroundImage")]
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
                .FileName.ToString()
                .Replace("\"", "");


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