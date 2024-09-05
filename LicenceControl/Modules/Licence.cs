using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenceControl.Modules
{
    public class Licence
    {
        public string OrganizationName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StopDate { get; set; }
    }
}
