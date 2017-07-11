using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasled
{
    abstract class Storage
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
        public abstract void Copy();
        public abstract double getFreeMemory();
        public abstract void CopyInfo();
    }
}
