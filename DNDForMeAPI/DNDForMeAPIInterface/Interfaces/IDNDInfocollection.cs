using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DNDForMeAPIInterface.DTO;


namespace DNDForMeAPIInterface.Interfaces
{
    public interface IDNDInfocollection
    {
        public List<DNDInfoDTO> GetAllDNDInfos();
        public DNDInfoDTO GetDNDInfo(int id);
        public void CreateDNDInfo(DNDInfoDTO dNDInfo, int UserId);
        public void DeleteDNDInfo(DNDInfoDTO dNDInfoDTO);
        public List<DNDInfoDTO> GetDNDIfnoData();
    }
}
