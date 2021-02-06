using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{
   public class CompFighter
    {
        public int Power { get; set; }

        public CompFighter()
        {
            Random random = new Random();
            Power = random.Next(125, 390);

        }



    }
}
