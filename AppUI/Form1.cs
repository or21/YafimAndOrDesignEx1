using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
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
        private const string k_WaitMessage = "This may take few seconds... Please click OK";
        private readonly User r_LoggedInUser;
        private List<Photo> m_ListOfPhotos;
        private List<Photo> m_TopLikeablePhotos;
        private List<Thread> m_Threads; 

        public Form1(LoginResult i_UserData)
        {
            InitializeComponent();
            r_LoggedInUser = i_UserData.LoggedInUser;
            FacebookService.s_CollectionLimit = 1000;
            fetchUserInfo();
        }

        private void textBoxPost_Click(object i_Sender, EventArgs i_E)
        {
            textBoxPost.Clear();
            textBoxPost.ForeColor = Color.Black;
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
            m_Threads = new List<Thread>();

            Thread threadPhotos = new Thread(fetchPhotos);
            m_Threads.Add(threadPhotos);
            threadPhotos.Start();
            
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
            m_ListOfPhotos = new List<Photo>();
            foreach (Album album in r_LoggedInUser.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    m_ListOfPhotos.Add(photo);
                }
            }

            findMostLikablePhotos(5);
        }

        private void findMostLikablePhotos(int i_AmountOfPhotosToShow)
        {
            //TODO: Singleton... 
            m_TopLikeablePhotos = new List<Photo>(i_AmountOfPhotosToShow);
            Photo minPhoto = new Photo();

            foreach (Photo photo in m_ListOfPhotos)
            {
                if (m_TopLikeablePhotos.Count != m_TopLikeablePhotos.Capacity)
                {
                    m_TopLikeablePhotos.Add(photo);
                    minPhoto = findMinInTopLikable();
                }
                else
                {
                    if (photo.LikedBy.Count >= minPhoto.LikedBy.Count)
                    {
                        addPhotoToList(photo, ref minPhoto);
                    }
                }
            }
            //TODO: no photos to show
        }

        private void addPhotoToList(Photo i_Photo, ref Photo i_MinPhoto)
        {
            m_TopLikeablePhotos.Remove(i_MinPhoto);
            m_TopLikeablePhotos.Add(i_Photo);
            i_MinPhoto = findMinInTopLikable();
        }

        private Photo findMinInTopLikable()
        {
            Photo minPhoto = m_TopLikeablePhotos[0];

            foreach (Photo photo in m_TopLikeablePhotos)
            {
                if (photo.LikedBy.Count <= minPhoto.LikedBy.Count)
                {
                    minPhoto = photo;
                }
            }

            return minPhoto;
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
            // TODO: check for null
            listBoxProfie.HorizontalScrollbar = true;
            pictureBoxProfile.LoadAsync(r_LoggedInUser.PictureNormalURL);
            listBoxProfie.Items.Add("Birthday: " + r_LoggedInUser.Birthday);
            listBoxProfie.Items.Add("Gender: " + r_LoggedInUser.Gender);
            listBoxProfie.Items.Add("Hometown: " + r_LoggedInUser.Hometown.Name);
            listBoxProfie.Items.Add("Email: " + r_LoggedInUser.Email);
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

        /// <summary>
        /// Sort list of photos by number of likes 
        /// </summary>
        private void sortPhotosByDescendingOrder()
        {
            m_TopLikeablePhotos.Sort((i_NumberOfLikesPhotoOne, i_NumberOfLikesPhotoTwo) =>
                i_NumberOfLikesPhotoOne.LikedBy.Count().CompareTo(i_NumberOfLikesPhotoTwo.LikedBy.Count()));
            m_TopLikeablePhotos.Reverse();
        }

        private void buttonTopLikeablePhotos_Click(object i_Sender, EventArgs i_E)
        {
            MessageBox.Show(k_WaitMessage);
            int width = 0;
            int height = 0;

            //TODO: Define general field by guy's guide... (private int readonly _NumberOfMostLikeablePictures = 5)
            foreach (Thread thread in m_Threads)
            {
                thread.Join();
            }

            sortPhotosByDescendingOrder();
            getWidthAndHeight(ref width, ref height);
            createTopLikeablePictureForm(width, height);
        }

        private void getWidthAndHeight(ref int i_Width, ref int i_Height)
        {
            foreach (Photo photo in m_TopLikeablePhotos)
            {
                if (photo.Width > i_Width)
                {
                    i_Width = (int)photo.Width;
                }

                if (photo.Height > i_Height)
                {
                    i_Height = (int)photo.Height;
                }
            }
        }

        /// <summary>
        /// Creates new top likeable pictures.
        /// </summary>
        private void createTopLikeablePictureForm(int i_Width, int i_Height)
        {
            TopLikeablePictureForm likeablePictureForm = new TopLikeablePictureForm(m_TopLikeablePhotos)
            {
                Size = new Size(i_Width, i_Height + 35),
                StartPosition = FormStartPosition.CenterScreen
            };
            likeablePictureForm.ShowDialog();
        }

        private void buttonGetCelebsBD_Click(object i_Sender, EventArgs i_E)
        {
            WhoWasBornOnMyBirthdayForm whoWasBornOnMyBirthdayForm = new WhoWasBornOnMyBirthdayForm(r_LoggedInUser.Birthday);
            whoWasBornOnMyBirthdayForm.ShowDialog();
        }
    }
}
