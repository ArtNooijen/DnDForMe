using System;
using DNDForMeFactory;
using DNDForMeAPIInterface;
using DNDForMeAPIInterface.DTO;
using DNDForMeAPIInterface.Interfaces;


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDForMeLogic
{
    public class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public IUser iUser { get; set; }
        public IDNDInfocollection infocollection { get; set; }
        



        public User(UserDto userDto)
        {
            iUser = UserFactory.CreateUserfactory();
            infocollection = DNDInfoFactory.GetDNDInfoCollection();

            Id = userDto.Id;
            Username = userDto.Username;
            Password = userDto.Password;
            Email = userDto.Email;
        }
        public User(IDNDInfocollection bookCollection)
        {
            infocollection = bookCollection;

           

            Id = 1;
            Username = "Art";
        }
        public User()
        {
            Id = 1;
            Username = "Art";
            infocollection = DNDInfoFactory.GetDNDInfoCollection();


        }

        /// <summary>
        /// Haalt Notes uit lijst van DTO's 
        /// </summary>
        /// <returns>
        /// Lijst<Notes> notes
        /// </returns>

    }
}
