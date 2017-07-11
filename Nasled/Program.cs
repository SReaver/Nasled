using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasled
{
    class Program
    {
        static void Main(string[] args)
        {
            Flash flash = new Flash();
            flash.Name = "King";
            flash.Model = "4GB";
            flash.Memory = 4000;
        }
    }
}
