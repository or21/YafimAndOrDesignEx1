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

/*        /// <summary>
        /// Parse JSON file        /// </summary>
        /// <returns>Parsed json </returns>
        private static void parseJSON(string i_JSON, out List<string> o_ListOfPeopleWhoWasBornOnMyBirthday)
        {
            foreach (JToken name in i_JSON[m_MyBirthdayDate])
            {
                o_ListOfPeopleWhoWasBornOnMyBirthday.Add(name.ToString());
            }
        }*/
    }
}
