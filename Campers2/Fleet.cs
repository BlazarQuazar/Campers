using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Campers2
{
    class Fleet
    {
        private List<Van> vansInFleet; 
        private Bookings bookings = new Bookings();
        private object locker = new object();

        public Fleet()
        {
            this.LoadAllVansFromFile();            
        }

        public void LoadAllVansFromFile()
        {
            vansInFleet = new List<Van>();

            try
            {
                using (StreamReader sr = new StreamReader("VanInfo.txt"))
                    while (sr.Peek() >= 0)
                    {
                        string[] vanInfo = sr.ReadLine().Split('\t');
                        vansInFleet.Add(new Van(vanInfo));
                    }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void SaveAllVansToFile()
        {
            vansInFleet = vansInFleet.OrderBy(x => x.name).ToList();
            try
            {
                lock (locker)
                {
                    using (StreamWriter sr = new StreamWriter("VanInfo.txt"))
                        try
                        {
                            if (vansInFleet.Count().Equals(0))
                            {
                                sr.Flush();
                            }
                            else
                            {
                                string saveString = string.Empty;

                                foreach (Van van in vansInFleet)
                                {
                                    saveString += van.RetrunVanInfoString();
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

        public string[] RetrunAllVanNames()
        {
            string[] oVanNames = new string[vansInFleet.Count()];

            for (int i = 0; i<vansInFleet.Count(); i++)
            {
                oVanNames[i] = vansInFleet[i].RetrunName();
            }
            return oVanNames;
        }

        public string VanNameFromIndex(int iIndex)
        {
            return vansInFleet[iIndex].RetrunName();
        }

        public void AddBooking(int iVanIndex, string iUser, DateTime iStatrtDate, DateTime iEndDate)
        {
            string oVanName = this.VanNameFromIndex(iVanIndex);
            bookings.AddBooking(oVanName, iUser, iStatrtDate, iEndDate);
        }

        public void DeleteBooking(int iVanIndex, string iUser, DateTime iStatrtDate, DateTime iEndDate)
        {
            string oVanName = this.VanNameFromIndex(iVanIndex);
            bookings.DeleteBooking(oVanName, iUser, iStatrtDate, iEndDate);
        }

        public void DeleteBookingWithVanName(string iVanName,  string iUser, DateTime iStatrtDate, DateTime iEndDate)
        {
            bookings.DeleteBooking(iVanName, iUser, iStatrtDate, iEndDate);
        }

        public DateTime[] ReturnBookedDaysByVanIndex(int iVanIndex)
        {
            string oVanName = this.VanNameFromIndex(iVanIndex);
            return bookings.ReturnBookedDatesForVanName(oVanName);
        }

        public string[] ReturnBookingWithVanIndexAndDate(int iVanIndex, DateTime iDate)
        {
            string oVanName = this.VanNameFromIndex(iVanIndex);
            return bookings.RetrunBookingDetailsForVanAndDate(oVanName, iDate);
        }

        public bool DoesBookingExist(int iVanIndex, string iUser, DateTime iStartDate, DateTime iEndDate)
        {
            string oVanName = this.VanNameFromIndex(iVanIndex);
            return bookings.DoesBookingExist(oVanName, iUser, iStartDate, iEndDate);
        }

        public bool UserHasTwoOrMoreBookings(string iUser)
        {
            return bookings.TwoOrMoreBookings(iUser);
        }

        public string ReturnVanNameFromUserBooked(string iUser)
        {
            return bookings.ReturnVanNameFromBookedUser(iUser);
        }

        public string ReturnVanInfoFromIndex(int iVanIndex)
        {
            return vansInFleet[iVanIndex].RetrunVanInfoString();
        }

        public int RetrunNumberOfVansInFleet()
        {
            return vansInFleet.Count();
        }

        public void AddVan(string iVanName, string iRegistraion, int iMaxPeople)
        {
            try
            {
                lock (locker)
                {
                    using (StreamWriter sr = new StreamWriter("VanInfo.txt"))
                        try
                        {
                            

                            if (vansInFleet.Count().Equals(0))
                            {
                                sr.Write(iVanName + "\t" + iRegistraion + "\t" + iMaxPeople.ToString());
                            }
                            else
                            {
                                string saveString = string.Empty;

                                foreach (Van van in vansInFleet)
                                {
                                    saveString += van.RetrunVanInfoString();
                                }
                                saveString += iVanName + "\t" + iRegistraion + "\t" + iMaxPeople.ToString();
                                sr.Write(saveString.TrimEnd());
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

            this.LoadAllVansFromFile();
        }

        public void DeleteVan(int iVanIndex)
        {
            vansInFleet.RemoveAt(iVanIndex);
            this.SaveAllVansToFile();
            this.LoadAllVansFromFile();
        }

        public void AmendVan(int iVanIndex, string iVanName, string iRegistration, int iMaxPeople)
        {
            vansInFleet[iVanIndex].AmendVanDetails(iVanName, iRegistration, iMaxPeople);
            this.SaveAllVansToFile();
            this.LoadAllVansFromFile();
        }

        public bool ContainsVan(string iVanName, string iRegistration)
        {
            foreach (Van tVan in vansInFleet)
            {
                if(tVan.RetrunName().Equals(iVanName) || tVan.ReturnVanRegistration().Equals(iRegistration))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
