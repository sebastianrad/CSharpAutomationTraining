using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6
{
    class HomePage
    {
        //variables
        String Image = "//div[@id = 'header']/a/img"; // (header)
        String HomeLink = "//header/ul/a[1]"; // (header)
        String HTML = "//h1"; //(h1)
        String Text = "//body/p"; // from page(body)
        String Email = "//input[@id = 'email']"; // (input):
        String Password = "//form/text()[2]"; // (text/label)
        String Login = "//button[@id = 'Login']"; // button
        String HomeFooter = "//footer/ul/li[1]"; // (footer)
    }
}
