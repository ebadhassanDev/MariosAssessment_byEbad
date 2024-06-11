using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MariosAssessment_byEbad
{
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
            var connection = ConfigurationManager.ConnectionStrings["ConnectionStrings:DefaultConnection"].ConnectionString;
            Application.Run(new Customer());
        }
    }
}
