using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_1.Models
{
    internal class Student
    {
        public int? Id { get; set; }
        public string Fname { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int? Age { get; set; }
        public int DepId { get; set; }
    }
}
