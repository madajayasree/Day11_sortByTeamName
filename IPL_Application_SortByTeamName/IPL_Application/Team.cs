using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_Application
{
    class Team
    {
        string teamName;
        string country;

        public Team()
        {
        }

        public Team(string teamName, string country)
        {
            this.teamName = teamName;
            this.country = country;
        }

        public string TeamName { get => teamName; set => teamName = value; }
        public string Country { get => country; set => country = value; }

        public override string ToString()
        {
            return String.Format("{0} {1} ", teamName, country);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        

    }
}
