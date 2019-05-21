using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Campers
{
    class CamperVans
    {
        private List<Van> camperVans = new List<Van>();
        private Bookings bookings = new Bookings();

        public CamperVans()
        {


            try
            {
                using (StreamReader sr = new StreamReader("VanInfo.txt"))


                    while (sr.Peek() >= 0)
                    {
                        string[] vanInfo = sr.ReadLine().Split('\t');
                        camperVans.Add(new Van(vanInfo));
                    }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message);
            }
        }

        public string[] ReturnAllVanNames()
        {
            string[] oCamperVans = new string[camperVans.Count()];

            for (int i = 0; i < camperVans.Count(); i++)
            {
                oCamperVans[i] = camperVans[i].ReturnName();
            }
            return oCamperVans;
        }

        public string ReturnVanNameByIndex(int iIndex)
        {
            return camperVans[iIndex].ReturnName();
        }

        public void addBookedDaysToVans()
        {
            foreach(Van van in camperVans)
            {
                van.AddBookingsForVan(bookings.ReturnBookingsForVan(van.ReturnName()));
            }
        }

        public void SaveBooking(int iVanIndex, string iUser, DateTime iStatrtDate, DateTime iEndDate)
        {
            string vanName = camperVans[iVanIndex].ReturnName();
            bookings.AddToBookings(vanName, iUser, iStatrtDate, iEndDate);
        }

        public DateTime[] ReturnBookedDaysByVanIndex(int iVanIndex)
        {
            string vanName = this.ReturnVanNameByIndex(iVanIndex);
            return bookings.ReturnBookedDatesFromVanName(vanName);
        }
    }
}
