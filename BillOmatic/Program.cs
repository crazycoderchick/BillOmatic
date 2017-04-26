using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillOmatic.Classes;

namespace BillOmatic
{
    static class Program
    {
        private static ProgramManager programManager;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            programManager = new ProgramManager();
            programManager.loadSavedData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            programManager.start();
        }

      
    }
}
