using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json.Linq;

namespace Utils
{
    /// <summary>
    /// This class holds the necessarily logic to use AppUI class.
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// Parse given date to MM-DD format
        /// </summary>
        /// <param name="i_BirthdayToParse">Birthday date mm/dd/yyyy </param>
        public static string ParseBirthdayDate(string i_BirthdayToParse)
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
        private static bool validateStringFormat(string i_StringToCheck)
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
        public static void ParseBirthdayJson(JObject i_Json, out List<string> o_ListOfPeopleWhoWasBornOnMyBirthday, string i_Key)
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
        public static void SetCurrentNameInFormat(string i_StrToForamt, out string o_CurrentCelebName)
        {
            o_CurrentCelebName = i_StrToForamt.Replace(" ", "_");
            
        }

        /// <summary>
        /// Build json request to wikipedia server using its API.
        /// properties: images|intro content - based on given name
        /// </summary>
        /// <param name="i_JsonWikiRequest">Request path</param>
        /// <param name="i_FullName">Full name as parameter</param>
        public static void BuildJsonWikiRequest(out string i_JsonWikiRequest, string i_FullName)
        {
            i_JsonWikiRequest = string.Format("https://en.wikipedia.org/w/api.php?action=query&titles={0}&prop=pageimages|extracts&exintro=&explaintext=&format=json&pithumbsize=300", i_FullName);
        }

        /// <summary>
        /// Get information from wiki json file
        /// </summary>
        public static string GetWikiJsonInfo(JObject i_Json)
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
        public static string GetJsonWikiInfoQuery(JObject i_Json)
        {
            return i_Json["query"]["pages"].First.First["extract"].ToString();
        }

        /// <summary>
        /// Get image from wiki-json
        /// </summary>
        /// <param name="i_Json"></param>
        /// <returns></returns>
        public static string GetJsonWikiImageQuery(JObject i_Json)
        {
            return i_Json["query"]["pages"].First.First["thumbnail"]["source"].ToString();
        }

        /// <summary>
        /// Send request to the wiki server, download json and parse it.
        /// </summary>
        /// <param name="m_JsonWikiUrl"></param>
        /// <param name="m_ParsedJson"></param>
        public static JObject getJSONFromUrl(string m_JsonWikiUrl)
        {
            using (WebDownload wc = new WebDownload())
            {
                string json = wc.DownloadString(m_JsonWikiUrl);
                return JObject.Parse(json);
            }
        }


    }
}
