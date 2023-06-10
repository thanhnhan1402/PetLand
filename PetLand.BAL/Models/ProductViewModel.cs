using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PetLand.BAL.Models
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public byte[] ImageProduct { get; set; }
        public string Label { get; set; }       
        public string Description { get; set; }
        public string Weight { get; set; }
        public decimal?UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public int CategoryId { get; set; }

    }
}
