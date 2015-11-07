using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookLoginTest
{
    public partial class Form1 : Form
    {
        private User m_LoggedInUser;

        public Form1()
        {
            InitializeComponent();
        }

        private void loginAndInit()
        {
            LoginResult result = FacebookService.Login("904603836301816", "public_profile");


            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void fetchUserInfo()
        {
            textBoxName.Text = m_LoggedInUser.Name;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }
    }
}
