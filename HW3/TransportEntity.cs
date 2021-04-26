using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    abstract class TransportEntity
    {
        public double EngineDisplacement {  get; }
        public string Transmission { get; }
        public double MaxSpeed { get; }
        public TransportEntity(double engineDisplacement, string transmission, double maxSpeed)
        {
            EngineDisplacement = engineDisplacement;
            Transmission = transmission;
            MaxSpeed = maxSpeed;
        }
        virtual public string GetFullInfo()
        {
            StringBuilder fullInfo = new StringBuilder("string value");
            #region Engine displacement info
            fullInfo.Append("Engine displacement is ");
            fullInfo.Append(EngineDisplacement.ToString()) ;
            fullInfo.Append(".\n");
            #endregion
            #region Transmission info
            fullInfo.Append("Transmission is ");
            fullInfo.Append(Transmission.ToString());
            fullInfo.Append(".\n");
            #endregion
            #region Maximum speed info
            fullInfo.Append("Maximum speed is ");
            fullInfo.Append(MaxSpeed.ToString());
            fullInfo.Append(".\n");
            #endregion
            return fullInfo.ToString();
        }
    }
}
