using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campers2
{
    class Van
    {
        public string name = string.Empty;
        private string registration = string.Empty;
        private int MaxNumberOfOccupants = 0;

        public Van(string[] iVanInfo)
        {
            this.name = iVanInfo[0].Trim();
            this.registration = iVanInfo[1].Trim();
            this.MaxNumberOfOccupants = Convert.ToInt32(iVanInfo[2].Trim());
        }

        public string RetrunName()
        {
            return this.name;
        }

        public string RetrunVanInfoString()
        {
            return this.name + "\t" + this.registration + "\t" + this.MaxNumberOfOccupants + "\n";
        }

        public void AmendVanDetails(string iVanName, string iRegistration, int iMaxPeople)
        {
            this.name = iVanName;
            this.registration = iRegistration;
            this.MaxNumberOfOccupants = iMaxPeople;
        }

        public string ReturnVanRegistration()
        {
            return this.registration;
        }
            

    }
}
