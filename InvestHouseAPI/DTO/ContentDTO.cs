using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvestHouseAPI.Models;
using InvestHouseAPI.Dto;

namespace InvestHouseAPI.DTO
{
    public class ContentDTO : RelationSubject
    {
        public int? SiteId { get; set; }
        public int? ContentType { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? OrderNumber { get; set; }
        public string MenuName {get; set;}
        public string MenuNameUA { get; set; }
        public string Title { get; set; }
        public string TitleUA { get; set; }
        public string Body { get; set; }
        public string BodyUA { get; set; }
        
        public ContentDTO()
        {


        }

        public ContentDTO(Content content)
        {
            SiteId = content.SiteId;
            ContentType = content.Type;
            CreationDate = content.CreationDate;
            OrderNumber = content.OrderNumber;
            MenuName = content.MenuName;
            Title = content.Title;
            Body = content.Body;
            BodyUA = content.BodyUa;
            MenuNameUA = content.MenuNameUa;
            TitleUA = content.TitleUa;
        }
    
    }
}
