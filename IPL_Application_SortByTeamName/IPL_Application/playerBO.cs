using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_Application
{
    class playerBO:IComparer<Team>
    {
        public int Compare(Team x, Team y)
        {
            return x.TeamName.CompareTo(y.TeamName);
        }
    }
}
