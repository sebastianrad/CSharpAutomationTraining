using System;

namespace D
{
    class IECurs2
    {
        //variables
        public int WindowWidth_int;
        public String WindowWidth_string;
        public double WindowWidth_double;
        private int count;

        public void displayWindowWidth(int WindowWidth_int)
        {
            if (WindowWidth_int > 1920)
            {
                while (count <3)
                {
                    Console.WriteLine("Window width = " + WindowWidth_int);
                    count++;
                    WindowWidth_int--;
                }
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Window width = " + WindowWidth_int);
                    WindowWidth_int++;
                }
            }
        }
    }
}
