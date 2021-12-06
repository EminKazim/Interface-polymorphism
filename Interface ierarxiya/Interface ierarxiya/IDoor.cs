using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_ierarxiya
{
   public interface IDoor
    {
        void DoorsLocked(string vechileType)
        {
            Console.WriteLine(vechileType+ "'s doors are locked");

        }
        
        
    }
}
