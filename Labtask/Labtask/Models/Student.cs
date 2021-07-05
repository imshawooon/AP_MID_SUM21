using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Labtask.Models
{
    public class Student
    {
        [Required]

        public string Name { get; set; }
        [Required]
        public string Id { get; set; }
        [Required]
        public string DOB { get; set; }
        [Required]
        public int Credit { get; set; }
        [Required]

        public string CGPA { get; set; }
        [Required]

        public int deptId { get; set; }

        public string UserName { get; set; }
        public string password { get; set; }
    }
}