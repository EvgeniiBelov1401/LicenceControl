using LicenceControl.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenceControl.Modules
{
    public class Licence
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StopDate { get; set; }
        public DateTime CurrentDay { get; set; }
        public bool Check { get; set; }

        public bool workTime = true;


        public Licence(string name, string login, string password, string startDate, string stopDate)
        {
            this.Name = name;
            this.Login = login;
            this.Password = password;
            this.StartDate = DateTime.Parse(startDate);
            this.StopDate = DateTime.Parse(stopDate);
            this.CurrentDay = this.StartDate;
        }

        public void CheckLicence()
        {
            if (workTime)
            {
                try
                {
                    // Здесь должна быть проверка на логин пароль и т.п.!!!
                    if (DateTime.Now >= this.StopDate || this.CurrentDay >= this.StopDate)
                    {
                        this.Check = false;
                        this.CurrentDay = DateTime.Now;
                        throw new EndLicenceException();
                        // Здесь должна быть заблокирована кнопка печати!!!
                    }
                    else if (DateTime.Now < this.CurrentDay)
                    {
                        this.Check = false;
                        throw new NonCurrentDateException();
                        // Здесь должна быть заблокирована кнопка печати!!!
                    }
                    else
                    {
                        this.Check = true;
                        this.CurrentDay = DateTime.Now;
                    }
                }
                catch (EndLicenceException)
                {
                    Console.WriteLine("Срок действия подписки истек...");
                    workTime = false;
                }
                catch (NonCurrentDateException)
                {
                    Console.WriteLine("Установите актуальную дату...");
                }
            }
            else
            {
                Console.WriteLine("Срок действия подписки истек...");
            }
        }
    }
}
