using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs6
{
    class HomePage
    {
        // XPath variables

        // Search in Header
        // search for div with ID "header" where an image link is found
        String Image = "//div[@id = 'header']/a/img";

        // Search in Header
        // search for home link under header, unordered list, first link
        String HomeLink = "//header/ul/a[1]"; 

        // Search in h1
        // search h1 HTML text
        String HTML = "//h1";

        // Search Text from page(body)
        // search text (paragraph - p) from body
        String Text = "//body/p"; 

        // Search input
        // search for input box with ID "email"
        String Email = "//input[@id = 'email']"; 

        // Search for text/label
        // search in form all text for password label
        String Password = "//form/text()[2]"; 
       
        // Search for button with ID "Login"
        String Login = "//button[@id = 'Login']"; 

        // Search footer 
        // search for homefooter link in unordered list 
        String HomeFooter = "//footer/ul/li[1]"; 
    }
}
