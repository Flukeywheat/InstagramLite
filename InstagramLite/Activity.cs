using System;
using System.Collections.Generic;
using System.Text;

namespace InstagramLite
{
    class Activity
    {
        public int UserId { get; set; }
        public string Description { get; set; }
        public string ImageUrl
        {
            get { return "https://loremflickr.com/320/240?random=" + UserId; }
        }       
    }
}
