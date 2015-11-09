using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace AppUI
{
    // Test comment to commit and push
    public partial class Form1 : Form
    {

        User m_LoggedInUser;

        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void fetchEvents()
        {
            listBoxEvents.DisplayMember = "Name";
            foreach (Event fbEvent in m_LoggedInUser.Events)
            {
                listBoxEvents.Items.Add(fbEvent);
            }

            if (m_LoggedInUser.Events.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void loginAndInit()
        {
            LoginResult result = FacebookService.Login("904603836301816", "user_photos", "public_profile", "user_events", "user_about_me", "user_birthday", "user_hometown");
            
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
            fetchEvents();
            fetchUserData();
        }

        private void fetchUserData()
        {
            pictureBox1.LoadAsync(m_LoggedInUser.PictureNormalURL);
            textBoxPost.Text = "What's on your mind...";
            listBoxProfie.Items.Add("Birthday: " + m_LoggedInUser.Birthday);
            listBoxProfie.Items.Add("Gender: " + m_LoggedInUser.Gender);
            listBoxProfie.Items.Add("Hometown: " + m_LoggedInUser.Hometown);
        }

        private void listBoxProfie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonFeature1_Click(object sender, EventArgs e)
        {
            fetchSomething();
        }

        private void fetchSomething()
        {
        }

    }
}
