using System;
using System.Collections.Generic;
using System.Text;

namespace helloWorld
{
    //ImagePost derives from Post and adds a property (image url) and two constructors
    class ImagePost:Post
    {
        public string ImageURL { get; set; }
        public ImagePost() { }
        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            //inherited from the Post class
            this.ID = GetNextID(); 
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            //this one is from this class, but not from the Post class
            this.ImageURL = imageURL; 
        }

        //Virtual method overrride of the ToString method that is inherited from helloWorld.Post.
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2} (URL: {3})", this.ID, this.Title, this.SendByUsername, this.ImageURL);
        }
    }
}
