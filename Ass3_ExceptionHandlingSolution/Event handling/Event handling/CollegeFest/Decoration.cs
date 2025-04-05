using System;

namespace CollegeFest
{
    public class Decoration
    {
        public void HandleDecoration(int attendees)
        {
            int decorationCost = 10000 + (attendees * 10);
            Console.WriteLine($"Decoration Bill: Rs. {decorationCost}");
        }
    }
}
