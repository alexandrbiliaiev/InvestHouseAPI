using InvestHouseAPI.Dto;
using InvestHouseAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestHouseAPI.DTO
{
    public class NewsDTO : RelationSubject
    {
        public int? SiteId { get; set; }
        public string Title { get; set; }
        public string TitleUa { get; set; }
        public string Text { get; set; }
        public string TextUa { get; set; }
        public string Image { get; set; }
        public DateTime? CreationDate { get; set; }

        public NewsDTO()
        {
        }

        public NewsDTO(News news)
        {
            Id = news.Id;
            SiteId = news.SiteId;
            Title = news.Title;
            TitleUa = news.TitleUa;
            Text = news.Text;
            TextUa = news.TextUa;
            Image = news.Image;
            CreationDate = news.CreationDate;
        }
    }
}
