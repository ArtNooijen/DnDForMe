using DNDForMeAPIInterface.DTO;
using DNDForMeAPIInterface.Interfaces;
using DNDForMeFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDForMeLogic
{
    public class DNDInfoCollection
    {
        public List<DNDInfo> dNDInfos = new();
        public List<DNDInfo> SortedDNDInfos = new();
        private readonly IDNDInfocollection dNDInfoCollection1;

        public DNDInfoCollection(IDNDInfocollection dNDInfoCollection)
        {
            dNDInfoCollection1 = dNDInfoCollection;
        }

        public DNDInfoCollection()
        {
            dNDInfoCollection1 = DNDInfoFactory.GetDNDInfoCollection();
            foreach (var dNDInfoDTO in dNDInfoCollection1.GetAllDNDInfos())
            {
                dNDInfos.Add(new(dNDInfoDTO));
            }
        }
        public List<DNDInfo> GetAllDNDInfos()
        {
            List<DNDInfo> dNDInfos = new();
            IDNDInfocollection dNDInfoDal = dNDInfoCollection1;
            foreach (var dNDInfoDTO in dNDInfoDal.GetAllDNDInfos())
            {
                dNDInfos.Add(new(dNDInfoDTO));
            }
            return dNDInfos;
        }

     

        public bool TryCreateDNDInfo(DNDInfo dNDInfo)
        {
            CreateControl createControl = new();
            if (!CreateControl.FilledInDNDIndo(dNDInfo))
            {
                return false;
            }
            else
            {
                //todo add Getbookdal Bool to the Test
                //IBookCollection bookCollection = BookFactory.GetBookDal();
                DNDInfoDTO dNDInfoDTO = new()
                {
                    
                    Name = dNDInfo.Name,
                    Description = dNDInfo.Description,
                    Note = dNDInfo.Note,
                  
                };
                dNDInfoCollection1.CreateDNDInfo(dNDInfoDTO, dNDInfo.UserId);
                return true;
            }
        }
    }
}
