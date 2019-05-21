using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Campers
{
    class Bookings
    {
        private List<string[]> bookings = new List<string[]>();

        public Bookings()
        {
            // can use this section as a refresh
            // -----------------------------------------
            bookings.Clear();
            try
            {
                using (StreamReader sr = new StreamReader("Bookings.txt"))

                    while (sr.Peek() >= 0)
                    {
                        string[] booking = new string[4];

                        booking = sr.ReadLine().Split('\t');
                        bookings.Add(booking);
                    }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message);
            }
            // ---------------------------------------
        }

        public void SaveAllBookingsToFile()
        {
            // Save edited booking to file
            try
            {
                using (StreamWriter swBookings = new StreamWriter("Bookings.txt"))
                {
                    for (int i = 0; i < bookings.Count(); i++)
                    {
                        string saveString = bookings[i][0] + "\t" + bookings[i][1] + "\t";
                        saveString += bookings[i][2].ToString() + "\t" + bookings[i][3];
                        swBookings.WriteLine(saveString.TrimEnd('\n'));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("This find could not be read");
                Console.WriteLine(e.Message);
            }
        }

        // from a van name input, return a list of user & booking date, list of list
        public List<string[]> ReturnBookingsForVan(string iVanName)
        {
            List<string[]> oBookings = new List<string[]>();
            string[] oTemp = new string[3];

            foreach (string[] booking in bookings)
            {
                if (booking[0].Trim().Equals(iVanName))
                {
                    oTemp[0] = booking[1].Trim();
                    oTemp[1] = booking[2].Trim();
                    oTemp[3] = booking[3].Trim();
                    oBookings.Add(oTemp);
                }
            }

            return oBookings;
        }

        public void AddToBookings(string iVanName, string iUser, DateTime iStartDate, DateTime iEndDate)
        {
            // at this stage availibility would have been checked, need van, booking & user
            string[] tBooking = new string[4];
            tBooking[0] = iVanName;
            tBooking[1] = iUser;
            tBooking[2] = iStartDate.ToString();
            tBooking[3] = iEndDate.ToString();
            bookings.Add(tBooking);

            // Save bookings
            this.SaveAllBookingsToFile();
        }

        public DateTime[] ReturnBookedDatesFromVanName(string iVanName)
        {
            List<DateTime> tBookedDates = new List<DateTime>();
            foreach (string[] booking in bookings)
            {
                if (booking[0].Equals(iVanName))
                {
                    DateTime startDate = Convert.ToDateTime(booking[2]);
                    DateTime endDate = Convert.ToDateTime(booking[3]);
                    int days = (endDate - startDate).Days;

                    for (int i = 0; i<=days;i++)
                    {
                        tBookedDates.Add(startDate.AddDays(i));
                    }
                }
            }

            return tBookedDates.ToArray();
        }

        /*
        public string[] ReturnBookingThatContainsDate(DateTime iDate)
        {

        }
        */
    }
}
