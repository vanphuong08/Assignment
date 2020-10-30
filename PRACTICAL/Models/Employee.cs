using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace PRACTICAL.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string phong_ban { get; set; }
        public double tienluong { get; set; }
    }
}