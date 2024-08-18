using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_1.Models
{
    internal class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 15)]
        public string Name { get; set; }
        [Required]
        [ForeignKey(nameof(Instructor))]
        public int InsId { get; set; }
        [Required]
        public int HiringDate { get; set; }

    }
}
