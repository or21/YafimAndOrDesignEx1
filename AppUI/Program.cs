using System;
using System.Windows.Forms;

namespace AppUI
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new LoginForm());
        //    Form currentForm = new LoginForm();
            //TODO: Delete. for fast debug only
            WhoWasBornOnMyBirthdayForm currentForm = new WhoWasBornOnMyBirthdayForm("12/10/1989");
            try
            {
                currentForm.ShowDialog();
            }
            catch (Exception e)
            {
                currentForm.Close();
            }
        }
    }
}
