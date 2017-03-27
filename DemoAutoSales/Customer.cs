using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace DemoAutoSales
{
    public class Customer
    {
        public enum customerType { Admin, Private, Dealer };
        #region properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Emailaddress { get; set; }
        public string streetAddress { get; set; }
        public string State { get; set; }
        public int zip { get; set; }
        [Key]
        public int customerID { get; private set; }
        public customerType TypeOfCustomer { get; set; }
        #endregion

    }
}