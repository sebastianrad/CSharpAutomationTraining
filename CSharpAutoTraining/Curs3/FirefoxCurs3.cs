﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class FirefoxCurs3 : BrowserCurs3
    {
        string profileName = "test";
        public void SetProfile(string profileName) 
        {
            Console.WriteLine("Acest mesaj se afiseaza din clasa Firefox3");
        }
    }
}
