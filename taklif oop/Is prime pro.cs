

using System.Threading.Channels;

namespace taklif_oop
{
    class Pisprime : calculator
    {
        public override bool istrue(int x)
        {
            
            for (int i = 2; i < Math.Sqrt(x); i++)
            {
                bool j = (x % i == 0);
                if (j == true) { return false; break; }
                
            }
            return true;
        }

        

    }
}
