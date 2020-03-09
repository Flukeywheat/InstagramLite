using System;
using System.Collections.Generic;
using System.Text;

namespace InstagramLite
{
    class User
    {
        private int Id { get; }
        private int Name { get; set; }
        private string Description { get; set; }
        private string ImageUrl { get; }

        User(int id, string imageurl)
        {
            Id = id;
            ImageUrl = imageurl;
        }
    }
}
