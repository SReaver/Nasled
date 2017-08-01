using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasled
{
   public abstract class Storage
    {
        protected string name;
        protected string model;
        protected double memory;

        public string Name
        {
            set { name = value; }
            get
            {
                return name;
            }
        }
        public string Model
        {
            set { model = value; }
            get
            {
                return model;
            }
        }
        public double Memory
        {
            set { memory = value; }
            get
            {
                return memory;
            }
        }

        public abstract double getMemory();
        public abstract void Copy(double infoSize);
        public abstract double getFreeMemory();
        public abstract double CopyInfo(double infoSize);
        public abstract void GetInfo();
        public enum speedType { USB3=300, USB2=150, USB1=50 };
    }
}
