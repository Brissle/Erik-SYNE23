using System;

class Program
{
/*
 Grupp-4
 Erik Brissle
 Mats Johansson
 */

    static void Main()
    {
        Console.Write("Ange ditt svenska personnummer (ÅÅMMDD-XXXX): ");
        string Personnummer = Console.ReadLine(); 
        //ber om ditt personnummer och sätter in i uträkningen

        bool isValid = ValidateSwedishPersonalNumber(Personnummer); 
        

        if (isValid)
        {
            Console.WriteLine("Giltigt personnummer.");
        }
        else
        {
            Console.WriteLine("Ogiltigt personnummer.");
        }
    }

    static bool ValidateSwedishPersonalNumber(string Personnummer)
    {
        // Ta bort eventuella bindestreck eller mellanslag
        Personnummer = Personnummer.Replace("-", "").Replace(" ", "");

        // Kontrollera att personnumret har rätt längd (10 siffror)
        if (Personnummer.Length != 10)
        {
            return false;
        }

        // Konvertera personnumret till en array av heltal
        int[] digits = new int[10];
        for (int i = 0; i < 10; i++)
        {
            if (!int.TryParse(Personnummer[i].ToString(), out digits[i]))
            {
                return false; //  Beräkna att varje siffra blir ett heltal, eller kolla felaktikt tecken
            }
        }

        // Beräkna kontrollsiffran
        int sum = 0;
        for (int i = 0; i < 9; i++)
        {
            int product = digits[i] * ((i % 2 == 0) ? 2 : 1);
            sum += (product > 9) ? product - 9 : product;
        }

        int checksum = (10 - (sum % 10)) % 10;

        // Jämför kontrollsiffran med den sista siffran i personnumret
        return checksum == digits[9];
    }
}
