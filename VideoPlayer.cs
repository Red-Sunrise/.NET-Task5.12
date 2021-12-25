using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5;
namespace Task5
{
    public class VideoPlayer : Player
    {
        public VideoPlayer(int volume, string modelName) : base(volume, modelName)
        {
            Videos = new List<IVideo>();
        }
        private int playbackSpeed = 1;
        public int PlaybackSpeed { get { return playbackSpeed; } }
        public List<IVideo> Videos { get; }

        public string PlayVideo(IVideo video)
        {
            Play();
            return "Воспроизводится " + video.ToString(); 
        }
        public void ChangePlaybackSpeed(int playbackSpeed)
        {
            this.playbackSpeed = playbackSpeed;
        }
        public override Dictionary<string, object> GetParameters()
        {
            Dictionary<string, object> parameters = base.GetParameters();
            parameters.Add("Скорость воспроизведения", PlaybackSpeed);
            parameters.Add("Список видео", Videos);
            return parameters;
        }
    }
}
