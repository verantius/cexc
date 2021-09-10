using System;

namespace JustPractiseIGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass;
            string cpass = "duparomana";
            Console.WriteLine("enter a login:");
            string login = Console.ReadLine();
            int p = 0;
            int pp = 2;

            System.Console.Write("password: ");
            string password = null;
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                password += key.KeyChar;
            }

            Console.WriteLine("enter password:");
            pass = Console.ReadLine();
            do
            {

                if (cpass == pass)
                {
                    Console.WriteLine($"Hasło poprawne! Witaj {login} miłego dnia!");

                    p = 2;
                }
                else
                {
                    Console.WriteLine($"zle haslo! podaj hasło ponownie. ilosc prób {pp}");
                    pass = Console.ReadLine();
                    p++;pp--;
                   // Console.WriteLine($"p={p}");
                    if (p==2) 
                        Console.WriteLine($"konto zablokowane");

                }


            } while (p != 2);
           
                
            
        }
    }
}
