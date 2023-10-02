using System;

namespace TalTillRomerska
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Ange ett tal: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
              if (num >= 1 && num <= 5999)
                {
                    string romerskt = OmvandlaTillRomerska(num);

                   
                    Console.WriteLine($"Originalsiffran: {num}");
                    Console.WriteLine($"Romerska siffror: {romerskt}");
                }
                else
                {
                    Console.WriteLine("Ogiltigt tal. Ange ett tal mellan 1 och 5999.");
                }
            }
            else
            {
                Console.WriteLine("Ogiltig inmatning. Ange ett heltal.");
            }
        }

        
        static string OmvandlaTillRomerska(int num)
        {
            string[] romerskaSiffror = 
            {
                "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M"
            };

            int[] nummerVärden = 
            {
                1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000
            };

            string romerskt = "";

            for (int i = 12; i >= 0; i--)
            {
                while (num >= nummerVärden[i])
                {
                    num -= nummerVärden[i];
                    romerskt += romerskaSiffror[i];
                }
            }

            return romerskt;
        }
    }
}




               


