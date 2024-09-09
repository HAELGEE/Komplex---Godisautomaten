using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Komplex___Godisautomaten;

internal class Program
{
    static void Main(string[] args)
    {        
        int japp = 20; 
        int dajm = 20;
        int kola = 20;
        int lakris = 20;
        int centerX = Console.WindowHeight / 2;
        int centerY = Console.WindowHeight / 2;
        
        bool loop = true;

        while (loop)
        {
            Console.Clear();
            
            Console.Write($"Lucka nummer 1. Här finns det ");
            if (japp > 0)
            {
                Green(japp);
            }
            if (japp <= 0)
            {
                Red(japp);
            }
            Console.Write(japp);
            Console.ResetColor();
            Console.WriteLine("st japp kvar.");

            Console.Write($"Lucka nummer 2. Här finns det ");
            if (dajm > 0)
            {
                Green(dajm);
            }
            else
            {
                Red(dajm);
            }
            Console.Write(dajm);
            Console.ResetColor();
            Console.WriteLine("st dajm kvar.");

            Console.Write($"Lucka nummer 3. Här finns det ");
            if (kola > 0)
            {
                Green(kola);
            }
            else
            {
                Red(kola);
            }
            Console.Write(kola);
            Console.ResetColor();
            Console.WriteLine("st kola kvar.");

            Console.Write($"Lucka nummer 4. Här finns det ");
            if (lakris > 0)
            {
                Green(lakris);
            }
            else
            {
                Red(lakris);
            }
            Console.Write(lakris);
            Console.ResetColor();
            Console.WriteLine("st lakris kvar.");
            Console.WriteLine("Vilken godis vill du ha? Välj siffra på luckan eller tryck Q för att avsluta");
            string choice = Console.ReadLine().ToUpper();



            if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "Q")
            {
                switch (choice)
                {
                    case "1":
                        if (japp > 0)
                        {
                            Console.WriteLine("Du får en japp, MUMS!");
                            japp--;
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Du har inga japp kvar, var god välj en annan godis <3");
                            Console.ReadKey();
                            break;
                        }


                    case "2":
                        if (dajm > 0)
                        {
                            Console.WriteLine("Du får en dajm, MUMS!");
                            dajm--;
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Du har inga dajm, kvar, var god välj en annan godis <3");
                            Console.ReadKey();
                            break;
                        }

                    case "3":
                        if (kola > 0)
                        {
                            Console.WriteLine("Du får en kola, MUMS!");
                            kola--;
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Du har inga kola kvar, var god välj en annan godis <3");
                            Console.ReadKey();
                            break;
                        }

                    case "4":
                        if (lakris > 0)
                        {
                            Console.WriteLine("Du får en lakris, MUMS!");
                            lakris--;
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Du har inga lakris kvar, var god välj en annan godis <3");
                            Console.ReadKey();
                            break;
                        }

                    case "Q":
                        Console.WriteLine("Godis automaten stängs nu ner.");
                        loop = false;
                        Console.ReadKey();
                        break;
                }

            }
            else
            {
                Console.WriteLine("Nu gick något fel, försök igen");
                Console.ReadKey();
                continue;
            }
        }
    } 
    static void Green(int value)
    {
        Console.ForegroundColor = ConsoleColor.Green;        
    }
    static void Red(int value)
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }

}

//Made by Christofer Hägg
       
    

