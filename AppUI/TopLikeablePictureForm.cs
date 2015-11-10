﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace AppUI
{
    public partial class TopLikeablePictureForm : Form
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTopPicture_Click(object sender, EventArgs e)
        {
            m_IndexOfCurrentImage = 0;
            loadImage(m_TopLikeablePhotos[m_IndexOfCurrentImage]);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            setNextImage();
        }

        private void buttonBack_Click(object sender, EventArgs e)
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
            labelNumberOfLikes.Text = i_Photo.LikedBy.Count.ToString();
        }

        private void loadImage(Photo i_ImageToLoad)
        {
            pictureBoxCurrentPic.LoadAsync(i_ImageToLoad.PictureThumbURL);
            setNumberOfLikes(i_ImageToLoad);
        }

    }
}
