


using BuilderPattern.Models;

PhoneBuilder phoneBuilder = new HuaweiConcreteBuilder();
CreatePhone createPhone = new CreatePhone();
createPhone.Create(phoneBuilder);


Console.WriteLine(phoneBuilder.Phone.ToString());