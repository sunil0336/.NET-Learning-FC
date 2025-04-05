using System;
using CollegeFest;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of people attending the fest: ");
        int attendees = int.Parse(Console.ReadLine());

        College college = new College();
        Catering catering = new Catering();
        Decoration decoration = new Decoration();

        // Subscribing to event
        college.CollegeFestEvent += catering.HandleCatering;
        college.CollegeFestEvent += decoration.HandleDecoration;

        // Trigger event
        college.StartFest(attendees);
    }
}
