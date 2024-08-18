using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_1.Models
{
    [Table("Course_Inst", Schema = "dbo")]
    internal class Course_Inst
    {
        public int CrsId { get; set; }
        public int InstId { get; set; }
        [Required]
        public string Evaluate { get; set; }

    }
}
