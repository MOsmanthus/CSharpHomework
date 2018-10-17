using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class MyAlarm
    {
        public void Alarming(MyTime time, int seconds)
        {
            Console.WriteLine($"Alarm time -- {time.Hour}:{time.Minute}:{time.Second}");
            Console.WriteLine($"Contiue {seconds} seconds");
            while (seconds-- > 0)
            {
                Console.WriteLine("dingling dingling dingling dingling dingling\a");
                Thread.Sleep(1000);
            }
        }
    }
}
