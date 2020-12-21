using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Timers;

namespace helloWorld
{
    class VideoPost: Post
    { 

        //Member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        System.Threading.Timer timer;

        //mine
        private System.Timers.Timer aTimer = new System.Timers.Timer(1000); 
        private int seconds = 0;
        //Properties
        private string VideoURL { get; set; }
        private int Length { get; set; }

        public VideoPost() { }
        public VideoPost(string title, string sendByUsername, string videoURL, int length, bool isPublic)
        {
            //inherited from the Post class
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            //this one is from this class, but not from the Post class
            this.VideoURL = videoURL;
            this.Length = length;
        }

        #region my attempt

        public void StartMine()
        { 
            aTimer.AutoReset = true;                 
            aTimer.Start();
            Console.WriteLine("Video started\nPress any key to stop the video");
            aTimer.Elapsed += ATimer_Elapsed;            
        }
        public void StopMine()
        {
            aTimer.Stop();
            int buffer = seconds;
            seconds = Length;
            Console.WriteLine("Video stopped at {0}s", buffer);           
        }
        private void ATimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(++seconds);
            if (Length <= seconds)
            {
                aTimer.Enabled = false;
                Console.WriteLine("Video finished");
            }
        }
        #endregion

        #region Denis attempt
        public void Play()
        {
            if(!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new System.Threading.Timer(TimerCallBack, null, 0, 1000);
            }
           
        }
        private void TimerCallBack(Object o)
        {
            if(currDuration<Length)
            {
                currDuration++;
                Console.WriteLine(currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }
        public void Stop()
        {
            if(isPlaying)
            {
                Console.WriteLine("Stopped at {0}", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
          
        }
        #endregion 

        public override string ToString()
        {
            return String.Format("{0} - {1} - (length={2}s) by {3} (URL: {4})", 
                this.ID, this.Title, this.Length, this.SendByUsername, this.VideoURL);
        }
    }
}
