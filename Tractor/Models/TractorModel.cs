using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tractor.Models
{
   public class TractorModel
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineType { get; set; }
        public string HorsePower { get; set; }
        public string PowerKW { get; set; }
        public decimal Price { get; set; }
    }
}