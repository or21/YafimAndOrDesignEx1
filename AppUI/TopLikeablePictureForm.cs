//-----------------------------------------------------------------------
// <copyright file="TopLikeablePictureForm.cs" company="A16_Ex01">
// Yafim Vodkov 308973882 Or Brand id 302521034
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using Utils;

namespace AppUI
{
    public partial class TopLikeablePictureForm : FbForm
    {
        private readonly List<Photo> m_TopLikeablePhotos;
        private int m_IndexOfCurrentImage;

        public TopLikeablePictureForm(List<Photo> i_TopLikeablePhotos)
        {
            InitializeComponent();
            m_TopLikeablePhotos = i_TopLikeablePhotos;
            m_IndexOfCurrentImage = 0;
        }

        /// <summary>
        /// Close form
        /// </summary>
        /// <param name="i_Sender"></param>
        /// <param name="i_E"></param>
        private void buttonExit_Click(object i_Sender, EventArgs i_E)
        {
            this.Close();
        }

        private void buttonTopPicture_Click(object i_Sender, EventArgs i_E)
        {
            m_IndexOfCurrentImage = 0;
            loadImage(m_TopLikeablePhotos[m_IndexOfCurrentImage]);
        }

        private void buttonNext_Click(object i_Sender, EventArgs i_E)
        {
            setNextImage();
        }

        private void buttonBack_Click(object i_Sender, EventArgs i_E)
        {
            setPrevImage();
        }

        private void setNextImage()
        {
            m_IndexOfCurrentImage = (m_IndexOfCurrentImage + 1 < m_TopLikeablePhotos.Count) ? m_IndexOfCurrentImage + 1 : 0;
            loadImage(m_TopLikeablePhotos[m_IndexOfCurrentImage]);
        }

        private void setPrevImage()
        {
            m_IndexOfCurrentImage = (m_IndexOfCurrentImage - 1 >= 0) ? m_IndexOfCurrentImage - 1 : m_TopLikeablePhotos.Count - 1;
            loadImage(m_TopLikeablePhotos[m_IndexOfCurrentImage]);
        }

        private void setNumberOfLikes(Photo i_Photo)
        {
            labelNumberOfLikes.Text = string.Format("{0} Likes", i_Photo.LikedBy.Count);
        }

        private void loadImage(Photo i_ImageToLoad)
        {
            pictureBoxCurrentPic.LoadAsync(i_ImageToLoad.PictureNormalURL);
            setNumberOfLikes(i_ImageToLoad);
        }
    }
}
