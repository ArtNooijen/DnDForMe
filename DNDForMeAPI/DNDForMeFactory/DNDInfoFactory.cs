using DNDForMeAPIData;
using DNDForMeAPIInterface.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDForMeFactory
{
    public class DNDInfoFactory
    {
        public static IDNDInfocollection GetDNDInfoCollection()
        {
            return new DNDInfoDal();
        }

        //public static IDNDInfo GetIDNDInfo()
        //{
        //    return new DNDInfoDal();
        //}
    }
}
