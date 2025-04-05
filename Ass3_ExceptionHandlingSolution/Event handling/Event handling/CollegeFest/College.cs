using System;

namespace CollegeFest
{
    // Delegate for event handling
    public delegate void FestHandler(int attendees);

    public class College
    {
        public event FestHandler CollegeFestEvent;

        public void StartFest(int attendees)
        {
            Console.WriteLine($"College Fest Started with {attendees} attendees!");
            CollegeFestEvent?.Invoke(attendees);
        }
    }
}
