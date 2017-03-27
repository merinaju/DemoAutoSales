using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAutoSales
{
    public static class Inventory
    {
        public static InventoryModel db = new InventoryModel();

        public static Customer FindCustomer(string emailaddress)
        {
            if (string.IsNullOrEmpty(emailaddress))
            {
                throw new ArgumentNullException("Email address cannot be empty");
            }
            return db.Customers.Where(c => c.Emailaddress == emailaddress).FirstOrDefault();
        }

        public static Customer Register(string firstname, string lastname, string streetaddress, string state, string emailaddress, int zip)
        {
            var customer = new Customer
            {
                FirstName = firstname,
                LastName = lastname,
                streetAddress = streetaddress,
                State = state,
                Emailaddress = emailaddress,
                zip = zip
            };
            db.Customers.Add(customer);
            db.SaveChanges();
            return customer;

        }
        public static Car createCar(string typeOfCar, string model, int mileage, int price, Customer customer)
        {
            var car = new Car { TypeOfCar = typeOfCar, Model = model, Mileage = mileage, Price = price, Customer = customer };
            db.Cars.Add(car);
            db.SaveChanges();
            return car;
        }
        public static Car[] GetAllCars(string emailaddress)
        {
            return db.Cars.Where(a => a.Customer.Emailaddress == emailaddress).ToArray();
        }
    }
}