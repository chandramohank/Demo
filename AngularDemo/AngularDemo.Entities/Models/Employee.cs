using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace AngularDemo.Entities.Models
{
    public class Employee
    {
        [Key]
        public string _id { get; set; }
        public int index { get; set; }
        public Guid guid { get; set; }
        public bool isActive { get; set; }
        public string balance { get; set; }
        public int age { get; set; }
        public string eyeColor { get; set; }
        public string address { get; set; }
        public string about { get; set; }
        public string picture { get; set; }
        [Required]
        public string company { get; set; }
        public string email { get; set; }
        public string phone { get; set; }        
        public name name { get; set; }
        public string registered { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string[] tags { get; set; }
        public int[] range { get; set; }
        public List<friends> friends { get; set; }
        public string greeting { get; set; }
        public string favoriteFruit { get; set; }
    }
}
