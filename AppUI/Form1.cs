using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Utils;

namespace AppUI
{
    // Test comment to commit and push
    public partial class Form1 : FbForm
    {
        private const string k_StartPost = "What's on your mind...";
        private const string k_NoEventYet = "No Events yet";
        private const string k_NoLikes = "You don't like any page";
        private const string k_NoCheckIns = "You didn't do any check in";
        private const string k_NoPostsToRetrieve = "No Posts to retrieve :(";
        private readonly User r_LoggedInUser;
        private List<Photo> m_ListOfPhotos;
        private List<Photo> m_TopLikeablePhotos; 

        public Form1(LoginResult i_UserData)
        {
            InitializeComponent();
            r_LoggedInUser = i_UserData.LoggedInUser;
            FacebookService.s_CollectionLimit = 1000;
            fetchUserInfo();
        }

        private void textBoxPost_TextChanged(object i_Sender, EventArgs i_E)
        {

        }

        private void textBoxPost_Click(object i_Sender, EventArgs i_E)
        {
            textBoxPost.Clear();
            textBoxPost.ForeColor = Color.Black;
        }

        private void pictureBoxProfile_Click(object i_Sender, EventArgs i_E)
        {

        }

        private void listBoxEvents_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            
        }

        private void fetchEvents()
        {
            listBoxEvents.HorizontalScrollbar = true;
            listBoxEvents.DisplayMember = "Name";
            foreach (Event fbEvent in r_LoggedInUser.Events)
            {
                listBoxEvents.Items.Add(fbEvent);
            }

            if (r_LoggedInUser.Events.Count == 0)
            {
                MessageBox.Show(k_NoEventYet);
            }
        }

        private void fetchUserInfo()
        {
            textBoxPost.Text = k_StartPost;
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
            foreach (Page fbPage in r_LoggedInUser.LikedPages)
            {
                listBoxPages.Items.Add(fbPage);
            }

            if (r_LoggedInUser.LikedPages.Count == 0)
            {
                MessageBox.Show(k_NoLikes);
            }
        }

        private void fetchCheckIn()
        {
            listBoxCheckIn.HorizontalScrollbar = true;
            listBoxCheckIn.DisplayMember = "Message";
            foreach (Checkin fbCheckin in r_LoggedInUser.Checkins)
            {
                listBoxCheckIn.Items.Add(fbCheckin);
            }

            if (r_LoggedInUser.Checkins.Count == 0)
            {
                MessageBox.Show(k_NoCheckIns);
            }
        }

        private void fetchPhotos()
        {
            //TODO: Singleton... 
            m_ListOfPhotos = new List<Photo>();
            m_TopLikeablePhotos = new List<Photo>();

            foreach (Album album in r_LoggedInUser.Albums)
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
            foreach (Post post in r_LoggedInUser.Posts)
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

            if (r_LoggedInUser.Posts.Count == 0)
            {
                MessageBox.Show(k_NoPostsToRetrieve);
            }
        }

        private void fetchUserData()
        {
            listBoxProfie.HorizontalScrollbar = true;
            pictureBoxProfile.LoadAsync(r_LoggedInUser.PictureNormalURL);
            listBoxProfie.Items.Add("Birthday: " + r_LoggedInUser.Birthday);
            listBoxProfie.Items.Add("Gender: " + r_LoggedInUser.Gender);
            listBoxProfie.Items.Add("Hometown: " + r_LoggedInUser.Hometown.Name);
            listBoxProfie.Items.Add("Email: " + r_LoggedInUser.Email);
            listBoxProfie.Items.Add("Languages: " + r_LoggedInUser.Languages);
        }

        private void listBoxProfie_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {

        }

        private void listBoxFeed_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {

        }

        private void buttonPost_Click(object i_Sender, EventArgs i_E)
        {
            Status postedStatus = r_LoggedInUser.PostStatus(textBoxPost.Text);
            MessageBox.Show(string.Format(@"Status: {0} Posted", postedStatus.Message));
        }

        private void buttonLogout_Click(object i_Sender, EventArgs i_E)
        {
            Application.Exit();
        }

        private void listBoxGroups_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {

        }

        /// <summary>
        /// Sort list of photos by number of likes 
        /// </summary>
        private void sortPhotosByDescendingOrder()
        {
            m_ListOfPhotos.Sort((i_NumberOfLikesPhotoOne, i_NumberOfLikesPhotoTwo) =>
                i_NumberOfLikesPhotoOne.LikedBy.Count().CompareTo(i_NumberOfLikesPhotoTwo.LikedBy.Count()));
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

        private void buttonFeature1_Click(object i_Sender, EventArgs i_E)
        {
            fetchPhotos();
            sortPhotosByDescendingOrder();

            //TODO: Define general field by guy's guide... (private int readonly _NumberOfMostLikeablePictures = 5)
            getMostLikeablePictures(5);
            createTopLikeablePictureForm();
        }

        /// <summary>
        /// Creates new top likeable pictures.
        /// </summary>
        private void createTopLikeablePictureForm()
        {
            TopLikeablePictureForm likeablePictureForm = new TopLikeablePictureForm(m_TopLikeablePhotos);
            likeablePictureForm.ShowDialog();
        }

        private void listBoxPages_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {

        }

        private void Form1_Load(object i_Sender, EventArgs i_E)
        {

        }

        private void buttonFeature2_Click(object sender, EventArgs e)
        {
            WhoWasBornOnMyBirthdayForm whoWasBornOnMyBirthdayForm = new WhoWasBornOnMyBirthdayForm(r_LoggedInUser.Birthday);
            whoWasBornOnMyBirthdayForm.ShowDialog();
        }
    }
}
