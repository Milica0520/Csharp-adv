using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiManager9000.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public string LicensePlate { get; set; }

        public DateTime LpExieryDate { get; set; }

        public List< Driver> Drivers { get; set; }
    }
}
