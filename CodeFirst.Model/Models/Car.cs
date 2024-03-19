using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Model.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public string ChassisNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        [ForeignKey("Engine")]
        public int Engine_Id { get; set; }
        public Engine Engine { get; set; }
    }
}
