using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Model.Models
{
    public class EngineType
    {

        [Key]
        public int Id { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Engine> Engines { get; set; }
    }
}
