using System;
namespace Upgift3_2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("har du gått ut gymnasiet svara J för ja och N för nej");
            string gym = Console.ReadLine().ToLower();
            Console.WriteLine("hur gammal är du");
            string åld = Console.ReadLine();
            int y = int.Parse(åld);
            if (gym == "j" && y <= 22)
            {
                Console.WriteLine("du har fått jobbet");
            }
            else
            {
                Console.WriteLine("vi letar tyvär efter npgon annan");
            }
        }
    }
}