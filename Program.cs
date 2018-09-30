using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    static class Program
    {
        /// <summary>
        /*
         * This Calculator Is Developed By Mohsin Ali Purki
         * GitHub --> github.com/AzaadPurki
         * LinkedIn --> www.linkedin.com/in/mohsin-ali-58a313163
         *
         * For Any Other Queries And Help Contact : azaadpurki@gmail.com
         *  
         *    ___________       _____           _____     ___________       _____       _____    __________________
         *  ____        ___     _____           _____   ____        ___     _____       _____    __________________
         *  ____        ___     _____           _____   ____        ___     _____   _____               _____       
         *  ____       ___      _____           _____   ____       ___      _________                   _____      
         *  ____     ___        _____           _____   ____     ___        _________                   _____
         *  _____ ___           _____           ____    _____ ___           _____   _____               _____
         *  ____                  _____       _____     ____     ___        _____       ______   __________________
         *  ____                      ______            ____        ___     _____       ______   __________________
         *  
         */
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Calculator());
        }
    }
}
