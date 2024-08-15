using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_1.Models
{
    internal class Instructor
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int Bonus { get; set; }
        public Double Salary { get; set; }
        public string Address { get; set; }
        public double HourRate { get; set; }
        public int DepId { get; set; }
    }
}
