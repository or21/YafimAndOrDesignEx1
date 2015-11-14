using System;
using System.Windows.Forms;
using AppUI;

namespace LoginForm
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //TODO: LoginForm should be inside AppUI class then remove folder JSONFile in LoginForm project.
          //  Application.Run(new WhoWasBornOnMyBirthdayForm("27/12/1989"));
        //    Application.Run(new FormTest("12/27/1989"));
        }
    }
}
