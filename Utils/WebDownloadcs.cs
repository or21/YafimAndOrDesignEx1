using System;
using System.Net;

namespace Utils
{
    public class WebDownload : WebClient
    {
        /// <summary>
        /// Time in milliseconds
        /// </summary>
        public int Timeout { get; set; }

        public WebDownload() : this(60000)
        {
        }

        public WebDownload(int i_Timeout)
        {
            this.Timeout = i_Timeout;
        }

        protected override WebRequest GetWebRequest(Uri i_Address)
        {
            WebRequest request = base.GetWebRequest(i_Address);
            if (request != null)
            {
                request.Timeout = this.Timeout;
            }

            return request;
        }
    }
}