using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGame_new_assign_S
{
    public class fireSetting:Random
    {
        
        Random random = new Random();
        
        //this method is used to get the rndom number to shoot the chnge 
        public int set() {
            return random.Next(1,5);
        }

        public int setup()
        {
            return random.Next(1, 3);
        }


    }
}
