using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            String numMacchina = "42303";
            String codAzienda = "Azienda1";
            String a = "https://libellula.kepler186.org/remote.php/webdav/";
            String newWebDav = a + codAzienda + "/"+ numMacchina + "/";
            Console.WriteLine(newWebDav);




        }
    }
}
