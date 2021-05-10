using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostApp.Helpers
{
    public static class DateTimeExtension
    {
        public static int CalculateCreation(this DateTime date)
        {
            int creation = DateTime.Now.Year - date.Year;
            return creation;
        }
    }
}
