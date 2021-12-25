using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        private List<VideoDisplay> ListDisplayedVideos = new List<VideoDisplay>();
        private VideoPlayer VideoPlayer = new VideoPlayer(100,"VideoPlayer1");
        public Form1()
        {
            InitializeComponent();
            UpdateVideoPlayerInformation();
        }

        private void AddCarriageButton_Click(object sender, EventArgs e)
        {
            new FormAddVideo(this).ShowDialog();
        }

        private void ClearListButton_Click(object sender, EventArgs e)
        {
            foreach(VideoDisplay current in this.ListDisplayedVideos)
            {
                current.Visible = false;
                this.VideoPlayer.Videos.Remove(current.video);
            }
            this.ListDisplayedVideos.Clear();
            ChangeScroller();
            UpdateVideoPlayerInformation();
        }

        private void ChangeScrollerValue(object sender,EventArgs e)
        {
            SetVideoLocation(0);
        }

        private void UpdateVideosListFilters(object sender,EventArgs e)
        {
            foreach(VideoDisplay current in this.ListDisplayedVideos)
            {
                current.Visible = false;
            }
            this.ListDisplayedVideos.Clear();

            foreach (Video video in this.VideoPlayer.Videos)
            {
                int index = PositionInList(video);
                if(index >= 0)
                {
                    this.ListDisplayedVideos.Insert(index, new VideoDisplay(video, this));
                    SetVideoLocation(index);
                    ChangeScroller();
                }
            }
        }

        private void RemoveVideo(VideoDisplay videoDisplay)
        {
            this.ListDisplayedVideos.Remove(videoDisplay);
            VideoPlayer.Videos.Remove(videoDisplay.video);
            videoDisplay.Visible = false;
            SetVideoLocation(0);
            ChangeScroller();
            UpdateVideoPlayerInformation();
        }


        public void AddVideo(Video video)
        {
            VideoPlayer.Videos.Add(video);
            int index = PositionInList(video);
            if (index >= 0)
            {
                this.ListDisplayedVideos.Insert(index, new VideoDisplay(video, this));
                SetVideoLocation(index);
                ChangeScroller();
            }
            UpdateVideoPlayerInformation();
        }

        private int PositionInList(Video video)
        {
            if (video.Duration < Convert.ToInt32(MinDuration.Value) ||
               video.Duration > Convert.ToInt32(MaxDuration.Value)) 
            {
                return -1;
            }

            if ("no order".Equals(comboBoxOrder.Text))
            {
                return 0;
            }

            int index = 0;
            foreach(VideoDisplay current in this.ListDisplayedVideos)
            {
                if("Duration".Equals(comboBoxOrder.Text) && video.Duration <= current.video.Duration)
                {
                    break;
                }
                index++;
            }
            return index;
        }

        private void ChangeScroller()
        {
            this.vScrollBar1.Minimum = 0;
            if (this.ListDisplayedVideos.Count <= 3)
            {
                this.vScrollBar1.Value = 0;
                this.vScrollBar1.Maximum = 0;
            }
            else
            {
                int max = (this.ListDisplayedVideos.Count - 3) * 90;
                if (this.vScrollBar1.Value > max) 
                { 
                    this.vScrollBar1.Value = max; 
                }
                this.vScrollBar1.Maximum = max;
            }
        }

        private Point AddNewPoint(int index)
        {
            return new Point(5, 30 + 90 * index - vScrollBar1.Value);
        }

        private void SetVideoLocation(int startIndex)
        {
            for (int i = startIndex; i < this.ListDisplayedVideos.Count; i++)
            {
                VideoDisplay current = this.ListDisplayedVideos[i];
                current.Location = AddNewPoint(i);
            }
        }

        private void UpdateVideoPlayerInformation()
        {
            String modelName = VideoPlayer.ModelName;
            int volume = VideoPlayer.Volume;
            State state = VideoPlayer.State;
            int playbackSpeed = VideoPlayer.PlaybackSpeed;

            LabelModelName.Text = Convert.ToString(modelName);
            labelVolume.Text = Convert.ToString(volume);
            labelState.Text = Convert.ToString(state);
            labelPlaybackSpeed.Text = Convert.ToString(playbackSpeed);
        }

        private class VideoDisplay : Panel
        {
            internal Video video;
            private Label descriptionLabel = new Label();
            private Button playButton = new Button();
            private Button removeButton = new Button();
            private Form1 form;

            private void RemoveButton_Click(object sender,EventArgs e)
            {
                this.form.RemoveVideo(this);
            }

            private void PlayButton_Click(object sender, EventArgs e)
            {
                string state = form.VideoPlayer.PlayVideo(this.video);
                form.labelPlays.Text = state;
                form.UpdateVideoPlayerInformation();
            }

            public VideoDisplay(Video video,Form1 form)
            {
                this.video = video;
                this.form = form;
                string description = string.Format(" Video: Title-{0}, \n Genre-{1}, \n Duration-{2}.",
                   video.Title, video.Genre, video.Duration);
                
                this.descriptionLabel.AutoSize = true;
                this.descriptionLabel.Text = description;
                this.Controls.Add(this.descriptionLabel);

                this.removeButton.AutoSize = true;
                this.removeButton.Text = "Remove.";
                this.removeButton.Click += new EventHandler(this.RemoveButton_Click);
                this.removeButton.Location = new Point(80, 60);
                this.Controls.Add(this.removeButton);

                this.playButton.AutoSize = true;
                this.playButton.Text = "Play.";
                this.playButton.Click += new EventHandler(this.PlayButton_Click);
                this.playButton.Location = new Point(0, 60);
                this.Controls.Add(this.playButton);

                form.groupBox1.Controls.Add(this);
                this.Size = new Size(250, 90);
            }
        }

        private void buttonVolume_Click(object sender, EventArgs e)
        {
            VideoPlayer.Volume = Convert.ToInt32(numericUpDownVolume.Value);
            UpdateVideoPlayerInformation();
        }

        private void buttonModelName_Click(object sender, EventArgs e)
        {
            VideoPlayer.ModelName = textBoxModelName.Text;
            UpdateVideoPlayerInformation();
        }

        private void buttonPlaybackSpeed_Click(object sender, EventArgs e)
        {
            int playbackSpeed = Convert.ToInt32(numericUpDownSpeed.Value);
            VideoPlayer.ChangePlaybackSpeed(playbackSpeed);
            UpdateVideoPlayerInformation();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            VideoPlayer.Pause();
            labelState.Text = Convert.ToString(VideoPlayer.State);
            labelPlays.Text = "";
            UpdateVideoPlayerInformation();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            VideoPlayer.Stop();
            labelState.Text = Convert.ToString(VideoPlayer.State);
            labelPlays.Text = "";
            UpdateVideoPlayerInformation();
        }
    }
}
