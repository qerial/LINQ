namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali mida soovid teha.");
            Console.WriteLine("1.Filtreerimine");

            int Choice = int.Parse(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    Filtreerimine();
                    break;

                case 2:

                    break;

                case 3:

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


        }
    }
}
