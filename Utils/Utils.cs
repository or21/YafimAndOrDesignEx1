using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
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
        public static string parseBirthdayDate(string i_BirthdayToParse)
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
        /// <param name="i_JSON">json object</param>
        /// <param name="o_ListOfPeopleWhoWasBornOnMyBirthday">The collection</param>
        /// <param name="i_Key">Key word</param>
        public static void parseBirthdayJSON(JObject i_JSON, out List<string> o_ListOfPeopleWhoWasBornOnMyBirthday, string i_Key)
        {
            o_ListOfPeopleWhoWasBornOnMyBirthday = new List<string>();

            foreach (JToken name in i_JSON[i_Key])
            {
                o_ListOfPeopleWhoWasBornOnMyBirthday.Add(name.ToString());
            }
        }

        /// <summary>
        /// Format selected name as "first_name" 
        /// </summary>
        public static void setCurrentNameInFormat(string i_StrToForamt, out string o_CurrentCelebName)
        {
            o_CurrentCelebName = i_StrToForamt.Replace(" ", "_");
            
        }

        /// <summary>
        /// Build json request to wikipedia server using its API.
        /// properties: images|intro content - based on given name
        /// </summary>
        /// <param name="o_JSONWikiRequest">Request path</param>
        /// <param name="i_FullName">Full name as parameter</param>
        public static void buildJSONWikiRequest(out string o_JSONWikiRequest, string i_FullName)
        {
            o_JSONWikiRequest = string.Format("https://en.wikipedia.org/w/api.php?action=query&titles={0}&prop=pageimages|extracts&exintro=&explaintext=&format=json&pithumbsize=300", i_FullName);
        }

        /// <summary>
        /// Get information from wiki json file
        /// </summary>
        public static string getWikiJSONInfo(JObject i_JSON)
        {
            string wikiInfo;

            try
            {
                wikiInfo = getJSONWikiInfoQuery(i_JSON);
            }
            catch (NullReferenceException nre)
            {
                wikiInfo = "Nothing was found... Please let us know";
            }

            return wikiInfo;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="i_JSON"></param>
        /// <returns></returns>
        public static string getJSONWikiInfoQuery(JObject i_JSON)
        {
            return i_JSON["query"]["pages"].First.First["extract"].ToString();
        }

        public static string getJSONWikiImageQuery(JObject i_JSON)
        {
            return i_JSON["query"]["pages"].First.First["thumbnail"]["source"].ToString();
        }
        

    }
}
