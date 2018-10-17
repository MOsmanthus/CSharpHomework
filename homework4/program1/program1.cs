using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyClock clock = new MyClock(); //时钟
                MyAlarm alarm = new MyAlarm(); //闹铃
                DateTime now = DateTime.Now;

                clock.AddAlarmTime(
                    new MyTime(now.Hour, now.Minute, now.Second + 5)); ;
                clock.AlarmEvent += alarm.Alarming;
                clock.Run();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
