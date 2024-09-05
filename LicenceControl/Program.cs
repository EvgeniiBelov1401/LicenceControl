namespace LicenceControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DateTime now = DateTime.Now;
                Console.Write("Показать тукущую дату (Enter)");
                Console.ReadLine();
                Console.WriteLine($"{currentDate():dd/MM/yyyy}");

                Console.ReadLine();
                Console.Clear();
            }
        }
        static DateTime currentDate()
        {
            return DateTime.Now;
        }
    }
}
