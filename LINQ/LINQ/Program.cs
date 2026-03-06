using System.Runtime.InteropServices;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali mida soovid teha.");
            Console.WriteLine("1.Filtreerimine");
            Console.WriteLine("2.Sorteerimine");
            Console.WriteLine("3.Andmete projitseerimine");
            Console.WriteLine("4.Andmete vahelejätmine");
            Console.WriteLine("5.Võtimine tingimuse alusel");
            Console.WriteLine("6.Üksiku elemendi leidmine");
            Console.WriteLine("7.Statistika");
            Console.WriteLine("8.");
            Console.WriteLine("\n");

            int Choice = int.Parse(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    Filtreerimine();
                    break;

                case 2:
                    Sorteerimine();
                    break;

                case 3:
                    Andmeteprojitseerimine();
                    break;

                case 4:
                    AndmeteVahelejätmine();
                    break;

                case 5:
                    Võtminetingimusealusel();
                    break;

                case 6:
                    üksikuelemendileidmine();
                    break;

                case 7:
                    Statistika();
                    break;

                case 8:

                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
        public static void Filtreerimine()
        {
            Console.Clear();
            Console.WriteLine("Kõik kliendid kes elavad Tallinnas:");
            string ClientCity = "Tallinn";

            var ClientCityWhere = ClientData.clients
           .Where(x => x.City == ClientCity);
            foreach (var client in ClientCityWhere)
            {
                Console.WriteLine(client.Id + " " + client.Name + " " + client.City);
            }
        }
        public static void Sorteerimine()
        {
            Console.Clear();
            Console.WriteLine("Sorteerib tooted hinna järgi kasvavalt");
            var hinnajärgikasvav = ProductData.products
                .OrderBy(x => x.Price)
                .ThenByDescending(x => x.Price);
            foreach (var Hind in hinnajärgikasvav)
            {
                Console.WriteLine(Hind.Id + " " + Hind.Name + " Hind: " + Hind.Price + "|Kogus:" + Hind.Amount);
            }
        }
        public static void Andmeteprojitseerimine()
        {
            Console.Clear();
            var projitseerimine = ClientData.clients.Select(x => new
            {
                Id = x.Id,
                Name = x.Name,
                City = x.City,
            });

            foreach (var client in projitseerimine)
            {
                Console.WriteLine(client.Id + " " + client.Name + " " + client.City);
            }
        }
        public static void AndmeteVahelejätmine()
        {
            Console.Clear();
            Console.WriteLine("Näitab tooteid siis kuni jõuab");
            var jätavahele = ProductData.products
            .SkipWhile(x => 20 < x.Price);
            foreach (var item in jätavahele)
            {
                Console.WriteLine(item.Id + " " + item.Name + " Hind: " + item.Price + "|Kogus:" + item.Amount);
            }
        }
        public static void Võtminetingimusealusel()
        {
            Console.Clear();
            Console.WriteLine("hinnalt järjestatud tooted seni, kui hind on alla 50 euro");
            var võtmine = ProductData.products
                .TakeWhile(x => x.Price < 50);
            foreach (var item in võtmine)
            {
                Console.WriteLine(item.Id + " " + item.Name + " Hind: " + item.Price + "|Kogus:" + item.Amount);
            }

        }
        public static void üksikuelemendileidmine()
        {
            Console.Clear();
            Console.WriteLine();
            string leidmine = ClientData.clients
                .FirstOrDefault(x => x.Id == 3).Name;
            
            Console.WriteLine("The first long name is '{0}'.", leidmine);

        }
        public static void Statistika()
        {
            Console.Clear();
        }
    }
}
