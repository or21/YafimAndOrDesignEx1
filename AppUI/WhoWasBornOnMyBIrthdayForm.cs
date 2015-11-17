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
        private List<string> m_ListOfPeopleWhoWasBornOnMyBirthday;

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
            
            Utils.Utils.parseBirthdayJSON(m_ParsedJson, out m_ListOfPeopleWhoWasBornOnMyBirthday, m_MyBirthdayDate);

            fetchBirthdays();
            initListBox();

            base.OnLoad(i_Event);
        }

        /// <summary>
        /// Init list box to selec first item in the list
        /// </summary>
        private void initListBox()
        {
            m_CurrentCelebName = m_ListOfPeopleWhoWasBornOnMyBirthday.First();
            listBoxWhoWasBorn.SelectedIndex = 0;
        }

        /// <summary>
        /// Set picture in picture box and display it
        /// </summary>
        private void setPictureBox()
        {
            try
            {
                m_ParsedJson = Utils.Utils.getJSONFromUrl(m_JsonWikiUrl);
                    try
                    {
                        string image = Utils.Utils.getJSONWikiImageQuery(m_ParsedJson);
                        pictureBox.LoadAsync(image);
                    }
                    catch (NullReferenceException nre)
                    {
                      pictureBox.Image = Utils.Properties.Resources.attachment_unavailable;
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
        /// Parse JSON file
        /// </summary>
        private void parseJSON()
        {
            m_ParsedJson = JObject.Parse(m_Json);
        }

        /// <summary>
        /// Insert birthday list into listBox
        /// </summary>
        private void fetchBirthdays()
        {
            foreach (string name in m_ListOfPeopleWhoWasBornOnMyBirthday)
            {
                listBoxWhoWasBorn.Items.Add(name);
            }

            //TODO: If no one was born today...?
            if (m_ListOfPeopleWhoWasBornOnMyBirthday.Count == 0)
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
        /// <param name="i_Sender">Sender object</param>
        /// <param name="i_Event">the event</param>
        private void listBoxWhoWasBorn_SelectedIndexChanged(object i_Sender, EventArgs i_Event)
        {
            labelName.Text = listBoxWhoWasBorn.Text;
            Utils.Utils.setCurrentNameInFormat(listBoxWhoWasBorn.Text, out m_CurrentCelebName);

            Utils.Utils.buildJSONWikiRequest(out m_JsonWikiUrl, m_CurrentCelebName);
            setPictureBox();
            textBoxInfo.Text = Utils.Utils.getWikiJSONInfo(m_ParsedJson);
        }
    }
}
