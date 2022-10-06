using System;
namespace Rookies.Events
{
    public class DisplayClock
    {
        public void Subcribe(Clock clock)
        {
            clock.clockTick += new Clock.clockTickHandler(ShowClock);
        }
        public void ShowClock(object clock, ClockEventArgs clockEventArgs)
        {
            System.Console.WriteLine($"{clockEventArgs.hour} : {clockEventArgs.minute} : {clockEventArgs.second}");
        }
    }
}