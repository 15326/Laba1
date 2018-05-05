using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Laba1_1
{
    class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            gun ObjGun = new gun();
            Console.WriteLine(ObjGun);
            gun oobGun = new gun("M16",7.62,1500);
            Console.WriteLine(oobGun);
            Console.ReadKey();
        }
    }
}
