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
            FacebookWrapper.FacebookService.s_CollectionLimit = 1000;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            listBoxEvents.HorizontalScrollbar = true;
            listBoxEvents.DisplayMember = "Name";
            foreach (Event fbEvent in m_LoggedInUser.Events)
            {
                listBoxEvents.Items.Add(fbEvent);
            }

            if (m_LoggedInUser.Events.Count == 0)
            {
                MessageBox.Show("No Events yet");
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void loginAndInit()
        {
            LoginResult result = FacebookService.Login("904603836301816", "user_friends", "email", "user_likes", "publish_actions", "user_posts", "public_profile", "user_events", "user_about_me", "user_birthday", "user_hometown");

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
            textBoxPost.Text = "What's on your mind...";
            fetchEvents();
            fetchUserData();
            fetchPosts();
            fetchPages();
            fetchCheckIn();
        }

        private void fetchPages()
        {
            listBoxPages.HorizontalScrollbar = true;
            listBoxPages.DisplayMember = "Name";
            foreach (Page fbPage in m_LoggedInUser.LikedPages)
            {
                listBoxPages.Items.Add(fbPage);
            }

            if (m_LoggedInUser.LikedPages.Count == 0)
            {
                MessageBox.Show("You don't like any page");
            }

        }

        private void fetchCheckIn()
        {
            listBoxCheckIn.HorizontalScrollbar = true;
            listBoxCheckIn.DisplayMember = "Message";
            foreach (Checkin fbCheckin in m_LoggedInUser.Checkins)
            {
                listBoxCheckIn.Items.Add(fbCheckin);
            }

            if (m_LoggedInUser.Checkins.Count == 0)
            {
                MessageBox.Show("You didn't do any check in");
            }
        }

        private void fetchPosts()
        {
            listBoxFeed.HorizontalScrollbar = true;
            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxFeed.Items.Add(post.UpdateTime + ": " + post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxFeed.Items.Add(post.UpdateTime + ": " + post.Caption);
                }
                else
                {
                    listBoxFeed.Items.Add(string.Format(post.UpdateTime + ": " + "[{0}]", post.Type));
                }
            }

            if (m_LoggedInUser.Posts.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void fetchUserData()
        {
            listBoxProfie.HorizontalScrollbar = true;
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            listBoxProfie.Items.Add("Birthday: " + m_LoggedInUser.Birthday);
            listBoxProfie.Items.Add("Gender: " + m_LoggedInUser.Gender);
            listBoxProfie.Items.Add("Hometown: " + m_LoggedInUser.Hometown.Name);
            listBoxProfie.Items.Add("Email: " + m_LoggedInUser.Email);
            listBoxProfie.Items.Add("Languages: " + m_LoggedInUser.Languages);
        }

        private void listBoxProfie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            Status postedStatus = m_LoggedInUser.PostStatus(textBoxPost.Text);
            MessageBox.Show("Status: " + postedStatus.Message + " Posted");
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
