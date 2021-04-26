using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class TransportDepot
    {
        public TransportEntity[] contents {get;}
        public void DisplayInfo()
        {
            foreach (TransportEntity entity in contents)
            {
                Console.WriteLine(entity.GetFullInfo());
            }
        }
        public TransportDepot(TransportEntity[] entries)
        {
            contents = entries;
        }
        //TODO: come back after learning about lists
        //public TransportDepot()
        //{
        //    contents = TransportEntity[0];
        //}
        //public void AddEntry(TransportEntity entry)
        //{

        //}
    }
}
