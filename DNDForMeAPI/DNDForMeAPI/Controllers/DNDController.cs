﻿using Microsoft.AspNetCore.Mvc;

namespace DNDForMeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DNDController : Controller
    {
        [HttpGet(Name = "GetDNDInfo")]
        public IEnumerable<DNDInfo> Get()
        {
            Random rnd = new Random();
            rnd.Next();
            return Enumerable.Range(0, 1).Select(index => new DNDInfo
            {
                Name = "Mage hand",
                Description = "C M V",
                Note = "A spectral, floating hand appears at a point you choose within range. The hand lasts for the duration or" +
                " until you dismiss it as an action. The hand vanishes if it is ever more than 30 feet away from you or if you cast this " +
                "spell again.You can use your action to control the hand.You can use the hand to manipulate an object," +
                " open an unlocked door or container," +
                " stow or retrieve an item from an open container," +
                " or pour the contents out of a vial.You can move the hand up to 30 feet each time you use it." +
                "The hand can’t attack," +
                "                activate magic items," +
                "                or carry more than 10 pounds."
            })
            .ToArray();
        }
    }
}
