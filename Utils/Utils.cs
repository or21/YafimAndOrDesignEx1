//-----------------------------------------------------------------------
// <copyright file="Utils.cs" company="A16_Ex01">
// Yafim Vodkov 308973882 Or Brand id 302521034
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using FacebookWrapper.ObjectModel;
using Newtonsoft.Json.Linq;

namespace Utils
{
    /// <summary>
    /// This class holds the necessarily logic to use AppUI class.
    /// </summary>
    public class Utils
    {
        private static readonly object sr_LockInstance = new object();
        private static Utils s_Instance;

        private Utils()
        {
        }

        public static Utils Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_LockInstance)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new Utils();
                        }
                    }
                }

                return s_Instance;
            }
        }

        #region WhoWasBornOnMyBirthdaylogic

        /// <summary>
        /// Parse given date to MM-DD format
        /// </summary>
        /// <param name="i_BirthdayToParse">Birthday date mm/dd/yyyy </param>
        public string ParseBirthdayDate(string i_BirthdayToParse)
        {
            bool isValidDate = validateStringFormat(i_BirthdayToParse);
            string strToReturn;

            if (isValidDate)
            {
                string formattedBirhdayDate = string.Format(
                    "{0}{1}-{2}{3}",
                    i_BirthdayToParse[0],
                    i_BirthdayToParse[1],
                    i_BirthdayToParse[3],
                    i_BirthdayToParse[4]);
                strToReturn = formattedBirhdayDate;
            }
            else
            {
                throw new FormatException();
            }

            return strToReturn;
        }

        /// <summary>
        /// return true if i_StringToCheck format is dd/mm/yyyy, Otherwise false..
        /// </summary>
        /// <param name="i_StringToCheck"></param>
        /// <returns></returns>
        private bool validateStringFormat(string i_StringToCheck)
        {
            bool isValid;
            try
            {
                DateTime parsedTime = DateTime.ParseExact(i_StringToCheck, "dd/mm/yyyy", CultureInfo.InvariantCulture);
                isValid = true;
            }
            catch (FormatException fe)
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Insert json-celeb data to collection
        /// TODO: Maybe use property instead out OR use as private method after parsing
        /// </summary>
        /// <param name="i_Json">json object</param>
        /// <param name="o_ListOfPeopleWhoWasBornOnMyBirthday">The collection</param>
        /// <param name="i_Key">Key word</param>
        public void ParseBirthdayJson(JObject i_Json, out List<string> o_ListOfPeopleWhoWasBornOnMyBirthday, string i_Key)
        {
            o_ListOfPeopleWhoWasBornOnMyBirthday = new List<string>();

            foreach (JToken name in i_Json[i_Key])
            {
                o_ListOfPeopleWhoWasBornOnMyBirthday.Add(name.ToString());
            }
        }

        /// <summary>
        /// Format selected name as "first_name" 
        /// </summary>
        public void SetCurrentNameInFormat(string i_StrToForamt, out string o_CurrentCelebName)
        {
            o_CurrentCelebName = i_StrToForamt.Replace(" ", "_");
        }

        /// <summary>
        /// Build json request to wikipedia server using its API.
        /// properties: images|intro content - based on given name
        /// </summary>
        /// <param name="i_JsonWikiRequest">Request path</param>
        /// <param name="i_FullName">Full name as parameter</param>
        public void BuildJsonWikiRequest(out string i_JsonWikiRequest, string i_FullName)
        {
            i_JsonWikiRequest = string.Format("https://en.wikipedia.org/w/api.php?action=query&titles={0}&prop=pageimages|extracts&exintro=&explaintext=&format=json&pithumbsize=300", i_FullName);
        }

        /// <summary>
        /// Get information from wiki json file
        /// </summary>
        public string GetWikiJsonInfo(JObject i_Json)
        {
            string wikiInfo;

            try
            {
                wikiInfo = GetJsonWikiInfoQuery(i_Json);
            }
            catch (NullReferenceException nre)
            {
                wikiInfo = "Nothing was found... Please let us know";
            }

            return wikiInfo;
        }

        /// <summary>
        /// Get information from wiki-json
        /// </summary>
        /// <param name="i_Json"></param>
        /// <returns></returns>
        public string GetJsonWikiInfoQuery(JObject i_Json)
        {
            return i_Json["query"]["pages"].First.First["extract"].ToString();
        }

        /// <summary>
        /// Get image from wiki-json
        /// </summary>
        /// <param name="i_Json"></param>
        /// <returns></returns>
        public string GetJsonWikiImageQuery(JObject i_Json)
        {
            return i_Json["query"]["pages"].First.First["thumbnail"]["source"].ToString();
        }

        /// <summary>
        /// Send request to the wiki server, download json and parse it.
        /// </summary>
        /// <param name="i_JsonWikiUrl"></param>
        public JObject GetJsonFromUrl(string i_JsonWikiUrl)
        {
            using (WebDownload wc = new WebDownload())
            {
                string json = wc.DownloadString(i_JsonWikiUrl);
                return ParseJson(json);
            }
        }

        /// <summary>
        /// Parse JSON file
        /// </summary>
        public JObject ParseJson(string i_JsonToParse)
        {
            return JObject.Parse(i_JsonToParse);
        }

        /// <summary>
        /// Get local JSON file
        /// </summary>
        /// <param name="i_PathToJsonFile">Path to json file</param>
        /// <returns>json file as string</returns>
        public string GetLocalJsonFile(string i_PathToJsonFile)
        {
            using (StreamReader reader = new StreamReader(i_PathToJsonFile))
            {
                return reader.ReadToEnd();
            }
        }
        #endregion

        #region MostLikeablePictures logic
        /// <summary>
        /// Set next image
        /// </summary>
        public int SetNextImage(int i_IndexOfCurrentImage, int i_NumberOfPictures)
        {
            return (i_IndexOfCurrentImage + 1 < i_NumberOfPictures) ? i_IndexOfCurrentImage + 1 : 0;
        }

        /// <summary>
        /// Set previous image
        /// </summary>
        public int SetPrevImage(int i_IndexOfCurrentImage, int i_NumberOfPictures)
        {
            return (i_IndexOfCurrentImage - 1 >= 0) ? i_IndexOfCurrentImage - 1 : i_NumberOfPictures - 1;
        }

        #endregion

        #region Form1

        /// <summary>
        /// Sort list of photos by number of likes 
        /// </summary>
        public void SortPhotosByDescendingOrder(List<Photo> io_ListOfPhotos)
        {
            io_ListOfPhotos.Sort((i_NumberOfLikesPhotoOne, i_NumberOfLikesPhotoTwo) =>
                i_NumberOfLikesPhotoOne.LikedBy.Count().CompareTo(i_NumberOfLikesPhotoTwo.LikedBy.Count()));
            io_ListOfPhotos.Reverse();
        }

        public List<Photo> FindMostLikablePhotos(int i_NumberOfPhotosToShow, List<Photo> i_ListOfPhotos)
        {
            List<Photo> topLikeablePhotos = new List<Photo>(i_NumberOfPhotosToShow);

            Photo minPhoto = new Photo();

            foreach (Photo photo in i_ListOfPhotos)
            {
                if (topLikeablePhotos.Count != topLikeablePhotos.Capacity)
                {
                    topLikeablePhotos.Add(photo);
                    minPhoto = findMinInTopLikable(topLikeablePhotos);
                }
                else
                {
                    if (photo.LikedBy.Count >= minPhoto.LikedBy.Count)
                    {
                        addPhotoToList(photo, ref minPhoto, topLikeablePhotos);
                    }
                }
            }

            return topLikeablePhotos;
            //TODO: no photos to show
        }

        private void addPhotoToList(Photo i_Photo, ref Photo io_MinPhoto, List<Photo> i_TopLikeablePhotos)
        {
            i_TopLikeablePhotos.Remove(io_MinPhoto);
            i_TopLikeablePhotos.Add(i_Photo);
            io_MinPhoto = findMinInTopLikable(i_TopLikeablePhotos);
        }

        private Photo findMinInTopLikable(List<Photo> i_TopLikeablePhotos)
        {
            Photo minPhoto = i_TopLikeablePhotos[0];

            foreach (Photo photo in i_TopLikeablePhotos)
            {
                if (photo.LikedBy.Count <= minPhoto.LikedBy.Count)
                {
                    minPhoto = photo;
                }
            }

            return minPhoto;
        }

        public void GetWidthAndHeight(ref int i_Width, ref int i_Height, List<Photo> i_TopLikeablePhotos)
        {
            foreach (Photo photo in i_TopLikeablePhotos)
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

        #endregion
    }
}
