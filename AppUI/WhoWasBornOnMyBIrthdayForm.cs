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
    /// Get information about famous people who was born on my birthday date
    /// </summary>
    public partial class WhoWasBornOnMyBirthdayForm : FbForm
    {
        /// <summary>
        /// Message to the user when no shared birthday was found
        /// </summary>
        private const string k_NoOneWasBornMessage = "NO ONE FAMOUS WAS BORN ON MY BIRTHDAY EXCEPT ME frown emoticon";

        /// <summary>
        /// Formatted birthday date date MM-DD
        /// </summary>
        private readonly string m_MyBirthdayDate;

        /// <summary>
        /// Path to Json file
        /// </summary>
        private readonly string m_PathToJsonFile = Application.StartupPath + @"/JSONFile/celeb-birthdays.JSON";

        /// <summary>
        /// Instance of Util class
        /// </summary>
        private readonly Utils.Utils r_Util;

        /// <summary>
        /// List of people who share the same birthday date.
        /// </summary>
        private List<string> m_ListOfPeopleWhoWasBornOnMyBirthday;

        /// <summary>
        /// Json file to parse
        /// </summary>
        private string m_Json;

        /// <summary>
        /// Json file from external url
        /// </summary>
        private string m_JsonWikiUrl;

        /// <summary>
        /// Current selected celeb name to work with.
        /// </summary>
        private string m_CurrentCelebName;

        /// <summary>
        /// Parsed json
        /// </summary>
        private JObject m_ParsedJson;

        /// <summary>
        /// Initializes a new instance of the WhoWasBornOnMyBirthdayForm class.
        /// </summary>
        /// <param name="i_BirthdayDate">Birthday date mm/dd/yyyy </param>
        public WhoWasBornOnMyBirthdayForm(string i_BirthdayDate)
        {
            InitializeComponent();

            r_Util = Utils.Utils.Instance;

            m_MyBirthdayDate = r_Util.ParseBirthdayDate(i_BirthdayDate);
        }

        /// <summary>
        /// 1. Get the json-celeb file and parse it
        /// 2. Fetch birthdays based on that json file
        /// 3. Initialize list box with all the birthdays
        /// </summary>
        /// <param name="i_Event">The event</param>
        protected override void OnLoad(EventArgs i_Event)
        {
            /// TODO:Handle exceptions
            m_Json = r_Util.GetLocalJsonFile(m_PathToJsonFile);

            m_ParsedJson = r_Util.ParseJSON(m_Json);

            r_Util.ParseBirthdayJson(m_ParsedJson, out m_ListOfPeopleWhoWasBornOnMyBirthday, m_MyBirthdayDate);

            fetchBirthdays();
            initListBox();

            base.OnLoad(i_Event);
        }

        /// <summary>
        /// Initialize list box to select first item in the list
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
                m_ParsedJson = r_Util.GetJsonFromUrl(m_JsonWikiUrl);
                string image = r_Util.GetJsonWikiImageQuery(m_ParsedJson);
                pictureBox.LoadAsync(image);
            }
            catch (WebException wes)
            {
                // Connection error 
                MessageBox.Show(wes.Message);
                this.Close();
            }
            catch (NullReferenceException nre)
            {
                pictureBox.Image = Utils.Properties.Resources.attachment_unavailable;
            }
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

            // TODO: If no one was born today...?
            if (m_ListOfPeopleWhoWasBornOnMyBirthday.Count == 0)
            {
                MessageBox.Show(k_NoOneWasBornMessage);
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
            r_Util.SetCurrentNameInFormat(listBoxWhoWasBorn.Text, out m_CurrentCelebName);

            r_Util.BuildJsonWikiRequest(out m_JsonWikiUrl, m_CurrentCelebName);
            setPictureBox();
            textBoxInfo.Text = r_Util.GetWikiJsonInfo(m_ParsedJson);
        }
    }
}