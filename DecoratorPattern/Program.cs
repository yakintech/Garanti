

using DecoratorPattern.Models;

IRepository<User> userRepository = new Repository<User>();
userRepository = new LoggingRepository<User>(userRepository);

userRepository.Add(new User { Name = "John", Surname = "Doe" });


Console.ReadLine();