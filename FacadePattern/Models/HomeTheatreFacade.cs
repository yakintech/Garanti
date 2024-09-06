using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Models
{
    public class HomeTheatreFacade
    {
        private TV _tv;
        private DVDPlayer _dvdPlayer;
        private SoundSystem _soundSystem;

        public HomeTheatreFacade(TV tv, DVDPlayer dvdPlayer, SoundSystem soundSystem)
        {
            _tv = tv;
            _dvdPlayer = dvdPlayer;
            _soundSystem = soundSystem;
        }

        public void WatchMovie(string name)
        {
            _tv.TurnOn();
            _dvdPlayer.Play();
            _soundSystem.TurnOn();
            _soundSystem.setVolume(10);
            _dvdPlayer.Play();

            Console.WriteLine($"Watching movie: {name}");
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting down the movie...");
            _tv.TurnOff();
            _dvdPlayer.Stop();
            _soundSystem.TurnOff();
        }
    }
}
