using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_1.Models
{
    internal class Course_Inst
    {
        public int CrsId { get; set; }
        public int InstId { get; set; }
        [Required]
        public string Evaluate { get; set; }

    }
}
