using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasled
{
    public class Flash : Storage
    {
        private double freeSize;

        public Flash(string name, double memory, string model)
        {
            Name = name;
            Model = model;
            Memory = memory;
            freeSize = memory;

            Program.myNositeli.Add(this);
        }

        public override double getMemory() { return Memory; }
        public override void Copy(double infoSize)
        {
            freeSize -= infoSize;
            //return time;
        }
        public override double getFreeMemory() { return freeSize; }
        public override void GetInfo() { }
        public override double CopyInfo(double infoSize)
        {
            return infoSize * (int)speedType.USB3;
        }

       
    }
}
