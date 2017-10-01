using InvestHouseAPI.Dto;
using InvestHouseAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestHouseAPI.DTO
{
    public class ContentDTO : RelationSubject
    {
        public string Body { get; set; }
        public DateTime? CreationDate { get; set; }
        public string MenuName { get; set; }
        public int? OrderNumber { get; set; }
        public string Title { get; set; }
        public int? Type { get; set; }
        public int? SiteId { get; set; }

        public ContentDTO()
        {

        }

        public ContentDTO(Content content)
        {

            Body = content.Body;
            CreationDate = content.CreationDate;
            MenuName = content.MenuName;
            OrderNumber = content.OrderNumber;
            Title = content.Title;
            Type = content.Type;
            SiteId = content.SiteId;

        }
    }
}
