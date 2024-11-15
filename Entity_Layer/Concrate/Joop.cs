using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrate
{
    public class Joop
    {
        [Key]
        public int JoobId { get; set; }
        public string JoobName { get; set; }
        public ICollection<Customer> customers { get; set; }

    }
}
