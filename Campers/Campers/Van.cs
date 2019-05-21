using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campers
{
    class Van
    {
        private string name = string.Empty;
        private string registration = string.Empty;
        private int MaxNumberOfOccupants = 0;
        private List<string[]> userAndBookedDays = new List<string[]>();
        private List<DateTime[]> bookedDays = new List<DateTime[]>();

        public Van(string[] iVanLine)
        {
            this.name = iVanLine[0].Trim();
            this.registration = iVanLine[1].Trim();
            this.MaxNumberOfOccupants = Convert.ToInt32(iVanLine[2].Trim());                
        }

        public string ReturnName()
        {
            return this.name;
        }

        public void AddBookingsForVan(List<string[]> iBookings)
        {
            string[] iTemp = new string[3];
            // input list oflist, [0] = user, [1] = date (in string)
            foreach(string[] booking in iBookings)
            {
                iTemp[0] = booking[0];
                iTemp[1] = booking[1];
                iTemp[2] = booking[2];
                userAndBookedDays.Add(iTemp);

                DateTime[] bookingRange = new DateTime[2];
                bookingRange[0] = Convert.ToDateTime(iTemp[1]);
                bookingRange[1] = Convert.ToDateTime(iTemp[2]);

                bookedDays.Add(bookingRange);
            }
        }

        public List<string[]> ReturnBookedUserAndDateRange()
        {
            List<string[]> oBookings = new List<string[]>();
            // string[] with user, start date, end date
            foreach(string[]booking in userAndBookedDays)
            {
                oBookings.Add(booking);
            }

            return oBookings;
        }

        public bool CheckIfVanAvailible(DateTime iStatDate, DateTime iEndDate)
        {
            foreach (DateTime[] range in bookedDays)
            {
                if ((range[0]<iStatDate && iStatDate<range[1]) || (range[0]<iEndDate && iEndDate<range[1]))
                {
                    return false;
                }
            }
            DateTime[] tRange = new DateTime[2];
            tRange[0] = iStatDate;
            tRange[1] = iEndDate;
            bookedDays.Add(tRange);
            return true;
        }
    }
}
