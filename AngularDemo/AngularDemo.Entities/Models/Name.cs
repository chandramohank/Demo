using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularDemo.Entities.Models
{
    public class name
    {
        [Required]
        [MaxLength(30)]
        public string first { get; set; }
        [Required]
        [MaxLength(50)]
        public string last { get; set; }

    }
}
