using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs3
{
    class BrowsersCurs_3
    {
        private int WindowWidth_int;
        private string WindowWidth_string;

        public virtual void ChangeWindowWidth(int val)
        {
            this.WindowWidth_int = val;
        }
        public virtual void About() { }


    }
}
