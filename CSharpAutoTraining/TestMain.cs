using CSharpAutoTraining.Curs3.Chrome_Curs_3;
using CSharpAutoTraining.Curs3.EdgeCurs_3;
using CSharpAutoTraining.Curs3.FirefoxCurs_3;
using CSharpAutoTraining.Curs3.IECurs_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3
{
    class TestMain
    {
        static void Main(string[] args)
        {
            //var browser = new BrowserCurs_3();
            var chrome = new ChromeCurs_3();
            var firefox = new FirefoxCurs_3();
            var ie = new IECurs_3();
            var edge = new EdgeCurs_3();

            chrome.ChangeWindowWidth();
            chrome.WindowWidth_int = 1080;
            chrome.ChangeWindowWidth();

            firefox.SetProfile



        }
    }
}
