using System;
using System.Collections.Generic;
using System.Text;

namespace InstagramLite
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl
        {
            get { return "https://loremflickr.com/320/240?random=" + Id; }
        }

    }
}
