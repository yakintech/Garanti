using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Models
{
    public class Product
    {

        //gozlemleyicleri tutan bir liste
        private List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }   

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }


        private void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

        public void UpdateStock()
        {
            Console.WriteLine("Product stock has been updated.");
            Notify();
        }
    }
}
