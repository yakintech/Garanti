

using CommandPattern.Models;

Light light = new Light();

ICommand turnOn = new TurnOnCommand(light);
ICommand turnOff = new TurnOffCommand(light);


RemoteControl remote = new RemoteControl();

//isigi acacak komutu ver
remote.SetCommand(turnOn);
remote.PressButton();


//isigi kapatacak komutu ver
remote.SetCommand(turnOff);
remote.PressButton();

//isigi geri acacak komutu ver
remote.PressUndo();