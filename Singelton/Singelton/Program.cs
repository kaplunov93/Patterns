using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singelton
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    /// <summary>
    /// Singelton class
    /// </summary>
    sealed class MySingelton
    {
        private MySingelton() { }
        private static MySingelton single = new MySingelton();

        /// <summary>
        /// method give reference to MySingelton object
        /// </summary>
        /// <returns>MySingelton</returns>
        public static MySingelton GetRef() { return single; }

        public string FirstName, LastName;
    }
}
