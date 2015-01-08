using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace BiblioConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessManager bm = new BusinessManager();
            bm.methodeTest();
        }
    }
}
