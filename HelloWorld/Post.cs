using System;
using System.Collections.Generic;
using System.Text;

namespace helloWorld
{
    class Post
    {
        private static int currentPostId;

        //properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }


        /* 
         * Default constructor. If a derived class does not invoke a base
         * class constructor explicitly, the defult constructor is called implicitly
         */
        public Post()
        {
            ID = 0;
            Title = "My first post";
            IsPublic = true;
            SendByUsername = "Manuel Rivera";
        }

        //Instance constructor that has 3 param
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        //Method to increase the ID each time the constructor from above is created
        protected int GetNextID()
        {
            return ++currentPostId;
        }

        //Method to modify the title and whether if a post is public or not
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        //Virtual method overrride of the ToString method that is inherited from System.Object.
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}",this.ID, this.Title, this.SendByUsername);
        }
    }
}
