﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs1
{
    class Browser
    {
        public int WindowWidth = 1024;
        public int WindowHeight = 1056;

        //curs 2
        public int WindowWidth_int = 30;
        public string WindowWidth_string = "44";
        public double WindowWidth_double = 124.6;

        //curs 3
        public int WindowWidth_intC3;
        public string WindowWidth_stringC3;

       

        public Browser()
        {

        }
       public Browser(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
        }
        public void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
            Console.WriteLine("IE");
        }
        public void ChangeWindowHeight(int newWindowHeight)

        {
            WindowHeight = newWindowHeight;
        }
        public int DisplayWindowWidth()
        {
            return WindowWidth;
            
        }
        public int DisplayWindowHeight()
        {
            return WindowHeight;
        }

        //curs3
        public virtual int ChangeWindowWidthC3(int val)
        {
            return val;
        }
        public virtual void About()
        {

        }


    }
}
