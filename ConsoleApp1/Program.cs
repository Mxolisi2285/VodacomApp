using System;

class VodacomApp
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n====== VODACOM MENU ======");
            Console.WriteLine("1. Buy Data");
            Console.WriteLine("2. Buy Voice Minutes");
            Console.WriteLine("3. Buy Data + Voice Bundle");
            Console.WriteLine("4. Exit");
            Console.Write("Select option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BuyData();
                    break;

                case "2":
                    BuyVoice();
                    break;

                case "3":
                    BuyBundle();
                    break;

                case "4":
                    Console.WriteLine("Thank you for using Vodacom Services.");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void BuyData()
    {
        Console.Write("Enter amount of data in GB: ");
        if (double.TryParse(Console.ReadLine(), out double gb))
        {
            double price = gb * 100; // R100 per GB (example)
            Console.WriteLine($"You bought {gb}GB for R{price}");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    static void BuyVoice()
    {
        Console.Write("Enter minutes: ");
        if (int.TryParse(Console.ReadLine(), out int minutes))
        {
            double price = minutes * 0.75; // 75c per minute
            Console.WriteLine($"You bought {minutes} minutes for R{price}");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    static void BuyBundle()
    {
        Console.Write("Enter data in GB: ");
        double.TryParse(Console.ReadLine(), out double gb);

        Console.Write("Enter minutes: ");
        int.TryParse(Console.ReadLine(), out int minutes);

        double total = (gb * 90) + (minutes * 0.60); // discounted rates

        Console.WriteLine($"You bought {gb}GB + {minutes} minutes");
        Console.WriteLine($"Total price: R{total}");
    }
}