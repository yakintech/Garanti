


using SingletonPattern.Models;

DbHelper dbHelper = DbHelper.GetInstance("connection string-1");
dbHelper.Status = "Connected-1";

DbHelper dbHelper2 = DbHelper.GetInstance("connection string-2");
dbHelper2.Status = "Connected-2";


Console.WriteLine(dbHelper.connectionString);
Console.WriteLine(dbHelper.Status);

Console.WriteLine(dbHelper2.connectionString);
Console.WriteLine(dbHelper2.Status);

Console.ReadLine();
