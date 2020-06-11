using System;
using Microsoft.Extensions.DependencyInjection;

namespace PrimeNumbersConsole
{
    class Program
    {
        static void Main(string[] args)        
        {
            int primeCount = 1;

            if(args.Length == 0)
            {
                Console.WriteLine("Please enter a number");
                Console.ReadLine();
                return;
            }
            else 
            {
                if(int.TryParse(args[0], out primeCount))
                {
                   if(primeCount < 1 )
                   {
                       Console.WriteLine("Please enter a number atleast 1"); 
                       Console.ReadLine();                      
                       return;
                   }
                }
                else
                {                    
                    Console.WriteLine("Please enter valid number");
                    Console.ReadLine();
                    return;
                }
            }

            var serviceProvider = GetServiceProvider();            
            IGridTable gridTable = serviceProvider.GetService<IGridTable>();

            var grid = gridTable.GetGridTable(primeCount);

            foreach(var table in grid)
            {
                foreach(int i in table.tableNumbers)
                {
                    Console.Write("{0} | ", i);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static ServiceProvider GetServiceProvider()
        {
            var collection = new ServiceCollection();
            collection.AddScoped<IPrimeNumber, PrimeNumberSimple>();
            collection.AddScoped<IPrimeNumbers, PrimeNumbers>();
            collection.AddScoped<IMultiplicationTable, MultiplicationTable>();
            collection.AddScoped<IGridTable, GridTable>();
            return collection.BuildServiceProvider();
        }
    }
}
