// See https://aka.ms/new-console-template for more information
namespace gibiocena
{
    internal class program
    {
        static void Main(string[] args)
        {//67
            int ocena;
            Console.WriteLine("Podaj swoją ocenę a my powiemy Ci jak ją napisać nie cyfrą lecz pisemnie:");
            string chwilowe = Console.ReadLine();
            int.TryParse(chwilowe, out ocena);
            switch (ocena)
            {
                case 1:
                    Console.WriteLine($"Twoja ocena: {ocena} - niedostateczny");
                    break;
                case 2:
                    Console.WriteLine($"Twoja ocena: {ocena} - dopuszczający");
                    break;
                case 3:
                    Console.WriteLine($"Twoja ocena: {ocena} - dostateczny");
                    break;
                case 4:
                    Console.WriteLine($"Twoja ocena: {ocena} - dobry");
                    break;
                case 5:
                    Console.WriteLine($"Twoja ocena: {ocena} - bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine($"Twoja ocena: {ocena} - celujący");
                    break;
                default:
                    Console.WriteLine("podaj ocenę od 1 do 6");
                    break;
            }

        }
    }
}
