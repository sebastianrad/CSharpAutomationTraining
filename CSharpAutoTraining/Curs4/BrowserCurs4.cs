﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Curs4
{
    abstract class BrowserCurs4
    {
        private int windowWidth;

        public int WindowWidth
        {
            get { return windowWidth; }
            set
            {
              if(value < 1024 || value > 1920)
                {
                    Console.WriteLine("Please enter a value between 1024 and 1920");
                }
              else
                {
                    windowWidth = value;
                }
            }
        }

        public abstract void StartBrowser();

    }
}
