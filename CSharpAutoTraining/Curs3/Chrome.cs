﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class Chrome: Browser
    {

        public void ChangeWindowWidth(string val)
        {
            WindowWidth_string = val;
            Console.WriteLine("WindowWidth_string = " + WindowWidth_string);
        }
    }
}
