using System;
using System.Windows.Forms;
using FacebookWrapper;
using Utils;

namespace AppUI
{
    public partial class LoginForm : FbForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void fbBlueButtonLogin_Click(object i_Sender, EventArgs i_E)
        {
            LoginResult result = FacebookService.Login(
                "904603836301816", 
                "user_friends", 
                "email", 
                "user_likes", 
                "publish_actions", 
                "user_posts",
                "public_profile", 
                "user_events", 
                "user_about_me", 
                "user_birthday", 
                "user_hometown", 
                "user_photos");

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                Form appUi = new MainWindow(result);
                appUi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }
    }
}
