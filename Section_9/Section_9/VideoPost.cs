using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Section_9
{
    internal class VideoPost : Post
    {
        // member fields
        private protected bool isPlaying = false;
        private protected int currDuration = 0;
        private Timer timer;

        // Properties
        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublic, int length)
        {
            // The following properties and the GetNexID method are inherited from Post.
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            // Property VideoURL is a member of VideoPost, but not of Post
            this.VideoURL = videoURL;
            this.Length = length;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(object o)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}s", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }

        public override string ToString()
        {
            return string.Format(
                "{0} - {1} - {2} - {3} - by {4}",
                this.ID, this.Title, this.VideoURL, this.Length, this.SendByUsername);
        }
    }
}
