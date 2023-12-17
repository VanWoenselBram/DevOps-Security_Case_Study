using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Augment
    {
        [Key]
        public int AugmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Place { get; set; }
    }
}
