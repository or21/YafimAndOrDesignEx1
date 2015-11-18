using System;
using System.IO;
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
            Application.Run(new LoginForm());
            Form currentForm = new LoginForm();

            //TODO: Delete. for fast debug only
            //WhoWasBornOnMyBirthdayForm currentForm = new WhoWasBornOnMyBirthdayForm("12/10/1989");
           
            try
            {
                /*currentForm.ShowDialog();*/
                Application.Run(new LoginForm());
            }
            catch (FormatException bfe)
            {
                MessageBox.Show(bfe.Message);
            }
            catch (FileNotFoundException fnf)
            {
                MessageBox.Show(fnf.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                //Application.Exit();
                
            }
        }
    }
}
