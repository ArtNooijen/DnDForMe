using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDForMeAPIInterface.DTO
{
    public class DNDInfoDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }

        public DNDInfoDTO()
        {

        }
    }
}
