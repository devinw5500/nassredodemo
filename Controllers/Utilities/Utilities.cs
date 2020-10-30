using System;

namespace TaxSystemNASS.Controllers.Utilities
{
    public class Utilities
    {
        private Utilities()
        {
        }

        public static DateTime Set_ETA_Time()
        {
            DateTime today = DateTime.Today;
            DateTime ETA = today.AddDays(14);
            ETA.AddMinutes(-1);
            return ETA;
        }
    }
}