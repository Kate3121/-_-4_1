using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СПЗ_Лр4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть назву мiста:"); string sName = Console.ReadLine();

            Console.Write("Введiть назву краiни:"); string sCountry = Console.ReadLine();

            Console.Write( "Введiть назву регiону:" ); string sRegion = Console.ReadLine();

            Console.Write( "Введiть кiлькiсть населення:" ); string sPopulation =
            Console.ReadLine();

            Console.Write( "Введiть рiчний дохiд:" ); string sYearIncome =
            Console.ReadLine();

            Console.Write( "Введiть площу, кв. км:" ); string sSquare = Console.ReadLine();

            Console.Write( "Чи є у мiстi порт ? (y - так, n - нi) :" ); ConsoleKeyInfo keyHasPort =
            Console.ReadKey(); Console.WriteLine();

            Console.Write( "Чи є у мiстi аеропорт ? (y - так, n - нi) : "); ConsoleKeyInfo
            keyHasAirport = Console.ReadKey(); Console.WriteLine();

            Town OurTown = new Town();

            OurTown.Name = sName; OurTown.Country = sCountry; OurTown.Region =
            sRegion;
            OurTown.Population = int.Parse(sPopulation); OurTown.YearIncome =
            double.Parse(sYearIncome); OurTown.Square = double.Parse(sSquare);
            OurTown.HasPort = keyHasPort.Key == ConsoleKey.Y ? true : false;
            OurTown.HasAirport = keyHasAirport.Key == ConsoleKey.Y ? true : false;
        }
    }
}
