using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laba_14EntityASP.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
        public Phone()
        {
            Phones = new List<Phone>();
        }
    }
}