using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cseveges2/*.Resources*/
{
    internal class Class1
    {

        private string kezdet;
        private string veg;
        private string kezdemenyezo;
        private string fogado;
 

        public Class1(string sor)
        {
            string[] d = sor.Split(';');


            kezdet = d[0];
            veg = d[1];
            kezdemenyezo = d[2];
            fogado = d[3];

        }

        public string Kezdet { get => kezdet; set => kezdet = value; }
        public string Veg { get => veg; set => veg = value; }
        public string Kezdemenyezo { get => kezdemenyezo; set => kezdemenyezo = value; }
        public string Fogado { get => fogado; set => fogado = value; }

    }
}