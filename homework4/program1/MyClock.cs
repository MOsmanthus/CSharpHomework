using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class MyClock
    {
        private MyTime currentTime;
        private List<MyTime> alarmTimes = new List<MyTime>();
        public delegate void AlarmEventHandler(MyTime time, int seconds);
        public event AlarmEventHandler AlarmEvent;
        public MyClock()
        {
            currentTime = new MyTime();
        }
        public MyTime CurrentTime
        {
            get { return currentTime; }
        }
        public void AddAlarmTime(MyTime time)
        {
            if (!alarmTimes.Contains(time))
                alarmTimes.Add(time);
        }
        public void RemoveAlarmTime(MyTime time)
        {
            if (alarmTimes.Contains(time))
                alarmTimes.Remove(time);
        }
        public void Run()
        {
            while (true)
            {
                DateTime now = DateTime.Now;
                currentTime = new MyTime(now.Hour, now.Minute, now.Second);
                if (alarmTimes.Contains(currentTime))
                    AlarmEvent(currentTime, 10);
                Thread.Sleep(1000);
            }
        }
    }
}
