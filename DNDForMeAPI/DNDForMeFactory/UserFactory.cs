

using DNDForMeAPIData;
using DNDForMeAPIInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DNDForMeAPIInterface.Interfaces;
using DNDForMeAPIData;

namespace DNDForMeFactory
{
    public class UserFactory
    {
        public static IUser CreateUserfactory()
        {
            return new UserDal();
        }
        public static IUserCollection CreateUserCollectionFactory()
        {
            return new UserDal();
        }
    }
}
