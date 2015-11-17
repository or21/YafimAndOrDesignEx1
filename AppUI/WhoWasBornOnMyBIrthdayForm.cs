//-----------------------------------------------------------------------
// <copyright file="WhoWasBornOnMyBirthdayForm.cs" company="A16_Ex01">
// Yafim Vodkov 308973882 Or Brand id 302521034
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Utils;

namespace AppUI
{
    /// <summary>
    /// Get inforamtion about famous people who was born on my birthday date
    /// </summary>
    public partial class WhoWasBornOnMyBirthdayForm : FbForm
    {
        /// <summary>
        /// Path to Json file
        /// </summary>
        private readonly string r_PathToJSONFile = Application.StartupPath + @"/JSONFile/celeb-birthdays.JSON";

        /// <summary>
        /// List of people who share the same birthday date.
        /// </summary>
        private readonly List<string> r_ListOfPeopleWhoWasBornOnMyBirthday;

        /// <summary>
        /// Message to the user when no shared birthday was found
        /// </summary>
        private readonly string r_NoOneWasBornMessage = "NO ONE FAMOUS WAS BORN ON MY BIRTHDAY EXCEPT ME frown emoticon";

        /// <summary>
        /// Formatted birthday date date MM-DD
        /// </summary>
        private readonly string m_MyBirthdayDate;

        /// <summary>
        /// Json file to parse
        /// </summary>
        private string m_Json;

        /// <summary>
        /// Json file from external url
        /// </summary>
        private string m_JsonWikiUrl;

        /// <summary>
        /// Current celected celeb name to work with.
        /// </summary>
        private string m_CurrentCelebName;

        /// <summary>
        /// 
        /// </summary>
        private JObject m_ParsedJson;

        /// <summary>
        /// Initializes a new instance of the WhoWasBornOnMyBirthdayForm class.
        /// </summary>
        /// <param name="i_BirthdayDate">Birthday date mm/dd/yyyy </param>
        public WhoWasBornOnMyBirthdayForm(string i_BirthdayDate)
        {
            InitializeComponent();
            try
            {
                m_MyBirthdayDate = Utils.Utils.parseBirthdayDate(i_BirthdayDate);
            }
            catch (FormatException bfe)
            {
                MessageBox.Show(bfe.Message);
                this.Close();
            }

            r_ListOfPeopleWhoWasBornOnMyBirthday = new List<string>();
        }

        /// <summary>
        /// 1. Get the json-celeb file and parse it
        /// 2. Fetch birthdays based on that json file
        /// 3. Init list box with all the birthdays
        /// </summary>
        /// <param name="i_Event"></param>
        protected override void OnLoad(EventArgs i_Event)
        {
            ///TODO: Validate no errors before parseJSON(). (file not found)
            // try
            getJSONFile();
            // catch fileNotFound

            parseJSON();

            fetchBirthdays();
            initListBox();

            base.OnLoad(i_Event);
        }

        /// <summary>
        /// Init list box to selec first item in the list
        /// </summary>
        private void initListBox()
        {
            m_CurrentCelebName = r_ListOfPeopleWhoWasBornOnMyBirthday.First();
            listBoxWhoWasBorn.SelectedIndex = 0;
        }

        /// <summary>
        /// Set picture in picture box and display it
        /// </summary>
        private void setPictureBox()
        {
            try
            {
                using (WebDownload wc = new WebDownload())
                {
                    string json = wc.DownloadString(m_JsonWikiUrl);
                    m_ParsedJson = JObject.Parse(json);
                    
                    try
                    {
                        string image = m_ParsedJson["query"]["pages"].First.First["thumbnail"]["source"].ToString();
                        pictureBox.LoadAsync(image);
                    }
                    catch (NullReferenceException nre)
                    {
                      pictureBox.Image = Utils.Properties.Resources.attachment_unavailable;
                    }

                }

            }
            // Connection error
            catch (WebException wes)
            {
                MessageBox.Show(wes.Message);
                this.Close();
            }

        }

        /// <summary>
        /// Set json url with current celected name
        /// </summary>
        private void setJsonUrl()
        {
            m_JsonWikiUrl = string.Format("https://en.wikipedia.org/w/api.php?action=query&titles={0}&prop=pageimages|extracts&exintro=&explaintext=&format=json&pithumbsize=300", m_CurrentCelebName);
        }


        /// <summary>
        /// If exists Get JSON file to read Otherwise throw relevant exception and exit
        /// </summary>
        private void getJSONFile()
        {
            try
            {
                using (StreamReader reader = new StreamReader(r_PathToJSONFile))
                {
                    m_Json = reader.ReadToEnd();
                }
            }
            catch (FileNotFoundException fnf)
            {
                MessageBox.Show(string.Format("error: {0}", fnf.Message));
                this.Close();
            }
        }

        /// <summary>
        /// Parse JSON file and insert it to collection
        /// </summary>
        private void parseJSON()
        {
          //  JObject parsedJSONFile = JObject.Parse(m_Json);
            m_ParsedJson = JObject.Parse(m_Json);

            foreach (JToken name in m_ParsedJson[m_MyBirthdayDate])
            {
                r_ListOfPeopleWhoWasBornOnMyBirthday.Add(name.ToString());
            }
        }



        

        /// <summary>
        /// Insert birthday list into listBox
        /// </summary>
        private void fetchBirthdays()
        {
            listBoxWhoWasBorn.HorizontalScrollbar = true;

            foreach (string name in r_ListOfPeopleWhoWasBornOnMyBirthday)
            {
                listBoxWhoWasBorn.Items.Add(name);
            }

            if (r_ListOfPeopleWhoWasBornOnMyBirthday.Count == 0)
            {
                MessageBox.Show(r_NoOneWasBornMessage);
            }
        }

        /// <summary>
        /// Close form
        /// </summary>
        /// <param name="i_Sender">Sender object</param>
        /// <param name="i_Event">Additional event arguments</param>
        private void fbWhiteButtonExit_Click(object i_Sender, EventArgs i_Event)
        {
            this.Close();
        }

        /// <summary>
        /// Update relevant information when item selected
        /// </summary>
        /// <param name="i_Sender"></param>
        /// <param name="i_Event"></param>
        private void listBoxWhoWasBorn_SelectedIndexChanged(object i_Sender, EventArgs i_Event)
        {
            labelName.Text = listBoxWhoWasBorn.Text;
            setCurrentNameInFormat(listBoxWhoWasBorn.Text);

            setJsonUrl();
            setPictureBox();
            setTextBoxInfo();
        }

        /// <summary>
        /// Format selected name as "first_name" 
        /// </summary>
        private void setCurrentNameInFormat(string i_StrToForamt)
        {
            m_CurrentCelebName = i_StrToForamt.Replace(" ", "_");
        }

        /// <summary>
        /// Set information in textbox
        /// </summary>
        private void setTextBoxInfo()
        {
            //TODO: Remove from here!!
            try
            {
                string info = m_ParsedJson["query"]["pages"].First.First["extract"].ToString();
                textBoxInfo.Text = info;
            }
            catch (NullReferenceException nre)
            {
                textBoxInfo.Text = "Nothing was found... Please let us know";
            }

        }
    }
}
