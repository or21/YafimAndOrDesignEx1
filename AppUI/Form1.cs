using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private List<Photo> m_ListOfPhotos;
        private List<Photo> m_TopLikeablePhotos; 

        public Form1()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 1000;
        }

        private void textBoxPost_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPost_Click(object sender, EventArgs e)
        {
            textBoxPost.Clear();
            textBoxPost.ForeColor = Color.Black;
        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
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
            LoginResult result = FacebookService.Login("904603836301816", 
                "user_friends", "email", "user_likes", "publish_actions", "user_posts", "public_profile",
                "user_events", "user_about_me", "user_birthday", "user_hometown", "user_photos");

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
        //    fetchUserData();
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

        private void fetchPhotos()
        {
            //TODO: Singleton... 
            m_ListOfPhotos = new List<Photo>();
            m_TopLikeablePhotos = new List<Photo>();

            foreach (Album album in m_LoggedInUser.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    m_ListOfPhotos.Add(photo);
                }
                
        }
            //TODO: no photos to show
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

        private void listBoxFeed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            Status postedStatus = m_LoggedInUser.PostStatus(textBoxPost.Text);
            MessageBox.Show("Status: " + postedStatus.Message + " Posted");
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Sort list of photos by number of likes 
        /// </summary>
        private void sortPhotosByDescendingOrder()
        {
            m_ListOfPhotos.Sort((p, q) => p.LikedBy.Count().CompareTo(q.LikedBy.Count()));
            m_ListOfPhotos.Reverse();

        }

        /// <summary>
        /// Get top five likeablePictures
        /// </summary>
        private void getMostLikeablePictures(int i_NumberOfPictures)
        {
            foreach (Photo photo in m_ListOfPhotos)
            {
                if (i_NumberOfPictures != 0)
                {
                    m_TopLikeablePhotos.Add(photo);
                    i_NumberOfPictures--;
                }
                else
                {
                    break;
                }
            }
        }

        private void buttonFeature1_Click(object sender, EventArgs e)
        {
            fetchPhotos();
            sortPhotosByDescendingOrder();

            //TODO: Define general field by guy's guide... (private int readonly _NumberOfMostLikeablePictures = 5)
            getMostLikeablePictures(5);
            createTopLikeablePictureForm();
        }

        /// <summary>
        /// Creates new top likeable pictures 
        /// </summary>
        private void createTopLikeablePictureForm()
        {
            TopLikeablePictureForm likeablePictureForm = new TopLikeablePictureForm(m_TopLikeablePhotos);
            likeablePictureForm.ShowDialog();
        }

        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
