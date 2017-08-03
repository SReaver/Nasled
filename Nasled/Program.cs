using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasled
{
   
    class Program
    {
        public static double AllMemory;
        public delegate void MyD();

        public static List<object> myNositeli = new List<object>();
        static void Main(string[] args)
        {
            Flash flash = new Flash("King",4000, "4GB");
            flash.Copy(3456);


            //MyD myD;

            //myD = Program.TestMsg()
            //    ;
            //myD.Invoke();

            Console.WriteLine(flash.CopyInfo(3456)+" "+  flash.getFreeMemory());
            List<double> obj = new List<double>();
            obj.Add(flash.Memory);

            //double tt=0;
            //foreach (var item in obj)
            //{
            //    tt += item;
                
            //}
            //Console.WriteLine(tt);

            foreach (var item in myNositeli)
            {
                listT(item);
            }
          

        }

        public static void TestMsg()
        {
            Console.WriteLine("MSG");
        }
        public static double listT<T>(T someT)
        {
            Type typeT = someT.GetType();
            PropertyInfo[] ppInfo = typeT.GetProperties();
            var tt = ppInfo.SingleOrDefault(w => w.Name == "Memory");

            tt.GetConstantValue();

            return 0;
            }


        }
}
