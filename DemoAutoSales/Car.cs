using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoAutoSales
{
    public class Car
    {
        #region Properties
        public string TypeOfCar { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public int Price { get; set; }
        [Key]
        public int CarID { get; private set; }
        public virtual Customer Customer { get; set; }
        #endregion
    }
}