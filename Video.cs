using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Video : IVideo
    {
        public Video(string title,string genre, int duration)
        {
            Title = title;
            Genre = genre;
            Duration = duration;
        }
        public string Title { get;}
        public string Genre { get;}
        public int Duration { get;}
        public override string ToString()
        {
            return "видео с названием " + Title + " с жанром " + Genre + " длительностью " + Duration + " минут";
        }
    }
}
