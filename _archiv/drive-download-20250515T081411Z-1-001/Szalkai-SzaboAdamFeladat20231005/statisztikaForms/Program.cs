using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statisztikaForms
{

    class stat
    {
        public string jatekos;
        public string elsodobas;
        public string masodikdobas;
        public string harmadikdobas;


        public stat(string sor)
        {
            string[] szet = sor.Split(';');

            this.jatekos = szet[0];
            this.elsodobas = szet[1];
            this.masodikdobas = szet[2];
            this.harmadikdobas = szet[3];


        }

    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Screen());
        }
    }
}
