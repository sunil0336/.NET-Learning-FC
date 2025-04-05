using System;

namespace CollegeFest
{
    public class Catering
    {
        public void HandleCatering(int attendees)
        {
            int cateringCost = attendees * 200;
            Console.WriteLine($"Catering Bill: Rs. {cateringCost}");
        }
    }
}
