using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Models
{
    internal class AudioPlayer : IMediaPlayer
    {

        private MediaPlayerAdapter _mediaPlayerAdapter;
        public void Play(string audioType, string fileName)
        {
            if (audioType == "mp3")
            {
                _mediaPlayerAdapter = new MediaPlayerAdapter(audioType);
                _mediaPlayerAdapter.Play(audioType, fileName);
            }
            else if (audioType == "vlc" || audioType == "mp4")
            {
                Console.WriteLine("Playing mp4 file. Name: " + fileName);
            }
            else
            {
                Console.WriteLine("Invalid media. " + audioType + " format not supported");
            }
        }
    }
}
