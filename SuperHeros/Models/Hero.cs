using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeros.Models
{
    public class Hero
    {
        [Key]
        public int ID { get; set; }
        public string HeroName { get; set; }
        public string FirstName { get; set;  }
        public string LastName { get; set;  }
        public string PrimaryPower { get; set; }
        public string SecondaryPower { get; set;  }
        public string Catchphrase { get; set; }

    }
}
