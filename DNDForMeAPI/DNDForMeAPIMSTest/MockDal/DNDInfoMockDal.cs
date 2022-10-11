using DNDForMeAPIInterface.DTO;
using DNDForMeAPIInterface.Interfaces;
using DNDForMeLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDForMeAPIMSTest.MockDal
{
    public class DNDInfoMockDal : IDNDInfocollection
    {
        public List<DNDInfoDTO> GetAllDNDInfos()
        {
            List<DNDInfoDTO> dNDInfoDTOs = new();
            dNDInfoDTOs.Add(new DNDInfoDTO() { Id = 1, Name = "Test1", Description = "Test1", Note = "note test1" });
            dNDInfoDTOs.Add(new DNDInfoDTO() { Id = 2, Name = "Test2", Description = "test2", Note = "note test2" });
            return dNDInfoDTOs;
        }

        public DNDInfoDTO GetDNDInfo(int Id)
        {
            DNDInfoDTO dNDInfoDTO = new() { Id = 2, Name = "Test2", Description = "test2", Note = "note test2" };
            return dNDInfoDTO;
        }

        public void UpdateDNDInfo(DNDInfoDTO dNDInfoDTO)
        {
        }

        public void CreateDNDInfo(DNDInfoDTO dNDInfoDTO, int UserId)
        {
        }

        public void DeleteDNDInfo(DNDInfoDTO dNDInfoDTO)
        {
        }

        public List<DNDInfoDTO> GetDNDIfnoData()
        {
            List<DNDInfoDTO> dNDInfoDTOs = new();
            dNDInfoDTOs.Add(new DNDInfoDTO() { Id = 1, Name = "Test1" });
            dNDInfoDTOs.Add(new DNDInfoDTO() { Id = 2, Name = "Test2" });
            return dNDInfoDTOs;
        }
    }
}

