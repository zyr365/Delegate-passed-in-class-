using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace WindowsFormsApp12
{
    class Class2
    {
       // public Action<string> ShowEvent1;
        public void test(Action<string> ShowEvent)
        {
            //System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            //ShowEvent("123456789");
            // Class1 cs1 = new Class1();
            //cs1.test1();
            ShowEvent("123456789");

        }
        public void Test<T>(Action<string> action, string str)
        {

        }
    }
}
