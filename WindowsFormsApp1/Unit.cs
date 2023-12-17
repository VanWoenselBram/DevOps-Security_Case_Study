using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp1
{
    public class Unit
    {
        [Key]
        public int UnitId { get; set; }
        public string Name { get; set; }
        public string Ability { get; set; }
        public int Place { get; set; }
    }
}