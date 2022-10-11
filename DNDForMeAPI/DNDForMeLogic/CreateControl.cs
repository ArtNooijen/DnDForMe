using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDForMeLogic
{
    public class CreateControl
    {
        public static bool FilledInDNDIndo(DNDInfo dNDInfo)
        {
            bool filled;
            if (dNDInfo.Name == null)
            {
                filled = false;
            }
            else if (dNDInfo.Description == null)
            {
                filled = false;

            }
            else if (dNDInfo.Note == null)
            {
                filled = false;

            }
            else
            {
                filled = true;
            }
            return filled;

        }
    }
}
