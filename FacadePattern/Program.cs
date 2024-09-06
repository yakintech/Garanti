


using FacadePattern.Models;

TV tv = new TV();
SoundSystem soundSystem = new SoundSystem();
DVDPlayer dvdPlayer = new DVDPlayer();

HomeTheatreFacade homeTheatre = new HomeTheatreFacade(tv, dvdPlayer, soundSystem);

homeTheatre.WatchMovie("The Matrix");

Console.ReadLine();


homeTheatre.EndMovie();

