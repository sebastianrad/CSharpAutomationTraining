﻿using CSharpAutoTraining.Curs2;
<<<<<<< branchIosifTamas
=======
using CSharpAutoTraining.Curs3;
using CSharpAutoTraining.Curs4;
>>>>>>> local
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs1
{
    class Test
    {
        static void Main(string[] args)
        {
            //Browser browser = new Browser();
            //browser.ChangeWindowHeight(1080);
            //browser.ChangeWindowWidth(1920);
            //browser.DisplayWindowHeight();
            //browser.DisplayWindowWidth();

<<<<<<< branchIosifTamas
            Curs2.Browser browser = new Curs2.Browser();
            Firefox firefox = new Firefox();
            Chrome chrome = new Chrome();
            IE ie = new IE();
=======
            //..........................Curs2.............................

            //Curs2.BrowserCurs2 browser = new Curs2.BrowserCurs2();
            //FirefoxCurs2 firefox = new FirefoxCurs2();
            //ChromeCurs2 chrome = new ChromeCurs2();
            //IECurs2 ie = new IECurs2();

            //firefox.WindowWidth_int = 1920;
            //firefox.WindowWidth_double = 1920.0;
            //firefox.WindowWidth_string = "1920";

            //Console.WriteLine(Convert.ToString(firefox.WindowWidth_int));
            //Console.WriteLine(Convert.ToDouble(firefox.WindowWidth_string));
            //Console.WriteLine(Convert.ToInt32(firefox.WindowWidth_double));

            //chrome.displayWindowWidth(1024);

            //ie.displayWindowWidth(1000);

            //......................Curs3................................

            //BrowserCurs3 browserCurs3 = new BrowserCurs3();
            //FirefoxCurs3 firefoxCurs3 = new FirefoxCurs3();
            //ChromeCurs3 chromeCurs3 = new ChromeCurs3();
            //IECurs3 iECurs3 = new IECurs3();
            //EdgeCurs3 edgeCurs3 = new EdgeCurs3();

            //browserCurs3.ChangeWindowWidth(1920);
            //browserCurs3.About();
            //Console.WriteLine("..........................................");

            //firefoxCurs3.ChangeWindowWidth(2000);
            //firefoxCurs3.About();
            //firefoxCurs3.SetProfile("profile1");
            //Console.WriteLine("..........................................");

            //chromeCurs3.ChangeWindowWidth(1024);
            //chromeCurs3.About();
            //chromeCurs3.ChangeWindowWidth("1920");
            //Console.WriteLine("..........................................");

            //iECurs3.ChangeWindowWidth(800);
            //iECurs3.About();
            //Console.WriteLine("..........................................");

            //edgeCurs3.ChangeWindowWidth(1920);
            //edgeCurs3.About();
            //edgeCurs3.NewFeatureFunction();
            //Console.WriteLine("..........................................");

            //.............................Curs4......................................


            FirefoxCurs4 ffCurs4 = new FirefoxCurs4();
            Skype skype = new Skype();

            ffCurs4.About();
            ffCurs4.StartBrowser();
            ffCurs4.Ping();
            ffCurs4.WindowWidth = 2000;

            Console.WriteLine(".........................................");

            skype.About();
            skype.Ping();
>>>>>>> local

            firefox.WindowWidth_int = 1920;
            firefox.WindowWidth_double = 1920.0;
            firefox.WindowWidth_string = "1920";

            Console.WriteLine(Convert.ToString(firefox.WindowWidth_int));
            Console.WriteLine(Convert.ToDouble(firefox.WindowWidth_string));
            Console.WriteLine(Convert.ToInt32(firefox.WindowWidth_double));

            chrome.displayWindowWidth(1024);

            ie.displayWindowWidth(1000);


        }
    }
}
