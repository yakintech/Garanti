


using ObserverPattern.Models;

Product product = new Product();


//ilgili gozlemciyi product nesnesine ekliyoruz. boylelikle degisiklik oldugunda gozlemciye haber verilecek.
product.Attach(new CustomerObserver());


//product nesnesindeki stok guncellemesi yapildiginda gozlemcilere haber verilecek.
product.UpdateStock();

Console.ReadLine();