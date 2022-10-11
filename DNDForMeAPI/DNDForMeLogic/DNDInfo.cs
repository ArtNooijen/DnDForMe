using DNDForMeAPIInterface;
using DNDForMeAPIInterface.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDForMeLogic
{
    public class DNDInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }

        public int UserId { get; set; }

        public DNDInfo(DNDInfoDTO dNDInfoDTO)
        {
            Id = dNDInfoDTO.Id;
            Name = dNDInfoDTO.Name;
            Description = dNDInfoDTO.Description;
            Note = dNDInfoDTO.Note;            
        }
        public DNDInfo()
        {

        }
    }
}
