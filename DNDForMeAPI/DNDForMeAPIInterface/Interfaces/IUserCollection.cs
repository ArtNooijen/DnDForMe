﻿using DNDForMeAPIInterface.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDForMeAPIInterface.Interfaces
{
    public interface IUserCollection
    {
        public List<UserDto> GetAllUsers();
        
    }
}
