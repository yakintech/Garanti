using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Models
{
    public class MediaPlayerAdapter
    {
        private MP3Player _mp3Player;

        public MediaPlayerAdapter(string audioType)
        {
            if (audioType.Equals("mp3", StringComparison.OrdinalIgnoreCase))
            {
                _mp3Player = new MP3Player();
            }
            
        }

        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("mp3", StringComparison.OrdinalIgnoreCase))
            {
                _mp3Player.PlayMusic();
            }
        }
    }
}
