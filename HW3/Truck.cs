using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Truck : TransportEntity
        //Грузович
    {
        public bool Monster { get; }
        // да, энергетик
        public Truck(double engineDisplacement, string transmission, double maxSpeed, bool _isMonster) : base(engineDisplacement, transmission, maxSpeed)
        {
            Monster = _isMonster;
        }
        override public string GetFullInfo()
        {
            StringBuilder fullInfo = new StringBuilder(base.GetFullInfo());
            #region Monster info
            if (Monster)
            {
                fullInfo.Append("It's a monster truck");
            }
            else
            {
                fullInfo.Append("It's not a monster truck");
            }
            fullInfo.Append(".\n");
            #endregion
            return fullInfo.ToString();
        }
    }
}
