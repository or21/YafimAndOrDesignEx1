//-----------------------------------------------------------------------
// <copyright file="TopLikeablePictureForm.cs" company="A16_Ex01">
// Yafim Vodkov 308973882 Or Brand id 302521034
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using FacebookWrapper.ObjectModel;
using Utils;

namespace AppUI
{
    /// <summary>
    /// Get the N likeable pictures you have on facebook.
    /// </summary>
    public partial class MostLikeablePictureForm : FbForm
    {
        private Photo m_CurrentImageDisplayed;
        /// <summary>
        /// Number of pictures 
        /// </summary>
        private readonly int m_NumberOfPicturesToShow;

        /// <summary>
        /// List of the top N pictures
        /// </summary>
        private readonly List<Photo> m_TopLikeablePhotos;

        /// <summary>
        /// Current image index
        /// </summary>
        private int m_IndexOfCurrentImage;

        /// <summary>
        /// Instance of Util class
        /// </summary>
        private Utils.Utils m_Util;

        /// <summary>
        /// Initializes a new instance of the MostLikeablePictureForm class.
        /// </summary>
        /// <param name="i_TopLikeablePhotos">Top likeable pictures</param>
        public MostLikeablePictureForm(List<Photo> i_TopLikeablePhotos, int iNumberOfPicturesToShow)
        {
            InitializeComponent();

            pictureBoxCurrentPic.LoadCompleted += pictureBoxCurrentPic_LoadCompleted;


            m_TopLikeablePhotos = i_TopLikeablePhotos;
            m_IndexOfCurrentImage = 0;

            m_NumberOfPicturesToShow = iNumberOfPicturesToShow;

            m_Util = Utils.Utils.Instance;
        }

        /// <summary>
        /// Close form
        /// </summary>
        /// <param name="i_Sender">Object sender</param>
        /// <param name="i_Event">The event</param>
        private void buttonExit_Click(object i_Sender, EventArgs i_Event)
        {
            this.Close();
        }

        /// <summary>
        /// Get the most likeable picture
        /// </summary>
        /// <param name="i_Sender">Object sender</param>
        /// <param name="i_Event">The event</param>
        private void buttonTopPicture_Click(object i_Sender, EventArgs i_Event)
        {
            m_IndexOfCurrentImage = 0;
            loadImage(m_TopLikeablePhotos[m_IndexOfCurrentImage]);
        }

        /// <summary>
        /// Next picture
        /// </summary>
        /// <param name="i_Sender">Object sender</param>
        /// <param name="i_Event">The event</param>
        private void buttonNext_Click(object i_Sender, EventArgs i_Event)
        {
            m_IndexOfCurrentImage = m_Util.SetNextImage(m_IndexOfCurrentImage ,m_NumberOfPicturesToShow);
            loadImage(m_TopLikeablePhotos[m_IndexOfCurrentImage]);
        }

        /// <summary>
        /// Previous picture
        /// </summary>
        /// <param name="i_Sender">Object sender</param>
        /// <param name="i_Event">The event</param>
        private void buttonBack_Click(object i_Sender, EventArgs i_Event)
        {
            m_IndexOfCurrentImage = m_Util.SetPrevImage(m_IndexOfCurrentImage, m_NumberOfPicturesToShow);
            loadImage(m_TopLikeablePhotos[m_IndexOfCurrentImage]);
        }

        /// <summary>
        /// Set number of likes
        /// </summary>
        /// <param name="i_Photo">Current photo</param>
        private void setNumberOfLikes(Photo i_Photo)
        {
            labelNumberOfLikes.Text = string.Format("{0} Likes", i_Photo.LikedBy.Count);
        }

        /// <summary>
        /// Load image to display
        /// </summary>
        /// <param name="i_ImageToLoad">Image to load</param>
        private void loadImage(Photo i_ImageToLoad)
        {
            m_CurrentImageDisplayed = i_ImageToLoad; 
            pictureBoxCurrentPic.LoadAsync(i_ImageToLoad.PictureNormalURL);
        }

        public void pictureBoxCurrentPic_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            setNumberOfLikes(m_CurrentImageDisplayed);
        }

        
    }
}
