using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    class Class1
    {
        public Action<string> ShowEvent;
        public void test()
        {
           // Control.CheckForIllegalCrossThreadCalls = false;
           // Class2 cs2 = new Class2();
            //Thread th = new Thread(cs2.test);


            //th.Start();
           //  ShowEvent("123456789");
           // test1();
            // Form1 f1 = new Form1();
            //f1.ShowlbDevTem("112");

           Class2 cs2 = new Class2();
           cs2.test(ShowEvent);

        }
        public void test1()
        {
            //Class2 cs2 = new Class2();
            //cs2.test();
            // ShowEvent("123456789");

            //test2();


        }
        public void test2()
        {
            //Class2 cs2 = new Class2();
            //cs2.test();
            // ShowEvent("123456789");

           // ShowEvent("123456789");


        }



    }
}
