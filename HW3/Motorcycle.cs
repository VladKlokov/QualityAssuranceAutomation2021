using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Motorcycle : TransportEntity
    {
        public int TimesAlmostDied { get; }
        // Х Р У С Т
        public Motorcycle(double engineDisplacement, string transmission, double maxSpeed, int timesAlmostDied) 
            : base(engineDisplacement, transmission, maxSpeed)
        {
            TimesAlmostDied = timesAlmostDied;
        }
        override public string GetFullInfo()
        {
            StringBuilder fullInfo = new StringBuilder(base.GetFullInfo());
            #region Times almost died info
            fullInfo.Append("Almost died ");
            fullInfo.Append(TimesAlmostDied.ToString());
            fullInfo.Append(" times");
            fullInfo.Append(".\n");
            #endregion
            return fullInfo.ToString();
        }
    }
}
