using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto[] auto = new Auto[7];

            for (int i = 0; i < 1; i++)
            {
                auto[i] = new Auto(100);

                Console.Write("Enter name of brand: ");
                try
                {
                    auto[i].Brand = Console.ReadLine();
                }
                catch(Exception)
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine("");
                Console.Write("Enter name of model: ");
                try
                {
                    auto[i].Model = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine("");
                Console.Write("Enter name of engine: ");
                try
                {
                    auto[i].Engine = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine("");
                Console.Write("Enter value of fuel: ");
                try
                {
                    auto[i].SetFuel(Convert.ToInt32(Console.ReadLine()));
                }
                catch (Exception)
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine("");
                Console.Write("Enter value of max speed: ");
                try
                {
                    auto[i].SetMaxSpeed(Convert.ToInt32(Console.ReadLine()));
                }
                catch (Exception)
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine("");
                Console.Write("Enter value of nitro: ");
                try
                {
                    auto[i].SetNitro(Convert.ToInt32(Console.ReadLine()));
                }
                catch (Exception)
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine("");
                Console.Write("Enter color: ");
                auto[i].Color = Console.ReadLine();

                if(auto[i].Color == "White" || auto[i].Color == "white") Console.ForegroundColor = ConsoleColor.White;
                if (auto[i].Color == "Blue" || auto[i].Color == "blue") Console.ForegroundColor = ConsoleColor.Blue;
                if (auto[i].Color == "Red" || auto[i].Color == "red") Console.ForegroundColor = ConsoleColor.Red;
                if (auto[i].Color == "Black" || auto[i].Color == "black") Console.ForegroundColor = ConsoleColor.Black;
                if (auto[i].Color == "Magenta" || auto[i].Color == "magenta") Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("");
                Console.WriteLine("---------------Car is ready---------------");
                Console.WriteLine("Car: " + auto[i].Brand + " " + auto[i].Model);
                Console.WriteLine("Engine: " + auto[i].Engine);
                Console.WriteLine("Fuel: " + auto[i].GetFuel() + "%");
                Console.WriteLine("Max speed: " + auto[i].GetSpeed() + " km/h");
                Console.WriteLine("Nitro: " + auto[i].GetNitro() + "%");
                Console.ResetColor();
            }
            Console.ReadKey();
        }
    }
}
