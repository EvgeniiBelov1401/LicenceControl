using LicenceControl.Modules;

namespace LicenceControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var licence1 = new Licence("Рога и копыта", "qwerty1234", "123456789", "01/09/2024", "10/09/2024");
            while (true)
            {
                ShowCurrentDate();
                Console.ReadLine();


                ShowLicenceInfo(licence1);

                Console.ReadLine();
                Console.Clear();
            }
        }
        static DateTime CurrentDate()
        {
            return DateTime.Now;
        }
        static void ShowCurrentDate()
        {
            Console.Write("Показать тукущую дату (Enter)");
            Console.ReadLine();
            Console.WriteLine($"{CurrentDate():dd/MM/yyyy}");
        }

        static void ShowLicenceInfo(Licence licence)
        {
            Console.WriteLine($"Организация: {licence.Name}\n" +
                $"Логин: {licence.Login}\nПароль: {licence.Password}");
            licence.CheckLicence();
            if (licence.Check)
            {
                Console.WriteLine($"Подписка действительна..." +
                    $"\nДата начала подписки: {licence.StartDate.ToString("dd.MM.yyyy")}" +
                    $"\nДата окончания подписки: {licence.StopDate.ToString("dd.MM.yyyy")}" +
                    $"\nДней до окончания подписки: {(licence.StopDate - CurrentDate()).ToString("dd")}");
            }
        }
    }
}
