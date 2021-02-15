using Business.Concrete;
using DataAccess.Concrete_InMemory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
   public class Program
    {
        
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new MemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araba Hakkındaki Bilgiler :"+car.Description);
            }
            

        }
    }
}
