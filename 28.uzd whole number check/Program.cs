using System;

namespace _28.uzd_whole_number_check
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Please enter number: ");
                int number;
                var result = int.TryParse(Console.ReadLine(), out number);

                if (result)
                {
                    Console.WriteLine(number);
                    break;
                }

                Console.WriteLine("Invalid number");
                continue;
            } while (true);
        }
    }
}
// Uztaisīt console aplikāciju, kura lietotājam paprasa ievadīt veselu skaitli. 
// Ja nav ievadīts vesels skaitlis, paziņot par kļūdu un likt ievadīt atkārtoti. 
// Ja ievadītā vērtība ir skaitlis, tad izvadīt to uz ekrāna.
