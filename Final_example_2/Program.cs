using System;

namespace Final_example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SecuritySystem ss = new SecuritySystem();
            SpeakerSystem speaker = new SpeakerSystem();
            ss.SomeEvent += speaker.speak;
            ss.FireAlarm("fire fire");
        }
    }

  
    public class SpeakerSystem
    {
        public void speak(Object sender, MyEvent e)
        {
            Console.WriteLine($"Some detected {e.SomeString}");

        }
    }

    public class SecuritySystem
    {
        public event SomeDelegate SomeEvent;

        public void FireAlarm(String str)
        {
            if (SomeEvent != null)
            {
                SomeEvent(this, new MyEvent(str));
            }
        }
    }

    public delegate void SomeDelegate(Object sender, MyEvent e);

    public class MyEvent : EventArgs
    {
        public String SomeString { get; set; }

        public MyEvent(String str)
        {
            SomeString = str;
        }
    }
}