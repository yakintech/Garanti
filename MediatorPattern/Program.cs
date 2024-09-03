

using MediatorPattern.Models;

Mediator mediator = new ChatRoomMediator();


Participant user1 = new User(mediator, "User1");
Participant user2 = new User(mediator, "User2");
Participant user3 = new User(mediator, "User3");


mediator.Register(user1);
mediator.Register(user2);
mediator.Register(user3);


user1.Send("User2", "Hello User2");


Console.ReadLine();


