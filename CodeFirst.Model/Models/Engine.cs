using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Model.Models
{
    public class Engine
    {
        [Key]
        public int Id { get; set; }
        public int Year { get; set; }
        public string SerialNumber { get; set; }
        public string Type { get; set; }

        public Car Car { get; set; }

    }
}
