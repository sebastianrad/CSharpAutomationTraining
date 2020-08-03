using System;

namespace C
{
    class ChromeCurs2
    {
        //variables
        public int WindowWidth_int;
        public String WindowWidth_string;
        public double WindowWidth_double;

        public void displayWindowWidth(int WindowWidth_int)
        {
            if(WindowWidth_int > 1920)
            {
                Console.WriteLine("Window width larger than 1920");
            } else
            {
                Console.WriteLine("“window width less than 1920");
            }
        }
    }
}
