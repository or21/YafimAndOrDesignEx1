//-----------------------------------------------------------------------
// <copyright file="WhoWasBornOnMyBirthdayForm.cs" company="A16_Ex01">
// Yafim Vodkov 308973882 Or Brand id 302521034
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
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
        /// Json file to parse
        /// </summary>
        private string m_Json;

        /// <summary>
        /// Formatted birthday date date MM-DD
        /// </summary>
        private string m_MyBirthdayDate;

        /// <summary>
        /// Initializes a new instance of the WhoWasBornOnMyBirthdayForm class.
        /// </summary>
        /// <param name="i_BirthdayDate">Birthday date mm/dd/yyyy </param>
        public WhoWasBornOnMyBirthdayForm(string i_BirthdayDate)
        {
            InitializeComponent();
            parseBirthdayDate(i_BirthdayDate);

            r_ListOfPeopleWhoWasBornOnMyBirthday = new List<string>();
        }

        /// <summary>
        /// Parse given date to MM-DD format
        /// </summary>
        /// <param name="i_BirthdayToParse">Birthday date mm/dd/yyyy </param>
        private void parseBirthdayDate(string i_BirthdayToParse)
        {
            m_MyBirthdayDate = string.Format("{0}{1}-{2}{3}", i_BirthdayToParse[0], i_BirthdayToParse[1], i_BirthdayToParse[3], i_BirthdayToParse[4]);
        }

        protected override void OnLoad(EventArgs e)
        {
            getJSONFile();
            ///TODO: Validate no errors before parseJSON(). (file not found)
            parseJSON();

            fetchBirthdays();
            base.OnLoad(e);
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
                //         this.Close();

            }
        }

        /// <summary>
        /// Parse JSON file and insert it to collection
        /// </summary>
        private void parseJSON()
        {
            JObject parsedJSONFile = JObject.Parse(m_Json);

            foreach (JToken name in parsedJSONFile[m_MyBirthdayDate])
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
    }
}
