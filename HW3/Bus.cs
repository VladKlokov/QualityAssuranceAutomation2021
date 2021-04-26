using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Bus : TransportEntity
    /*
     * безрельсовое механическое моторное транспортное средство, технически предназначенное для перевозки девяти и более пассажиров
     * и способное маневрировать на дороге, приводимое в движение источником энергии, запасённым или производимым из топлива, 
     * хранящегося на борту
     */
    {
        public string Driver { get; }
        public Bus(double engineDisplacement, string transmission, double maxSpeed, string driver) : base(engineDisplacement, transmission, maxSpeed)
        {
            Driver = driver;
        }
        override public string GetFullInfo()
        {
            StringBuilder fullInfo = new StringBuilder(base.GetFullInfo());
            #region Driver info
            fullInfo.Append("Driver is ");
            fullInfo.Append(Driver);
            fullInfo.Append(".\n");
            #endregion
            return fullInfo.ToString();
        }
    }
}
