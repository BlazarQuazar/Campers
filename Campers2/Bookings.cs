using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Campers2
{
    class Bookings
    {
        List<string[]> bookings = new List<string[]>();
        private static object locker = new object();

        public Bookings()
        {
            this.LoadAllBookingsFromFile();
            if (bookings.Count() > 0)
            {
                this.DeleteHistoricalDays();
            }
            
        }

        private void SaveAllBookingsToFile()
        {
            // try to lock locker, if already locked return exception
            try
            {
                lock (locker)
                {
                    using (StreamWriter sr = new StreamWriter("Bookings.txt"))
                        try
                        {
                            if (bookings.Count().Equals(0))
                            {
                                sr.Flush();
                            }
                            else
                            {
                                string saveString = string.Empty;

                                foreach (string[] booking in bookings)
                                {
                                    saveString += booking[0] + "\t" + booking[1] + "\t";
                                    saveString += booking[2] + "\t" + booking[3] + "\n";
                                }
                                sr.WriteLine(saveString.TrimEnd());
                            }

                            
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void LoadAllBookingsFromFile()
        {
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

            foreach (string[] booking in bookings)
            {
                for (int i = 0; i < booking.Count(); i++)
                {
                    booking[i] = booking[i].Trim();
                }
            }
        }

        public DateTime[] ReturnBookedDatesForVanName(string iVanName)
        {
            List<DateTime> tBookedDates = new List<DateTime>();
            foreach (string[] booking in bookings)
            {
                if (booking[0].Equals(iVanName))
                {
                    DateTime startDate = Convert.ToDateTime(booking[2]).Date;
                    DateTime endDate = Convert.ToDateTime(booking[3]).Date;
                    int days = (endDate - startDate).Days;

                    for (int i = 0; i <= days; i++)
                    {
                        tBookedDates.Add(startDate.AddDays(i));
                    }
                }
            }

            return tBookedDates.ToArray();
        }

        public void AddBooking(string iVanName, string iUser, DateTime iStartDate, DateTime iEndDate)
        {
            // at this stage availibility would have been checked, need van, booking & user
            string[] tBooking = new string[4];
            tBooking[0] = iVanName;
            tBooking[1] = iUser;
            tBooking[2] = iStartDate.Date.ToString();
            tBooking[3] = iEndDate.Date.ToString();
            bookings.Add(tBooking);

            // Save bookings
            this.SaveAllBookingsToFile();
            this.LoadAllBookingsFromFile();
        }

        public void DeleteBooking(string iVanName, string iUser, DateTime iStartDate, DateTime iEndDate)
        {
            string iBooking = iVanName + iUser + iStartDate.Date.ToString() + iEndDate.Date.ToString();
            string[] tempBooking = new string[4];

            foreach(string[] booking in bookings)
            {
                string bookString = booking[0] + booking[1] + booking[2] + booking[3];

                if (bookString.Equals(iBooking))
                {
                    tempBooking = booking;
                }
            }

            bookings.Remove(tempBooking);

            this.SaveAllBookingsToFile();
            this.LoadAllBookingsFromFile();

            /*
            string[] iBooking = new string[4];
            iBooking[0] = iVanName;
            iBooking[1] = iUser;
            iBooking[2] = iStartDate.Date.ToString();
            iBooking[3] = iEndDate.Date.ToString();

            foreach (string[] booking in bookings)
            {
                if (booking.Equals(iBooking))
                {
                    bookings.Remove(iBooking);

                    SaveAllBookingsToFile();
                    LoadAllBookingsFromFile();
                }
            }
            */
        }

        public string[] RetrunBookingDetailsForVanAndDate(string iVanName, DateTime iDate)
        {
            foreach (string[] booking in bookings)
            {

                bool dateIsBetween = this.IsBetweenTwoDate(iDate, booking[2], booking[3]);

                if (booking[0].Equals(iVanName) && dateIsBetween)
                {
                    return booking;
                }
            }
            return new string[4];
        }

        private void DeleteHistoricalDays()
        {
            // after adding the flush to save bookings this if can be removed
            if (bookings[0][0] != "")
            {
                foreach (string[] booking in bookings)
                {
                    if (this.IsBetweenTwoDate(DateTime.Now.Date, booking[2], booking[3]))
                    {
                        if (DateTime.Now.Date > Convert.ToDateTime(booking[3]).Date)
                        {
                            bookings.Remove(booking);
                        }
                        else
                        {
                            booking[2] = DateTime.Now.Date.ToString();
                        }
                    }
                }

                this.SaveAllBookingsToFile();
                this.LoadAllBookingsFromFile();

            }
        }

        private bool IsBetweenTwoDate(DateTime iDate, string iStartDate, string iEndDate)
        {
            DateTime startDate = Convert.ToDateTime(iStartDate).Date;
            DateTime endDate = Convert.ToDateTime(iEndDate).Date;

            return iDate.Date >= startDate && iDate.Date <= endDate;
        }

        public bool DoesBookingExist(string iVanName, string iUser, DateTime iStartDate, DateTime iEndDate)
        {
            string bookCheck = iVanName + iUser + iStartDate.Date.ToString() + iEndDate.Date.ToString();

            foreach(string[]booking in bookings)
            {
                string bookString = booking[0] + booking[1] + booking[2] + booking[3];
                if (bookString.Equals(bookCheck))
                {
                    return true;
                }
            }
            return false;
            
            
            /*
            string[] bookCheck = new string[4];
            bookCheck[0] = iVanName;
            bookCheck[1] = iUser;
            bookCheck[2] = iStartDate.Date.ToString();
            bookCheck[3] = iEndDate.Date.ToString();

            foreach(string[] booking in bookings)
            {
                for(int i = 0; i < 4; i++)
                {
                    if (booking[i] != bookCheck[i])
                    {
                        i = 4;
                    }
                    else
                    {
                        if (i == 3)
                        {
                            return true;
                        }
                    }
                }

            }
            return false;

            if (bookings.Contains(bookCheck))
            {
                return true;
            }
            else
            {
                return false;
            }
            */
        }

        public bool TwoOrMoreBookings(string iUser)
        {
            if (bookings.Count().Equals(0) || bookings[0][0].Equals(""))
            {
                return false;
            }

            int numberOfBooings = bookings.Where(x => x[1].Equals(iUser)).Count();
            if(numberOfBooings >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ReturnVanNameFromBookedUser(string iUser)
        {
            try
            {
                if (bookings.Where(x => x[1].Equals(iUser)).Count() > 0)
                {
                    string[] currentBook = bookings.First(x => x[1].Equals(iUser));
                    return currentBook[0];
                }
                else
                {
                    return string.Empty;
                }
            }
            catch
            {
                return string.Empty;
            }

            
        }

        public void ChangeBookingsVanName(string iOrigVanName, string iNewVanName)
        {
            if (iOrigVanName.Equals(iNewVanName))
            {
                return;
            }

            foreach (string[] booking in bookings)
            {
                if (booking[0].Equals(iOrigVanName))
                {
                    booking[0] = iNewVanName;
                }
            }

            this.SaveAllBookingsToFile();
            this.LoadAllBookingsFromFile();
        }

        public bool DoesVanHaveBookings(string iVanName)
        {
            foreach(string[] booking in bookings)
            {
                if (booking[0].Equals(iVanName))
                {
                    return true;
                }
            }

            return false;
        }

    }
}
