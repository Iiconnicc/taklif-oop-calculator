

using System.Reflection.Metadata.Ecma335;

namespace taklif_oop
{
    internal class Risprime : calculator
    {
        public override bool istrue(int x)
        {
            for (int i = 2; i < x; i++)
            {
                bool j = (x % i == 0);
                if (j == true) { return false; break; }

            }
            return true;
            
        }
        
    }
}
