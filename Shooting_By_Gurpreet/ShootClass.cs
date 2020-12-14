using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooting_By_Gurpreet
{
    public class ShootClass
    {
        public int gpLoad { get; set; }
        public int gpSpin { get; set; }

        public int ShootgpLoop(int gpskip)//for accessing the shoot loop
        {
            if (gpskip == 6)
            {
                gpskip = 1;
            }
            else
            {
                gpskip++;
            }
            return gpskip;
        }
    }
}
